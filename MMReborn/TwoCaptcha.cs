using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MMReborn
{
	// Token: 0x02000008 RID: 8
	internal class TwoCaptcha
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000CD87 File Offset: 0x0000AF87
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000CD8F File Offset: 0x0000AF8F
		public string APIKey { get; private set; }

		// Token: 0x0600007C RID: 124 RVA: 0x0000CD98 File Offset: 0x0000AF98
		public TwoCaptcha(string apiKey)
		{
			this.APIKey = apiKey;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		public bool SolveRecaptchaV2(string googleKey, string pageUrl, out string result)
		{
			string requestUriString = string.Concat(new string[]
			{
				"http://2captcha.com/in.php?key=",
				this.APIKey,
				"&method=userrecaptcha&googlekey=",
				googleKey,
				"&pageurl=",
				pageUrl
			});
			try
			{
				WebRequest webRequest = WebRequest.Create(requestUriString);
				using (WebResponse response = webRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
					{
						string text = streamReader.ReadToEnd();
						bool flag = text.Length < 3;
						if (flag)
						{
							result = text;
							return false;
						}
						bool flag2 = text.Substring(0, 3) == "OK|";
						if (flag2)
						{
							string str = text.Remove(0, 3);
							for (int i = 0; i < 24; i++)
							{
								WebRequest webRequest2 = WebRequest.Create("http://2captcha.com/res.php?key=" + this.APIKey + "&action=get&id=" + str);
								using (WebResponse response2 = webRequest2.GetResponse())
								{
									using (StreamReader streamReader2 = new StreamReader(response2.GetResponseStream()))
									{
										string text2 = streamReader2.ReadToEnd();
										bool flag3 = text2.Length < 3;
										if (flag3)
										{
											result = text2;
											return false;
										}
										bool flag4 = text2.Substring(0, 3) == "OK|";
										if (flag4)
										{
											result = text2.Remove(0, 3);
											return true;
										}
										bool flag5 = text2 != "CAPCHA_NOT_READY";
										if (flag5)
										{
											result = text2;
											return false;
										}
									}
								}
								Task<int> task = Task.Run<int>(async delegate()
								{
									await Task.Delay(5000);
									return 42;
								});
								task.Wait();
							}
							result = "Timeout";
							return false;
						}
						result = text;
						return false;
					}
				}
			}
			catch (Exception ex)
			{
			}
			result = "Unknown error";
			return false;
		}
	}
}

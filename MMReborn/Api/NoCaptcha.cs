using System;
using Newtonsoft.Json.Linq;

namespace MMReborn.Api
{
	// Token: 0x0200000D RID: 13
	public class NoCaptcha : NoCaptchaProxyless
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000D66A File Offset: 0x0000B86A
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000D672 File Offset: 0x0000B872
		public string Cookies { protected get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000D67B File Offset: 0x0000B87B
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000D683 File Offset: 0x0000B883
		public string ProxyLogin { protected get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000D68C File Offset: 0x0000B88C
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000D694 File Offset: 0x0000B894
		public string ProxyPassword { protected get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000D69D File Offset: 0x0000B89D
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000D6A5 File Offset: 0x0000B8A5
		public int? ProxyPort { protected get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000D6AE File Offset: 0x0000B8AE
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000D6B6 File Offset: 0x0000B8B6
		public AnticaptchaBase.ProxyTypeOption? ProxyType { protected get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000D6BF File Offset: 0x0000B8BF
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000D6C7 File Offset: 0x0000B8C7
		public string UserAgent { protected get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public string ProxyAddress { protected get; set; }

		// Token: 0x0600009A RID: 154 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public override JObject GetPostData()
		{
			JObject postData = base.GetPostData();
			postData["type"] = "NoCaptchaTask";
			bool flag;
			if (this.ProxyType != null && this.ProxyPort != null)
			{
				int? proxyPort = this.ProxyPort;
				int num = 1;
				if (!(proxyPort.GetValueOrDefault() < num & proxyPort != null))
				{
					proxyPort = this.ProxyPort;
					num = 65535;
					if (!(proxyPort.GetValueOrDefault() > num & proxyPort != null))
					{
						flag = string.IsNullOrEmpty(this.ProxyAddress);
						goto IL_8E;
					}
				}
			}
			flag = true;
			IL_8E:
			bool flag2 = flag;
			JObject result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				postData.Add("proxyType", this.ProxyType.ToString().ToLower());
				postData.Add("proxyAddress", this.ProxyAddress);
				postData.Add("proxyPort", this.ProxyPort);
				postData.Add("proxyLogin", this.ProxyLogin);
				postData.Add("proxyPassword", this.ProxyPassword);
				postData.Add("userAgent", this.UserAgent);
				postData.Add("cookies", this.Cookies);
				result = postData;
			}
			return result;
		}
	}
}

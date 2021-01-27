using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace MMReborn.Helper
{
	// Token: 0x0200000B RID: 11
	public class HttpHelper
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		[return: Dynamic]
		public static dynamic Post(Uri url, string post, out string error)
		{
			error = null;
			object result = null;
			byte[] bytes = Encoding.UTF8.GetBytes(post);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.ContentLength = (long)bytes.Length;
			httpWebRequest.Timeout = 30000;
			try
			{
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
				}
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
					result = JsonConvert.DeserializeObject(streamReader.ReadToEnd());
					httpWebResponse.Close();
				}
			}
			catch (Exception ex)
			{
				error = ex.Message;
				return false;
			}
			return result;
		}
	}
}

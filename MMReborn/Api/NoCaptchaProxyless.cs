using System;
using MMReborn.ApiResponse;
using Newtonsoft.Json.Linq;

namespace MMReborn.Api
{
	// Token: 0x0200000E RID: 14
	public class NoCaptchaProxyless : AnticaptchaBase, IAnticaptchaTaskProtocol
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000D850 File Offset: 0x0000BA50
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000D858 File Offset: 0x0000BA58
		public Uri WebsiteUrl { protected get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000D861 File Offset: 0x0000BA61
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000D869 File Offset: 0x0000BA69
		public string WebsiteKey { protected get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000D872 File Offset: 0x0000BA72
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000D87A File Offset: 0x0000BA7A
		public string WebsiteSToken { protected get; set; }

		// Token: 0x060000A2 RID: 162 RVA: 0x0000D884 File Offset: 0x0000BA84
		public override JObject GetPostData()
		{
			return new JObject
			{
				{
					"type",
					"NoCaptchaTaskProxyless"
				},
				{
					"websiteURL",
					this.WebsiteUrl
				},
				{
					"websiteKey",
					this.WebsiteKey
				},
				{
					"websiteSToken",
					this.WebsiteSToken
				}
			};
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		public TaskResultResponse.SolutionData GetTaskSolution()
		{
			return base.TaskInfo.Solution;
		}
	}
}

using System;
using MMReborn.ApiResponse;
using Newtonsoft.Json.Linq;

namespace MMReborn
{
	// Token: 0x02000004 RID: 4
	public interface IAnticaptchaTaskProtocol
	{
		// Token: 0x06000063 RID: 99
		JObject GetPostData();

		// Token: 0x06000064 RID: 100
		TaskResultResponse.SolutionData GetTaskSolution();
	}
}

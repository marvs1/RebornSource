using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using MMReborn.Helper;
using Newtonsoft.Json.Linq;

namespace MMReborn.ApiResponse
{
	// Token: 0x02000011 RID: 17
	public class TaskResultResponse
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000E038 File Offset: 0x0000C238
		public TaskResultResponse(dynamic json)
		{
			if (TaskResultResponse.<>o__1.<>p__1 == null)
			{
				TaskResultResponse.<>o__1.<>p__1 = CallSite<Func<CallSite, object, int?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int?), typeof(TaskResultResponse)));
			}
			Func<CallSite, object, int?> target = TaskResultResponse.<>o__1.<>p__1.Target;
			CallSite <>p__ = TaskResultResponse.<>o__1.<>p__1;
			if (TaskResultResponse.<>o__1.<>p__0 == null)
			{
				TaskResultResponse.<>o__1.<>p__0 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractInt", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			this.ErrorId = target(<>p__, TaskResultResponse.<>o__1.<>p__0.Target(TaskResultResponse.<>o__1.<>p__0, typeof(JsonHelper), json, "errorId"));
			bool flag = this.ErrorId != null;
			if (flag)
			{
				bool flag2 = this.ErrorId.Equals(0);
				if (flag2)
				{
					if (TaskResultResponse.<>o__1.<>p__4 == null)
					{
						TaskResultResponse.<>o__1.<>p__4 = CallSite<Func<CallSite, object, TaskResultResponse.StatusType?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(TaskResultResponse.StatusType?), typeof(TaskResultResponse)));
					}
					Func<CallSite, object, TaskResultResponse.StatusType?> target2 = TaskResultResponse.<>o__1.<>p__4.Target;
					CallSite <>p__2 = TaskResultResponse.<>o__1.<>p__4;
					if (TaskResultResponse.<>o__1.<>p__3 == null)
					{
						TaskResultResponse.<>o__1.<>p__3 = CallSite<Func<CallSite, TaskResultResponse, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ParseStatus", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, TaskResultResponse, object, object> target3 = TaskResultResponse.<>o__1.<>p__3.Target;
					CallSite <>p__3 = TaskResultResponse.<>o__1.<>p__3;
					if (TaskResultResponse.<>o__1.<>p__2 == null)
					{
						TaskResultResponse.<>o__1.<>p__2 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.Status = target2(<>p__2, target3(<>p__3, this, TaskResultResponse.<>o__1.<>p__2.Target(TaskResultResponse.<>o__1.<>p__2, typeof(JsonHelper), json, "status")));
					bool flag3 = this.Status.Equals(TaskResultResponse.StatusType.Ready);
					if (flag3)
					{
						if (TaskResultResponse.<>o__1.<>p__6 == null)
						{
							TaskResultResponse.<>o__1.<>p__6 = CallSite<Func<CallSite, object, double?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double?), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, double?> target4 = TaskResultResponse.<>o__1.<>p__6.Target;
						CallSite <>p__4 = TaskResultResponse.<>o__1.<>p__6;
						if (TaskResultResponse.<>o__1.<>p__5 == null)
						{
							TaskResultResponse.<>o__1.<>p__5 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractDouble", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.Cost = target4(<>p__4, TaskResultResponse.<>o__1.<>p__5.Target(TaskResultResponse.<>o__1.<>p__5, typeof(JsonHelper), json, "cost"));
						if (TaskResultResponse.<>o__1.<>p__8 == null)
						{
							TaskResultResponse.<>o__1.<>p__8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target5 = TaskResultResponse.<>o__1.<>p__8.Target;
						CallSite <>p__5 = TaskResultResponse.<>o__1.<>p__8;
						if (TaskResultResponse.<>o__1.<>p__7 == null)
						{
							TaskResultResponse.<>o__1.<>p__7 = CallSite<Func<CallSite, Type, object, string, object, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.Ip = target5(<>p__5, TaskResultResponse.<>o__1.<>p__7.Target(TaskResultResponse.<>o__1.<>p__7, typeof(JsonHelper), json, "ip", null, true));
						if (TaskResultResponse.<>o__1.<>p__10 == null)
						{
							TaskResultResponse.<>o__1.<>p__10 = CallSite<Func<CallSite, object, int?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int?), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, int?> target6 = TaskResultResponse.<>o__1.<>p__10.Target;
						CallSite <>p__6 = TaskResultResponse.<>o__1.<>p__10;
						if (TaskResultResponse.<>o__1.<>p__9 == null)
						{
							TaskResultResponse.<>o__1.<>p__9 = CallSite<Func<CallSite, Type, object, string, object, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractInt", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.SolveCount = target6(<>p__6, TaskResultResponse.<>o__1.<>p__9.Target(TaskResultResponse.<>o__1.<>p__9, typeof(JsonHelper), json, "solveCount", null, true));
						if (TaskResultResponse.<>o__1.<>p__13 == null)
						{
							TaskResultResponse.<>o__1.<>p__13 = CallSite<Func<CallSite, object, DateTime?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DateTime?), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, DateTime?> target7 = TaskResultResponse.<>o__1.<>p__13.Target;
						CallSite <>p__7 = TaskResultResponse.<>o__1.<>p__13;
						if (TaskResultResponse.<>o__1.<>p__12 == null)
						{
							TaskResultResponse.<>o__1.<>p__12 = CallSite<Func<CallSite, TaskResultResponse, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "UnixTimeStampToDateTime", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, TaskResultResponse, object, object> target8 = TaskResultResponse.<>o__1.<>p__12.Target;
						CallSite <>p__8 = TaskResultResponse.<>o__1.<>p__12;
						if (TaskResultResponse.<>o__1.<>p__11 == null)
						{
							TaskResultResponse.<>o__1.<>p__11 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractDouble", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.CreateTime = target7(<>p__7, target8(<>p__8, this, TaskResultResponse.<>o__1.<>p__11.Target(TaskResultResponse.<>o__1.<>p__11, typeof(JsonHelper), json, "createTime")));
						if (TaskResultResponse.<>o__1.<>p__16 == null)
						{
							TaskResultResponse.<>o__1.<>p__16 = CallSite<Func<CallSite, object, DateTime?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DateTime?), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, DateTime?> target9 = TaskResultResponse.<>o__1.<>p__16.Target;
						CallSite <>p__9 = TaskResultResponse.<>o__1.<>p__16;
						if (TaskResultResponse.<>o__1.<>p__15 == null)
						{
							TaskResultResponse.<>o__1.<>p__15 = CallSite<Func<CallSite, TaskResultResponse, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "UnixTimeStampToDateTime", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, TaskResultResponse, object, object> target10 = TaskResultResponse.<>o__1.<>p__15.Target;
						CallSite <>p__10 = TaskResultResponse.<>o__1.<>p__15;
						if (TaskResultResponse.<>o__1.<>p__14 == null)
						{
							TaskResultResponse.<>o__1.<>p__14 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractDouble", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.EndTime = target9(<>p__9, target10(<>p__10, this, TaskResultResponse.<>o__1.<>p__14.Target(TaskResultResponse.<>o__1.<>p__14, typeof(JsonHelper), json, "endTime")));
						TaskResultResponse.SolutionData solutionData = new TaskResultResponse.SolutionData();
						TaskResultResponse.SolutionData solutionData2 = solutionData;
						if (TaskResultResponse.<>o__1.<>p__18 == null)
						{
							TaskResultResponse.<>o__1.<>p__18 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target11 = TaskResultResponse.<>o__1.<>p__18.Target;
						CallSite <>p__11 = TaskResultResponse.<>o__1.<>p__18;
						if (TaskResultResponse.<>o__1.<>p__17 == null)
						{
							TaskResultResponse.<>o__1.<>p__17 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						solutionData2.Token = target11(<>p__11, TaskResultResponse.<>o__1.<>p__17.Target(TaskResultResponse.<>o__1.<>p__17, typeof(JsonHelper), json, "solution", "token", true));
						TaskResultResponse.SolutionData solutionData3 = solutionData;
						if (TaskResultResponse.<>o__1.<>p__20 == null)
						{
							TaskResultResponse.<>o__1.<>p__20 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target12 = TaskResultResponse.<>o__1.<>p__20.Target;
						CallSite <>p__12 = TaskResultResponse.<>o__1.<>p__20;
						if (TaskResultResponse.<>o__1.<>p__19 == null)
						{
							TaskResultResponse.<>o__1.<>p__19 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant | CSharpArgumentInfoFlags.NamedArgument, "silent")
							}));
						}
						solutionData3.GRecaptchaResponse = target12(<>p__12, TaskResultResponse.<>o__1.<>p__19.Target(TaskResultResponse.<>o__1.<>p__19, typeof(JsonHelper), json, "solution", "gRecaptchaResponse", true));
						TaskResultResponse.SolutionData solutionData4 = solutionData;
						if (TaskResultResponse.<>o__1.<>p__22 == null)
						{
							TaskResultResponse.<>o__1.<>p__22 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target13 = TaskResultResponse.<>o__1.<>p__22.Target;
						CallSite <>p__13 = TaskResultResponse.<>o__1.<>p__22;
						if (TaskResultResponse.<>o__1.<>p__21 == null)
						{
							TaskResultResponse.<>o__1.<>p__21 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant | CSharpArgumentInfoFlags.NamedArgument, "silent")
							}));
						}
						solutionData4.GRecaptchaResponseMd5 = target13(<>p__13, TaskResultResponse.<>o__1.<>p__21.Target(TaskResultResponse.<>o__1.<>p__21, typeof(JsonHelper), json, "solution", "gRecaptchaResponseMd5", true));
						TaskResultResponse.SolutionData solutionData5 = solutionData;
						if (TaskResultResponse.<>o__1.<>p__24 == null)
						{
							TaskResultResponse.<>o__1.<>p__24 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target14 = TaskResultResponse.<>o__1.<>p__24.Target;
						CallSite <>p__14 = TaskResultResponse.<>o__1.<>p__24;
						if (TaskResultResponse.<>o__1.<>p__23 == null)
						{
							TaskResultResponse.<>o__1.<>p__23 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant | CSharpArgumentInfoFlags.NamedArgument, "silent")
							}));
						}
						solutionData5.Text = target14(<>p__14, TaskResultResponse.<>o__1.<>p__23.Target(TaskResultResponse.<>o__1.<>p__23, typeof(JsonHelper), json, "solution", "text", true));
						TaskResultResponse.SolutionData solutionData6 = solutionData;
						if (TaskResultResponse.<>o__1.<>p__26 == null)
						{
							TaskResultResponse.<>o__1.<>p__26 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
						}
						Func<CallSite, object, string> target15 = TaskResultResponse.<>o__1.<>p__26.Target;
						CallSite <>p__15 = TaskResultResponse.<>o__1.<>p__26;
						if (TaskResultResponse.<>o__1.<>p__25 == null)
						{
							TaskResultResponse.<>o__1.<>p__25 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant | CSharpArgumentInfoFlags.NamedArgument, "silent")
							}));
						}
						solutionData6.Url = target15(<>p__15, TaskResultResponse.<>o__1.<>p__25.Target(TaskResultResponse.<>o__1.<>p__25, typeof(JsonHelper), json, "solution", "url", true));
						this.Solution = solutionData;
						try
						{
							TaskResultResponse.SolutionData solution = this.Solution;
							if (TaskResultResponse.<>o__1.<>p__29 == null)
							{
								TaskResultResponse.<>o__1.<>p__29 = CallSite<Func<CallSite, object, JObject>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(JObject), typeof(TaskResultResponse)));
							}
							Func<CallSite, object, JObject> target16 = TaskResultResponse.<>o__1.<>p__29.Target;
							CallSite <>p__16 = TaskResultResponse.<>o__1.<>p__29;
							if (TaskResultResponse.<>o__1.<>p__28 == null)
							{
								TaskResultResponse.<>o__1.<>p__28 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "answers", typeof(TaskResultResponse), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target17 = TaskResultResponse.<>o__1.<>p__28.Target;
							CallSite <>p__17 = TaskResultResponse.<>o__1.<>p__28;
							if (TaskResultResponse.<>o__1.<>p__27 == null)
							{
								TaskResultResponse.<>o__1.<>p__27 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "solution", typeof(TaskResultResponse), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							solution.Answers = target16(<>p__16, target17(<>p__17, TaskResultResponse.<>o__1.<>p__27.Target(TaskResultResponse.<>o__1.<>p__27, json)));
						}
						catch
						{
							this.Solution.Answers = null;
						}
					}
				}
				else
				{
					if (TaskResultResponse.<>o__1.<>p__31 == null)
					{
						TaskResultResponse.<>o__1.<>p__31 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
					}
					Func<CallSite, object, string> target18 = TaskResultResponse.<>o__1.<>p__31.Target;
					CallSite <>p__18 = TaskResultResponse.<>o__1.<>p__31;
					if (TaskResultResponse.<>o__1.<>p__30 == null)
					{
						TaskResultResponse.<>o__1.<>p__30 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorCode = target18(<>p__18, TaskResultResponse.<>o__1.<>p__30.Target(TaskResultResponse.<>o__1.<>p__30, typeof(JsonHelper), json, "errorCode"));
					if (TaskResultResponse.<>o__1.<>p__33 == null)
					{
						TaskResultResponse.<>o__1.<>p__33 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(TaskResultResponse)));
					}
					Func<CallSite, object, string> target19 = TaskResultResponse.<>o__1.<>p__33.Target;
					CallSite <>p__19 = TaskResultResponse.<>o__1.<>p__33;
					if (TaskResultResponse.<>o__1.<>p__32 == null)
					{
						TaskResultResponse.<>o__1.<>p__32 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(TaskResultResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorDescription = target19(<>p__19, TaskResultResponse.<>o__1.<>p__32.Target(TaskResultResponse.<>o__1.<>p__32, typeof(JsonHelper), json, "errorDescription") ?? "(no error description)");
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		public int? ErrorId { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		public string ErrorCode { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000EDE1 File Offset: 0x0000CFE1
		public string ErrorDescription { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public TaskResultResponse.StatusType? Status { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000EDF1 File Offset: 0x0000CFF1
		public TaskResultResponse.SolutionData Solution { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000EDF9 File Offset: 0x0000CFF9
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000EE01 File Offset: 0x0000D001
		public double? Cost { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000EE0A File Offset: 0x0000D00A
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000EE12 File Offset: 0x0000D012
		public string Ip { get; private set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000EE1B File Offset: 0x0000D01B
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000EE23 File Offset: 0x0000D023
		public DateTime? CreateTime { get; private set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000EE2C File Offset: 0x0000D02C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000EE34 File Offset: 0x0000D034
		public DateTime? EndTime { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000EE3D File Offset: 0x0000D03D
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000EE45 File Offset: 0x0000D045
		public int? SolveCount { get; private set; }

		// Token: 0x060000C8 RID: 200 RVA: 0x0000EE50 File Offset: 0x0000D050
		private TaskResultResponse.StatusType? ParseStatus(string status)
		{
			bool flag = string.IsNullOrEmpty(status);
			TaskResultResponse.StatusType? result;
			if (flag)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new TaskResultResponse.StatusType?((TaskResultResponse.StatusType)Enum.Parse(typeof(TaskResultResponse.StatusType), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(status), true));
				}
				catch
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		private static DateTime? UnixTimeStampToDateTime(double? unixTimeStamp)
		{
			bool flag = unixTimeStamp == null;
			DateTime? result;
			if (flag)
			{
				result = null;
			}
			else
			{
				DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
				result = new DateTime?(dateTime.AddSeconds(unixTimeStamp.Value).ToUniversalTime());
			}
			return result;
		}

		// Token: 0x02000025 RID: 37
		public enum StatusType
		{
			// Token: 0x04000123 RID: 291
			Processing,
			// Token: 0x04000124 RID: 292
			Ready
		}

		// Token: 0x02000026 RID: 38
		public class SolutionData
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000F437 File Offset: 0x0000D637
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000F43F File Offset: 0x0000D63F
			public JObject Answers { get; internal set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000F448 File Offset: 0x0000D648
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000F450 File Offset: 0x0000D650
			public string GRecaptchaResponse { get; internal set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000F459 File Offset: 0x0000D659
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000F461 File Offset: 0x0000D661
			public string GRecaptchaResponseMd5 { get; internal set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000F46A File Offset: 0x0000D66A
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000F472 File Offset: 0x0000D672
			public string Text { get; internal set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000F47B File Offset: 0x0000D67B
			// (set) Token: 0x060000EA RID: 234 RVA: 0x0000F483 File Offset: 0x0000D683
			public string Url { get; internal set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000EB RID: 235 RVA: 0x0000F48C File Offset: 0x0000D68C
			// (set) Token: 0x060000EC RID: 236 RVA: 0x0000F494 File Offset: 0x0000D694
			public string Token { get; internal set; }
		}
	}
}

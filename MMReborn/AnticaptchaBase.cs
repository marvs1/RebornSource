using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;
using MMReborn.ApiResponse;
using MMReborn.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MMReborn
{
	// Token: 0x02000002 RID: 2
	public abstract class AnticaptchaBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public string ErrorMessage { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public int TaskId { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000207B File Offset: 0x0000027B
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public string ClientKey { private get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00000283
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000208B File Offset: 0x0000028B
		public TaskResultResponse TaskInfo { get; protected set; }

		// Token: 0x06000009 RID: 9
		public abstract JObject GetPostData();

		// Token: 0x0600000A RID: 10 RVA: 0x00002094 File Offset: 0x00000294
		public bool CreateTask()
		{
			JObject postData = this.GetPostData();
			bool flag = postData == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				JObject jobject = new JObject();
				jobject["clientKey"] = this.ClientKey;
				jobject["task"] = postData;
				object obj = this.JsonPostRequest(AnticaptchaBase.ApiMethod.CreateTask, jobject);
				if (AnticaptchaBase.<>o__20.<>p__0 == null)
				{
					AnticaptchaBase.<>o__20.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object obj2 = AnticaptchaBase.<>o__20.<>p__0.Target(AnticaptchaBase.<>o__20.<>p__0, obj, null);
				if (AnticaptchaBase.<>o__20.<>p__4 == null)
				{
					AnticaptchaBase.<>o__20.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				bool flag2;
				if (!AnticaptchaBase.<>o__20.<>p__4.Target(AnticaptchaBase.<>o__20.<>p__4, obj2))
				{
					if (AnticaptchaBase.<>o__20.<>p__3 == null)
					{
						AnticaptchaBase.<>o__20.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = AnticaptchaBase.<>o__20.<>p__3.Target;
					CallSite <>p__ = AnticaptchaBase.<>o__20.<>p__3;
					if (AnticaptchaBase.<>o__20.<>p__2 == null)
					{
						AnticaptchaBase.<>o__20.<>p__2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> target2 = AnticaptchaBase.<>o__20.<>p__2.Target;
					CallSite <>p__2 = AnticaptchaBase.<>o__20.<>p__2;
					object arg = obj2;
					if (AnticaptchaBase.<>o__20.<>p__1 == null)
					{
						AnticaptchaBase.<>o__20.<>p__1 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Equals", null, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					flag2 = target(<>p__, target2(<>p__2, arg, AnticaptchaBase.<>o__20.<>p__1.Target(AnticaptchaBase.<>o__20.<>p__1, obj, false)));
				}
				else
				{
					flag2 = true;
				}
				bool flag3 = flag2;
				if (flag3)
				{
					result = false;
				}
				else
				{
					if (AnticaptchaBase.<>o__20.<>p__5 == null)
					{
						AnticaptchaBase.<>o__20.<>p__5 = CallSite<Func<CallSite, Type, object, CreateTaskResponse>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					CreateTaskResponse createTaskResponse = AnticaptchaBase.<>o__20.<>p__5.Target(AnticaptchaBase.<>o__20.<>p__5, typeof(CreateTaskResponse), obj);
					bool flag4 = !createTaskResponse.ErrorId.Equals(0);
					if (flag4)
					{
						this.ErrorMessage = createTaskResponse.ErrorDescription;
						result = false;
					}
					else
					{
						bool flag5 = createTaskResponse.TaskId == null;
						if (flag5)
						{
							result = false;
						}
						else
						{
							this.TaskId = createTaskResponse.TaskId.Value;
							result = true;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002370 File Offset: 0x00000570
		public bool WaitForResult(int maxSeconds = 120, int currentSecond = 0)
		{
			bool flag = currentSecond >= maxSeconds;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = currentSecond.Equals(0);
				if (flag2)
				{
					Thread.Sleep(3000);
				}
				else
				{
					Thread.Sleep(1000);
				}
				JObject jobject = new JObject();
				jobject["clientKey"] = this.ClientKey;
				jobject["taskId"] = this.TaskId;
				object obj = this.JsonPostRequest(AnticaptchaBase.ApiMethod.GetTaskResult, jobject);
				if (AnticaptchaBase.<>o__21.<>p__0 == null)
				{
					AnticaptchaBase.<>o__21.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object obj2 = AnticaptchaBase.<>o__21.<>p__0.Target(AnticaptchaBase.<>o__21.<>p__0, obj, null);
				if (AnticaptchaBase.<>o__21.<>p__4 == null)
				{
					AnticaptchaBase.<>o__21.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				bool flag3;
				if (!AnticaptchaBase.<>o__21.<>p__4.Target(AnticaptchaBase.<>o__21.<>p__4, obj2))
				{
					if (AnticaptchaBase.<>o__21.<>p__3 == null)
					{
						AnticaptchaBase.<>o__21.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = AnticaptchaBase.<>o__21.<>p__3.Target;
					CallSite <>p__ = AnticaptchaBase.<>o__21.<>p__3;
					if (AnticaptchaBase.<>o__21.<>p__2 == null)
					{
						AnticaptchaBase.<>o__21.<>p__2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> target2 = AnticaptchaBase.<>o__21.<>p__2.Target;
					CallSite <>p__2 = AnticaptchaBase.<>o__21.<>p__2;
					object arg = obj2;
					if (AnticaptchaBase.<>o__21.<>p__1 == null)
					{
						AnticaptchaBase.<>o__21.<>p__1 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Equals", null, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					flag3 = target(<>p__, target2(<>p__2, arg, AnticaptchaBase.<>o__21.<>p__1.Target(AnticaptchaBase.<>o__21.<>p__1, obj, false)));
				}
				else
				{
					flag3 = true;
				}
				bool flag4 = flag3;
				if (flag4)
				{
					result = false;
				}
				else
				{
					if (AnticaptchaBase.<>o__21.<>p__5 == null)
					{
						AnticaptchaBase.<>o__21.<>p__5 = CallSite<Func<CallSite, Type, object, TaskResultResponse>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					this.TaskInfo = AnticaptchaBase.<>o__21.<>p__5.Target(AnticaptchaBase.<>o__21.<>p__5, typeof(TaskResultResponse), obj);
					bool flag5 = !this.TaskInfo.ErrorId.Equals(0);
					if (flag5)
					{
						this.ErrorMessage = this.TaskInfo.ErrorDescription;
						result = false;
					}
					else
					{
						bool flag6 = this.TaskInfo.Status.Equals(TaskResultResponse.StatusType.Processing);
						if (flag6)
						{
							result = this.WaitForResult(maxSeconds, currentSecond + 1);
						}
						else
						{
							bool flag7 = this.TaskInfo.Status.Equals(TaskResultResponse.StatusType.Ready);
							if (flag7)
							{
								bool flag8 = this.TaskInfo.Solution.GRecaptchaResponse == null && this.TaskInfo.Solution.Text == null && this.TaskInfo.Solution.Answers == null && this.TaskInfo.Solution.Token == null;
								result = !flag8;
							}
							else
							{
								this.ErrorMessage = "An unknown API status, please update your software";
								result = false;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002718 File Offset: 0x00000918
		[return: Dynamic]
		private dynamic JsonPostRequest(AnticaptchaBase.ApiMethod methodName, JObject jsonPostData)
		{
			string arg = char.ToLowerInvariant(methodName.ToString()[0]).ToString() + methodName.ToString().Substring(1);
			string text;
			object obj = HttpHelper.Post(new Uri(AnticaptchaBase.SchemeType.Https + "://api.anti-captcha.com/" + arg), JsonConvert.SerializeObject(jsonPostData, Formatting.Indented), out text);
			bool flag = string.IsNullOrEmpty(text);
			if (flag)
			{
				if (AnticaptchaBase.<>o__22.<>p__1 == null)
				{
					AnticaptchaBase.<>o__22.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = AnticaptchaBase.<>o__22.<>p__1.Target;
				CallSite <>p__ = AnticaptchaBase.<>o__22.<>p__1;
				if (AnticaptchaBase.<>o__22.<>p__0 == null)
				{
					AnticaptchaBase.<>o__22.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				bool flag2 = target(<>p__, AnticaptchaBase.<>o__22.<>p__0.Target(AnticaptchaBase.<>o__22.<>p__0, obj, null));
				if (!flag2)
				{
					return obj;
				}
				text = "Got empty or invalid response from API";
			}
			else
			{
				text = "HTTP or JSON error: " + text;
			}
			return false;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002860 File Offset: 0x00000A60
		public double? GetBalance()
		{
			JObject jobject = new JObject();
			jobject["clientKey"] = this.ClientKey;
			object obj = this.JsonPostRequest(AnticaptchaBase.ApiMethod.GetBalance, jobject);
			if (AnticaptchaBase.<>o__23.<>p__0 == null)
			{
				AnticaptchaBase.<>o__23.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object obj2 = AnticaptchaBase.<>o__23.<>p__0.Target(AnticaptchaBase.<>o__23.<>p__0, obj, null);
			if (AnticaptchaBase.<>o__23.<>p__4 == null)
			{
				AnticaptchaBase.<>o__23.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			bool flag;
			if (!AnticaptchaBase.<>o__23.<>p__4.Target(AnticaptchaBase.<>o__23.<>p__4, obj2))
			{
				if (AnticaptchaBase.<>o__23.<>p__3 == null)
				{
					AnticaptchaBase.<>o__23.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = AnticaptchaBase.<>o__23.<>p__3.Target;
				CallSite <>p__ = AnticaptchaBase.<>o__23.<>p__3;
				if (AnticaptchaBase.<>o__23.<>p__2 == null)
				{
					AnticaptchaBase.<>o__23.<>p__2 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = AnticaptchaBase.<>o__23.<>p__2.Target;
				CallSite <>p__2 = AnticaptchaBase.<>o__23.<>p__2;
				object arg = obj2;
				if (AnticaptchaBase.<>o__23.<>p__1 == null)
				{
					AnticaptchaBase.<>o__23.<>p__1 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Equals", null, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				flag = target(<>p__, target2(<>p__2, arg, AnticaptchaBase.<>o__23.<>p__1.Target(AnticaptchaBase.<>o__23.<>p__1, obj, false)));
			}
			else
			{
				flag = true;
			}
			bool flag2 = flag;
			double? result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				if (AnticaptchaBase.<>o__23.<>p__5 == null)
				{
					AnticaptchaBase.<>o__23.<>p__5 = CallSite<Func<CallSite, Type, object, BalanceResponse>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(AnticaptchaBase), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				BalanceResponse balanceResponse = AnticaptchaBase.<>o__23.<>p__5.Target(AnticaptchaBase.<>o__23.<>p__5, typeof(BalanceResponse), obj);
				bool flag3 = !balanceResponse.ErrorId.Equals(0);
				if (flag3)
				{
					this.ErrorMessage = balanceResponse.ErrorDescription;
					result = null;
				}
				else
				{
					result = balanceResponse.Balance;
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const string Host = "api.anti-captcha.com";

		// Token: 0x04000002 RID: 2
		private const AnticaptchaBase.SchemeType Scheme = AnticaptchaBase.SchemeType.Https;

		// Token: 0x02000012 RID: 18
		public enum ProxyTypeOption
		{
			// Token: 0x040000CA RID: 202
			Http,
			// Token: 0x040000CB RID: 203
			Socks4,
			// Token: 0x040000CC RID: 204
			Socks5
		}

		// Token: 0x02000013 RID: 19
		private enum ApiMethod
		{
			// Token: 0x040000CE RID: 206
			CreateTask,
			// Token: 0x040000CF RID: 207
			GetTaskResult,
			// Token: 0x040000D0 RID: 208
			GetBalance
		}

		// Token: 0x02000014 RID: 20
		private enum SchemeType
		{
			// Token: 0x040000D2 RID: 210
			Http,
			// Token: 0x040000D3 RID: 211
			Https
		}
	}
}

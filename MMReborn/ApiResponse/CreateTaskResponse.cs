using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using MMReborn.Helper;

namespace MMReborn.ApiResponse
{
	// Token: 0x02000010 RID: 16
	public class CreateTaskResponse
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		public CreateTaskResponse(dynamic json)
		{
			if (CreateTaskResponse.<>o__0.<>p__1 == null)
			{
				CreateTaskResponse.<>o__0.<>p__1 = CallSite<Func<CallSite, object, int?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int?), typeof(CreateTaskResponse)));
			}
			Func<CallSite, object, int?> target = CreateTaskResponse.<>o__0.<>p__1.Target;
			CallSite <>p__ = CreateTaskResponse.<>o__0.<>p__1;
			if (CreateTaskResponse.<>o__0.<>p__0 == null)
			{
				CreateTaskResponse.<>o__0.<>p__0 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractInt", null, typeof(CreateTaskResponse), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			this.ErrorId = target(<>p__, CreateTaskResponse.<>o__0.<>p__0.Target(CreateTaskResponse.<>o__0.<>p__0, typeof(JsonHelper), json, "errorId"));
			bool flag = this.ErrorId != null;
			if (flag)
			{
				bool flag2 = this.ErrorId.Equals(0);
				if (flag2)
				{
					if (CreateTaskResponse.<>o__0.<>p__3 == null)
					{
						CreateTaskResponse.<>o__0.<>p__3 = CallSite<Func<CallSite, object, int?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int?), typeof(CreateTaskResponse)));
					}
					Func<CallSite, object, int?> target2 = CreateTaskResponse.<>o__0.<>p__3.Target;
					CallSite <>p__2 = CreateTaskResponse.<>o__0.<>p__3;
					if (CreateTaskResponse.<>o__0.<>p__2 == null)
					{
						CreateTaskResponse.<>o__0.<>p__2 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractInt", null, typeof(CreateTaskResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.TaskId = target2(<>p__2, CreateTaskResponse.<>o__0.<>p__2.Target(CreateTaskResponse.<>o__0.<>p__2, typeof(JsonHelper), json, "taskId"));
				}
				else
				{
					if (CreateTaskResponse.<>o__0.<>p__5 == null)
					{
						CreateTaskResponse.<>o__0.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CreateTaskResponse)));
					}
					Func<CallSite, object, string> target3 = CreateTaskResponse.<>o__0.<>p__5.Target;
					CallSite <>p__3 = CreateTaskResponse.<>o__0.<>p__5;
					if (CreateTaskResponse.<>o__0.<>p__4 == null)
					{
						CreateTaskResponse.<>o__0.<>p__4 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(CreateTaskResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorCode = target3(<>p__3, CreateTaskResponse.<>o__0.<>p__4.Target(CreateTaskResponse.<>o__0.<>p__4, typeof(JsonHelper), json, "errorCode"));
					if (CreateTaskResponse.<>o__0.<>p__7 == null)
					{
						CreateTaskResponse.<>o__0.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CreateTaskResponse)));
					}
					Func<CallSite, object, string> target4 = CreateTaskResponse.<>o__0.<>p__7.Target;
					CallSite <>p__4 = CreateTaskResponse.<>o__0.<>p__7;
					if (CreateTaskResponse.<>o__0.<>p__6 == null)
					{
						CreateTaskResponse.<>o__0.<>p__6 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(CreateTaskResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorDescription = target4(<>p__4, CreateTaskResponse.<>o__0.<>p__6.Target(CreateTaskResponse.<>o__0.<>p__6, typeof(JsonHelper), json, "errorDescription") ?? "(no error description)");
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000DFF3 File Offset: 0x0000C1F3
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000DFFB File Offset: 0x0000C1FB
		public int? ErrorId { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000E004 File Offset: 0x0000C204
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000E00C File Offset: 0x0000C20C
		public string ErrorCode { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000E015 File Offset: 0x0000C215
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000E01D File Offset: 0x0000C21D
		public string ErrorDescription { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000E026 File Offset: 0x0000C226
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000E02E File Offset: 0x0000C22E
		public int? TaskId { get; private set; }
	}
}

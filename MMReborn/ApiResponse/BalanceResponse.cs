using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using MMReborn.Helper;

namespace MMReborn.ApiResponse
{
	// Token: 0x0200000F RID: 15
	public class BalanceResponse
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x0000D920 File Offset: 0x0000BB20
		public BalanceResponse(dynamic json)
		{
			if (BalanceResponse.<>o__0.<>p__1 == null)
			{
				BalanceResponse.<>o__0.<>p__1 = CallSite<Func<CallSite, object, int?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int?), typeof(BalanceResponse)));
			}
			Func<CallSite, object, int?> target = BalanceResponse.<>o__0.<>p__1.Target;
			CallSite <>p__ = BalanceResponse.<>o__0.<>p__1;
			if (BalanceResponse.<>o__0.<>p__0 == null)
			{
				BalanceResponse.<>o__0.<>p__0 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractInt", null, typeof(BalanceResponse), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			this.ErrorId = target(<>p__, BalanceResponse.<>o__0.<>p__0.Target(BalanceResponse.<>o__0.<>p__0, typeof(JsonHelper), json, "errorId"));
			bool flag = this.ErrorId != null;
			if (flag)
			{
				bool flag2 = this.ErrorId.Equals(0);
				if (flag2)
				{
					if (BalanceResponse.<>o__0.<>p__3 == null)
					{
						BalanceResponse.<>o__0.<>p__3 = CallSite<Func<CallSite, object, double?>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double?), typeof(BalanceResponse)));
					}
					Func<CallSite, object, double?> target2 = BalanceResponse.<>o__0.<>p__3.Target;
					CallSite <>p__2 = BalanceResponse.<>o__0.<>p__3;
					if (BalanceResponse.<>o__0.<>p__2 == null)
					{
						BalanceResponse.<>o__0.<>p__2 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractDouble", null, typeof(BalanceResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.Balance = target2(<>p__2, BalanceResponse.<>o__0.<>p__2.Target(BalanceResponse.<>o__0.<>p__2, typeof(JsonHelper), json, "balance"));
				}
				else
				{
					if (BalanceResponse.<>o__0.<>p__5 == null)
					{
						BalanceResponse.<>o__0.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(BalanceResponse)));
					}
					Func<CallSite, object, string> target3 = BalanceResponse.<>o__0.<>p__5.Target;
					CallSite <>p__3 = BalanceResponse.<>o__0.<>p__5;
					if (BalanceResponse.<>o__0.<>p__4 == null)
					{
						BalanceResponse.<>o__0.<>p__4 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(BalanceResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorCode = target3(<>p__3, BalanceResponse.<>o__0.<>p__4.Target(BalanceResponse.<>o__0.<>p__4, typeof(JsonHelper), json, "errorCode"));
					if (BalanceResponse.<>o__0.<>p__7 == null)
					{
						BalanceResponse.<>o__0.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(BalanceResponse)));
					}
					Func<CallSite, object, string> target4 = BalanceResponse.<>o__0.<>p__7.Target;
					CallSite <>p__4 = BalanceResponse.<>o__0.<>p__7;
					if (BalanceResponse.<>o__0.<>p__6 == null)
					{
						BalanceResponse.<>o__0.<>p__6 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(BalanceResponse), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					this.ErrorDescription = target4(<>p__4, BalanceResponse.<>o__0.<>p__6.Target(BalanceResponse.<>o__0.<>p__6, typeof(JsonHelper), json, "errorDescription") ?? "(no error description)");
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000DC67 File Offset: 0x0000BE67
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000DC6F File Offset: 0x0000BE6F
		public int? ErrorId { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000DC78 File Offset: 0x0000BE78
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000DC80 File Offset: 0x0000BE80
		public string ErrorCode { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000DC89 File Offset: 0x0000BE89
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000DC91 File Offset: 0x0000BE91
		public string ErrorDescription { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000DC9A File Offset: 0x0000BE9A
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000DCA2 File Offset: 0x0000BEA2
		public double? Balance { get; private set; }
	}
}

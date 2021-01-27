using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace MMReborn.Helper
{
	// Token: 0x0200000C RID: 12
	public class JsonHelper
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		public static string ExtractStr(dynamic json, string firstLevel, string secondLevel = null, bool silent = false)
		{
			string text = firstLevel + ((secondLevel == null) ? "" : ("=>" + secondLevel));
			string result;
			try
			{
				if (JsonHelper.<>o__0.<>p__0 == null)
				{
					JsonHelper.<>o__0.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(JsonHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				object obj = JsonHelper.<>o__0.<>p__0.Target(JsonHelper.<>o__0.<>p__0, json, firstLevel);
				bool flag = obj != null && secondLevel != null;
				if (flag)
				{
					if (JsonHelper.<>o__0.<>p__2 == null)
					{
						JsonHelper.<>o__0.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(JsonHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, string, object> target = JsonHelper.<>o__0.<>p__2.Target;
					CallSite <>p__ = JsonHelper.<>o__0.<>p__2;
					if (JsonHelper.<>o__0.<>p__1 == null)
					{
						JsonHelper.<>o__0.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(JsonHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					obj = target(<>p__, JsonHelper.<>o__0.<>p__1.Target(JsonHelper.<>o__0.<>p__1, json, firstLevel), secondLevel);
				}
				bool flag2 = obj == null;
				if (flag2)
				{
					result = null;
				}
				else
				{
					result = obj.ToString();
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000D360 File Offset: 0x0000B560
		public static string AsString(dynamic json)
		{
			if (JsonHelper.<>o__1.<>p__1 == null)
			{
				JsonHelper.<>o__1.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(JsonHelper)));
			}
			Func<CallSite, object, string> target = JsonHelper.<>o__1.<>p__1.Target;
			CallSite <>p__ = JsonHelper.<>o__1.<>p__1;
			if (JsonHelper.<>o__1.<>p__0 == null)
			{
				JsonHelper.<>o__1.<>p__0 = CallSite<Func<CallSite, Type, object, Formatting, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "SerializeObject", null, typeof(JsonHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			return target(<>p__, JsonHelper.<>o__1.<>p__0.Target(JsonHelper.<>o__1.<>p__0, typeof(JsonConvert), json, Formatting.Indented));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D424 File Offset: 0x0000B624
		public static double? ExtractDouble(dynamic json, string firstLevel, string secondLevel = null)
		{
			if (JsonHelper.<>o__2.<>p__1 == null)
			{
				JsonHelper.<>o__2.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(JsonHelper)));
			}
			Func<CallSite, object, string> target = JsonHelper.<>o__2.<>p__1.Target;
			CallSite <>p__ = JsonHelper.<>o__2.<>p__1;
			if (JsonHelper.<>o__2.<>p__0 == null)
			{
				JsonHelper.<>o__2.<>p__0 = CallSite<Func<CallSite, Type, object, string, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(JsonHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			string text = target(<>p__, JsonHelper.<>o__2.<>p__0.Target(JsonHelper.<>o__2.<>p__0, typeof(JsonHelper), json, firstLevel, secondLevel));
			double value;
			bool flag = text == null || !double.TryParse(text.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out value);
			double? result;
			if (flag)
			{
				string text2 = firstLevel + ((secondLevel == null) ? "" : ("=>" + secondLevel));
				result = null;
			}
			else
			{
				result = new double?(value);
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D550 File Offset: 0x0000B750
		public static int? ExtractInt(dynamic json, string firstLevel, string secondLevel = null, bool silent = false)
		{
			if (JsonHelper.<>o__3.<>p__1 == null)
			{
				JsonHelper.<>o__3.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(JsonHelper)));
			}
			Func<CallSite, object, string> target = JsonHelper.<>o__3.<>p__1.Target;
			CallSite <>p__ = JsonHelper.<>o__3.<>p__1;
			if (JsonHelper.<>o__3.<>p__0 == null)
			{
				JsonHelper.<>o__3.<>p__0 = CallSite<Func<CallSite, Type, object, string, string, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ExtractStr", null, typeof(JsonHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			string s = target(<>p__, JsonHelper.<>o__3.<>p__0.Target(JsonHelper.<>o__3.<>p__0, typeof(JsonHelper), json, firstLevel, secondLevel, silent));
			int value;
			bool flag = !int.TryParse(s, out value);
			int? result;
			if (flag)
			{
				string text = firstLevel + ((secondLevel == null) ? "" : ("=>" + secondLevel));
				result = null;
			}
			else
			{
				result = new int?(value);
			}
			return result;
		}
	}
}

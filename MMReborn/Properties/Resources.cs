using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MMReborn.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000D02C File Offset: 0x0000B22C
		internal Resources()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000D038 File Offset: 0x0000B238
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("MMReborn.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000D080 File Offset: 0x0000B280
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000D097 File Offset: 0x0000B297
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000AA RID: 170
		private static ResourceManager resourceMan;

		// Token: 0x040000AB RID: 171
		private static CultureInfo resourceCulture;
	}
}

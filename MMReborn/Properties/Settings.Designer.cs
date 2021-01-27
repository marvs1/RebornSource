using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MMReborn.Properties
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000AC RID: 172
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

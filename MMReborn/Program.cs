using System;
using System.Windows.Forms;

namespace MMReborn
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

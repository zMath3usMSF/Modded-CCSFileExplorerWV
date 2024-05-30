using System;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000016 RID: 22
	internal static class Program
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00008EBE File Offset: 0x000070BE
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

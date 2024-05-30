using System;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200003B RID: 59
	public class ErrorBlock : Block
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public ErrorBlock(string message)
		{
			this.error = message;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000BC0B File Offset: 0x00009E0B
		public override TreeNode ToNode()
		{
			return new TreeNode(this.error);
		}

		// Token: 0x040000CF RID: 207
		public string error;
	}
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000010 RID: 16
	public class ObjectEntry
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public ObjectEntry(string desc)
		{
			this.name = desc;
			this.blocks = new List<Block>();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003CDC File Offset: 0x00001EDC
		public TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.name);
			foreach (Block b in this.blocks)
			{
				result.Nodes.Add(b.ToNode());
			}
			return result;
		}

		// Token: 0x0400002A RID: 42
		public string name;

		// Token: 0x0400002B RID: 43
		public List<Block> blocks;
	}
}

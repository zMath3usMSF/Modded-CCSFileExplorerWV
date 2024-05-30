using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000024 RID: 36
	public class Block0400 : Block
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x0000A56C File Offset: 0x0000876C
		public Block0400(Stream s)
		{
			long length = s.Length;
			this.unknown = new List<uint>();
			while (s.Position < length)
			{
				uint u = StreamHelper.ReadUInt32(s);
				if (Block.isValidBlockType(u))
				{
					s.Seek(-4L, SeekOrigin.Current);
					return;
				}
				this.unknown.Add(u);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000A5C5 File Offset: 0x000087C5
		public override TreeNode ToNode()
		{
			return new TreeNode(this.type.ToString("X8"));
		}

		// Token: 0x040000B3 RID: 179
		public List<uint> unknown;
	}
}

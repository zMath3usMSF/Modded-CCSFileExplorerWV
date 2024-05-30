using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200002D RID: 45
	public class Block0800 : Block
	{
		// Token: 0x060000FE RID: 254 RVA: 0x0000AD90 File Offset: 0x00008F90
		public Block0800(Stream s)
		{
			this.type = 3435923456U;
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

		// Token: 0x060000FF RID: 255 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000C1 RID: 193
		public List<uint> unknown;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000023 RID: 35
	public class Block0300 : Block
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public Block0300(Stream s)
		{
			this.type = 3435922176U;
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

		// Token: 0x060000E4 RID: 228 RVA: 0x0000A538 File Offset: 0x00008738
		public override TreeNode ToNode()
		{
			return new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
		}

		// Token: 0x040000B2 RID: 178
		public List<uint> unknown;
	}
}

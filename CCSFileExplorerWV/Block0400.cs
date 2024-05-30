using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x0200000C RID: 12
	public class Block0400 : Block
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00003670 File Offset: 0x00001870
		public Block0400(Stream s)
		{
			this.BlockID = 3435922432U;
			long length = s.Length;
			this.unknown = new List<uint>();
			while (s.Position < length)
			{
				uint u = Block.ReadUInt32(s);
				if (Block.isValidBlockType(u))
				{
					s.Seek(-4L, SeekOrigin.Current);
					return;
				}
				this.unknown.Add(u);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000036D4 File Offset: 0x000018D4
		public override TreeNode ToNode()
		{
			return new TreeNode(this.BlockID.ToString("X8"));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000036EC File Offset: 0x000018EC
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, this.BlockID);
			Block.WriteUInt32(s, (uint)(this.Data.Length / 4 + 51));
			Block.WriteUInt32(s, this.ID);
			s.Write(this.Data, 0, this.Data.Length);
		}

		// Token: 0x0400001C RID: 28
		public List<uint> unknown;
	}
}

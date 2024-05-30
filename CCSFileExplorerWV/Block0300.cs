using System;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000009 RID: 9
	public class Block0300 : Block
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public Block0300(Stream s)
		{
			this.Size = Block.ReadUInt32(s);
			this.ID = Block.ReadUInt32(s);
			uint size = this.Size - 1U;
			MemoryStream i = new MemoryStream();
			uint j = 0U;
			uint u = 0;
			while (j++ < size - 0x32)
			{
				u = Block.ReadUInt32(s);
                i.Write(BitConverter.GetBytes(u), 0, 4);
			}
			if (Block.isValidBlockType(u))
			{
				s.Seek(-4L, SeekOrigin.Current);
			}
			this.Data = i.ToArray();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C24 File Offset: 0x00000E24
		public override TreeNode ToNode()
		{
			return new TreeNode(string.Concat(new string[]
			{
				this.BlockID.ToString("X8"),
				"ID:0x",
				this.ID.ToString("X"),
				" Size: 0x",
				this.Data.Length.ToString("X")
			}));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002C90 File Offset: 0x00000E90
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, this.BlockID);
			Block.WriteUInt32(s, (uint)(this.Data.Length / 4 + 51));
			Block.WriteUInt32(s, this.ID);
			s.Write(this.Data, 0, this.Data.Length);
		}
	}
}

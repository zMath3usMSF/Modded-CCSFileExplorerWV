using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000006 RID: 6
	public class Block0001 : Block
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000025F4 File Offset: 0x000007F4
		public Block0001(Stream s)
		{
			this.Size = Block.ReadUInt32(s);
			this.ID = Block.ReadUInt32(s);
			uint size = this.Size - 1U;
			this.Data = new byte[size * 4U];
			s.Read(this.Data, 0, (int)(size * 4U));
			this.Name = Block.ReadFixedLenString(this.Data, 0, 32);
			this.Unknown = new List<uint>();
			int i = 0;
			while ((long)i < (long)((ulong)(size - 8U)))
			{
				this.Unknown.Add(BitConverter.ToUInt32(this.Data, i * 4 + 32));
				i++;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002694 File Offset: 0x00000894
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

		// Token: 0x06000019 RID: 25 RVA: 0x00002700 File Offset: 0x00000900
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, this.BlockID);
			Block.WriteUInt32(s, (uint)(this.Data.Length / 4 + 1));
			Block.WriteUInt32(s, this.ID);
			s.Write(this.Data, 0, this.Data.Length);
		}

		// Token: 0x0400000C RID: 12
		public string Name;

		// Token: 0x0400000D RID: 13
		public List<uint> Unknown;
	}
}

using System;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000008 RID: 8
	public class Block0005 : Block
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002A58 File Offset: 0x00000C58
		public override byte[] FullBlockData
		{
			get
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(BitConverter.GetBytes(this.BlockID), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.Size), 0, 4);
				memoryStream.Write(this.Data, 0, this.Data.Length);
				return memoryStream.ToArray();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002AAC File Offset: 0x00000CAC
		public Block0005(Stream s)
		{
			this.Size = Block.ReadUInt32(s);
			uint size = this.Size;
			this.ID = uint.MaxValue;
			this.Data = new byte[size * 4U];
			s.Read(this.Data, 0, (int)(size * 4U));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002AF8 File Offset: 0x00000CF8
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

		// Token: 0x06000021 RID: 33 RVA: 0x00002B63 File Offset: 0x00000D63
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, this.BlockID);
			Block.WriteUInt32(s, 1U);
			Block.WriteUInt32(s, 1U);
		}
	}
}

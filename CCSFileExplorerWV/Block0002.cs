using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000007 RID: 7
	public class Block0002 : Block
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000274C File Offset: 0x0000094C
		public override byte[] FullBlockData
		{
			get
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(BitConverter.GetBytes(this.BlockID), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.Size), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.FileCount + 1U), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.ObjCount + 1U), 0, 4);
				memoryStream.Write(this.Data, 0, this.Data.Length);
				return memoryStream.ToArray();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027C8 File Offset: 0x000009C8
		public Block0002(Stream s)
		{
			this.ID = uint.MaxValue;
			this.Size = Block.ReadUInt32(s);
			this.FileCount = Block.ReadUInt32(s) - 1U;
			this.ObjCount = Block.ReadUInt32(s) - 1U;
			uint size = this.Size;
			this.Data = new byte[size * 4U];
			s.Read(this.Data, 0, (int)(size * 4U));
			int pos = 32;
			this.filenames = new List<string>();
			int i = 0;
			while ((long)i < (long)((ulong)this.FileCount))
			{
				this.filenames.Add(Block.ReadFixedLenString(this.Data, pos, 0x20));
				pos += 32;
				i++;
			}
			pos += 32;
			this.objnames = new List<string>();
			this.indexes = new List<ushort>();
			int j = 0;
			while ((long)j < (long)((ulong)this.ObjCount))
			{
				this.objnames.Add(Block.ReadFixedLenString(this.Data, pos, 0x1E));
				this.indexes.Add(BitConverter.ToUInt16(this.Data, pos + 30));
				pos += 32;
				j++;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028D4 File Offset: 0x00000AD4
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

		// Token: 0x0600001D RID: 29 RVA: 0x00002940 File Offset: 0x00000B40
		public override void WriteBlock(Stream s)
		{
			Block.WriteUInt32(s, this.BlockID);
			MemoryStream i = new MemoryStream();
			i.Write(new byte[32], 0, 32);
			foreach (string name in this.filenames)
			{
				Block.WriteString(i, name, 32);
			}
			i.Write(new byte[32], 0, 32);
			int j = 0;
			while ((long)j < (long)((ulong)this.ObjCount))
			{
				Block.WriteString(i, this.objnames[j], 30);
				i.Write(BitConverter.GetBytes(this.indexes[j]), 0, 2);
				j++;
			}
			Block.WriteUInt32(i, 3U);
			Block.WriteUInt32(i, 0U);
			Block.WriteUInt32(s, (uint)(i.Length / 4L));
			Block.WriteUInt32(s, this.FileCount + 1U);
			Block.WriteUInt32(s, this.ObjCount + 1U);
			s.Write(i.ToArray(), 0, (int)i.Length);
		}

		// Token: 0x0400000E RID: 14
		public uint FileCount;

		// Token: 0x0400000F RID: 15
		public uint ObjCount;

		// Token: 0x04000010 RID: 16
		public List<string> filenames;

		// Token: 0x04000011 RID: 17
		public List<string> objnames;

		// Token: 0x04000012 RID: 18
		public List<ushort> indexes;
	}
}

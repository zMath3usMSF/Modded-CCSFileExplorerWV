using System;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200002C RID: 44
	public class Block0700 : Block
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000AC50 File Offset: 0x00008E50
		public Block0700(Stream s)
		{
			this.type = 3435923200U;
			uint size = StreamHelper.ReadUInt32(s) * 4U;
			byte[] buff = new byte[size];
			s.Read(buff, 0, (int)size);
			MemoryStream i = new MemoryStream();
			i.Write(buff, 12, buff.Length - 12);
			i.Seek(0L, SeekOrigin.Begin);
			this.subBlocks = Block.ReadBlocks(i);
			this.unk1 = BitConverter.ToUInt32(buff, 0);
			this.unk2 = BitConverter.ToUInt32(buff, 4);
			this.unk3 = BitConverter.ToUInt32(buff, 8);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public override TreeNode ToNode()
		{
			return new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8") + " +")
			{
				Nodes = 
				{
					"Unknown 1 : 0x" + this.unk1.ToString("X8"),
					"Unknown 2 : 0x" + this.unk2.ToString("X8"),
					"Unknown 3 : 0x" + this.unk3.ToString("X8")
				}
			};
		}

		// Token: 0x040000BE RID: 190
		public uint unk1;

		// Token: 0x040000BF RID: 191
		public uint unk2;

		// Token: 0x040000C0 RID: 192
		public uint unk3;
	}
}

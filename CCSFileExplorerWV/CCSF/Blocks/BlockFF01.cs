using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200003A RID: 58
	public class BlockFF01 : Block
	{
		// Token: 0x06000118 RID: 280 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		public BlockFF01(Stream s)
		{
			this.type = 3435986689U;
			uint size = StreamHelper.ReadUInt32(s) * 4U;
			byte[] buff = new byte[size];
			s.Read(buff, 0, (int)size);
			this.unknown = new List<uint>();
			int i = 0;
			while ((long)i < (long)((ulong)(size / 4U)))
			{
				this.unknown.Add(BitConverter.ToUInt32(buff, i * 4));
				i++;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000CE RID: 206
		public List<uint> unknown;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000028 RID: 40
	public class Block0600 : Block
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000A830 File Offset: 0x00008A30
		public Block0600(Stream s)
		{
			this.type = 3435922944U;
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

		// Token: 0x060000F5 RID: 245 RVA: 0x0000A898 File Offset: 0x00008A98
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000BA RID: 186
		public List<uint> unknown;
	}
}

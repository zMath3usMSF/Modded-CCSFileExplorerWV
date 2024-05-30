using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000029 RID: 41
	public class Block0601 : Block
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000A938 File Offset: 0x00008B38
		public Block0601(Stream s)
		{
			this.type = 3435922945U;
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

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000BB RID: 187
		public List<uint> unknown;
	}
}

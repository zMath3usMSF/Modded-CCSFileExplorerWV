using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000038 RID: 56
	public class Block1901 : Block
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		public Block1901(Stream s)
		{
			this.type = 3435927809U;
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

		// Token: 0x06000115 RID: 277 RVA: 0x0000B94C File Offset: 0x00009B4C
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000CC RID: 204
		public List<uint> unknown;
	}
}

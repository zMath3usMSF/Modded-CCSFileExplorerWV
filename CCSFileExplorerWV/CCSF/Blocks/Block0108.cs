﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x02000021 RID: 33
	public class Block0108 : Block
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000A2C4 File Offset: 0x000084C4
		public Block0108(Stream s)
		{
			this.type = 3435921672U;
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

		// Token: 0x060000E0 RID: 224 RVA: 0x0000A32C File Offset: 0x0000852C
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000B0 RID: 176
		public List<uint> unknown;
	}
}

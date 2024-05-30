using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200001C RID: 28
	public class Block0001 : Block
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00009C8C File Offset: 0x00007E8C
		public Block0001(Stream s)
		{
			this.type = 3435921409U;
			uint size = StreamHelper.ReadUInt32(s) * 4U;
			byte[] buff = new byte[size];
			s.Read(buff, 0, (int)size);
			int pos = 0;
			this.name = "";
			while (buff[pos] != 0)
			{
				string str = this.name;
				char c = (char)buff[pos++];
				this.name = str + c.ToString();
			}
			this.unknown = new List<uint>();
			int i = 0;
			while ((long)i < (long)((ulong)((size - 32U) / 4U)))
			{
				this.unknown.Add(BitConverter.ToUInt32(buff, 32 + i * 4));
				i++;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00009D34 File Offset: 0x00007F34
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			result.Nodes.Add(this.name);
			foreach (uint u in this.unknown)
			{
				result.Nodes.Add("0x" + u.ToString("X8"));
			}
			return result;
		}

		// Token: 0x040000A9 RID: 169
		public string name;

		// Token: 0x040000AA RID: 170
		public List<uint> unknown;
	}
}

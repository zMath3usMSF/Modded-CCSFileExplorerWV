using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200001D RID: 29
	public class Block0002 : Block
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00009DE8 File Offset: 0x00007FE8
		public Block0002(Stream s)
		{
			this.type = 3435921410U;
			uint size = StreamHelper.ReadUInt32(s) * 4U + 8U;
			byte[] buff = new byte[size];
			s.Read(buff, 0, (int)size);
			uint filecount = BitConverter.ToUInt32(buff, 0) - 1U;
			BitConverter.ToUInt32(buff, 4);
			int pos = 40;
			this.filenames = new List<string>();
			this.objnames = new List<string>();
			int i = 0;
			while ((long)i < (long)((ulong)filecount))
			{
				this.filenames.Add(StreamHelper.ReadString(buff, pos));
				pos += 32;
				i++;
			}
			pos += 32;
			int j = 0;
			while ((long)j < (long)((ulong)filecount))
			{
				this.objnames.Add(StreamHelper.ReadString(buff, pos));
				pos += 32;
				j++;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00009EA4 File Offset: 0x000080A4
		public override TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.type.ToString("X8") + " @0x" + this.offset.ToString("X8"));
			TreeNode t = new TreeNode("File Names");
			foreach (string name in this.filenames)
			{
				t.Nodes.Add(name);
			}
			TreeNode t2 = new TreeNode("Object Names");
			foreach (string name2 in this.objnames)
			{
				t2.Nodes.Add(name2);
			}
			result.Nodes.Add(t);
			result.Nodes.Add(t2);
			return result;
		}

		// Token: 0x040000AB RID: 171
		public List<string> filenames;

		// Token: 0x040000AC RID: 172
		public List<string> objnames;
	}
}

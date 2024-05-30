using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x0200000F RID: 15
	public class FileEntry
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003C37 File Offset: 0x00001E37
		public FileEntry(string desc)
		{
			this.name = desc;
			this.objects = new List<ObjectEntry>();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003C54 File Offset: 0x00001E54
		public TreeNode ToNode()
		{
			TreeNode result = new TreeNode(this.name);
			foreach (ObjectEntry entry in this.objects)
			{
				result.Nodes.Add(entry.ToNode());
			}
			return result;
		}

		// Token: 0x04000028 RID: 40
		public string name;

		// Token: 0x04000029 RID: 41
		public List<ObjectEntry> objects;
	}
}

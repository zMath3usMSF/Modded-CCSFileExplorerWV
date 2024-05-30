using System;

namespace CCSFileExplorerWV.CCSF
{
	// Token: 0x02000017 RID: 23
	public class VertexConnection
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00008ED5 File Offset: 0x000070D5
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00008EDD File Offset: 0x000070DD
		public byte Unknown1 { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00008EE6 File Offset: 0x000070E6
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00008EEE File Offset: 0x000070EE
		public byte Unknown2 { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00008EF7 File Offset: 0x000070F7
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00008EFF File Offset: 0x000070FF
		public byte Unknown3 { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00008F08 File Offset: 0x00007108
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00008F10 File Offset: 0x00007110
		public byte Connect { get; set; }

		// Token: 0x06000090 RID: 144 RVA: 0x00008F19 File Offset: 0x00007119
		public VertexConnection(byte[] b)
		{
			this.Unknown1 = b[0];
			this.Unknown2 = b[1];
			this.Unknown3 = b[2];
			this.Connect = b[3];
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008F48 File Offset: 0x00007148
		public VertexConnection(uint b)
		{
			this.Unknown1 = (byte)(255U & b);
			b >>= 8;
			this.Unknown2 = (byte)(255U & b);
			b >>= 8;
			this.Unknown3 = (byte)(255U & b);
			b >>= 8;
			this.Connect = (byte)(255U & b);
		}
	}
}

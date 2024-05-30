using System;

namespace CCSFileExplorerWV.CCSF
{
	// Token: 0x02000018 RID: 24
	public class Tristrip
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00008FA2 File Offset: 0x000071A2
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00008FAA File Offset: 0x000071AA
		public Vector3f V1 { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00008FB3 File Offset: 0x000071B3
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00008FBB File Offset: 0x000071BB
		public Vector3f V2 { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00008FC4 File Offset: 0x000071C4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00008FCC File Offset: 0x000071CC
		public Vector3f V3 { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00008FD5 File Offset: 0x000071D5
		private Vector3f Centroid
		{
			get
			{
				return this.V1.Add(this.V2).Add(this.V3).Div(3f);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00008FFD File Offset: 0x000071FD
		private Vector3f Normal
		{
			get
			{
				return this.V2.Sub(this.V1).Cross(this.V3.Sub(this.V1)).Normalize();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000902B File Offset: 0x0000722B
		public Tristrip(Tristrip other) : this(other.V1, other.V2, other.V3)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009045 File Offset: 0x00007245
		public Tristrip(Vector3f V1, Vector3f V2, Vector3f V3)
		{
			this.V1 = new Vector3f(V1);
			this.V2 = new Vector3f(V2);
			this.V3 = new Vector3f(V3);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009071 File Offset: 0x00007271
		public bool Contains(Vector3f v)
		{
			return v.Equals(this.V1) || v.Equals(this.V2) || v.Equals(this.V3);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000090A0 File Offset: 0x000072A0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"f ",
				this.V1.ID.ToString(),
				"/",
				this.V1.ID.ToString(),
				" ",
				this.V2.ID.ToString(),
				"/",
				this.V2.ID.ToString(),
				" ",
				this.V3.ID.ToString(),
				"/",
				this.V3.ID.ToString()
			});
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009170 File Offset: 0x00007370
		public bool Equals(Tristrip other)
		{
			return this.Normal.Equals(other.Normal);
		}
	}
}

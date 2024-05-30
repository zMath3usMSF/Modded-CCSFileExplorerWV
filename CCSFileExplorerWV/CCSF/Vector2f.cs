using System;

namespace CCSFileExplorerWV.CCSF
{
	// Token: 0x02000019 RID: 25
	public class Vector2f : IComparable<Vector2f>
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00009183 File Offset: 0x00007383
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000918B File Offset: 0x0000738B
		public int ID { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00009194 File Offset: 0x00007394
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000919C File Offset: 0x0000739C
		public float U { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000091A5 File Offset: 0x000073A5
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000091AD File Offset: 0x000073AD
		public float V { get; set; }

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2f()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000091B6 File Offset: 0x000073B6
		public Vector2f(float u, float v)
		{
			this.U = u;
			this.V = v;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000091CC File Offset: 0x000073CC
		public Vector2f(Vector2f v) : this(v.U, v.V)
		{
			this.ID = v.ID;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000091EC File Offset: 0x000073EC
		public Vector2f(byte[] data, int id)
		{
			this.U = (float)((int)((sbyte)data[0]) & 255) / 256f + (float)((sbyte)data[1]);
			this.V = (float)((int)((sbyte)data[2]) & 255) / 256f + (float)((sbyte)data[3]);
			this.ID = id;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009240 File Offset: 0x00007440
		public Vector2f Add(Vector2f other)
		{
			Vector2f vector2f = new Vector2f(this);
			vector2f.U += other.U;
			vector2f.V += other.V;
			return vector2f;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000926E File Offset: 0x0000746E
		public Vector2f Sub(Vector2f other)
		{
			Vector2f vector2f = new Vector2f();
			vector2f.U -= other.U;
			vector2f.V -= other.V;
			return vector2f;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000929B File Offset: 0x0000749B
		public Vector2f Mul(float scalar)
		{
			Vector2f result = new Vector2f();
			this.U *= scalar;
			this.V *= scalar;
			return result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000092BE File Offset: 0x000074BE
		public Vector2f Div(float factor)
		{
			return this.Mul(1f / factor);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000092CD File Offset: 0x000074CD
		public float Dot(Vector2f other)
		{
			return this.U * this.U + this.V * this.V;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000092EC File Offset: 0x000074EC
		public Vector2f Normalize()
		{
			Vector2f vector2f = new Vector2f(this);
			float length = this.Length();
			vector2f.U /= length;
			vector2f.V /= length;
			return vector2f;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00009322 File Offset: 0x00007522
		public void Negate()
		{
			this.U = -this.U;
			this.V = -this.V;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000933E File Offset: 0x0000753E
		public float Length()
		{
			return (float)Math.Abs(Math.Sqrt((double)(this.U * this.U + this.V * this.V)));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00009368 File Offset: 0x00007568
		public override bool Equals(object obj)
		{
			if (obj is Vector2f)
			{
				Vector2f other = (Vector2f)obj;
				return this.U == other.U && this.U == other.V;
			}
			return base.Equals(obj);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000093AC File Offset: 0x000075AC
		public override string ToString()
		{
			return "vt " + this.U.ToString() + " " + this.V.ToString();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000093E4 File Offset: 0x000075E4
		int IComparable<Vector2f>.CompareTo(Vector2f other)
		{
			return (int)(this.Length() - other.Length());
		}
	}
}

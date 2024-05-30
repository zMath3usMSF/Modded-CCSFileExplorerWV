using System;

namespace CCSFileExplorerWV.CCSF
{
	// Token: 0x0200001A RID: 26
	public class Vector3f : IComparable<Vector3f>
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000093F4 File Offset: 0x000075F4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000093FC File Offset: 0x000075FC
		public int ID { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009405 File Offset: 0x00007605
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000940D File Offset: 0x0000760D
		public float X { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009416 File Offset: 0x00007616
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000941E File Offset: 0x0000761E
		public float Y { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00009427 File Offset: 0x00007627
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000942F File Offset: 0x0000762F
		public float Z { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00009438 File Offset: 0x00007638
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00009440 File Offset: 0x00007640
		public float W { get; set; }

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3f()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00009449 File Offset: 0x00007649
		public Vector3f(float X, float Y, float Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = 1f;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00009471 File Offset: 0x00007671
		public Vector3f(Vector3f v) : this(v.X, v.Y, v.Z)
		{
			this.ID = v.ID;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009498 File Offset: 0x00007698
		public Vector3f(byte[] data, int id)
		{
			this.X = (float)((int)((sbyte)data[0]) & 255) / 256f + (float)((sbyte)data[1]);
			this.Y = (float)((int)((sbyte)data[2]) & 255) / 256f + (float)((sbyte)data[3]);
			this.Z = (float)((int)((sbyte)data[4]) & 255) / 256f + (float)((sbyte)data[5]);
			this.W = 1f;
			this.ID = id;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009514 File Offset: 0x00007714
		public Vector3f Add(Vector3f other)
		{
			Vector3f vector3f = new Vector3f(this);
			vector3f.X += this.X;
			this.Y += this.Y;
			this.Z += this.Z;
			return vector3f;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009560 File Offset: 0x00007760
		public Vector3f Sub(Vector3f other)
		{
			Vector3f vector3f = new Vector3f(this);
			vector3f.X -= this.X;
			vector3f.Y -= this.Y;
			vector3f.Z -= this.Z;
			return vector3f;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000095AC File Offset: 0x000077AC
		public Vector3f Mul(float scalar)
		{
			Vector3f vector3f = new Vector3f(this);
			vector3f.X *= scalar;
			vector3f.Y *= scalar;
			vector3f.Z *= scalar;
			return vector3f;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000095DE File Offset: 0x000077DE
		public Vector3f Div(float factor)
		{
			return this.Mul(1f / factor);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000095F0 File Offset: 0x000077F0
		public Vector3f Cross(Vector3f other)
		{
			return new Vector3f(this)
			{
				X = this.Y * this.Z - this.Z * this.Y,
				Y = this.Z * this.X - this.X * this.Z,
				Z = this.X * this.Y - this.Y * this.X
			};
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009666 File Offset: 0x00007866
		public float Dot(Vector3f other)
		{
			return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009694 File Offset: 0x00007894
		public Vector3f Normalize()
		{
			Vector3f vector3f = new Vector3f(this);
			float length = this.Length();
			vector3f.X /= length;
			vector3f.Y /= length;
			vector3f.Z /= length;
			return vector3f;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000096D8 File Offset: 0x000078D8
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009701 File Offset: 0x00007901
		public float Length()
		{
			return (float)Math.Abs(Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z)));
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009738 File Offset: 0x00007938
		public float Length2D()
		{
			return (float)Math.Abs(Math.Sqrt((double)(this.X * this.X + this.Z * this.Z)));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009764 File Offset: 0x00007964
		public override bool Equals(object obj)
		{
			if (obj is Vector3f)
			{
				Vector3f other = (Vector3f)obj;
				return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
			}
			return base.Equals(obj);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000097B4 File Offset: 0x000079B4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"v ",
				this.X.ToString(),
				" ",
				this.Y.ToString(),
				" ",
				this.Z.ToString()
			});
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00009817 File Offset: 0x00007A17
		int IComparable<Vector3f>.CompareTo(Vector3f other)
		{
			return (int)(this.Length() - other.Length());
		}

		// Token: 0x0400009F RID: 159
		public static Vector3f UNIT_Z = new Vector3f(0f, 0f, 1f);
	}
}

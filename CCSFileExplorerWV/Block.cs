using System;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000005 RID: 5
	public abstract class Block
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000023B0 File Offset: 0x000005B0
		public virtual byte[] FullBlockData
		{
			get
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(BitConverter.GetBytes(this.BlockID), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.Size), 0, 4);
				memoryStream.Write(BitConverter.GetBytes(this.ID), 0, 4);
				memoryStream.Write(this.Data, 0, this.Data.Length);
				return memoryStream.ToArray();
			}
		}

		// Token: 0x0600000C RID: 12
		public abstract TreeNode ToNode();

		// Token: 0x0600000D RID: 13
		public abstract void WriteBlock(Stream s);

		// Token: 0x0600000E RID: 14 RVA: 0x00002418 File Offset: 0x00000618
		public static Block ReadBlock(Stream s)
		{
			uint type = Block.ReadUInt32(s);
			Block result;
			switch (type)
			{
			case 3435921409U:
				result = new Block0001(s);
				goto IL_6F;
			case 3435921410U:
				result = new Block0002(s);
				goto IL_6F;
			case 3435921411U:
			case 3435921412U:
				break;
			case 3435921413U:
				result = new Block0005(s);
				goto IL_6F;
			default:
				if (type == 3435922176U)
				{
					result = new Block0300(s);
					goto IL_6F;
				}
				if (type == 3435923456U)
				{
					result = new Block0800(s);
					goto IL_6F;
				}
				break;
			}
			result = new BlockDefault(s);
			IL_6F:
			result.BlockID = type;
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000249C File Offset: 0x0000069C
		public static uint ReadUInt32(Stream s)
		{
			byte[] buff = new byte[4];
			s.Read(buff, 0, 4);
			return BitConverter.ToUInt32(buff, 0);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024C4 File Offset: 0x000006C4
		public static string ReadFixedLenString(byte[] buff, int pos, int len)
		{
			string result = "";
			int i = 0;
			while (buff[pos] != 0 && i < len)
			{
				string str = result;
				char c = (char)buff[pos++];
				result = str + c.ToString();
				i++;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002500 File Offset: 0x00000700
		public static string ReadString(byte[] buff, int pos)
		{
			string result = "";
			while (buff[pos] != 0)
			{
				string str = result;
				char c = (char)buff[pos++];
				result = str + c.ToString();
			}
			return result;
		}
        // Token: 0x06000012 RID: 18 RVA: 0x00002532 File Offset: 0x00000732
        public static void WriteUInt32(Stream s, uint u)
		{
			s.Write(BitConverter.GetBytes(u), 0, 4);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002544 File Offset: 0x00000744
		public static void WriteString(Stream s, string t, int minsize = -1)
		{
			MemoryStream i = new MemoryStream();
			foreach (char c in t)
			{
				i.WriteByte((byte)c);
			}
			if(t.Length != 0x20)
			{
                i.WriteByte(0);
                if (minsize != -1)
                {
                    while (i.Length != (long)minsize)
                    {
                        i.WriteByte(0);
                    }
                }
            }
			s.Write(i.ToArray(), 0, (int)i.Length);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000025AC File Offset: 0x000007AC
		public static bool isValidBlockType(uint u)
		{
			foreach (uint vu in Block.validBlockTypes)
			{
				if (u == vu)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000004 RID: 4
		public uint BlockID;

		// Token: 0x04000005 RID: 5
		public uint Size;

		// Token: 0x04000006 RID: 6
		public uint ID;

		// Token: 0x04000007 RID: 7
		public byte[] Data;

		// Token: 0x04000008 RID: 8
		public CCSFile CCSFile;

		// Token: 0x04000009 RID: 9
		public FileEntry FileEntry;

		// Token: 0x0400000A RID: 10
		public ObjectEntry ObjectEntry;

		// Token: 0x0400000B RID: 11
		public static uint[] validBlockTypes = new uint[]
		{
			3435921409U,
			3435921410U,
			3435921413U,
			3435921664U,
			3435921666U,
			3435921672U,
			3435921920U,
			3435922176U,
			3435922432U,
			3435922688U,
			3435922690U,
			3435922944U,
			3435922945U,
			3435922947U,
			3435922953U,
			3435923200U,
			3435923456U,
			3435923712U,
			3435923968U,
			3435924224U,
			3435924480U,
			3435924992U,
			3435925760U,
			3435926016U,
			3435926272U,
			3435926528U,
			3435927808U,
			3435927809U,
			3435929600U,
			3435986689U,
			3435921922U
		};
	}
}

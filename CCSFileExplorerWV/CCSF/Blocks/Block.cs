using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200001B RID: 27
	public abstract class Block
	{
		// Token: 0x060000D0 RID: 208
		public abstract TreeNode ToNode();

		// Token: 0x060000D1 RID: 209 RVA: 0x00009844 File Offset: 0x00007A44
		public static List<Block> ReadBlocks(Stream s)
		{
			List<Block> result = new List<Block>();
			byte[] buff = new byte[4];
			bool error = false;
			while (s.Position < s.Length)
			{
				uint pos = (uint)s.Position;
				s.Read(buff, 0, 4);
				uint type = BitConverter.ToUInt32(buff, 0);
				Block b;
				if (type <= 3435923456U)
				{
					if (type <= 3435922176U)
					{
						if (type <= 3435921666U)
						{
							switch (type)
							{
							case 3435921409U:
								b = new Block0001(s);
								break;
							case 3435921410U:
								b = new Block0002(s);
								break;
							case 3435921411U:
							case 3435921412U:
								goto IL_384;
							case 3435921413U:
								b = new Block0005(s);
								break;
							default:
								if (type != 3435921664U)
								{
									if (type != 3435921666U)
									{
										goto IL_384;
									}
									b = new Block0102(s);
								}
								else
								{
									b = new Block0100(s);
								}
								break;
							}
						}
						else if (type != 3435921672U)
						{
							if (type != 3435921920U)
							{
								if (type != 3435922176U)
								{
									goto IL_384;
								}
								b = new Block0300(s);
							}
							else
							{
								b = new Block0200(s);
							}
						}
						else
						{
							b = new Block0108(s);
						}
					}
					else if (type <= 3435922690U)
					{
						if (type != 3435922432U)
						{
							if (type != 3435922688U)
							{
								if (type != 3435922690U)
								{
									goto IL_384;
								}
								b = new Block0502(s);
							}
							else
							{
								b = new Block0500(s);
							}
						}
						else
						{
							b = new Block0400(s);
						}
					}
					else if (type <= 3435922953U)
					{
						switch (type)
						{
						case 3435922944U:
							b = new Block0600(s);
							break;
						case 3435922945U:
							b = new Block0601(s);
							break;
						case 3435922946U:
							goto IL_384;
						case 3435922947U:
							b = new Block0603(s);
							break;
						default:
							if (type != 3435922953U)
							{
								goto IL_384;
							}
							b = new Block0609(s);
							break;
						}
					}
					else if (type != 3435923200U)
					{
						if (type != 3435923456U)
						{
							goto IL_384;
						}
						b = new Block0800(s);
					}
					else
					{
						b = new Block0700(s);
					}
				}
				else if (type <= 3435925760U)
				{
					if (type <= 3435924224U)
					{
						if (type != 3435923712U)
						{
							if (type != 3435923968U)
							{
								if (type != 3435924224U)
								{
									goto IL_384;
								}
								b = new Block0B00(s);
							}
							else
							{
								b = new Block0A00(s);
							}
						}
						else
						{
							b = new Block0900(s);
						}
					}
					else if (type != 3435924480U)
					{
						if (type != 3435924992U)
						{
							if (type != 3435925760U)
							{
								goto IL_384;
							}
							b = new Block1100(s);
						}
						else
						{
							b = new Block0E00(s);
						}
					}
					else
					{
						b = new Block0C00(s);
					}
				}
				else if (type <= 3435926528U)
				{
					if (type != 3435926016U)
					{
						if (type != 3435926272U)
						{
							if (type != 3435926528U)
							{
								goto IL_384;
							}
							b = new Block1400(s);
						}
						else
						{
							b = new Block1300(s);
						}
					}
					else
					{
						b = new Block1200(s);
					}
				}
				else if (type <= 3435927809U)
				{
					if (type != 3435927808U)
					{
						if (type != 3435927809U)
						{
							goto IL_384;
						}
						b = new Block1901(s);
					}
					else
					{
						b = new Block1900(s);
					}
				}
				else if (type != 3435929600U)
				{
					if (type != 3435986689U)
					{
						goto IL_384;
					}
					b = new BlockFF01(s);
				}
				else
				{
					b = new Block2000(s);
				}
				IL_3BC:
				b.offset = pos;
				result.Add(b);
				if (!error)
				{
					continue;
				}
				break;
				IL_384:
				error = true;
				b = new ErrorBlock("Error at 0x" + s.Position.ToString("X8") + " read type:0x" + type.ToString("X8"));
				goto IL_3BC;
			}
			return result;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009C34 File Offset: 0x00007E34
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

		// Token: 0x040000A5 RID: 165
		public List<Block> subBlocks = new List<Block>();

		// Token: 0x040000A6 RID: 166
		public uint type;

		// Token: 0x040000A7 RID: 167
		public uint offset;

		// Token: 0x040000A8 RID: 168
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
			3435986689U
		};
	}
}

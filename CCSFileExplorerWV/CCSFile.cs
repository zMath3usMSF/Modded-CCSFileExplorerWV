using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace CCSFileExplorerWV
{
	// Token: 0x0200000E RID: 14
	public class CCSFile
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000377D File Offset: 0x0000197D
		public CCSFile(byte[] rawBuffer, CCSFile.FileVersionEnum FileVersion)
		{
			this.raw = rawBuffer;
			this.FileVersion = FileVersion;
			this.Reload();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000379C File Offset: 0x0000199C
		public void Reload()
		{
			this.isvalid = false;
			MemoryStream i = new MemoryStream(this.raw);
			i.Seek(0L, SeekOrigin.Begin);
			this.blocks = new List<Block>();
			while (i.Position < (long)this.raw.Length)
			{
				Block b = Block.ReadBlock(i);
				b.CCSFile = this;
				this.blocks.Add(b);
			}
			if (File.Exists("blocks.txt"))
			{
				File.Delete("blocks.txt");
			}
			StreamWriter sw = new StreamWriter("blocks.txt");
			foreach (Block b2 in this.blocks)
			{
				sw.WriteLine(b2.BlockID.ToString("X2") + "\n");
			}
			sw.Close();
			if (this.blocks.Count == 0)
			{
				return;
			}
			this.isvalid = true;
			this.header = (Block0001)this.blocks[0];
			this.toc = (Block0002)this.blocks[1];
			this.files = new List<FileEntry>();
			int j = 0;
			while ((long)j < (long)((ulong)this.toc.FileCount))
			{
				FileEntry entry = new FileEntry(this.toc.filenames[j]);
				int k = 0;
				while ((long)k < (long)((ulong)this.toc.ObjCount))
				{
					if ((int)(this.toc.indexes[k] - 1) == j)
					{
						ObjectEntry obj = new ObjectEntry(this.toc.objnames[k]);
						for (int l = 2; l < this.blocks.Count; l++)
						{
							if ((ulong)(this.blocks[l].ID - 1U) == (ulong)((long)k))
							{
								obj.blocks.Add(this.blocks[l]);
								this.blocks[l].ObjectEntry = obj;
								this.blocks[l].FileEntry = entry;
							}
						}
						entry.objects.Add(obj);
					}
					k++;
				}
				this.files.Add(entry);
				j++;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000039F8 File Offset: 0x00001BF8
		public void Rebuild()
		{
			MemoryStream i = new MemoryStream();
			foreach (Block block in this.blocks)
			{
				block.WriteBlock(i);
			}
			this.raw = i.ToArray();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003A5C File Offset: 0x00001C5C
		public void Save(string filename)
		{
			this.Rebuild();
			File.WriteAllBytes(filename, this.raw);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003A70 File Offset: 0x00001C70
		public string Info()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Arquivo Válido : " + this.isvalid.ToString());
			if (this.isvalid)
			{
				sb.AppendLine(this.files.Count.ToString() + " files loaded");
			}
			return sb.ToString();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public static Bitmap CreateImage(byte[] palette, byte[] data)
		{
			List<Color> pal = new List<Color>();
			int pos;
			for (pos = 16; pos < palette.Length; pos += 4)
			{
				byte r = palette[pos];
				byte g = palette[pos + 1];
				byte b = palette[pos + 2];
				byte a = palette[pos + 3];
				if (a <= 128)
				{
					a = (byte)(a * byte.MaxValue / 128);
				}
				pal.Add(Color.FromArgb((int)a, (int)r, (int)g, (int)b));
			}
			int sizeX = (int)Math.Pow(2.0, (double)data[12]);
			int sizeY = (int)Math.Pow(2.0, (double)data[13]);
			pos = 24;
			int dataSize = data.Length - pos;
			Bitmap result = new Bitmap(sizeX, sizeY);
			if (dataSize * 2 == sizeX * sizeY)
			{
				for (int y = 0; y < sizeY; y++)
				{
					for (int x = 0; x < sizeX / 2; x++)
					{
						result.SetPixel(x * 2, sizeY - y - 1, pal[(int)(data[pos] % 16)]);
						result.SetPixel(x * 2 + 1, sizeY - y - 1, pal[(int)(data[pos] / 16)]);
						pos++;
					}
				}
			}
			else if (dataSize >= sizeX * sizeY)
			{
				for (int y2 = 0; y2 < sizeY; y2++)
				{
					for (int x2 = 0; x2 < sizeX; x2++)
					{
						result.SetPixel(x2, sizeY - y2 - 1, pal[(int)data[pos++]]);
					}
				}
			}
			return result;
		}

		// Token: 0x04000021 RID: 33
		public CCSFile.FileVersionEnum FileVersion;

		// Token: 0x04000022 RID: 34
		public byte[] raw;

		// Token: 0x04000023 RID: 35
		public bool isvalid;

		// Token: 0x04000024 RID: 36
		public Block0001 header;

		// Token: 0x04000025 RID: 37
		public Block0002 toc;

		// Token: 0x04000026 RID: 38
		public List<FileEntry> files;

		// Token: 0x04000027 RID: 39
		public List<Block> blocks;

		// Token: 0x0200003F RID: 63
		public enum FileVersionEnum
		{
			// Token: 0x040000DE RID: 222
			HACK_GU,
			// Token: 0x040000DF RID: 223
			IMOQF
		}
	}
}

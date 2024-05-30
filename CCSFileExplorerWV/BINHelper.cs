using System;
using System.IO;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000004 RID: 4
	public static class BINHelper
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020B8 File Offset: 0x000002B8
		public static void UnpackToFolder(string filename, string folder, ToolStripProgressBar pb1 = null, ToolStripStatusLabel strip = null)
		{
			FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
			fs.Seek(0L, SeekOrigin.End);
			long size = fs.Position;
			fs.Seek(0L, SeekOrigin.Begin);
			byte[] buff = new byte[4];
			if (pb1 != null)
			{
				pb1.Maximum = (int)size;
			}
			int fileindex = 0;
			while (fs.Position < size)
			{
				fs.Read(buff, 0, 4);
				if (FileHelper.isGzipMagic(buff, 0))
				{
					int pos = (int)fs.Position - 4;
					int start = pos;
					while ((long)pos < size)
					{
						pos += 2048;
						fs.Seek(2044L, SeekOrigin.Current);
						fs.Read(buff, 0, 4);
						if (FileHelper.isGzipMagic(buff, 0))
						{
							fs.Seek(-4L, SeekOrigin.Current);
							break;
						}
					}
					fs.Seek((long)start, SeekOrigin.Begin);
					buff = new byte[pos - start];
					fs.Read(buff, 0, pos - start);
					buff = FileHelper.unzipArray(buff);
					string name = "";
					int tpos = 12;
					while (buff[tpos] != 0)
					{
						string str = name;
						char c = (char)buff[tpos++];
						name = str + c.ToString();
					}
					File.WriteAllBytes(folder + name + ".tmp", buff);
					fileindex++;
					if (pb1 != null)
					{
						pb1.Value = start;
						strip.Text = name;
						Application.DoEvents();
					}
					buff = new byte[4];
				}
				else
				{
					fs.Seek(2044L, SeekOrigin.Current);
				}
			}
			if (pb1 != null)
			{
				pb1.Value = 0;
				strip.Text = "";
			}
			fs.Close();
		}
        public static byte[] UnpackTo(string filename, string folder, ToolStripProgressBar pb1 = null, ToolStripStatusLabel strip = null)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            fs.Seek(0L, SeekOrigin.End);
            long size = fs.Position;
            fs.Seek(0L, SeekOrigin.Begin);
            byte[] buff = new byte[4];
			byte[] tmpBuff = new byte[4];
            if (pb1 != null)
            {
                pb1.Maximum = (int)size;
            }
            int fileindex = 0;
            while (fs.Position < size)
            {
                fs.Read(buff, 0, 4);
                if (FileHelper.isGzipMagic(buff, 0))
                {
                    int pos = (int)fs.Position - 4;
                    int start = pos;
                    while ((long)pos < size)
                    {
                        pos += 2048;
                        fs.Seek(2044L, SeekOrigin.Current);
                        fs.Read(buff, 0, 4);
                        if (FileHelper.isGzipMagic(buff, 0))
                        {
                            fs.Seek(-4L, SeekOrigin.Current);
                            break;
                        }
                    }
                    fs.Seek((long)start, SeekOrigin.Begin);
                    buff = new byte[pos - start];
                    fs.Read(buff, 0, pos - start);
                    buff = FileHelper.unzipArray(buff);
                    string name = "";
                    int tpos = 12;
                    while (buff[tpos] != 0)
                    {
                        string str = name;
                        char c = (char)buff[tpos++];
                        name = str + c.ToString();
                    }
					tmpBuff = buff;
                    fileindex++;
                    if (pb1 != null)
                    {
                        pb1.Value = start;
                        strip.Text = name;
                        Application.DoEvents();
                    }
                    buff = new byte[4];
                }
                else
                {
                    fs.Seek(2044L, SeekOrigin.Current);
                }
            }
            if (pb1 != null)
            {
                pb1.Value = 0;
                strip.Text = "";
            }
            fs.Close();
            return tmpBuff;
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002238 File Offset: 0x00000438
        public static void Repack(string localtosave, string file)
		{
			FileStream fs = new FileStream(localtosave, FileMode.Create, FileAccess.Write);
			byte[] buff = File.ReadAllBytes(file);
			MemoryStream i = new MemoryStream();
			string infilename = Path.GetFileNameWithoutExtension(file).Substring(0) + ".tmp";
			buff = FileHelper.zipArray(buff, infilename);
			buff[8] = 0;
			buff[9] = 3;
			i.Write(buff, 0, buff.Length);
			while (i.Length % 2048L != 0L)
			{
				i.WriteByte(0);
			}
			i.Seek(-3L, SeekOrigin.Current);
			i.Read(buff, 0, 3);
			if (buff[0] / 16 != 0 || buff[1] != 0 || buff[2] != 0)
			{
				i.Write(new byte[2048], 0, 2048);
			}
			buff = i.ToArray();
			fs.Write(buff, 0, buff.Length);
			fs.Close();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022FC File Offset: 0x000004FC
		public static void Repackccs(string localtosave, byte[] file, string filename)
		{
			FileStream fs = new FileStream(localtosave, FileMode.Create, FileAccess.Write);
			MemoryStream i = new MemoryStream();
			string infilename = filename + ".tmp";
			byte[] buff = FileHelper.zipArray(file, infilename);
			buff[8] = 0;
			buff[9] = 3;
			i.Write(buff, 0, buff.Length);
			while (i.Length % 2048L != 0L)
			{
				i.WriteByte(0);
			}
			i.Seek(-3L, SeekOrigin.Current);
			i.Read(buff, 0, 3);
			if (buff[0] / 16 != 0 || buff[1] != 0 || buff[2] != 0)
			{
				i.Write(new byte[2048], 0, 2048);
			}
			buff = i.ToArray();
			fs.Write(buff, 0, buff.Length);
			fs.Close();
		}
	}
}

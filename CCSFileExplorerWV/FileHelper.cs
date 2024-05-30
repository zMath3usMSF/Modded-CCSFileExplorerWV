using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace CCSFileExplorerWV
{
	// Token: 0x02000013 RID: 19
	public static class FileHelper
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00004579 File Offset: 0x00002779
		public static bool isGzipMagic(byte[] data, int start = 0)
		{
			return data[start++] == 31 && data[start++] == 139 && data[start++] == 8 && (data[start] == 8 || data[start] == 0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000045B0 File Offset: 0x000027B0
		public static byte[] unzipArray(byte[] data)
		{
			MemoryStream result = new MemoryStream();
			GZipStream gzipStream = new GZipStream(new MemoryStream(data), CompressionMode.Decompress);
			gzipStream.CopyTo(result);
			gzipStream.Close();
			return result.ToArray();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000045E4 File Offset: 0x000027E4
		public static byte[] zipArray(byte[] data, string filename)
		{
			MemoryStream i = new MemoryStream();
			GZipStream stream = new GZipStream(i, CompressionMode.Compress);
			new MemoryStream(data).CopyTo(stream);
			stream.Close();
			byte[] cdata = i.ToArray();
			i = new MemoryStream();
			if (filename != null && filename != "")
			{
				byte[] buff = Encoding.ASCII.GetBytes(filename);
				i.Write(cdata, 0, 3);
				i.WriteByte(8);
				i.Write(cdata, 4, 6);
				i.Write(buff, 0, buff.Length);
				i.WriteByte(0);
				i.Write(cdata, 10, cdata.Length - 10);
			}
			else
			{
				i.Write(cdata, 0, cdata.Length);
			}
			return i.ToArray();
		}
	}
}

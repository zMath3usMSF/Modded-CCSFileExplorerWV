using System;
using System.IO;

namespace CCSFileExplorerWV.CCSF.Blocks
{
	// Token: 0x0200003C RID: 60
	public static class StreamHelper
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000BC18 File Offset: 0x00009E18
		public static uint ReadUInt32(Stream s)
		{
			byte[] buff = new byte[4];
			s.Read(buff, 0, 4);
			return BitConverter.ToUInt32(buff, 0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000BC40 File Offset: 0x00009E40
		public static string ReadString(byte[] array, int pos)
		{
			string result = "";
			while (array[pos] != 0)
			{
				string str = result;
				char c = (char)array[pos++];
				result = str + c.ToString();
			}
			return result;
		}
	}
}

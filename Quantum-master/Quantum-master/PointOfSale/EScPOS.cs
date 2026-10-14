using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000163 RID: 355
	public class EScPOS
	{
		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0019B6F8 File Offset: 0x001998F8
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x0019B6E8 File Offset: 0x001998E8
		public static object PrinterName
		{
			get
			{
				return EScPOS.PrintNam;
			}
			set
			{
				EScPOS.PrintNam = Conversions.ToString(value);
			}
		}

		// Token: 0x06002F71 RID: 12145
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "OpenPrinterW", ExactSpelling = true, SetLastError = true)]
		public static extern bool OpenPrinter(string src, ref IntPtr hPrinter, long pd);

		// Token: 0x06002F72 RID: 12146
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool ClosePrinter(IntPtr hPrinter);

		// Token: 0x06002F73 RID: 12147
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "StartDocPrinterW", ExactSpelling = true, SetLastError = true)]
		public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref EScPOS.DOCINFOW pDI);

		// Token: 0x06002F74 RID: 12148
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool EndDocPrinter(IntPtr hPrinter);

		// Token: 0x06002F75 RID: 12149
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool StartPagePrinter(IntPtr hPrinter);

		// Token: 0x06002F76 RID: 12150
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool EndPagePrinter(IntPtr hPrinter);

		// Token: 0x06002F77 RID: 12151
		[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, ref int dwWritten);

		// Token: 0x06002F78 RID: 12152 RVA: 0x0019B710 File Offset: 0x00199910
		public static bool PrintImage(Bitmap BM)
		{
			byte[] array = EScPOS.ConvertImagetoBytes(BM);
			IntPtr intPtr = Marshal.AllocCoTaskMem(array.Count<byte>());
			Marshal.Copy(array, 0, intPtr, array.Count<byte>());
			return EScPOS.PrintBytes(array);
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x0019B74C File Offset: 0x0019994C
		public static bool PrintBytes(byte[] Document)
		{
			EScPOS.DOCINFOW docinfow = default(EScPOS.DOCINFOW);
			docinfow.pDocName = "RAW LOGO";
			docinfow.pDataType = "RAW";
			IntPtr intPtr = new IntPtr(0);
			bool flag = false;
			bool flag2 = EScPOS.OpenPrinter(Conversions.ToString(NewLateBinding.LateGet(EScPOS.PrinterName, null, "Normalize", new object[0], null, null, null)), ref intPtr, 0L);
			if (flag2)
			{
				bool flag3 = EScPOS.StartDocPrinter(intPtr, 1, ref docinfow);
				if (flag3)
				{
					IntPtr intPtr2 = Marshal.AllocCoTaskMem(Document.Length);
					Marshal.Copy(Document, 0, intPtr2, Document.Length);
					bool flag4 = EScPOS.StartPagePrinter(intPtr);
					if (flag4)
					{
						int num;
						flag = EScPOS.WritePrinter(intPtr, intPtr2, Document.Length, ref num);
						EScPOS.EndPagePrinter(intPtr);
					}
					Marshal.FreeCoTaskMem(intPtr2);
					EScPOS.EndDocPrinter(intPtr);
				}
				EScPOS.ClosePrinter(intPtr);
			}
			bool flag5 = !flag;
			if (flag5)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
			}
			return flag;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x0019B838 File Offset: 0x00199A38
		public static byte[] ConvertImagetoBytes(Bitmap BM)
		{
			EScPOS.BitMapData bitmapData = EScPOS.GetBitmapData(BM);
			MemoryStream memoryStream = new MemoryStream();
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write('\u001b');
			binaryWriter.Write('@');
			binaryWriter.Write('\u001b');
			binaryWriter.Write('3');
			binaryWriter.Write(24);
			int i = 0;
			checked
			{
				while (i < (int)bitmapData.Height)
				{
					binaryWriter.Write('\u001b');
					binaryWriter.Write('*');
					binaryWriter.Write(33);
					byte[] bytes = BitConverter.GetBytes(bitmapData.Width);
					binaryWriter.Write(bytes[0]);
					binaryWriter.Write(bytes[1]);
					int num = (int)(bitmapData.Width - 1);
					for (int j = 0; j <= num; j++)
					{
						int num2 = 0;
						do
						{
							byte b = 0;
							int num3 = 0;
							do
							{
								int num4 = (i / 8 + num2) * 8 + num3;
								int num5 = num4 * (int)bitmapData.Width + j;
								bool flag = false;
								bool flag2 = num5 < bitmapData.Dots.Length;
								if (flag2)
								{
									flag = bitmapData.Dots[num5];
								}
								b |= (byte)((flag ? 1 : 0) << ((7 - num3) & 31));
								num3++;
							}
							while (num3 <= 7);
							binaryWriter.Write(b);
							num2++;
						}
						while (num2 <= 2);
					}
					i += 24;
					binaryWriter.Write("\r\n".ToCharArray());
				}
				binaryWriter.Write('\u001b');
				binaryWriter.Write('3');
				binaryWriter.Write(30);
				binaryWriter.Flush();
				return memoryStream.ToArray();
			}
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x0019B9CC File Offset: 0x00199BCC
		private static EScPOS.BitMapData GetBitmapData(Bitmap BM)
		{
			int num = 127;
			int num2 = 0;
			checked
			{
				int num3 = BM.Width * BM.Height;
				BitArray bitArray = new BitArray(num3);
				EScPOS.BitMapData bitMapData = new EScPOS.BitMapData();
				int num4 = BM.Height - 1;
				for (int i = 0; i <= num4; i++)
				{
					int num5 = BM.Width - 1;
					for (int j = 0; j <= num5; j++)
					{
						Color pixel = BM.GetPixel(j, i);
						int num6 = (int)Math.Round(unchecked((double)pixel.R * 0.3 + (double)pixel.G * 0.59 + (double)pixel.B * 0.11));
						bool flag = num6 < num;
						if (flag)
						{
						}
						bitArray[num2] = num6 < num;
						num2++;
					}
				}
				bitMapData.Dots = bitArray;
				bitMapData.Height = (short)BM.Height;
				bitMapData.Width = (short)BM.Width;
				return bitMapData;
			}
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x0019BAD4 File Offset: 0x00199CD4
		private static bool PrintEsto(IntPtr pBytes, int dwCount)
		{
			EScPOS.DOCINFOW docinfow = default(EScPOS.DOCINFOW);
			docinfow.pDocName = "RAW Document";
			docinfow.pDataType = "RAW";
			bool flag = false;
			IntPtr intPtr;
			bool flag2 = EScPOS.OpenPrinter(Conversions.ToString(EScPOS.PrinterName), ref intPtr, 0L);
			if (flag2)
			{
				bool flag3 = EScPOS.StartDocPrinter(intPtr, 1, ref docinfow);
				if (flag3)
				{
					bool flag4 = EScPOS.StartPagePrinter(intPtr);
					if (flag4)
					{
						int num;
						flag = EScPOS.WritePrinter(intPtr, pBytes, dwCount, ref num);
						EScPOS.EndPagePrinter(intPtr);
					}
					EScPOS.EndDocPrinter(intPtr);
				}
				EScPOS.ClosePrinter(intPtr);
			}
			bool flag5 = !flag;
			if (flag5)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
			}
			return flag;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x0019BB7C File Offset: 0x00199D7C
		public static bool PrintFile(string szFileName)
		{
			checked
			{
				bool flag2;
				try
				{
					FileStream fileStream = new FileStream(szFileName, FileMode.Open);
					BinaryReader binaryReader = new BinaryReader(fileStream);
					byte[] array = new byte[(int)fileStream.Length + 1];
					array = binaryReader.ReadBytes((int)fileStream.Length);
					IntPtr intPtr = Marshal.AllocCoTaskMem((int)fileStream.Length);
					Marshal.Copy(array, 0, intPtr, (int)fileStream.Length);
					bool flag = EScPOS.PrintEsto(intPtr, (int)fileStream.Length);
					Marshal.FreeCoTaskMem(intPtr);
					fileStream.Close();
					flag2 = flag;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
					flag2 = false;
				}
				return flag2;
			}
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x0019BC2C File Offset: 0x00199E2C
		public static object PrintString(string szString)
		{
			int length = szString.Length;
			IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(szString);
			bool flag = EScPOS.PrintEsto(intPtr, length);
			Marshal.FreeCoTaskMem(intPtr);
			return flag;
		}

		// Token: 0x04001455 RID: 5205
		private static string PrintNam = "POS";

		// Token: 0x02000593 RID: 1427
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DOCINFOW
		{
			// Token: 0x040037A6 RID: 14246
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDocName;

			// Token: 0x040037A7 RID: 14247
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pOutputFile;

			// Token: 0x040037A8 RID: 14248
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDataType;
		}

		// Token: 0x02000594 RID: 1428
		private class BitMapData
		{
			// Token: 0x040037A9 RID: 14249
			public BitArray Dots;

			// Token: 0x040037AA RID: 14250
			public short Height;

			// Token: 0x040037AB RID: 14251
			public short Width;
		}
	}
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Utils.QRCode
{
	// Token: 0x0200021E RID: 542
	[StandardModule]
	public sealed class modQRCode
	{
		// Token: 0x060061C3 RID: 25027 RVA: 0x0037A878 File Offset: 0x00378A78
		public static byte[] Create(string data, int height = 100, int width = 100, int margin = 0)
		{
			byte[] array = null;
			BarcodeWriter barcodeWriter = new BarcodeWriter
			{
				Format = BarcodeFormat.QR_CODE,
				Options = new QrCodeEncodingOptions
				{
					Height = height,
					Width = width,
					Margin = margin
				}
			};
			using (Bitmap bitmap = barcodeWriter.Write(data))
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					bitmap.Save(memoryStream, ImageFormat.Png);
					array = memoryStream.ToArray();
				}
			}
			return array;
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0037A934 File Offset: 0x00378B34
		public static string Read(byte[] bytes)
		{
			string text = string.Empty;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				using (Image image = Image.FromStream(memoryStream))
				{
					BarcodeReader barcodeReader = new BarcodeReader
					{
						AutoRotate = true,
						TryInverted = true,
						Options = new DecodingOptions
						{
							TryHarder = true,
							PossibleFormats = new BarcodeFormat[] { BarcodeFormat.QR_CODE }
						}
					};
					Result result = barcodeReader.Decode((Bitmap)image);
					bool flag = result != null;
					if (flag)
					{
						text = result.Text;
					}
				}
			}
			return text;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

namespace PointOfSale
{
	// Token: 0x02000167 RID: 359
	public class PrinterX
	{
		// Token: 0x06002FC1 RID: 12225 RVA: 0x0019C6A8 File Offset: 0x0019A8A8
		static PrinterX()
		{
			PrinterX.prn.PrintPage += PrinterX.Document_PrintPage;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x0019C724 File Offset: 0x0019A924
		public static void NewPrint(string printer_name)
		{
			PrinterX.PrintDatalist = new PrintDatalist();
			PrinterX._myfont = new Font("Courier New", 8f, FontStyle.Regular, GraphicsUnit.Point);
			PrinterX.prn = new PrintDocument();
			PrinterX.prn.PrinterSettings.PrinterName = printer_name;
			PrinterX.row = 0L;
			PageSettings pageSettings = new PageSettings();
			PageSettings pageSettings2 = pageSettings;
			pageSettings2.PrinterSettings.PrinterName = printer_name;
			pageSettings2.PaperSize = PrinterX.prn.PrinterSettings.PaperSizes.Cast<PaperSize>().Select<PaperSize, PaperSize>((PrinterX._Closure$__.$I8-0 == null) ? (PrinterX._Closure$__.$I8-0 = (PaperSize s) => s) : PrinterX._Closure$__.$I8-0).FirstOrDefault<PaperSize>();
			pageSettings2.Margins.Left = 0;
			pageSettings2.Margins.Right = 0;
			pageSettings2.Margins.Top = 0;
			pageSettings2.Margins.Bottom = 0;
			PrinterX.prn.DefaultPageSettings = pageSettings;
			PrinterX.prn.PrintPage += PrinterX.Document_PrintPage;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x0019C82D File Offset: 0x0019AA2D
		public static void SetFont(string FontFamily, float emSize, FontStyle style)
		{
			PrinterX._myfont = new Font(FontFamily, emSize, style, GraphicsUnit.Point);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x0019C83E File Offset: 0x0019AA3E
		public static void Print(string text)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, text, PrinterX._myfont, null, null, 0);
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0019C868 File Offset: 0x0019AA68
		public static void Print(string text, int[] arrWidth)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, text, PrinterX._myfont, arrWidth, null, 0);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0019C892 File Offset: 0x0019AA92
		public static void Print(string text, int[] arrWidth, StringFormat[] arrFormat)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, text, PrinterX._myfont, arrWidth, arrFormat, 0);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0019C8BC File Offset: 0x0019AABC
		public static void Print(string text, int[] arrWidth, int iLeft)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, text, PrinterX._myfont, arrWidth, null, iLeft);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x0019C8E6 File Offset: 0x0019AAE6
		public static void Print(Image img)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, img);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x0019C908 File Offset: 0x0019AB08
		public static void Print(Image img, int Width, int Height)
		{
			PrinterX.PrintDatalist = (PrintDatalist)PrintDatalist.AddItemToDataList(ref PrinterX.PrintDatalist, PrinterX.PrintDatalist.Count, img, Width, Height);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0019C92C File Offset: 0x0019AB2C
		public static void DoPrint()
		{
			PrinterX.prn.Print();
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0019C93C File Offset: 0x0019AB3C
		private static void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			int num = checked((int)Math.Round((double)e.PageSettings.HardMarginY));
			int num2 = 0;
			StringFormat stringFormat = PrinterX.c.MidLeft;
			while (PrinterX.row < (long)PrinterX.PrintDatalist.Count)
			{
				checked
				{
					PrintData printData = PrinterX.PrintDatalist[(int)PrinterX.row];
					bool flag = printData.img != null;
					if (flag)
					{
						bool flag2 = printData.Width == 0;
						if (flag2)
						{
							e.Graphics.DrawImage(printData.img, printData.iLeft, num);
							num += printData.img.Height;
						}
						else
						{
							e.Graphics.DrawImage(printData.img, printData.iLeft, num, printData.Width, printData.Height);
							num += printData.Height;
						}
					}
					else
					{
						bool flag3 = printData.ColumnWidth == null;
						if (flag3)
						{
							stringFormat = PrinterX.c.MidLeft;
							bool flag4 = printData.CAlign != null;
							if (flag4)
							{
								stringFormat = printData.CAlign[0];
							}
							bool flag5 = printData.iLeft > 0;
							if (flag5)
							{
								num = PrinterX.c.PrintCellText(printData.StringValue, printData.iLeft, num, e.PageBounds.Width, e, printData.Fnt, stringFormat, false, null, 0) - 8;
							}
							else
							{
								num = PrinterX.c.PrintCellText(printData.StringValue, num2, num, e.PageBounds.Width, e, printData.Fnt, stringFormat, false, null, 0) - 8;
							}
						}
						else
						{
							string[] array = printData.StringValue.Split(new char[] { ';' });
							int num3 = 0;
							int num4 = num2;
							bool flag6 = printData.iLeft > 0;
							if (flag6)
							{
								num4 = printData.iLeft;
							}
							int num5 = num;
							int num6 = 0;
							foreach (string text in array)
							{
								bool flag7 = num3 > printData.ColumnWidth.Count<int>() - 1;
								if (flag7)
								{
									num3 = 0;
								}
								int num7 = printData.ColumnWidth[num3];
								bool flag8 = printData.CAlign != null;
								if (flag8)
								{
									bool flag9 = num6 > printData.CAlign.Count<StringFormat>() - 1;
									if (flag9)
									{
										num6 = 0;
									}
									bool flag10 = num6 < printData.CAlign.Length;
									if (flag10)
									{
										stringFormat = printData.CAlign[num6];
									}
								}
								int num8 = PrinterX.c.PrintCellText(text, num4, num5, num7, e, printData.Fnt, stringFormat, false, null, 0) - 8;
								bool flag11 = num8 > num;
								if (flag11)
								{
									num = num8;
								}
								num3++;
								num6++;
								num4 += num7;
							}
						}
					}
					PrinterX.row += 1L;
				}
				bool flag12 = (double)num >= 0.99 * (double)e.PageBounds.Height;
				if (flag12)
				{
					e.HasMorePages = true;
					break;
				}
			}
		}

		// Token: 0x0400146A RID: 5226
		private static Queue<string> Lines = new Queue<string>();

		// Token: 0x0400146B RID: 5227
		private static Font _myfont = new Font("Courier New", 8f, FontStyle.Regular, GraphicsUnit.Point);

		// Token: 0x0400146C RID: 5228
		private static PrintDocument prn = new PrintDocument();

		// Token: 0x0400146D RID: 5229
		private static PrintDatalist PrintDatalist = new PrintDatalist();

		// Token: 0x0400146E RID: 5230
		private static PrintingFormat c = new PrintingFormat();

		// Token: 0x0400146F RID: 5231
		private static long row = 0L;
	}
}

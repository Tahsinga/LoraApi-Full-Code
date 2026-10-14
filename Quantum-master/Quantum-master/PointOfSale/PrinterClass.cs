using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace PointOfSale
{
	// Token: 0x02000168 RID: 360
	public class PrinterClass
	{
		// Token: 0x06002FCC RID: 12236 RVA: 0x0019CC23 File Offset: 0x0019AE23
		public PrinterClass(string AppPath)
		{
			this._Align = PrinterClass.TextAlignment.Default;
			this.bIsDebug = false;
			this.SetPrinterName("Microsoft Print to PDF", AppPath);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0019CC48 File Offset: 0x0019AE48
		public PrinterClass(string strPrinterName, string AppPath)
		{
			this._Align = PrinterClass.TextAlignment.Default;
			this.bIsDebug = false;
			this.SetPrinterName(strPrinterName, AppPath);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0019CC6C File Offset: 0x0019AE6C
		private void SetPrinterName(string PrinterName, string AppPath)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)GlobalModule.Printers))
					{
						Printer printer = (Printer)obj;
						bool flag = Operators.CompareString(printer.DeviceName, PrinterName, false) == 0;
						if (flag)
						{
							this.p = printer;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.p.DocumentName = "ERP System";
				this.Path = AppPath;
				bool flag2 = this.bIsDebug;
				if (flag2)
				{
					this.p.PrintAction = PrintAction.PrintToPreview;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x0019CD38 File Offset: 0x0019AF38
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x0019CD50 File Offset: 0x0019AF50
		public PrinterClass.TextAlignment Alignment
		{
			get
			{
				return this._Align;
			}
			set
			{
				this._Align = value;
			}
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x0019CD5A File Offset: 0x0019AF5A
		public void AlignLeft()
		{
			this._Align = PrinterClass.TextAlignment.Left;
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0019CD64 File Offset: 0x0019AF64
		public void AlignCenter()
		{
			this._Align = PrinterClass.TextAlignment.Center;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x0019CD6E File Offset: 0x0019AF6E
		public void AlignRight()
		{
			this._Align = PrinterClass.TextAlignment.Right;
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x0019CD78 File Offset: 0x0019AF78
		// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x0019CD95 File Offset: 0x0019AF95
		public string FontName
		{
			get
			{
				return this.p.FontName;
			}
			set
			{
				this.p.FontName = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x0019CDA8 File Offset: 0x0019AFA8
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x0019CDC5 File Offset: 0x0019AFC5
		public float FontSize
		{
			get
			{
				return this.p.FontSize;
			}
			set
			{
				this.p.FontSize = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x0019CDD8 File Offset: 0x0019AFD8
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x0019CDF5 File Offset: 0x0019AFF5
		public bool Bold
		{
			get
			{
				return this.p.FontBold;
			}
			set
			{
				this.p.FontBold = value;
			}
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0019CE08 File Offset: 0x0019B008
		public void DrawLine()
		{
			this.p.DrawWidth = 2;
			this.p.Line((float)this.p.Width, this.p.CurrentY);
			Printer printer;
			(printer = this.p).CurrentY = printer.CurrentY + 20f;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0019CE60 File Offset: 0x0019B060
		public void NormalFont()
		{
			this.FontSize = 9.5f;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0019CE6F File Offset: 0x0019B06F
		public void BigFont()
		{
			this.FontSize = 15f;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0019CE7E File Offset: 0x0019B07E
		public void SmallFont()
		{
			this.FontSize = 6f;
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0019CE8D File Offset: 0x0019B08D
		public void SetFont(float FontSize = 9.5f, string FontName = "FontA1x1", bool BoldType = false)
		{
			this.FontSize = FontSize;
			this.FontName = FontName;
			this.Bold = BoldType;
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x0019CEA8 File Offset: 0x0019B0A8
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x0019CEC0 File Offset: 0x0019B0C0
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				this._Path = value;
			}
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0019CECA File Offset: 0x0019B0CA
		public void PrintLogo(int space_padding)
		{
			this.PrintImage("C:\\Quantum\\logo.bmp", space_padding);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0019CEDC File Offset: 0x0019B0DC
		public void PrintBarcodeImage(PictureBox picbox, int space_padding)
		{
			Image image = picbox.Image;
			this.p.PaintPicture(image, (float)space_padding, this.p.CurrentY, float.NaN, float.NaN, 0f, 0f, float.NaN, float.NaN);
			this.p.CurrentY = this.p.CurrentY + (float)(checked(image.Height * 11));
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0019CF4C File Offset: 0x0019B14C
		private void PrintImage(string FileName, int space_padding)
		{
			Image image = Image.FromFile(FileName);
			this.p.PaintPicture(image, this.p.CurrentX + (float)space_padding, this.p.CurrentY, float.NaN, float.NaN, 0f, 0f, float.NaN, float.NaN);
			this.p.CurrentY = this.p.CurrentY + (float)(checked(image.Height * 11));
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0019CFC7 File Offset: 0x0019B1C7
		public void NewPage()
		{
			this.p.NewPage();
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x0019CFD8 File Offset: 0x0019B1D8
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x0019CFF5 File Offset: 0x0019B1F5
		public bool RTL
		{
			get
			{
				return this.p.RightToLeft;
			}
			set
			{
				this.p.RightToLeft = value;
			}
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0019D008 File Offset: 0x0019B208
		public void FeedPaper(int nlines = 3)
		{
			checked
			{
				for (int i = 1; i <= nlines; i++)
				{
					this.WriteLine("");
				}
			}
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x0019D030 File Offset: 0x0019B230
		public void GotoCol(int ColNumber = 0)
		{
			float num = (float)((double)this.p.Width / 48.0);
			this.p.CurrentX = num * (float)ColNumber;
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x0019D068 File Offset: 0x0019B268
		public void GotoSixth(int nSixth = 1)
		{
			float num = (float)((double)this.p.Width / 6.0);
			this.p.CurrentX = num * (float)(checked(nSixth - 1));
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x0019D0A0 File Offset: 0x0019B2A0
		public void UnderlineOn()
		{
			this.p.FontUnderline = true;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0019D0B0 File Offset: 0x0019B2B0
		public void UnderlineOff()
		{
			this.p.FontUnderline = false;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0019D0C0 File Offset: 0x0019B2C0
		public void EndDoc()
		{
			this.p.EndDoc();
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0019D0CF File Offset: 0x0019B2CF
		public void EndJob()
		{
			this.EndDoc();
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0019D0DC File Offset: 0x0019B2DC
		public void WriteLine(string Text)
		{
			float num = this.p.TextWidth(Text);
			switch (this._Align)
			{
			case PrinterClass.TextAlignment.Left:
				this.p.CurrentX = 0f;
				break;
			case PrinterClass.TextAlignment.Center:
				this.p.CurrentX = ((float)this.p.Width - num) / 2f;
				break;
			case PrinterClass.TextAlignment.Right:
				this.p.CurrentX = (float)this.p.Width - num;
				break;
			}
			this.p.Print(new object[] { Text });
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x0019D185 File Offset: 0x0019B385
		public void WriteChars(string Text)
		{
			this.p.Write(new object[] { Text });
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0019CFC7 File Offset: 0x0019B1C7
		public void CutPaper()
		{
			this.p.NewPage();
		}

		// Token: 0x04001470 RID: 5232
		private Printer p;

		// Token: 0x04001471 RID: 5233
		private string _Path;

		// Token: 0x04001472 RID: 5234
		private PrinterClass.TextAlignment _Align;

		// Token: 0x04001473 RID: 5235
		private bool bIsDebug;

		// Token: 0x02000597 RID: 1431
		public enum TextAlignment : byte
		{
			// Token: 0x040037B4 RID: 14260
			Default,
			// Token: 0x040037B5 RID: 14261
			Left,
			// Token: 0x040037B6 RID: 14262
			Center,
			// Token: 0x040037B7 RID: 14263
			Right
		}
	}
}

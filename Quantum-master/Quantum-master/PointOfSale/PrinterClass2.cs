using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
	// Token: 0x02000164 RID: 356
	public class PrinterClass2
	{
		// Token: 0x06002F7F RID: 12159 RVA: 0x0019BC64 File Offset: 0x00199E64
		public PrinterClass2(string AppPath)
		{
			this._Align = PrinterClass2.TextAlignment.Default;
			this.bIsDebug = false;
			this._FontName = "Consolas";
			this._FontSize = 9.5f;
			this._FontBold = false;
			this._FontUnderline = false;
			this._RightToLeft = false;
			this._LinesToPrint = new List<string>();
			this._ImagesToPrint = new List<Tuple<Image, int>>();
			this.SetPrinter("Microsoft Print to PDF", AppPath);
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x0019BCD8 File Offset: 0x00199ED8
		public PrinterClass2(string strPrinterName, string AppPath)
		{
			this._Align = PrinterClass2.TextAlignment.Default;
			this.bIsDebug = false;
			this._FontName = "Consolas";
			this._FontSize = 9.5f;
			this._FontBold = false;
			this._FontUnderline = false;
			this._RightToLeft = false;
			this._LinesToPrint = new List<string>();
			this._ImagesToPrint = new List<Tuple<Image, int>>();
			this.SetPrinter(strPrinterName, AppPath);
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0019BD48 File Offset: 0x00199F48
		private void SetPrinter(string printerName, string appPath)
		{
			bool flag = PrinterSettings.InstalledPrinters.Cast<string>().Contains(printerName);
			if (flag)
			{
				this.printDoc = new PrintDocument();
				this.printDoc.PrinterSettings.PrinterName = printerName;
				this.printDoc.DocumentName = "ERP System";
				this._Path = appPath;
				bool flag2 = this.bIsDebug;
				if (flag2)
				{
					this.printDoc.PrintController = new StandardPrintController();
				}
				this.printDoc.PrintPage += this.OnPrintPage;
				return;
			}
			throw new Exception("Printer not found: " + printerName);
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x0019BDEC File Offset: 0x00199FEC
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x0019BE04 File Offset: 0x0019A004
		public PrinterClass2.TextAlignment Alignment
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

		// Token: 0x06002F84 RID: 12164 RVA: 0x0019BE0E File Offset: 0x0019A00E
		public void AlignLeft()
		{
			this._Align = PrinterClass2.TextAlignment.Left;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0019BE18 File Offset: 0x0019A018
		public void AlignCenter()
		{
			this._Align = PrinterClass2.TextAlignment.Center;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0019BE22 File Offset: 0x0019A022
		public void AlignRight()
		{
			this._Align = PrinterClass2.TextAlignment.Right;
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x0019BE2C File Offset: 0x0019A02C
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x0019BE44 File Offset: 0x0019A044
		public string FontName
		{
			get
			{
				return this._FontName;
			}
			set
			{
				this._FontName = value;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x0019BE50 File Offset: 0x0019A050
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x0019BE68 File Offset: 0x0019A068
		public float FontSize
		{
			get
			{
				return this._FontSize;
			}
			set
			{
				this._FontSize = value;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x0019BE74 File Offset: 0x0019A074
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x0019BE8C File Offset: 0x0019A08C
		public bool Bold
		{
			get
			{
				return this._FontBold;
			}
			set
			{
				this._FontBold = value;
			}
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x0019BE96 File Offset: 0x0019A096
		public void NormalFont()
		{
			this.FontSize = 9.5f;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x0019BEA5 File Offset: 0x0019A0A5
		public void BigFont()
		{
			this.FontSize = 15f;
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x0019BEB4 File Offset: 0x0019A0B4
		public void SmallFont()
		{
			this.FontSize = 6f;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0019BEC3 File Offset: 0x0019A0C3
		public void SetFont(float FontSize = 9.5f, string FontName = "Consolas", bool BoldType = false)
		{
			this.FontSize = FontSize;
			this.FontName = FontName;
			this.Bold = BoldType;
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x0019BEE0 File Offset: 0x0019A0E0
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x0019BEF8 File Offset: 0x0019A0F8
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

		// Token: 0x06002F93 RID: 12179 RVA: 0x0019BF02 File Offset: 0x0019A102
		public void PrintLogo(int space_padding)
		{
			this.PrintImage("C:\\Quantum\\logo.bmp", space_padding);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x0019BF14 File Offset: 0x0019A114
		public void PrintBarcodeImage(PictureBox picbox, int space_padding)
		{
			bool flag = picbox.Image != null;
			if (flag)
			{
				this._ImagesToPrint.Add(Tuple.Create<Image, int>(picbox.Image, space_padding));
			}
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x0019BF4C File Offset: 0x0019A14C
		private void PrintImage(string FileName, int space_padding)
		{
			bool flag = File.Exists(FileName);
			if (flag)
			{
				Image image = Image.FromFile(FileName);
				this._ImagesToPrint.Add(Tuple.Create<Image, int>(image, space_padding));
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x0019BF80 File Offset: 0x0019A180
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x0019BF98 File Offset: 0x0019A198
		public bool RTL
		{
			get
			{
				return this._RightToLeft;
			}
			set
			{
				this._RightToLeft = value;
			}
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x0019BFA4 File Offset: 0x0019A1A4
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

		// Token: 0x06002F99 RID: 12185 RVA: 0x0019BFCC File Offset: 0x0019A1CC
		public void UnderlineOn()
		{
			this._FontUnderline = true;
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x0019BFD6 File Offset: 0x0019A1D6
		public void UnderlineOff()
		{
			this._FontUnderline = false;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00002A30 File Offset: 0x00000C30
		public void EndDoc()
		{
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x0019BFE0 File Offset: 0x0019A1E0
		public void EndJob()
		{
			this.EndDoc();
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x0019BFEA File Offset: 0x0019A1EA
		public void WriteLine(string Text)
		{
			this._LinesToPrint.Add(Text);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0019BFEA File Offset: 0x0019A1EA
		public void WriteChars(string Text)
		{
			this._LinesToPrint.Add(Text);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0019BFFA File Offset: 0x0019A1FA
		public void CutPaper()
		{
			this.FeedPaper(5);
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0019C008 File Offset: 0x0019A208
		public void Print()
		{
			bool flag = this.printDoc != null;
			if (flag)
			{
				bool flag2 = new PrintDialog
				{
					Document = this.printDoc
				}.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					this.printDoc.Print();
				}
			}
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0019C054 File Offset: 0x0019A254
		private void OnPrintPage(object sender, PrintPageEventArgs e)
		{
			FontStyle fontStyle = (this._FontBold ? FontStyle.Bold : FontStyle.Regular);
			bool fontUnderline = this._FontUnderline;
			if (fontUnderline)
			{
				fontStyle |= FontStyle.Underline;
			}
			Font font = new Font(this._FontName, this._FontSize, fontStyle);
			float num = (float)e.MarginBounds.Top;
			float height = font.GetHeight(e.Graphics);
			try
			{
				foreach (string text in this._LinesToPrint)
				{
					float num2 = (float)e.MarginBounds.Left;
					float width = e.Graphics.MeasureString(text, font).Width;
					switch (this._Align)
					{
					case PrinterClass2.TextAlignment.Left:
						num2 = (float)e.MarginBounds.Left;
						break;
					case PrinterClass2.TextAlignment.Center:
						num2 = (float)e.MarginBounds.Left + ((float)e.MarginBounds.Width - width) / 2f;
						break;
					case PrinterClass2.TextAlignment.Right:
						num2 = (float)e.MarginBounds.Right - width;
						break;
					}
					e.Graphics.DrawString(text, font, Brushes.Black, num2, num);
					num += height;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (Tuple<Image, int> tuple in this._ImagesToPrint)
				{
					Image item = tuple.Item1;
					int item2 = tuple.Item2;
					e.Graphics.DrawImage(item, (float)(checked(e.MarginBounds.Left + item2)), num);
					num += (float)(checked(item.Height + 10));
				}
			}
			finally
			{
				List<Tuple<Image, int>>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this._LinesToPrint.Clear();
			this._ImagesToPrint.Clear();
			e.HasMorePages = false;
		}

		// Token: 0x04001456 RID: 5206
		private PrintDocument printDoc;

		// Token: 0x04001457 RID: 5207
		private string _Path;

		// Token: 0x04001458 RID: 5208
		private PrinterClass2.TextAlignment _Align;

		// Token: 0x04001459 RID: 5209
		private bool bIsDebug;

		// Token: 0x0400145A RID: 5210
		private string _FontName;

		// Token: 0x0400145B RID: 5211
		private float _FontSize;

		// Token: 0x0400145C RID: 5212
		private bool _FontBold;

		// Token: 0x0400145D RID: 5213
		private bool _FontUnderline;

		// Token: 0x0400145E RID: 5214
		private bool _RightToLeft;

		// Token: 0x0400145F RID: 5215
		private List<string> _LinesToPrint;

		// Token: 0x04001460 RID: 5216
		private List<Tuple<Image, int>> _ImagesToPrint;

		// Token: 0x02000595 RID: 1429
		public enum TextAlignment : byte
		{
			// Token: 0x040037AD RID: 14253
			Default,
			// Token: 0x040037AE RID: 14254
			Left,
			// Token: 0x040037AF RID: 14255
			Center,
			// Token: 0x040037B0 RID: 14256
			Right
		}
	}
}

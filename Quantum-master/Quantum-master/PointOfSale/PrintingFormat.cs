using System;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace PointOfSale
{
	// Token: 0x0200016A RID: 362
	public class PrintingFormat
	{
		// Token: 0x06003184 RID: 12676 RVA: 0x001AC968 File Offset: 0x001AAB68
		public PrintingFormat()
		{
			this.mTopLeft = new StringFormat();
			this.mTopCenter = new StringFormat();
			this.mTopRight = new StringFormat();
			this.mMidLeft = new StringFormat();
			this.mMidCenter = new StringFormat();
			this.mMidRight = new StringFormat();
			this.mBotLeft = new StringFormat();
			this.mBotCenter = new StringFormat();
			this.mBotRight = new StringFormat();
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x001AC9E0 File Offset: 0x001AABE0
		public Font FntTitle
		{
			get
			{
				return new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point);
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x001ACA04 File Offset: 0x001AAC04
		public Font FntTableHeader
		{
			get
			{
				return new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point);
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x001ACA28 File Offset: 0x001AAC28
		public Font FntTableCell
		{
			get
			{
				return new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point);
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x001ACA4C File Offset: 0x001AAC4C
		public StringFormat TopLeft
		{
			get
			{
				this.mTopLeft.LineAlignment = StringAlignment.Near;
				this.mTopLeft.Alignment = StringAlignment.Near;
				return this.mTopLeft;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x001ACA80 File Offset: 0x001AAC80
		public StringFormat TopCenter
		{
			get
			{
				this.mTopCenter.LineAlignment = StringAlignment.Near;
				this.mTopCenter.Alignment = StringAlignment.Center;
				return this.mTopCenter;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x001ACAB4 File Offset: 0x001AACB4
		public StringFormat TopRight
		{
			get
			{
				this.mTopRight.LineAlignment = StringAlignment.Near;
				this.mTopRight.Alignment = StringAlignment.Far;
				return this.mTopRight;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x001ACAE8 File Offset: 0x001AACE8
		public StringFormat MidLeft
		{
			get
			{
				this.mMidLeft.LineAlignment = StringAlignment.Center;
				this.mMidLeft.Alignment = StringAlignment.Near;
				return this.mMidLeft;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x001ACB1C File Offset: 0x001AAD1C
		public StringFormat MidCenter
		{
			get
			{
				this.mMidCenter.LineAlignment = StringAlignment.Center;
				this.mMidCenter.Alignment = StringAlignment.Center;
				return this.mMidCenter;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x001ACB50 File Offset: 0x001AAD50
		public StringFormat MidRight
		{
			get
			{
				this.mMidRight.LineAlignment = StringAlignment.Center;
				this.mMidRight.Alignment = StringAlignment.Far;
				return this.mMidRight;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x001ACB84 File Offset: 0x001AAD84
		public StringFormat BotLeft
		{
			get
			{
				this.mBotLeft.LineAlignment = StringAlignment.Far;
				this.mBotLeft.Alignment = StringAlignment.Near;
				return this.mBotLeft;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x001ACBB8 File Offset: 0x001AADB8
		public StringFormat BotCenter
		{
			get
			{
				this.mBotCenter.LineAlignment = StringAlignment.Far;
				this.mBotCenter.Alignment = StringAlignment.Center;
				return this.mBotCenter;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x001ACBEC File Offset: 0x001AADEC
		public StringFormat BotRight
		{
			get
			{
				this.mBotRight.LineAlignment = StringAlignment.Far;
				this.mBotRight.Alignment = StringAlignment.Far;
				return this.mBotRight;
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x001ACC20 File Offset: 0x001AAE20
		public int PrintCellText(string strValue, int x, int y, int w, PrintPageEventArgs e, Font Font, StringFormat Format, bool Border = false, Brush Fill = null, int h = 0)
		{
			RectangleF rectangleF = default(RectangleF);
			rectangleF.Location = new Point(x, y);
			bool flag = h > 0;
			checked
			{
				if (flag)
				{
					rectangleF.Size = new Size(w, h);
				}
				else
				{
					rectangleF.Size = new Size(w, 10 + (int)Math.Round((double)e.Graphics.MeasureString(strValue, Font, w - 10, StringFormat.GenericTypographic).Height));
				}
				bool flag2 = !Information.IsNothing(Fill);
				if (flag2)
				{
					e.Graphics.FillRectangle(Fill, Rectangle.Round(rectangleF));
				}
				e.Graphics.DrawString(strValue, Font, Brushes.Black, rectangleF, Format);
				if (Border)
				{
					e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectangleF));
				}
				else
				{
					e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectangleF));
				}
				return (int)Math.Round((double)(unchecked((float)y + rectangleF.Size.Height)));
			}
		}

		// Token: 0x04001518 RID: 5400
		private StringFormat mTopLeft;

		// Token: 0x04001519 RID: 5401
		private StringFormat mTopCenter;

		// Token: 0x0400151A RID: 5402
		private StringFormat mTopRight;

		// Token: 0x0400151B RID: 5403
		private StringFormat mMidLeft;

		// Token: 0x0400151C RID: 5404
		private StringFormat mMidCenter;

		// Token: 0x0400151D RID: 5405
		private StringFormat mMidRight;

		// Token: 0x0400151E RID: 5406
		private StringFormat mBotLeft;

		// Token: 0x0400151F RID: 5407
		private StringFormat mBotCenter;

		// Token: 0x04001520 RID: 5408
		private StringFormat mBotRight;
	}
}

using System;
using System.Drawing;

namespace PointOfSale
{
	// Token: 0x02000165 RID: 357
	public class PrintData
	{
		// Token: 0x06002FA2 RID: 12194 RVA: 0x0019C268 File Offset: 0x0019A468
		public PrintData(int Id, string StringValue = "", Font Fnt = null, int[] ColumnWidth = null, StringFormat[] CAlign = null, int iLeft = 0)
		{
			this.mID = 0;
			this.mStringValue = null;
			this.mFnt = null;
			this.mColumnWidth = null;
			this.mCAlign = null;
			this.miLeft = 0;
			this.mImg = null;
			this.mWidth = 0;
			this.mHeight = 0;
			this.mID = Id;
			this.mStringValue = StringValue;
			this.mFnt = Fnt;
			this.mColumnWidth = ColumnWidth;
			this.mCAlign = CAlign;
			this.miLeft = iLeft;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0019C2EC File Offset: 0x0019A4EC
		public PrintData(int Id, Image img)
		{
			this.mID = 0;
			this.mStringValue = null;
			this.mFnt = null;
			this.mColumnWidth = null;
			this.mCAlign = null;
			this.miLeft = 0;
			this.mImg = null;
			this.mWidth = 0;
			this.mHeight = 0;
			this.mID = Id;
			this.mImg = img;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x0019C350 File Offset: 0x0019A550
		public PrintData(int Id, Image img, int Width, int Height)
		{
			this.mID = 0;
			this.mStringValue = null;
			this.mFnt = null;
			this.mColumnWidth = null;
			this.mCAlign = null;
			this.miLeft = 0;
			this.mImg = null;
			this.mWidth = 0;
			this.mHeight = 0;
			this.mID = Id;
			this.mImg = img;
			this.mWidth = Width;
			this.mHeight = Height;
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0019C3C4 File Offset: 0x0019A5C4
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x0019C3DC File Offset: 0x0019A5DC
		public int Id
		{
			get
			{
				return this.mID;
			}
			set
			{
				this.mID = value;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x0019C3E8 File Offset: 0x0019A5E8
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x0019C400 File Offset: 0x0019A600
		public string StringValue
		{
			get
			{
				return this.mStringValue;
			}
			set
			{
				this.mStringValue = value;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x0019C40C File Offset: 0x0019A60C
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0019C424 File Offset: 0x0019A624
		public Font Fnt
		{
			get
			{
				return this.mFnt;
			}
			set
			{
				this.mFnt = value;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x0019C430 File Offset: 0x0019A630
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0019C448 File Offset: 0x0019A648
		public int[] ColumnWidth
		{
			get
			{
				return this.mColumnWidth;
			}
			set
			{
				this.mColumnWidth = value;
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x0019C454 File Offset: 0x0019A654
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0019C46C File Offset: 0x0019A66C
		public StringFormat[] CAlign
		{
			get
			{
				return this.mCAlign;
			}
			set
			{
				this.mCAlign = value;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0019C478 File Offset: 0x0019A678
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0019C490 File Offset: 0x0019A690
		public int iLeft
		{
			get
			{
				return this.miLeft;
			}
			set
			{
				this.miLeft = value;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x0019C49C File Offset: 0x0019A69C
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x0019C4B4 File Offset: 0x0019A6B4
		public Image img
		{
			get
			{
				return this.mImg;
			}
			set
			{
				this.mImg = value;
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0019C4C0 File Offset: 0x0019A6C0
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0019C4D8 File Offset: 0x0019A6D8
		public int Width
		{
			get
			{
				return this.mWidth;
			}
			set
			{
				this.mWidth = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x0019C4E4 File Offset: 0x0019A6E4
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0019C4FC File Offset: 0x0019A6FC
		public int Height
		{
			get
			{
				return this.mHeight;
			}
			set
			{
				this.mHeight = value;
			}
		}

		// Token: 0x04001461 RID: 5217
		private int mID;

		// Token: 0x04001462 RID: 5218
		private string mStringValue;

		// Token: 0x04001463 RID: 5219
		private Font mFnt;

		// Token: 0x04001464 RID: 5220
		private int[] mColumnWidth;

		// Token: 0x04001465 RID: 5221
		private StringFormat[] mCAlign;

		// Token: 0x04001466 RID: 5222
		private int miLeft;

		// Token: 0x04001467 RID: 5223
		private Image mImg;

		// Token: 0x04001468 RID: 5224
		private int mWidth;

		// Token: 0x04001469 RID: 5225
		private int mHeight;
	}
}

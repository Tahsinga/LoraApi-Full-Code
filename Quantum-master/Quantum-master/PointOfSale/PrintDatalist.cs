using System;
using System.Collections;
using System.Drawing;

namespace PointOfSale
{
	// Token: 0x02000166 RID: 358
	public class PrintDatalist : CollectionBase
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x0019C510 File Offset: 0x0019A710
		public PrintData Add(int Id, string StringValue, Font Fnt, int[] ColumnWidth = null, StringFormat[] CAlign = null, int iLeft = 0)
		{
			PrintData printData = new PrintData(Id, StringValue, Fnt, ColumnWidth, CAlign, iLeft);
			base.InnerList.Add(printData);
			return printData;
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0019C540 File Offset: 0x0019A740
		public PrintData Add(int Id, Image img)
		{
			PrintData printData = new PrintData(Id, img);
			base.InnerList.Add(printData);
			return printData;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0019C568 File Offset: 0x0019A768
		public PrintData Add(int Id, Image img, int Width, int Height)
		{
			PrintData printData = new PrintData(Id, img, Width, Height);
			base.InnerList.Add(printData);
			return printData;
		}

		// Token: 0x170011B1 RID: 4529
		public PrintData this[int Index]
		{
			get
			{
				bool flag = Index > checked(base.InnerList.Count - 1) || Index < 0;
				if (flag)
				{
					throw new IndexOutOfRangeException("Index out of Range");
				}
				return (PrintData)base.InnerList[Index];
			}
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0019C5E0 File Offset: 0x0019A7E0
		public int IndexOf(int Id)
		{
			int num = -1;
			checked
			{
				int num2 = base.InnerList.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					PrintData printData = (PrintData)base.InnerList[i];
					bool flag = printData.Id == Id;
					if (flag)
					{
						num = i;
						break;
					}
				}
				return num;
			}
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0019C63C File Offset: 0x0019A83C
		public static object AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, string StringValue, Font Fnt, int[] ColumnWidth = null, StringFormat[] CFormat = null, int iLeft = 0)
		{
			PrintDatalist.Add(Id, StringValue, Fnt, ColumnWidth, CFormat, iLeft);
			return PrintDatalist;
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x0019C664 File Offset: 0x0019A864
		public static object AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, Image Img)
		{
			PrintDatalist.Add(Id, Img);
			return PrintDatalist;
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0019C684 File Offset: 0x0019A884
		public static object AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, Image Img, int Width, int Height)
		{
			PrintDatalist.Add(Id, Img, Width, Height);
			return PrintDatalist;
		}
	}
}

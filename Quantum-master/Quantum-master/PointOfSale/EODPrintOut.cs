using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000056 RID: 86
	[DesignerGenerated]
	public partial class EODPrintOut : Form
	{
		// Token: 0x060011F1 RID: 4593 RVA: 0x000AC1A0 File Offset: 0x000AA3A0
		public EODPrintOut()
		{
			base.Load += this.EODPrintOut_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.TextToPrint = "";
			this.PrintCharCount = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000AC7E1 File Offset: 0x000AA9E1
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x000AC7EB File Offset: 0x000AA9EB
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000AC7F4 File Offset: 0x000AA9F4
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x000AC800 File Offset: 0x000AAA00
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000AC843 File Offset: 0x000AAA43
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x000AC84D File Offset: 0x000AAA4D
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x000AC856 File Offset: 0x000AAA56
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x000AC860 File Offset: 0x000AAA60
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000AC869 File Offset: 0x000AAA69
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x000AC873 File Offset: 0x000AAA73
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000AC87C File Offset: 0x000AAA7C
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x000AC886 File Offset: 0x000AAA86
		internal virtual ComboBox cboUser
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000AC88F File Offset: 0x000AAA8F
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x000AC89C File Offset: 0x000AAA9C
		internal virtual PrintDocument PrintDocument1
		{
			[CompilerGenerated]
			get
			{
				return this._PrintDocument1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				PrintDocument printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage -= printPageEventHandler;
				}
				this._PrintDocument1 = value;
				printDocument = this._PrintDocument1;
				if (printDocument != null)
				{
					printDocument.PrintPage += printPageEventHandler;
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000AC8DF File Offset: 0x000AAADF
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x000AC8E9 File Offset: 0x000AAAE9
		internal virtual CheckBox chkShowItemsSold
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000AC8F2 File Offset: 0x000AAAF2
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000AC8FC File Offset: 0x000AAAFC
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000AC905 File Offset: 0x000AAB05
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000AC910 File Offset: 0x000AAB10
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000AC954 File Offset: 0x000AAB54
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintSummary(this.GetSalesSummary(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd"))), this.GetUserSalesDetail(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.cboUser.Text, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), false), this.GetUserSalesPaymentSummary(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.cboUser.Text, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), false), this.GetSalesSummarybyCategory(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), this.cboUser.Text, false), this.cboUser.Text);
				MessageBox.Show("Print Job Sent.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing end of day slip. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000ACAEC File Offset: 0x000AACEC
		private void PrintSummary(DataTable salessummary, DataTable salesdata, DataTable paymeth, DataTable salesbycategory, string sales_user)
		{
			bool flag = !this.chkShowItemsSold.Checked;
			if (flag)
			{
				salesdata.Rows.Clear();
			}
			string text = "";
			text = this.coname;
			int num = text.Length;
			num = text.Length;
			checked
			{
				string text2 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
				this.TextToPrint = text2 + text + Environment.NewLine;
				bool flag2 = Operators.CompareString(this.cobranch, "", false) != 0;
				ref string ptr;
				if (flag2)
				{
					text = "Branch: " + this.cobranch;
					num = text.Length;
					string text3 = new string(' ', (int)Math.Round(Math.Round((double)(50 - num) / 2.0)));
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + text + Environment.NewLine;
				}
				text = Environment.NewLine;
				text = text + "END OF DAY PRINT OUT FOR " + sales_user + Environment.NewLine;
				text += this.DTDate.Value.ToShortDateString();
				text += Environment.NewLine;
				text += DateTime.Now.ToString("HH:mm");
				text += Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = "";
				text = text + "ALL USERS SALES SUMMARY" + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				text = "";
				try
				{
					foreach (object obj in salessummary.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["DoneBy"], ": "), MyProject.Forms.Form1.basecurrency), dataRow["ShiftSales"].ToString())));
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text + Environment.NewLine;
						text = "";
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
				text = text + text + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = "CATEGORY SALES FOR " + sales_user + Environment.NewLine + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				text = "";
				try
				{
					foreach (object obj2 in salesbycategory.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						text = text + dataRow2["CatDesc"].ToString() + Environment.NewLine;
						text = string.Concat(new string[]
						{
							text,
							MyProject.Forms.Form1.basecurrency,
							dataRow2["Revenue"].ToString(),
							Environment.NewLine,
							Environment.NewLine
						});
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text;
						text = "";
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				text = "ITEMS SOLD BY " + sales_user + Environment.NewLine + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				text = "";
				try
				{
					foreach (object obj3 in salesdata.Rows)
					{
						DataRow dataRow3 = (DataRow)obj3;
						string text4 = dataRow3["Product_Code"].ToString();
						text = string.Concat(new string[]
						{
							text,
							dataRow3["Product_Description"].ToString(),
							" X ",
							dataRow3["Quantity_Sold"].ToString(),
							" @ ",
							dataRow3["Unit_Price"].ToString(),
							Environment.NewLine
						});
						text = text + MyProject.Forms.Form1.basecurrency + dataRow3["Revenue"].ToString() + Environment.NewLine;
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + text;
						text = "";
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				text = text + text + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				text = "";
				text = text + "PAYMENT SUMMARY" + Environment.NewLine + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				text = "";
				try
				{
					foreach (object obj4 in paymeth.Rows)
					{
						DataRow dataRow4 = (DataRow)obj4;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow4["PaymentMethodDesc"], " "), dataRow4["Revenue"].ToString()), Environment.NewLine)));
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = "End";
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text;
				this.stringToRead = new StringReader(this.TextToPrint);
				try
				{
					StandardPrintController standardPrintController = new StandardPrintController();
					this.PrintDocument1.PrintController = standardPrintController;
					this.PrintDocument1.Print();
				}
				catch (Exception ex)
				{
					this.stringToRead.Close();
				}
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000AD17C File Offset: 0x000AB37C
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				try
				{
					this.coname = dataRow["CompanyName"].ToString();
					this.coadd = dataRow["Address"].ToString();
					this.cobranch = dataRow["Branch"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000AD29C File Offset: 0x000AB49C
		private DataTable GetSalesSummary(int coid, string branch, int thedate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ShiftSalesSummaryByUser";
			sqlCommand.Parameters.AddWithValue("shiftdate", thedate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000AD330 File Offset: 0x000AB530
		private DataTable GetUserSalesDetail(int coid, string branch, string user, int thedate, bool allusers)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "USERSalesDayDetail";
			sqlCommand.Parameters.AddWithValue("shiftdate", thedate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("theuser", user);
			if (allusers)
			{
				sqlCommand.Parameters.AddWithValue("allusers", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("allusers", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000AD410 File Offset: 0x000AB610
		private DataTable GetUserSalesPaymentSummary(int coid, string branch, string user, int thedate, bool allusers)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "USERSalesPaymentSummary";
			sqlCommand.Parameters.AddWithValue("shiftdate", thedate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("theuser", user);
			if (allusers)
			{
				sqlCommand.Parameters.AddWithValue("allusers", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("allusers", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			checked
			{
				int num7 = (int)Math.Round(Math.Round((double)num3 / 1.0));
				Rectangle rectangle = new Rectangle(num5, num6, num4, num3);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num8 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				while (i < num8)
				{
					text = this.stringToRead.ReadLine();
					bool flag = text == null;
					if (flag)
					{
						break;
					}
					float num9 = unchecked(num2 + (float)i * font.GetHeight(e.Graphics));
					e.Graphics.DrawString(text, font, Brushes.Black, num, num9, new StringFormat());
					i++;
				}
				bool flag2 = text == null;
				if (flag2)
				{
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
				}
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000AD644 File Offset: 0x000AB844
		private void LoadUsers()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboUser.DataSource = dataTable;
			this.cboUser.ValueMember = "Username";
			this.cboUser.DisplayMember = "Username";
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000AD6EC File Offset: 0x000AB8EC
		private void EODPrintOut_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				this.LoadUsers();
				this.GetBranchDetails();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000AD74C File Offset: 0x000AB94C
		private DataTable GetSalesSummarybyCategory(int coid, string branch, int thedate, string theuser, bool allusers)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UserSalesCategorySummaryPERIOD";
			sqlCommand.Parameters.AddWithValue("shiftdate", thedate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("theuser", theuser);
			if (allusers)
			{
				sqlCommand.Parameters.AddWithValue("allusers", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("allusers", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000AD82C File Offset: 0x000ABA2C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintSummary(this.GetSalesSummary(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd"))), this.GetUserSalesDetail(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "All Users", Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), true), this.GetUserSalesPaymentSummary(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "All Users", Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), true), this.GetSalesSummarybyCategory(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")), "All Users", true), "All Users");
				MessageBox.Show("Print Job Sent.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing end of day slip. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000878 RID: 2168
		private string _cnn;

		// Token: 0x04000879 RID: 2169
		private string TextToPrint;

		// Token: 0x0400087A RID: 2170
		private IList<Stream> m_streams;

		// Token: 0x0400087B RID: 2171
		private int m_currentPageIndex;

		// Token: 0x0400087C RID: 2172
		private string coadd;

		// Token: 0x0400087D RID: 2173
		private string coname;

		// Token: 0x0400087E RID: 2174
		private string cobranch;

		// Token: 0x0400087F RID: 2175
		private int PrintCharCount;

		// Token: 0x04000880 RID: 2176
		private StringReader stringToRead;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BarcodeRender;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PointOfSale.My;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x0200020C RID: 524
	[DesignerGenerated]
	public partial class ViewCancelledSales : UserControl
	{
		// Token: 0x06005E2D RID: 24109 RVA: 0x0035E7B8 File Offset: 0x0035C9B8
		public ViewCancelledSales()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.pf2 = new PublicFunctions2();
			this.TextToPrint = "";
			this.datCustomerDetails = new DataTable();
			this.ProdtDiscTotal = 0m;
			this.isReprint = 0;
			this.LINE = "_________________________________________________________________________";
			this.datPayDetails = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x0035F324 File Offset: 0x0035D524
		// (set) Token: 0x06005E31 RID: 24113 RVA: 0x0035F32E File Offset: 0x0035D52E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x0035F337 File Offset: 0x0035D537
		// (set) Token: 0x06005E33 RID: 24115 RVA: 0x0035F344 File Offset: 0x0035D544
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x0035F387 File Offset: 0x0035D587
		// (set) Token: 0x06005E35 RID: 24117 RVA: 0x0035F391 File Offset: 0x0035D591
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x0035F39A File Offset: 0x0035D59A
		// (set) Token: 0x06005E37 RID: 24119 RVA: 0x0035F3A4 File Offset: 0x0035D5A4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x0035F3AD File Offset: 0x0035D5AD
		// (set) Token: 0x06005E39 RID: 24121 RVA: 0x0035F3B8 File Offset: 0x0035D5B8
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

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x0035F3FB File Offset: 0x0035D5FB
		// (set) Token: 0x06005E3B RID: 24123 RVA: 0x0035F405 File Offset: 0x0035D605
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06005E3C RID: 24124 RVA: 0x0035F40E File Offset: 0x0035D60E
		// (set) Token: 0x06005E3D RID: 24125 RVA: 0x0035F418 File Offset: 0x0035D618
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x0035F421 File Offset: 0x0035D621
		// (set) Token: 0x06005E3F RID: 24127 RVA: 0x0035F42B File Offset: 0x0035D62B
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x0035F434 File Offset: 0x0035D634
		// (set) Token: 0x06005E41 RID: 24129 RVA: 0x0035F43E File Offset: 0x0035D63E
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0035F447 File Offset: 0x0035D647
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x0035F451 File Offset: 0x0035D651
		internal virtual DataGridView dgvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0035F45A File Offset: 0x0035D65A
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x0035F464 File Offset: 0x0035D664
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0035F46D File Offset: 0x0035D66D
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x0035F478 File Offset: 0x0035D678
		internal virtual DataGridView dgvInvoices
		{
			[CompilerGenerated]
			get
			{
				return this._dgvInvoices;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
				DataGridView dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvInvoices = value;
				dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0035F4BB File Offset: 0x0035D6BB
		// (set) Token: 0x06005E49 RID: 24137 RVA: 0x0035F4C8 File Offset: 0x0035D6C8
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

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06005E4A RID: 24138 RVA: 0x0035F50B File Offset: 0x0035D70B
		// (set) Token: 0x06005E4B RID: 24139 RVA: 0x0035F515 File Offset: 0x0035D715
		internal virtual PictureBox PicQRCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06005E4C RID: 24140 RVA: 0x0035F51E File Offset: 0x0035D71E
		// (set) Token: 0x06005E4D RID: 24141 RVA: 0x0035F528 File Offset: 0x0035D728
		internal virtual DataGridView dgv
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x0035F534 File Offset: 0x0035D734
		private void LoadSales()
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CancelledSalesForPeriodByInvoice";
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTstart.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTend.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvoices.DataSource = dataTable;
				this.dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Details";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Reprint Credit Note";
				dataGridViewButtonColumn2.Text = "Reprint";
				dataGridViewButtonColumn2.Name = "Reprint";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Print Debit Note";
				dataGridViewButtonColumn3.Text = "print";
				dataGridViewButtonColumn3.Name = "print";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Retry REVMAX";
				dataGridViewButtonColumn4.Text = "Retry Fiscalisation";
				dataGridViewButtonColumn4.Name = "RevmaxRetry";
				dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn4);
			}
			else
			{
				MessageBox.Show("There are no sales for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvInvoices.DataSource = dataTable2;
			}
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x0035F7B4 File Offset: 0x0035D9B4
		private void LoadDetails(int inv)
		{
			this.GroupBox2.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CancelledSalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvDetails.DataSource = dataTable;
				this.dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.GroupBox2.Text = "Showing details for invoice: " + Conversions.ToString(inv);
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				this.dgvDetails.DataSource = dataTable2;
				this.GroupBox2.Text = "No details availablefor invoice: " + Conversions.ToString(inv);
			}
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0035F8E4 File Offset: 0x0035DAE4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadSales();
			}
			catch (Exception ex)
			{
				MessageBox.Show("error loading sales for period. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x0035F938 File Offset: 0x0035DB38
		private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "view", false) == 0;
					if (flag2)
					{
						this.LoadDetails(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Reprint", false) == 0;
						if (flag3)
						{
							bool flag4 = MyProject.Forms.Form1.inv_template_GetPro == 1;
							if (flag4)
							{
								CreditNoteGetPro creditNoteGetPro = new CreditNoteGetPro();
								creditNoteGetPro.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
								creditNoteGetPro.revmax_sign = "";
								creditNoteGetPro.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
								creditNoteGetPro.reprint = 0;
								creditNoteGetPro.branch = MyProject.Forms.Form1.branch;
								creditNoteGetPro.isfiscal = 1;
								creditNoteGetPro.ShowDialog(this);
								creditNoteGetPro.Dispose();
							}
							else
							{
								SalesInvoicePortraitCN salesInvoicePortraitCN = new SalesInvoicePortraitCN();
								salesInvoicePortraitCN.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
								salesInvoicePortraitCN.revmax_sign = "";
								salesInvoicePortraitCN.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
								salesInvoicePortraitCN.reprint = 1;
								salesInvoicePortraitCN.branch = MyProject.Forms.Form1.branch;
								bool flag5 = MyProject.Forms.Form1.FiscalRevmax == 1;
								if (flag5)
								{
									salesInvoicePortraitCN.isfiscal = 1;
								}
								salesInvoicePortraitCN.ShowDialog(this);
								salesInvoicePortraitCN.Dispose();
							}
						}
						else
						{
							bool flag6 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "print", false) == 0;
							if (flag6)
							{
								SalesInvoicePortraitCN salesInvoicePortraitCN2 = new SalesInvoicePortraitCN();
								salesInvoicePortraitCN2.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
								salesInvoicePortraitCN2.revmax_sign = "";
								salesInvoicePortraitCN2.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
								salesInvoicePortraitCN2.reprint = 0;
								salesInvoicePortraitCN2.branch = MyProject.Forms.Form1.branch;
								salesInvoicePortraitCN2.isdebitorder = 1;
								salesInvoicePortraitCN2.ShowDialog(this);
								salesInvoicePortraitCN2.Dispose();
							}
							else
							{
								bool flag7 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "RevmaxRetry", false) == 0;
								if (flag7)
								{
									MessageBox.Show("Work in progress.");
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occured on Invoice Grid. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x0035FCAC File Offset: 0x0035DEAC
		private void PrintReceipt(int invnumber, DataTable invDetails, DataTable payDetails, DataTable customerDetails, bool IsCancelledREceipt, bool isdebitnote)
		{
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			IEnumerable<string> enumerable = invDetails.AsEnumerable().Select<DataRow, string>((ViewCancelledSales._Closure$__.$I99-0 == null) ? (ViewCancelledSales._Closure$__.$I99-0 = (DataRow row) => row.Field<string>("DigSig")) : ViewCancelledSales._Closure$__.$I99-0).Distinct<string>();
			string text = enumerable.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable2 = invDetails.AsEnumerable().Select<DataRow, string>((ViewCancelledSales._Closure$__.$I99-1 == null) ? (ViewCancelledSales._Closure$__.$I99-1 = (DataRow row) => row.Field<string>("Invoice_Number_Display")) : ViewCancelledSales._Closure$__.$I99-1).Distinct<string>();
			string text2 = enumerable2.ElementAtOrDefault<string>(0);
			IEnumerable<decimal> enumerable3 = invDetails.AsEnumerable().Select<DataRow, decimal>((ViewCancelledSales._Closure$__.$I99-2 == null) ? (ViewCancelledSales._Closure$__.$I99-2 = (DataRow row) => row.Field<decimal>("invdiscount")) : ViewCancelledSales._Closure$__.$I99-2).Distinct<decimal>();
			decimal num = enumerable3.ElementAtOrDefault<decimal>(0);
			IEnumerable<decimal> enumerable4 = invDetails.AsEnumerable().Select<DataRow, decimal>((ViewCancelledSales._Closure$__.$I99-3 == null) ? (ViewCancelledSales._Closure$__.$I99-3 = (DataRow row) => row.Field<decimal>("therate")) : ViewCancelledSales._Closure$__.$I99-3).Distinct<decimal>();
			decimal num2 = enumerable4.ElementAtOrDefault<decimal>(0);
			IEnumerable<string> enumerable5 = invDetails.AsEnumerable().Select<DataRow, string>((ViewCancelledSales._Closure$__.$I99-4 == null) ? (ViewCancelledSales._Closure$__.$I99-4 = (DataRow row) => row.Field<string>("Ref")) : ViewCancelledSales._Closure$__.$I99-4).Distinct<string>();
			string text3 = enumerable5.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable6 = invDetails.AsEnumerable().Select<DataRow, string>((ViewCancelledSales._Closure$__.$I99-5 == null) ? (ViewCancelledSales._Closure$__.$I99-5 = (DataRow row) => row.Field<string>("Done_By")) : ViewCancelledSales._Closure$__.$I99-5).Distinct<string>();
			string text4 = enumerable6.ElementAtOrDefault<string>(0);
			IEnumerable<int> enumerable7 = invDetails.AsEnumerable().Select<DataRow, int>((ViewCancelledSales._Closure$__.$I99-6 == null) ? (ViewCancelledSales._Closure$__.$I99-6 = (DataRow row) => row.Field<int>("paymentmethod")) : ViewCancelledSales._Closure$__.$I99-6).Distinct<int>();
			int num3 = enumerable7.ElementAtOrDefault<int>(0);
			bool flag = num3 == 10;
			string text5;
			if (flag)
			{
				text5 = "True";
			}
			else
			{
				text5 = "False";
			}
			this.datCustomerDetails = customerDetails;
			IEnumerable<string> enumerable8 = this.datCustomerDetails.AsEnumerable().Select<DataRow, string>((ViewCancelledSales._Closure$__.$I99-7 == null) ? (ViewCancelledSales._Closure$__.$I99-7 = (DataRow row) => row.Field<string>("Address")) : ViewCancelledSales._Closure$__.$I99-7).Distinct<string>();
			string text6 = enumerable8.ElementAtOrDefault<string>(0);
			decimal num4 = invDetails.AsEnumerable().Sum<DataRow>((ViewCancelledSales._Closure$__.$I99-8 == null) ? (ViewCancelledSales._Closure$__.$I99-8 = (DataRow row) => row.Field<decimal>("Tax")) : ViewCancelledSales._Closure$__.$I99-8);
			decimal num5 = invDetails.AsEnumerable().Sum<DataRow>((ViewCancelledSales._Closure$__.$I99-9 == null) ? (ViewCancelledSales._Closure$__.$I99-9 = (DataRow row) => row.Field<decimal>("Sub_Total")) : ViewCancelledSales._Closure$__.$I99-9);
			num5 = decimal.Add(num5, num4);
			this.PrintHeader(text4, IsCancelledREceipt, isdebitnote);
			this.ItemsToBePrinted(invnumber, text5, text3, text6, IsCancelledREceipt, num2, num, text2, isdebitnote, IsCancelledREceipt);
			this.PrintFooter(num4.ToString(), text5, num5, num, "", this.qrveri_code, this.qrveri_link);
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				bool flag2 = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
				if (flag2)
				{
					this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
				}
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x00360048 File Offset: 0x0035E248
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			float num = 1f;
			float num2 = 1f;
			float num3 = 1f;
			Font font = new Font("Times New Roman", (float)MyProject.Forms.Form1.ReceiptFontSize, FontStyle.Bold);
			PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			checked
			{
				int num8 = (int)Math.Round(Math.Round((double)num4 / 1.0));
				Rectangle rectangle = new Rectangle(num6, num7, num5, num4);
				Rectangle rectangle2 = default(Rectangle);
				rectangle2 = e.PageBounds;
				StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
				int num9 = (int)Math.Round((double)((float)e.MarginBounds.Height / font.GetHeight(e.Graphics)));
				int i = 0;
				string text = null;
				while (i < num9)
				{
					text = this.stringToRead.ReadLine();
					bool flag = text == null;
					if (flag)
					{
						break;
					}
					num = unchecked(num3 + (float)i * font.GetHeight(e.Graphics));
					e.Graphics.DrawString(text, font, Brushes.Black, num2, num, new StringFormat());
					i++;
				}
				bool flag2 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
				if (flag2)
				{
					try
					{
						BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
						SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, Conversions.ToString(this.invnum), 20);
						e.Graphics.DrawImage(symbologyTestCase.BarcodeImage, new Point(45, 5));
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed to print barcode on receipt. Error: " + ex.Message);
					}
				}
				bool flag3 = (Operators.CompareString(text, "", false) == 0) | Information.IsNothing(text);
				if (flag3)
				{
					Graphics graphics = e.Graphics;
					bool flag4 = this.PicQRCode.Image != null;
					if (flag4)
					{
						this.PicQRCode.Image.Dispose();
					}
					bool flag5 = this.QRCodeVariable != null;
					if (flag5)
					{
						this.PicQRCode.Image = this.QRCodeVariable;
						graphics.DrawImage(this.PicQRCode.Image, num2, num, 100f, 100f);
					}
					e.HasMorePages = false;
				}
				else
				{
					e.HasMorePages = true;
				}
			}
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x003602A8 File Offset: 0x0035E4A8
		public void PrintHeader(string tellername, bool iscreditnote, bool isdebitnote)
		{
			int num = 80;
			this.TextToPrint = "";
			string text = "";
			ref string ptr;
			if (iscreditnote)
			{
				text = "CREDIT NOTE";
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
			if (isdebitnote)
			{
				text = "DEBIT NOTE";
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
			bool flag = !isdebitnote & !iscreditnote;
			if (flag)
			{
				text = "FISCAL TAX INVOICE";
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
			}
			bool flag2 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
			if (flag2)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = string.Concat(new string[]
				{
					ptr,
					this.TextToPrint,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine,
					Environment.NewLine
				});
			}
			text = this.pf.StringPadCentre(text, num);
			text = this.coname;
			text = this.pf.StringPadCentre(text, num);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text + Environment.NewLine;
			bool flag3 = Operators.CompareString(this.cobpnum, "", false) != 0;
			if (flag3)
			{
				text = this.bpnum_name + " " + this.cobpnum;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			bool flag4 = Operators.CompareString(this.coVATNum, "", false) != 0;
			if (flag4)
			{
				text = this.vatnum_name + " " + this.coVATNum;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
			text = this.coadd;
			int length = text.Length;
			bool flag5 = length > 49;
			checked
			{
				if (flag5)
				{
					string text2 = text.Substring(0, 50);
					string text3 = text.Substring(50, length - 50);
					string text4 = new string(' ', (int)Math.Round(Math.Round((double)(50 - text2.Length) / 2.0)));
					text2 = this.pf.StringPadCentre(text2, num);
					text3 = this.pf.StringPadCentre(text3, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text2 + Environment.NewLine;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + Environment.NewLine;
				}
				else
				{
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag6 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag6)
				{
					text = "Email: " + this.coemail;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag7 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag7)
				{
					text = this.cotel;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag8 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag8)
				{
					text = this.cotel2 + "  " + this.cotel3;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine + Environment.NewLine;
				text = "Teller: " + tellername;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x00360738 File Offset: 0x0035E938
		public void ItemsToBePrinted(int invnumber, string saletype, string customername, string customeraddress, bool IsCancelSale, decimal invrate, decimal invdisc, string invoicenum_display, bool is_debitnote, bool is_cancelledinv)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			if (IsCancelSale)
			{
				sqlCommand.CommandText = "SalesCancelledForPeriodByInvoiceDetails";
			}
			else
			{
				sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			}
			sqlCommand.Parameters.AddWithValue("invoicenum", invnumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataRow["ref"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			bool flag = customerDetails.Rows.Count > 0;
			DataRow dataRow2;
			if (flag)
			{
				dataRow2 = customerDetails.Rows[0];
			}
			this.ProdtDiscTotal = 0m;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			bool flag2 = this.isReprint == 1;
			if (flag2)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "RE-PRINT" + Environment.NewLine;
			}
			else if (is_cancelledinv)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Credit Note Number:" + dataRow["CreditNoteNum"].ToString() + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = Conversions.ToString(Operators.ConcatenateObject(ptr, Operators.ConcatenateObject(Operators.ConcatenateObject("Comments: ", dataRow["CreditNoteComment"]), Environment.NewLine)));
			}
			else if (is_debitnote)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "Debit Note Number:" + dataRow["DebitNoteNum"].ToString() + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = Conversions.ToString(Operators.ConcatenateObject(ptr, Operators.ConcatenateObject(Operators.ConcatenateObject("Comments: ", dataRow["DebitNoteComment"]), Environment.NewLine)));
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Number: " + Conversions.ToString(invnumber);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			string text = Conversions.ToString(dataRow["trantime"]);
			string text2 = Conversions.ToString(dataRow["Sale_Date"]);
			string text3 = "yyyyMMdd";
			DateTime dateTime = DateTime.ParseExact(text2.ToString(), text3, CultureInfo.InvariantCulture);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "Invoice Date: " + dateTime.ToShortDateString() + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = string.Concat(new string[]
			{
				ptr,
				"Invoice Time: ",
				text,
				Environment.NewLine,
				Environment.NewLine
			});
			string text4 = dataRow["ref"].ToString();
			bool flag3 = (Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0) & (customerDetails.Rows.Count > 0);
			string text5;
			if (flag3)
			{
				text5 = Environment.NewLine + "Customer: " + dataRow2["CustomerName"].ToString();
				bool flag4 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
				if (flag4)
				{
					text5 = text5 + Environment.NewLine + "Address: " + dataRow2["Address"].ToString();
				}
				bool flag5 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
				if (flag5)
				{
					text5 = text5 + Environment.NewLine + "Phone #: " + dataRow2["Mobile"].ToString();
				}
				bool flag6 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
				if (flag6)
				{
					text5 = string.Concat(new string[]
					{
						text5,
						Environment.NewLine,
						this.bpnum_name,
						" ",
						dataRow2["BPNumber"].ToString()
					});
				}
				bool flag7 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
				if (flag7)
				{
					text5 = string.Concat(new string[]
					{
						text5,
						Environment.NewLine,
						this.vatnum_name,
						" ",
						dataRow2["VATNumber"].ToString()
					});
				}
				text5 = text5 + Environment.NewLine + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text5;
			}
			string text6 = Conversions.ToString(Operators.ConcatenateObject(dataRow["PaymentMethodDesc"], Environment.NewLine));
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "HS Code : Description " + text6;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + this.LINE;
			decimal num2 = 0m;
			string text7 = "Qty";
			string text8 = "UnitPrice";
			string text9 = "VAT";
			string text10 = "Amount(Incl)";
			text5 = string.Concat(new string[]
			{
				Environment.NewLine,
				text7.PadLeft(this.qty_spacing, ' '),
				text8.PadLeft(this.unitprice_spacing, ' '),
				text9.PadLeft(this.tax_spacing, ' '),
				text10.PadLeft(this.total_spacing, ' ')
			});
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text5 + Environment.NewLine;
			bool flag8 = num > 0;
			checked
			{
				if (flag8)
				{
					int num3 = 0;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow3 = (DataRow)obj;
							num3++;
							bool flag9 = decimal.Compare(Conversions.ToDecimal(dataRow3["Unit_Selling_Price"]), 0m) != 0;
							if (flag9)
							{
								string text11 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["HSCode"], " - "), dataRow3["Description"]));
								string text12 = Conversions.ToString(dataRow3["UOM"]);
								bool flag10 = Operators.CompareString(text12, "EA", false) == 0;
								if (flag10)
								{
									object obj2 = null;
									Type typeFromHandle = typeof(Math);
									string text13 = "Round";
									DataRow dataRow4;
									object[] array2;
									object[] array = (array2 = new object[]
									{
										(dataRow4 = dataRow3)["Quantity"],
										0
									});
									string[] array3 = null;
									Type[] array4 = null;
									bool[] array5 = new bool[2];
									array5[0] = true;
									bool[] array6 = array5;
									object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text13, array, array3, array4, array5);
									if (array6[0])
									{
										dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
									}
									num2 = Conversions.ToDecimal(obj3);
								}
								else
								{
									object obj4 = null;
									Type typeFromHandle2 = typeof(Math);
									string text14 = "Round";
									DataRow dataRow4;
									object[] array2;
									object[] array7 = (array2 = new object[]
									{
										(dataRow4 = dataRow3)["Quantity"],
										2
									});
									string[] array8 = null;
									Type[] array9 = null;
									bool[] array10 = new bool[2];
									array10[0] = true;
									bool[] array6 = array10;
									object obj3 = NewLateBinding.LateGet(obj4, typeFromHandle2, text14, array7, array8, array9, array10);
									if (array6[0])
									{
										dataRow4["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
									}
									num2 = Conversions.ToDecimal(obj3);
								}
								bool flag11 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
								double num4;
								if (flag11)
								{
									num4 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
								}
								else
								{
									num4 = Conversions.ToDouble(dataRow3["Unit_Selling_Price"]);
								}
								double num5 = Conversions.ToDouble(dataRow3["Sub_Total"]);
								string text15 = Conversions.ToString(dataRow3["HSCode"]);
								int num6 = (int)Math.Round(Conversion.Val(text11.Length));
								bool flag12 = num6 >= 51;
								if (flag12)
								{
									text11 = text11.Substring(0, 50);
								}
								int length = text11.Length;
								bool flag13 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag13)
								{
									DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow3["Product_Code"].ToString(), this._cnn);
									DataRow dataRow5 = productDetailsByBarCode.Rows[0];
									decimal num7 = Conversions.ToDecimal(dataRow5["TaxRate"]);
									int num8 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])));
									bool flag14 = decimal.Compare(num7, 0m) > 0;
									if (flag14)
									{
										text11 = "T: " + text11;
									}
									else
									{
										bool flag15 = num8 == 1;
										if (flag15)
										{
											text11 = "E: " + text11;
										}
										else
										{
											text11 = "Z: " + text11;
										}
									}
								}
								decimal num9 = 0m;
								bool flag16 = dataRow3["DiscountAmt"].ToString().Length > 0;
								if (flag16)
								{
									bool flag17 = Operators.CompareString(dataRow3["DiscountAmt"].ToString(), "0.00", false) == 0;
									if (!flag17)
									{
										this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow3["DiscountAmt"], dataRow3["Quantity"]));
										text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow3["DiscountAmt"]), Environment.NewLine));
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5;
									}
								}
								bool flag18 = dataRow3["Comments"].ToString().Length > 50;
								if (flag18)
								{
									text5 = dataRow3["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
									text5 = text5 + dataRow3["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text5;
								}
								else
								{
									bool flag19 = dataRow3["Comments"].ToString().Length > 0;
									if (flag19)
									{
										bool flag20 = Operators.CompareString(dataRow3["comments"].ToString(), "", false) == 0;
										if (!flag20)
										{
											text5 = Conversions.ToString(Operators.ConcatenateObject(dataRow3["Comments"], Environment.NewLine));
											ptr = ref this.TextToPrint;
											this.TextToPrint = ptr + text5;
										}
									}
								}
								decimal num10 = new decimal(Math.Round(num4, 2, MidpointRounding.AwayFromZero));
								num9 = Conversions.ToDecimal(Operators.AddObject(unchecked(num4 * Convert.ToDouble(num2)), dataRow3["Tax"]));
								string text16 = Strings.Format(num10, "N2");
								string text17 = Strings.Format(num9, "N2");
								bool flag21 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 1, false);
								string text18;
								if (flag21)
								{
									text18 = Strings.Format(0.0, "N2");
								}
								else
								{
									text18 = Strings.Format(RuntimeHelpers.GetObjectValue(dataRow3["Tax"]), "N2");
								}
								string text19 = num2.ToString();
								text5 = text11 + Environment.NewLine;
								text5 = string.Concat(new string[]
								{
									text5,
									text19.ToString().PadLeft(this.qty_spacing, ' '),
									text16.PadLeft(this.unitprice_spacing, ' '),
									text18.PadLeft(this.tax_spacing, ' '),
									text17.PadLeft(this.total_spacing, ' ')
								});
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text5 + Environment.NewLine;
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
				}
			}
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x00361448 File Offset: 0x0035F648
		private void PrintFooter(string tax, string saletype, decimal subtotal, decimal discamt, string RevmaxDigital_Signature, string qrverificationcode, string qrverificationlink)
		{
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			int num = 0;
			int num2 = num;
			checked
			{
				string text = new string(' ', Convert.ToInt32(Math.Round(new decimal(26 - num2))));
				bool flag = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				string text3;
				if (flag)
				{
					decimal num3 = Convert.ToDecimal(subtotal);
					string text2 = Math.Round(num3, 2, MidpointRounding.AwayFromZero).ToString();
					text3 = string.Format("{0,20}", "Inv. Subtotal: " + text2.PadLeft(36 - text2.Length, ' '));
				}
				else
				{
					string text4 = Math.Round(subtotal, 2, MidpointRounding.AwayFromZero).ToString();
					text3 = string.Format("{0,20}", "Inv. Subtotal: " + text4.PadLeft(36 - text4.Length, ' '));
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + text3 + Environment.NewLine;
				string text5 = Math.Round(Conversion.Val(tax), 2, MidpointRounding.AwayFromZero).ToString();
				text3 = string.Format("{0,20}", "Total VAT: " + text5.PadLeft(40 - text5.Length, ' '));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + text3 + Environment.NewLine;
				string text6 = Math.Round(discamt, 2, MidpointRounding.AwayFromZero).ToString();
				text3 = string.Format("{0,20}", "Inv. Discount: " + text6.PadLeft(36 - text6.Length, ' '));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + text3 + Environment.NewLine;
				string text7 = Math.Round(decimal.Subtract(subtotal, discamt), 2, MidpointRounding.AwayFromZero).ToString();
				text3 = string.Format("{0,20}", "Invoice Total: " + text7.PadLeft(36 - text7.Length, ' '));
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + text3 + Environment.NewLine;
				bool flag2 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
				if (flag2)
				{
					bool flag3 = Conversions.ToBoolean(saletype);
					string text8;
					if (flag3)
					{
						text8 = "Account";
					}
					else
					{
						text8 = "COD";
					}
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + Environment.NewLine;
					text3 = "Payment Method:" + text8;
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + Environment.NewLine;
					bool flag4 = Operators.CompareString(text8, "COD", false) == 0;
					if (flag4)
					{
						try
						{
							foreach (object obj in this.datPayDetails.Rows)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								string text9 = NewLateBinding.LateIndexGet(objectValue, new object[] { "PaymentMethodDesc" }, null).ToString();
								string text10 = ": ";
								object obj2 = null;
								Type typeFromHandle = typeof(Math);
								string text11 = "Round";
								object[] array = new object[3];
								int num4 = 0;
								object obj3 = objectValue;
								object obj4 = obj3;
								object[] array2 = new object[1];
								object obj5 = (array2[0] = "AmountPaid");
								array[num4] = NewLateBinding.LateIndexGet(obj4, array2, null);
								array[1] = 2;
								array[2] = MidpointRounding.AwayFromZero;
								object[] array3 = array;
								string[] array4 = null;
								Type[] array5 = null;
								bool[] array6 = new bool[3];
								array6[0] = true;
								bool[] array7 = array6;
								object obj6 = NewLateBinding.LateGet(obj2, typeFromHandle, text11, array, array4, array5, array6);
								if (array7[0])
								{
									NewLateBinding.LateIndexSetComplex(obj3, new object[]
									{
										obj5,
										array3[0]
									}, null, true, false);
								}
								text3 = text9 + text10 + obj6.ToString();
								ptr = ref this.TextToPrint;
								this.TextToPrint = ptr + text3 + Environment.NewLine;
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
						ptr = ref this.TextToPrint;
						this.TextToPrint = ptr + Environment.NewLine;
					}
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text3 = this.footnote;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				bool flag5 = (MyProject.Forms.Form1.PrintFiscal == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1) & (MyProject.Forms.Form1.PrintReceipt == 1);
				if (flag5)
				{
					text3 = string.Concat(new string[]
					{
						"Verification Code:",
						Environment.NewLine,
						qrverificationcode,
						Environment.NewLine,
						"You can manually verify this receipt at:",
						Environment.NewLine,
						qrverificationlink
					});
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text3 + Environment.NewLine + Environment.NewLine;
				}
			}
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x0036193C File Offset: 0x0035FB3C
		private void ProcessRevmaxCreditNote(int invnum, int coid, string branch, DataTable cancelledprodtsDT, DataTable customerdet)
		{
			try
			{
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ProductCode", typeof(string));
				dataTable.Columns.Add("ProductDesc", typeof(string));
				dataTable.Columns.Add("Qty", typeof(decimal));
				dataTable.Columns.Add("SellingPrice", typeof(decimal));
				dataTable.Columns.Add("Total", typeof(decimal));
				dataTable.Columns.Add("Tax", typeof(decimal));
				dataTable.Columns.Add("Taxr", typeof(decimal));
				decimal num = 0m;
				decimal num2 = 0m;
				string text = "";
				decimal num3 = 0m;
				int num4 = 0;
				string text2 = "";
				string text3 = "";
				try
				{
					foreach (object obj in cancelledprodtsDT.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["CreditNoteComment"])), "", RuntimeHelpers.GetObjectValue(dataRow["CreditNoteComment"])));
						num4 = Conversions.ToInteger(dataRow["CreditNoteNum"]);
						object obj2 = null;
						Type typeFromHandle = typeof(Math);
						string text4 = "Round";
						DataRow dataRow2;
						object[] array2;
						object[] array = (array2 = new object[]
						{
							(dataRow2 = dataRow)["therate"],
							2
						});
						string[] array3 = null;
						Type[] array4 = null;
						bool[] array5 = new bool[2];
						array5[0] = true;
						bool[] array6 = array5;
						object obj3 = NewLateBinding.LateGet(obj2, typeFromHandle, text4, array, array3, array4, array5);
						if (array6[0])
						{
							dataRow2["therate"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
						}
						num3 = Conversions.ToDecimal(obj3);
						text = Conversions.ToString(dataRow["Currency"]);
						num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow["Tax"]));
						num = Conversions.ToDecimal(Operators.AddObject(Operators.AddObject(num, dataRow["Sub_Total"]), dataRow["Tax"]));
						decimal num5 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.DivideObject(dataRow["taxrate"], 100),
							2
						}, null, null, null));
						DataRowCollection rows = dataTable.Rows;
						object[] array7 = new object[7];
						array7[0] = this.pf.GetRevmax8CharCode(dataRow["Product_Code"].ToString());
						array7[1] = dataRow["Desc"];
						array7[2] = dataRow["Qty"];
						array7[3] = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(dataRow["UnitPrice"], Operators.DivideObject(dataRow["Tax"], dataRow["Qty"])),
							3,
							MidpointRounding.AwayFromZero
						}, null, null, null);
						array7[4] = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(dataRow["Sub_Total"], dataRow["Tax"]),
							2,
							MidpointRounding.AwayFromZero
						}, null, null, null);
						int num6 = 5;
						object obj4 = null;
						Type typeFromHandle2 = typeof(Math);
						string text5 = "Round";
						object[] array8 = (array2 = new object[]
						{
							(dataRow2 = dataRow)["Tax"],
							2,
							MidpointRounding.AwayFromZero
						});
						string[] array9 = null;
						Type[] array10 = null;
						bool[] array11 = new bool[3];
						array11[0] = true;
						array6 = array11;
						obj3 = NewLateBinding.LateGet(obj4, typeFromHandle2, text5, array8, array9, array10, array11);
						if (array6[0])
						{
							dataRow2["Tax"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
						}
						array7[num6] = obj3;
						array7[6] = num5;
						rows.Add(array7);
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
				string text6 = "";
				string text7 = "";
				string text8 = "";
				string text9 = "";
				string text10 = "";
				bool flag = customerdet.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow3 = customerdet.Rows[0];
					text6 = Conversions.ToString(dataRow3["CustomerName"]);
					text7 = Conversions.ToString(dataRow3["VATNumber"]);
					text8 = Conversions.ToString(dataRow3["Address"]);
					text9 = Conversions.ToString(dataRow3["Mobile"]);
					text10 = Conversions.ToString(dataRow3["BPNumber"]);
				}
				string text11 = this.pf2.BuildItemsXML(dataTable);
				string text12 = this.pf2.BuildCurrencyXML(text, Math.Round(num, 2, MidpointRounding.AwayFromZero), num3);
				bool flag2 = MyProject.Forms.Form1.RevmaxTest == 1;
				if (flag2)
				{
					MessageBox.Show(text11);
					MessageBox.Show(text12);
					MessageBox.Show("Invoice Number: " + invnum.ToString() + ", tax inv number: " + text3.ToString());
				}
				string text13 = MyProject.Forms.Form1.myrevmax.TransactM(text, MyProject.Forms.Form1.branch, num4.ToString(), text6, text7, text8, text9, text10, Math.Round(num, 2).ToString(), Math.Round(num2, 2).ToString(), "02", text2, invnum.ToString(), text11, text12);
				JObject jobject = JObject.Parse(text13);
				string text14 = jobject["Message"].ToObject<string>();
				bool flag3 = MyProject.Forms.Form1.RevmaxTest == 1;
				if (flag3)
				{
					MessageBox.Show(text14);
				}
				bool flag4 = text14.Contains("Success");
				if (!flag4)
				{
					MessageBox.Show("Sale cancelled. Fiscalisation Error. Detail: " + text14);
				}
				Bitmap qrcodeImageFromRevmaxJSON = this.pf2.GetQRCodeImageFromRevmaxJSON(text13);
				this.QRCodeVariable = qrcodeImageFromRevmaxJSON;
				this.PicQRCode.Image = this.QRCodeVariable;
				this.qrveri_code = jobject["VerificationCode"].ToObject<string>();
				this.qrveri_link = jobject["VerificationLink"].ToObject<string>();
				string text15 = (string)jobject["Data"]["receipt"]["receiptGlobalNo"];
				this.SaveDigSigCreditNote(qrcodeImageFromRevmaxJSON, invnum, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this.qrveri_code, this.qrveri_link, text15);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing revmax credit note. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x00362080 File Offset: 0x00360280
		private void SaveDigSigCreditNote(Bitmap digsig, int invnum, string branch, int coid, string veri_code, string veri_link, string tax_inv)
		{
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				digsig.Save(memoryStream, ImageFormat.Bmp);
				array = memoryStream.ToArray();
			}
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SaveQRCodeCredit";
			sqlCommand.Parameters.AddWithValue("qrcode", array);
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("verificationlink", veri_link);
			sqlCommand.Parameters.AddWithValue("verificationcode", veri_code);
			sqlCommand.Parameters.AddWithValue("tax_invnumCR", tax_inv);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04002942 RID: 10562
		private string _cnn;

		// Token: 0x04002943 RID: 10563
		private PublicFunctions pf;

		// Token: 0x04002944 RID: 10564
		private PublicFunctions2 pf2;

		// Token: 0x04002945 RID: 10565
		private string qrveri_code;

		// Token: 0x04002946 RID: 10566
		private string qrveri_link;

		// Token: 0x04002947 RID: 10567
		private Bitmap QRCodeVariable;

		// Token: 0x04002948 RID: 10568
		private StringReader stringToRead;

		// Token: 0x04002949 RID: 10569
		private int invnum;

		// Token: 0x0400294A RID: 10570
		private string TextToPrint;

		// Token: 0x0400294B RID: 10571
		private DataTable datCustomerDetails;

		// Token: 0x0400294C RID: 10572
		private string coname;

		// Token: 0x0400294D RID: 10573
		private string coadd;

		// Token: 0x0400294E RID: 10574
		private string cotel;

		// Token: 0x0400294F RID: 10575
		private string coemail;

		// Token: 0x04002950 RID: 10576
		private string cobpnum;

		// Token: 0x04002951 RID: 10577
		private string cotel2;

		// Token: 0x04002952 RID: 10578
		private string cotel3;

		// Token: 0x04002953 RID: 10579
		private string coVATNum;

		// Token: 0x04002954 RID: 10580
		private string bpnum_name;

		// Token: 0x04002955 RID: 10581
		private string vatnum_name;

		// Token: 0x04002956 RID: 10582
		private decimal ProdtDiscTotal;

		// Token: 0x04002957 RID: 10583
		private int isReprint;

		// Token: 0x04002958 RID: 10584
		private string LINE;

		// Token: 0x04002959 RID: 10585
		private int qty_spacing;

		// Token: 0x0400295A RID: 10586
		private int desc_spacing;

		// Token: 0x0400295B RID: 10587
		private int unitprice_spacing;

		// Token: 0x0400295C RID: 10588
		private int total_spacing;

		// Token: 0x0400295D RID: 10589
		private int tax_spacing;

		// Token: 0x0400295E RID: 10590
		private DataTable datPayDetails;

		// Token: 0x0400295F RID: 10591
		private string footnote;
	}
}

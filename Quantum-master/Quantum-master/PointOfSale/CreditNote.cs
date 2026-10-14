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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BarcodeRender;
using EltradeFPAx;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using PointOfSale.My;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x02000031 RID: 49
	[DesignerGenerated]
	public partial class CreditNote : UserControl
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x0005CDFC File Offset: 0x0005AFFC
		public CreditNote()
		{
			base.Load += this.CreditNote_Load;
			base.Disposed += this.CreditNote_Disposed;
			this.TextToPrint = "";
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datInvDetails = new DataTable();
			this.datPayDetails = new DataTable();
			this.datCustomerDetails = new DataTable();
			this.pf = new PublicFunctions();
			this.isReprint = 0;
			this.website_og = "";
			this.website_comment = "";
			this.ProdtDiscTotal = 0m;
			this.LINE = "_________________________________________________________________________";
			this.pf2 = new PublicFunctions2();
			this.InitializeComponent();
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0005DE3A File Offset: 0x0005C03A
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0005DE44 File Offset: 0x0005C044
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0005DE4D File Offset: 0x0005C04D
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0005DE57 File Offset: 0x0005C057
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0005DE60 File Offset: 0x0005C060
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0005DE6A File Offset: 0x0005C06A
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0005DE73 File Offset: 0x0005C073
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0005DE7D File Offset: 0x0005C07D
		internal virtual DataGridView dgvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0005DE86 File Offset: 0x0005C086
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0005DE90 File Offset: 0x0005C090
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0005DED3 File Offset: 0x0005C0D3
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0005DEDD File Offset: 0x0005C0DD
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0005DEE6 File Offset: 0x0005C0E6
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0005DEF0 File Offset: 0x0005C0F0
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0005DF33 File Offset: 0x0005C133
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0005DF3D File Offset: 0x0005C13D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0005DF46 File Offset: 0x0005C146
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0005DF50 File Offset: 0x0005C150
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0005DF59 File Offset: 0x0005C159
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0005DF63 File Offset: 0x0005C163
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0005DF6C File Offset: 0x0005C16C
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0005DF76 File Offset: 0x0005C176
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0005DF7F File Offset: 0x0005C17F
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0005DF8C File Offset: 0x0005C18C
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0005DFCF File Offset: 0x0005C1CF
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0005DFDC File Offset: 0x0005C1DC
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0005E01F File Offset: 0x0005C21F
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0005E029 File Offset: 0x0005C229
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0005E032 File Offset: 0x0005C232
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0005E03C File Offset: 0x0005C23C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0005E045 File Offset: 0x0005C245
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0005E04F File Offset: 0x0005C24F
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0005E058 File Offset: 0x0005C258
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0005E064 File Offset: 0x0005C264
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0005E0A7 File Offset: 0x0005C2A7
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0005E0B4 File Offset: 0x0005C2B4
		internal virtual TextBox txtinvnum
		{
			[CompilerGenerated]
			get
			{
				return this._txtinvnum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtinvnum_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtinvnum_KeyDown);
				TextBox textBox = this._txtinvnum;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtinvnum = value;
				textBox = this._txtinvnum;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0005E112 File Offset: 0x0005C312
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0005E11C File Offset: 0x0005C31C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0005E125 File Offset: 0x0005C325
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0005E130 File Offset: 0x0005C330
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0005E173 File Offset: 0x0005C373
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0005E17D File Offset: 0x0005C37D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0005E186 File Offset: 0x0005C386
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0005E190 File Offset: 0x0005C390
		internal virtual PictureBox PicQRCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0005E199 File Offset: 0x0005C399
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0005E1A3 File Offset: 0x0005C3A3
		internal virtual PictureBox PictureBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		private void LoadSales()
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoice";
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTstart.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTend.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvoices.DataSource = dataTable;
				this.dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvInvoices.Columns["pending_approval"].Visible = false;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Details";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(5, dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Cancel Sale";
				dataGridViewButtonColumn2.Text = "Cancel";
				dataGridViewButtonColumn2.Name = "cancel";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(6, dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Reprint Invoice";
				dataGridViewButtonColumn3.Text = "Reprint Inv";
				dataGridViewButtonColumn3.Name = "reprint";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(7, dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Reprint 80mm Receipt";
				dataGridViewButtonColumn4.Text = "Reprint 80mm";
				dataGridViewButtonColumn4.Name = "reprint80";
				dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(8, dataGridViewButtonColumn4);
				DataGridViewButtonColumn dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn5.HeaderText = "Back-Date Inv";
				dataGridViewButtonColumn5.Text = "Back-Date";
				dataGridViewButtonColumn5.Name = "Back-Date";
				dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(9, dataGridViewButtonColumn5);
				DataGridViewButtonColumn dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn6.HeaderText = "Reprint D. Note";
				dataGridViewButtonColumn6.Text = "Reprint D. Note";
				dataGridViewButtonColumn6.Name = "Reprint DNote";
				dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(10, dataGridViewButtonColumn6);
				DataGridViewButtonColumn dataGridViewButtonColumn7 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn7.HeaderText = "Change Consultant";
				dataGridViewButtonColumn7.Text = "Change Consultant";
				dataGridViewButtonColumn7.Name = "Change Consultant";
				dataGridViewButtonColumn7.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(11, dataGridViewButtonColumn7);
				DataGridViewButtonColumn dataGridViewButtonColumn8 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn8.HeaderText = "Print Debit Note";
				dataGridViewButtonColumn8.Text = "Debit Note";
				dataGridViewButtonColumn8.Name = "Debit Note";
				dataGridViewButtonColumn8.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(12, dataGridViewButtonColumn8);
				DataGridViewButtonColumn dataGridViewButtonColumn9 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn9.HeaderText = "Retry REVMAX";
				dataGridViewButtonColumn9.Text = "Retry Fiscalisation";
				dataGridViewButtonColumn9.Name = "RevmaxRetry";
				dataGridViewButtonColumn9.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(13, dataGridViewButtonColumn9);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvInvoices.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["pending_approval"].Value, 1, false);
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Pink;
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
			else
			{
				MessageBox.Show("There are no sales for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvInvoices.DataSource = dataTable2;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0005E658 File Offset: 0x0005C858
		private void loadSalesbyInvNumber(int invoicenumber)
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumberEntered";
			sqlCommand.Parameters.AddWithValue("invoicenumber", invoicenumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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
				this.dgvInvoices.Columns.Insert(3, dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Cancel Sale";
				dataGridViewButtonColumn2.Text = "Cancel";
				dataGridViewButtonColumn2.Name = "cancel";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(4, dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Reprint Invoice";
				dataGridViewButtonColumn3.Text = "Reprint Inv";
				dataGridViewButtonColumn3.Name = "reprint";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(5, dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Reprint 80mm Receipt";
				dataGridViewButtonColumn4.Text = "Reprint 80mm";
				dataGridViewButtonColumn4.Name = "reprint80";
				dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(6, dataGridViewButtonColumn4);
				DataGridViewButtonColumn dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn5.HeaderText = "Back-Date Inv";
				dataGridViewButtonColumn5.Text = "Back-Date";
				dataGridViewButtonColumn5.Name = "Back-Date";
				dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(4, dataGridViewButtonColumn5);
				DataGridViewButtonColumn dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn6.HeaderText = "Reprint D. Note";
				dataGridViewButtonColumn6.Text = "Reprint D. Note";
				dataGridViewButtonColumn6.Name = "Reprint DNote";
				dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(7, dataGridViewButtonColumn6);
				DataGridViewButtonColumn dataGridViewButtonColumn7 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn7.HeaderText = "Print Debit Note";
				dataGridViewButtonColumn7.Text = "Debit Note";
				dataGridViewButtonColumn7.Name = "Debit Note";
				dataGridViewButtonColumn7.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(8, dataGridViewButtonColumn7);
				DataGridViewButtonColumn dataGridViewButtonColumn8 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn8.HeaderText = "Retry REVMAX";
				dataGridViewButtonColumn8.Text = "Retry Fiscalisation";
				dataGridViewButtonColumn8.Name = "RevmaxRetry";
				dataGridViewButtonColumn8.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Insert(13, dataGridViewButtonColumn8);
			}
			else
			{
				SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
				SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
				sqlCommand2.CommandType = CommandType.StoredProcedure;
				sqlCommand2.CommandText = "CheckIfInvCancelled";
				sqlCommand2.Parameters.AddWithValue("invoicenumber", invoicenumber);
				sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable2 = new DataTable();
				SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
				int num2 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num2 > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable2.Rows[0];
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					string text = DateTime.ParseExact(dataRow["trandate"].ToString(), "yyyyMMdd", invariantCulture).ToString();
					string text2 = DateTime.ParseExact(dataRow["DateCancelled"].ToString(), "yyyyMMdd", invariantCulture).ToString();
					MessageBox.Show("This invoice has been cancelled. Sale date: " + text.Substring(0, 10) + ", Date cancelled: " + text2.Substring(0, 10));
				}
				else
				{
					MessageBox.Show("Invoice not found.");
					DataTable dataTable3 = new DataTable();
					this.dgvInvoices.DataSource = dataTable3;
				}
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0005EADC File Offset: 0x0005CCDC
		private void LoadDetails(int inv)
		{
			this.GroupBox2.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetailsLite";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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

		// Token: 0x06000A11 RID: 2577 RVA: 0x0005EC08 File Offset: 0x0005CE08
		private void CancelSale(int inv, string customername, string comment)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CancelSale";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
			bool flag = MyProject.Forms.Form1.UseApprovals == 1;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("approval", 1);
				sqlCommand.Parameters.AddWithValue("comment", comment);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("approval", 0);
				sqlCommand.Parameters.AddWithValue("comment", comment);
			}
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
			DataTable cancelledProducts = this.pf.GetCancelledProducts(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text);
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, customername.ToString(), MyProject.Forms.Form1.coid, this.cboBranch.Text);
			this.ProcessRevmaxCreditNote(inv, MyProject.Forms.Form1.coid, this.cboBranch.Text, cancelledProducts, customerDetails);
			bool flag2 = MyProject.Forms.Form1.FiscalRevmax == 1;
			if (flag2)
			{
				this.ProcessRevmaxCreditNote(inv, MyProject.Forms.Form1.coid, this.cboBranch.Text, cancelledProducts, customerDetails);
			}
			bool flag3 = MyProject.Forms.Form1.UseApprovals == 1;
			if (!flag3)
			{
				bool flag4 = MyProject.Forms.Form1.PrintReceipt == 1;
				if (flag4)
				{
					DataTable additionalSettingsPrinters = this.pf.GetAdditionalSettingsPrinters(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.receipt_template);
					bool flag5 = additionalSettingsPrinters.Rows.Count > 0;
					if (flag5)
					{
						DataRow dataRow = additionalSettingsPrinters.Rows[0];
						this.desc_spacing = Conversions.ToInteger(dataRow["receipt_desc_spacing"]);
						this.qty_spacing = Conversions.ToInteger(dataRow["receipt_qty_spacing"]);
						this.unitprice_spacing = Conversions.ToInteger(dataRow["receipt_unitprice_spacing"]);
						this.total_spacing = Conversions.ToInteger(dataRow["receipt_total_spacing"]);
						this.tax_spacing = Conversions.ToInteger(dataRow["receipt_tax_spacing"]);
					}
					bool flag6 = MyProject.Forms.Form1.PrintFiscal == 0;
					if (flag6)
					{
						this.PrintReceipt(inv, cancelledProducts, this.pf.GetPayDetails(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text), customerDetails, true, false);
					}
					else
					{
						bool flag7 = MyProject.Forms.Form1.PrintFiscal == 1;
						if (flag7)
						{
							bool flag8 = MyProject.Forms.Form1.FiscalEltrade == 1;
							if (flag8)
							{
								DataTable cancelledProducts2 = this.pf.GetCancelledProducts(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text);
								DataTable payDetails = this.pf.GetPayDetails(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text);
								DataRow dataRow2 = payDetails.Rows[0];
								DataTable eltradeSetting = this.pf.getEltradeSetting(Conversions.ToInteger(dataRow2["PaymentMethodID"]), this._cnn);
								bool flag9 = eltradeSetting.Rows.Count > 0;
								if (flag9)
								{
									DataRow dataRow3 = eltradeSetting.Rows[0];
									MyProject.Forms.Form1.FiscalcomPortNum = Conversions.ToInteger(dataRow3["ComPort"]);
									MyProject.Forms.Form1.FiscalcomPortSpeed = Conversions.ToInteger(dataRow3["ComSpeed"]);
									EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
									string text = this.PrintEltradeInvoiceCancell(cancelledProducts2, this.pf.GetFiscalGroup(Conversions.ToInteger(dataRow2["PaymentMethodID"]), this._cnn), Conversions.ToString(dataRow2["PaymentMethodDesc"]), Conversions.ToDouble(dataRow2["AmountPaid"]), MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, this.pf.GetEltradeFiscalCountryID(Conversions.ToInteger(dataRow2["PaymentMethodID"]), this._cnn), 4, MyProject.Forms.Form1.username, this.invnum, "", "", MyProject.Forms.Form1.companyname, "", this.coadd, "MOL", "", eltradeFprn, this.pf.GetCustomerDetails(this._cnn, customername.ToString(), MyProject.Forms.Form1.coid, this.cboBranch.Text));
									bool flag10 = Operators.CompareString(text, "SUCCESS", false) != 0;
									if (flag10)
									{
										eltradeFprn.Close();
										MessageBox.Show("Cancellation Done in System but Fiscal Error. " + text);
									}
									else
									{
										eltradeFprn.Close();
										MessageBox.Show("Cancellation Done Successfully.");
									}
								}
								else
								{
									MessageBox.Show("Failed to get Eltrade Com Settings for payment method. ");
								}
							}
							else
							{
								bool flag11 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag11)
								{
									bool flag12 = MyProject.Forms.Form1.PrintToFile == 1;
									if (flag12)
									{
										PublicFunctions2 publicFunctions = new PublicFunctions2();
										this.PrintReceiptnutNOTPrint(inv, this.pf.GetCancelledProducts(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetPayDetails(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetCustomerDetails(this._cnn, customername.ToString(), MyProject.Forms.Form1.coid, this.cboBranch.Text), true, false);
										publicFunctions.PrintToFile(inv, MyProject.Forms.Form1.InterfacedFiscalSaveas, this.TextToPrint, "CR");
									}
									else
									{
										this.PrintReceipt(inv, cancelledProducts, this.pf.GetPayDetails(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text), customerDetails, true, false);
									}
								}
								else
								{
									bool flag13 = MyProject.Forms.Form1.FiscalRevmax == 1;
									if (flag13)
									{
										DataTable remaxQRDetails = this.pf2.GetRemaxQRDetails(inv, MyProject.Forms.Form1.coid, this.cboBranch.Text, 0, 1, this._cnn);
										bool flag14 = remaxQRDetails.Rows.Count > 0;
										if (flag14)
										{
											DataRow dataRow4 = remaxQRDetails.Rows[0];
											byte[] array = (byte[])dataRow4["QRCodeCredit"];
											MemoryStream memoryStream = new MemoryStream(array, false);
											Image image = Image.FromStream(memoryStream);
											this.QRCodeVariable = (Bitmap)image;
											this.qrveri_code = Conversions.ToString(dataRow4["QRCodeVerificationCodeCredit"]);
											this.qrveri_link = Conversions.ToString(dataRow4["QRVerificationLinkCredit"]);
										}
										this.PrintReceipt(inv, cancelledProducts, this.pf.GetPayDetails(inv, MyProject.Forms.Form1.Constring, this.cboBranch.Text), customerDetails, true, false);
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag15 = (MyProject.Forms.Form1.PrintInvoice == 1) & (MyProject.Forms.Form1.FiscalEltradeESD == 1);
					if (flag15)
					{
						SalesInvoicePortraitCN salesInvoicePortraitCN = new SalesInvoicePortraitCN();
						salesInvoicePortraitCN.invnum = inv;
						salesInvoicePortraitCN.revmax_sign = this.pf.GetDigSig(inv, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
						salesInvoicePortraitCN.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
						salesInvoicePortraitCN.reprint = 0;
						salesInvoicePortraitCN.branch = this.cboBranch.Text;
						salesInvoicePortraitCN.ShowDialog(this);
						salesInvoicePortraitCN.Dispose();
					}
					else
					{
						bool flag16 = MyProject.Forms.Form1.PrintInvoice == 1;
						if (flag16)
						{
							bool flag17 = MyProject.Forms.Form1.inv_template_GetPro == 1;
							if (flag17)
							{
								CreditNoteGetPro creditNoteGetPro = new CreditNoteGetPro();
								creditNoteGetPro.invnum = inv;
								creditNoteGetPro.isfiscal = 1;
								creditNoteGetPro.revmax_sign = "";
								creditNoteGetPro.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
								creditNoteGetPro.reprint = 0;
								creditNoteGetPro.branch = this.cboBranch.Text;
								creditNoteGetPro.ShowDialog(this);
								creditNoteGetPro.Dispose();
							}
							else
							{
								SalesInvoicePortraitCN salesInvoicePortraitCN2 = new SalesInvoicePortraitCN();
								salesInvoicePortraitCN2.invnum = inv;
								salesInvoicePortraitCN2.revmax_sign = "";
								salesInvoicePortraitCN2.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
								salesInvoicePortraitCN2.reprint = 0;
								salesInvoicePortraitCN2.branch = this.cboBranch.Text;
								bool flag18 = MyProject.Forms.Form1.FiscalRevmax == 1;
								if (flag18)
								{
									salesInvoicePortraitCN2.isfiscal = 1;
								}
								salesInvoicePortraitCN2.ShowDialog(this);
								salesInvoicePortraitCN2.Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0005F690 File Offset: 0x0005D890
		private DataTable createDTFromGrid(DataGridView dgv)
		{
			DataTable dataTable = new DataTable();
			try
			{
				foreach (object obj in dgv.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					dataTable.Columns.Add(dataGridViewColumn.Name);
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
			try
			{
				foreach (object obj2 in ((IEnumerable)dgv.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					DataRow dataRow = dataTable.NewRow();
					try
					{
						foreach (object obj3 in dataGridViewRow.Cells)
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
							dataRow[dataGridViewCell.ColumnIndex] = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
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
					dataTable.Rows.Add(dataRow);
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
			return dataTable;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0005F7E4 File Offset: 0x0005D9E4
		private string PrintEltradeInvoiceCancell(DataTable datproducts, int paymentmethodnumber, string paymentmethoddesc, double paymentamount, int comport, int comspeed, int receiptcurrencyID, int bontype, string cashiername, int invoicenumber, string customerTaxNumber, string customerVATNumber, string invcompany, string invcity, string invaddress, string invMOL, string invReceipient, EltradeFprn peltrade, DataTable customerDetails)
		{
			bool flag = customerDetails.Rows.Count > 0;
			string text;
			string text2;
			string text3;
			string text4;
			if (flag)
			{
				DataRow dataRow = customerDetails.Rows[0];
				text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["CustomerName"])), "", RuntimeHelpers.GetObjectValue(dataRow["CustomerName"])));
				text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["BPNumber"])));
				text3 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])), "", RuntimeHelpers.GetObjectValue(dataRow["VATNumber"])));
				text4 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Address"])), "", RuntimeHelpers.GetObjectValue(dataRow["Address"])));
			}
			else
			{
				text = "Cash";
				text2 = "";
				text3 = "";
				text4 = "";
			}
			bool flag2 = peltrade.Init(comport, comspeed, 0, 0, 0, "") == 0;
			string text5;
			if (flag2)
			{
				peltrade.CurrencyID = receiptcurrencyID;
				bool flag3 = peltrade.StartBon(bontype, 0, cashiername, Conversions.ToString(invoicenumber), text2, text3, invcompany, invcompany, text4, invMOL, text) == 0;
				if (flag3)
				{
					try
					{
						foreach (object obj in datproducts.Rows)
						{
							DataRow dataRow2 = (DataRow)obj;
							peltrade.PLUCurrencyID = receiptcurrencyID;
							bool flag4 = peltrade.AddPLU(Conversions.ToString(dataRow2["Product_Code"]), Conversions.ToString(dataRow2["Desc"]), Conversions.ToDouble(Operators.MultiplyObject(dataRow2["UnitPrice"], Operators.AddObject(1, Operators.DivideObject(dataRow2["taxrate"], 100)))), Conversions.ToDouble(dataRow2["Qty"]), this.GetVATGroup(Conversions.ToInteger(dataRow2["ProdtID"]))) == 0;
							if (!flag4)
							{
								return "Adding PLU error. Detail. " + peltrade.GetLastError(1);
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
					bool flag5 = peltrade.AddPayment(paymentmethodnumber, paymentmethoddesc, paymentamount, 1.0) == 0;
					if (flag5)
					{
						bool flag6 = peltrade.EndBon() == 0;
						if (flag6)
						{
							text5 = "SUCCESS";
						}
						else
						{
							text5 = "Error printing bon. Detail: " + peltrade.GetLastError(1);
						}
					}
					else
					{
						text5 = "Error adding payment. Detail: " + peltrade.GetLastError(1);
					}
				}
				else
				{
					text5 = "Start Bon error. Details: " + peltrade.GetLastError(1);
				}
			}
			else
			{
				text5 = "Fiscal Device initialisation Error. Detail: " + peltrade.GetLastError(1);
			}
			return text5;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0005FB08 File Offset: 0x0005DD08
		private void GetEtradePortSettings(int paymentmethodid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "getEltradePortSettings";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			MyProject.Forms.Form1.FiscalcomPortNum = Conversions.ToInteger(dataRow["ComPort"]);
			MyProject.Forms.Form1.FiscalcomPortSpeed = Conversions.ToInteger(dataRow["ComSpeed"]);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0005FBB8 File Offset: 0x0005DDB8
		private int GetVATGroup(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select TaxRate  from products where productid = " + productid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["TaxRate"], 0, false);
				if (flag2)
				{
					num2 = 2;
				}
				else
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 1;
			}
			return num2;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0005FC58 File Offset: 0x0005DE58
		private void GenerateDebitNote(int inv, string comment)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GenerateDebitNoteNumber";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("comment", comment);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0005FD30 File Offset: 0x0005DF30
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
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "cancel", false) == 0;
						if (flag3)
						{
							DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to cancel this selected sales invoice? " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString(), MsgBoxStyle.YesNo, null);
							bool flag4 = dialogResult == DialogResult.Yes;
							if (flag4)
							{
								bool flag5 = MyProject.Forms.Form1.IsSupervisor | MyProject.Forms.Form1.IsAdmin;
								if (flag5)
								{
									string text = "Enter the reason for cancellation";
									string text2 = "Sales Cancellation Reason";
									string text3 = Interaction.InputBox(text, text2, "", -1, -1);
									this.CancelSale(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Customer"].Value), text3);
									DataTable dataTable = new DataTable();
									this.dgvDetails.DataSource = dataTable;
									this.LoadSales();
									bool flag6 = MyProject.Forms.Form1.UseApprovals == 1;
									if (flag6)
									{
										MessageBox.Show("Invoice marked for cancellation pending approval.");
									}
									else
									{
										MessageBox.Show("Invoice cancelled.");
									}
								}
								else
								{
									ApprovalForm approvalForm = new ApprovalForm();
									approvalForm.lblHeader.Text = "Enter Admin/Supervisor credentials to cancel this sale.";
									approvalForm.ShowDialog();
									approvalForm.Dispose();
									bool flag7 = !MyProject.Forms.Form1.approved;
									if (flag7)
									{
										MessageBox.Show("You do not have permission to cancel a sale.");
									}
									else
									{
										DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to cancel this selected sales invoice? " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString(), MsgBoxStyle.YesNo, null);
										bool flag8 = dialogResult2 == DialogResult.Yes;
										if (flag8)
										{
											string text4 = "Enter the reason for cancellation";
											string text5 = "Sales Cancellation Reason";
											string text6 = Interaction.InputBox(text4, text5, "", -1, -1);
											this.CancelSale(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Customer"].Value), text6);
											DataTable dataTable2 = new DataTable();
											this.dgvDetails.DataSource = dataTable2;
											this.LoadSales();
											bool flag9 = MyProject.Forms.Form1.UseApprovals == 1;
											if (flag9)
											{
												MessageBox.Show("Invoice marked for cancellation pending approval.");
											}
											else
											{
												MessageBox.Show("Invoice cancelled.");
											}
										}
									}
								}
							}
						}
						else
						{
							bool flag10 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Debit Note", false) == 0;
							if (flag10)
							{
								DialogResult dialogResult3 = (DialogResult)Interaction.MsgBox("Are you sure you want to generate a debit note for this selected sales invoice? " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString(), MsgBoxStyle.YesNo, null);
								bool flag11 = dialogResult3 == DialogResult.Yes;
								if (flag11)
								{
									string text7 = "Enter the comment for Debit Order";
									string text8 = "Debit Order Comment";
									string text9 = Interaction.InputBox(text7, text8, "", -1, -1);
									this.GenerateDebitNote(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), text9);
									bool flag12 = MyProject.Forms.Form1.PrintReceipt == 1;
									if (flag12)
									{
										DataTable additionalSettingsPrinters = this.pf.GetAdditionalSettingsPrinters(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.receipt_template);
										bool flag13 = additionalSettingsPrinters.Rows.Count > 0;
										if (flag13)
										{
											DataRow dataRow = additionalSettingsPrinters.Rows[0];
											this.desc_spacing = Conversions.ToInteger(dataRow["receipt_desc_spacing"]);
											this.qty_spacing = Conversions.ToInteger(dataRow["receipt_qty_spacing"]);
											this.unitprice_spacing = Conversions.ToInteger(dataRow["receipt_unitprice_spacing"]);
											this.total_spacing = Conversions.ToInteger(dataRow["receipt_total_spacing"]);
											this.tax_spacing = Conversions.ToInteger(dataRow["receipt_tax_spacing"]);
										}
										this.PrintReceipt(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), this.pf.GetInvoiceDetails(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetPayDetails(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Customer"].Value), MyProject.Forms.Form1.coid, this.cboBranch.Text), false, true);
										MessageBox.Show("Debit note print job sent");
									}
									else
									{
										int num = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
										ViewDebitNote viewDebitNote = new ViewDebitNote();
										viewDebitNote.invnum = num;
										viewDebitNote.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
										viewDebitNote.reprint = 0;
										viewDebitNote.branch = this.cboBranch.Text;
										viewDebitNote.ShowDialog(this);
										viewDebitNote.Dispose();
									}
								}
							}
							else
							{
								bool flag14 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "reprint", false) == 0;
								if (flag14)
								{
									bool flag15 = Operators.ConditionalCompareObjectEqual(dataGridView.Rows[e.RowIndex].Cells["isbookingitem"].Value, 1, false);
									if (flag15)
									{
										SalesInvPortraitBooking salesInvPortraitBooking = new SalesInvPortraitBooking();
										salesInvPortraitBooking.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
										salesInvPortraitBooking.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
										salesInvPortraitBooking.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
										salesInvPortraitBooking.reprint = 1;
										salesInvPortraitBooking.ShowDialog(this);
										salesInvPortraitBooking.Dispose();
									}
									else
									{
										bool flag16 = MyProject.Forms.Form1.inv_template_normal == 1;
										if (flag16)
										{
											SalesInvoicePortrait salesInvoicePortrait = new SalesInvoicePortrait();
											salesInvoicePortrait.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
											salesInvoicePortrait.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
											salesInvoicePortrait.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
											salesInvoicePortrait.reprint = 1;
											salesInvoicePortrait.branch = this.cboBranch.Text;
											salesInvoicePortrait.hidevat = MyProject.Forms.Form1.hidevat;
											bool flag17 = MyProject.Forms.Form1.AllowInvDiscount == 1;
											if (flag17)
											{
												salesInvoicePortrait.showinvdisc = 1;
											}
											salesInvoicePortrait.ShowDialog(this);
											salesInvoicePortrait.Dispose();
										}
										else
										{
											bool flag18 = MyProject.Forms.Form1.inv_template_pharma == 1;
											if (flag18)
											{
												SalesInvoicePortraitPharma salesInvoicePortraitPharma = new SalesInvoicePortraitPharma();
												salesInvoicePortraitPharma.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
												salesInvoicePortraitPharma.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
												salesInvoicePortraitPharma.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
												salesInvoicePortraitPharma.reprint = 1;
												salesInvoicePortraitPharma.branch = this.cboBranch.Text;
												bool flag19 = MyProject.Forms.Form1.AllowInvDiscount == 1;
												if (flag19)
												{
													salesInvoicePortraitPharma.showinvdisc = 1;
												}
												salesInvoicePortraitPharma.ShowDialog(this);
												salesInvoicePortraitPharma.Dispose();
											}
											else
											{
												bool flag20 = MyProject.Forms.Form1.inv_template_incotex == 1;
												if (flag20)
												{
													SalesInvoicePortraitInco salesInvoicePortraitInco = new SalesInvoicePortraitInco();
													salesInvoicePortraitInco.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
													salesInvoicePortraitInco.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
													salesInvoicePortraitInco.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
													salesInvoicePortraitInco.reprint = 1;
													salesInvoicePortraitInco.branch = this.cboBranch.Text;
													bool flag21 = MyProject.Forms.Form1.AllowInvDiscount == 1;
													if (flag21)
													{
														salesInvoicePortraitInco.showinvdisc = 1;
													}
													salesInvoicePortraitInco.ShowDialog(this);
													salesInvoicePortraitInco.Dispose();
												}
												else
												{
													bool flag22 = MyProject.Forms.Form1.inv_template_revmax == 1;
													if (flag22)
													{
														SalesInvoiceRevmax salesInvoiceRevmax = new SalesInvoiceRevmax();
														salesInvoiceRevmax.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
														salesInvoiceRevmax.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
														salesInvoiceRevmax.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
														salesInvoiceRevmax.reprint = 1;
														salesInvoiceRevmax.branch = this.cboBranch.Text;
														bool flag23 = MyProject.Forms.Form1.AllowInvDiscount == 1;
														if (flag23)
														{
															salesInvoiceRevmax.showinvdisc = 1;
														}
														salesInvoiceRevmax.ShowDialog(this);
														salesInvoiceRevmax.Dispose();
													}
													else
													{
														bool flag24 = MyProject.Forms.Form1.inv_template_tongaat == 1;
														if (flag24)
														{
															SalesInvoicePortraitTongaat salesInvoicePortraitTongaat = new SalesInvoicePortraitTongaat();
															salesInvoicePortraitTongaat.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
															salesInvoicePortraitTongaat.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
															salesInvoicePortraitTongaat.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
															salesInvoicePortraitTongaat.reprint = 1;
															salesInvoicePortraitTongaat.branch = this.cboBranch.Text;
															bool flag25 = MyProject.Forms.Form1.AllowInvDiscount == 1;
															if (flag25)
															{
																salesInvoicePortraitTongaat.showinvdisc = 1;
															}
															salesInvoicePortraitTongaat.ShowDialog(this);
															salesInvoicePortraitTongaat.Dispose();
														}
														else
														{
															bool flag26 = MyProject.Forms.Form1.inv_template_lea == 1;
															if (flag26)
															{
																SalesInvoicePortraitLea salesInvoicePortraitLea = new SalesInvoicePortraitLea();
																salesInvoicePortraitLea.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																salesInvoicePortraitLea.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																salesInvoicePortraitLea.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																salesInvoicePortraitLea.reprint = 1;
																salesInvoicePortraitLea.branch = this.cboBranch.Text;
																bool flag27 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																if (flag27)
																{
																	salesInvoicePortraitLea.showinvdisc = 1;
																}
																salesInvoicePortraitLea.ShowDialog(this);
																salesInvoicePortraitLea.Dispose();
															}
															else
															{
																bool flag28 = MyProject.Forms.Form1.inv_template_FDMS == 1;
																if (flag28)
																{
																	SalesInvoicePortraitFDMS salesInvoicePortraitFDMS = new SalesInvoicePortraitFDMS();
																	salesInvoicePortraitFDMS.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																	salesInvoicePortraitFDMS.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																	salesInvoicePortraitFDMS.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																	salesInvoicePortraitFDMS.reprint = 1;
																	salesInvoicePortraitFDMS.branch = this.cboBranch.Text;
																	bool flag29 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																	if (flag29)
																	{
																		salesInvoicePortraitFDMS.showinvdisc = 1;
																	}
																	salesInvoicePortraitFDMS.ShowDialog(this);
																	salesInvoicePortraitFDMS.Dispose();
																}
																else
																{
																	bool flag30 = MyProject.Forms.Form1.inv_template_GetPro == 1;
																	if (flag30)
																	{
																		SalesInvoicePortraitGetpro salesInvoicePortraitGetpro = new SalesInvoicePortraitGetpro();
																		salesInvoicePortraitGetpro.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																		salesInvoicePortraitGetpro.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																		salesInvoicePortraitGetpro.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																		salesInvoicePortraitGetpro.reprint = 1;
																		salesInvoicePortraitGetpro.branch = this.cboBranch.Text;
																		bool flag31 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																		if (flag31)
																		{
																			salesInvoicePortraitGetpro.showinvdisc = 1;
																		}
																		salesInvoicePortraitGetpro.ShowDialog(this);
																		salesInvoicePortraitGetpro.Dispose();
																	}
																	else
																	{
																		bool flag32 = MyProject.Forms.Form1.inv_template_Binum == 1;
																		if (flag32)
																		{
																			SalesInvoicePortraitBinum salesInvoicePortraitBinum = new SalesInvoicePortraitBinum();
																			salesInvoicePortraitBinum.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																			salesInvoicePortraitBinum.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																			salesInvoicePortraitBinum.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																			salesInvoicePortraitBinum.reprint = 1;
																			salesInvoicePortraitBinum.branch = this.cboBranch.Text;
																			bool flag33 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																			if (flag33)
																			{
																				salesInvoicePortraitBinum.showinvdisc = 1;
																			}
																			salesInvoicePortraitBinum.ShowDialog(this);
																			salesInvoicePortraitBinum.Dispose();
																		}
																		else
																		{
																			bool flag34 = MyProject.Forms.Form1.inv_template_Farhan == 1;
																			if (flag34)
																			{
																				SalesInvoicePortraitFarhan salesInvoicePortraitFarhan = new SalesInvoicePortraitFarhan();
																				salesInvoicePortraitFarhan.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																				salesInvoicePortraitFarhan.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																				salesInvoicePortraitFarhan.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																				salesInvoicePortraitFarhan.reprint = 1;
																				salesInvoicePortraitFarhan.branch = this.cboBranch.Text;
																				bool flag35 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																				if (flag35)
																				{
																					salesInvoicePortraitFarhan.showinvdisc = 1;
																				}
																				salesInvoicePortraitFarhan.ShowDialog(this);
																				salesInvoicePortraitFarhan.Dispose();
																			}
																			else
																			{
																				SalesInvoicePortrait salesInvoicePortrait2 = new SalesInvoicePortrait();
																				salesInvoicePortrait2.invnum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
																				salesInvoicePortrait2.revmax_sign = this.pf.GetDigSig(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, this._cnn);
																				salesInvoicePortrait2.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
																				salesInvoicePortrait2.reprint = 1;
																				salesInvoicePortrait2.branch = this.cboBranch.Text;
																				salesInvoicePortrait2.hidevat = MyProject.Forms.Form1.hidevat;
																				bool flag36 = MyProject.Forms.Form1.AllowInvDiscount == 1;
																				if (flag36)
																				{
																					salesInvoicePortrait2.showinvdisc = 1;
																				}
																				salesInvoicePortrait2.ShowDialog(this);
																				salesInvoicePortrait2.Dispose();
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								else
								{
									bool flag37 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "reprint80", false) == 0;
									if (flag37)
									{
										DataTable additionalSettingsPrinters2 = this.pf.GetAdditionalSettingsPrinters(this._cnn, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.receipt_template);
										bool flag38 = additionalSettingsPrinters2.Rows.Count > 0;
										if (flag38)
										{
											DataRow dataRow2 = additionalSettingsPrinters2.Rows[0];
											this.desc_spacing = Conversions.ToInteger(dataRow2["receipt_desc_spacing"]);
											this.qty_spacing = Conversions.ToInteger(dataRow2["receipt_qty_spacing"]);
											this.unitprice_spacing = Conversions.ToInteger(dataRow2["receipt_unitprice_spacing"]);
											this.total_spacing = Conversions.ToInteger(dataRow2["receipt_total_spacing"]);
											this.tax_spacing = Conversions.ToInteger(dataRow2["receipt_tax_spacing"]);
										}
										bool flag39 = (MyProject.Forms.Form1.PrintReceipt == 1) & (MyProject.Forms.Form1.FiscalRevmax == 1) & (MyProject.Forms.Form1.PrintFiscal == 1);
										if (flag39)
										{
											DataTable dataTable3 = new DataTable();
											int num2 = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
											dataTable3 = this.pf2.GetRemaxQRDetails(num2, MyProject.Forms.Form1.coid, this.cboBranch.Text, 1, 0, this._cnn);
											bool flag40 = dataTable3.Rows.Count > 0;
											if (flag40)
											{
												DataRow dataRow3 = dataTable3.Rows[0];
												bool flag41 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["QRCode"]));
												if (!flag41)
												{
													byte[] array = (byte[])dataRow3["QRCode"];
													MemoryStream memoryStream = new MemoryStream(array, false);
													Image image = Image.FromStream(memoryStream);
													this.PicQRCode.Image = image;
													this.QRCodeVariable = (Bitmap)image;
												}
												this.qrveri_code = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["QRCodeVerificationCode"])), "", RuntimeHelpers.GetObjectValue(dataRow3["QRCodeVerificationCode"])));
												this.qrveri_link = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["QRVerificationLink"])), "", RuntimeHelpers.GetObjectValue(dataRow3["QRVerificationLink"])));
											}
										}
										this.isReprint = 1;
										this.PrintReceipt(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), this.pf.GetInvoiceDetails(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetPayDetails(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), MyProject.Forms.Form1.Constring, this.cboBranch.Text), this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Customer"].Value), MyProject.Forms.Form1.coid, this.cboBranch.Text), false, false);
										this.PrintAirtimeVoucher(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), MyProject.Forms.Form1.coid, this.cboBranch.Text);
									}
									else
									{
										bool flag42 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Back-Date", false) == 0;
										if (flag42)
										{
											DialogResult dialogResult4 = (DialogResult)Interaction.MsgBox("Are you sure you want to Back Date selected invoice? " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString(), MsgBoxStyle.YesNo, null);
											bool flag43 = dialogResult4 == DialogResult.Yes;
											if (flag43)
											{
												BackDateValue backDateValue = new BackDateValue();
												backDateValue.ShowDialog(this);
												backDateValue.Dispose();
												bool flag44 = MyProject.Forms.Form1.backdatevalue != 0;
												if (flag44)
												{
													bool flag45 = MyProject.Forms.Form1.IsSupervisor | MyProject.Forms.Form1.IsAdmin;
													if (flag45)
													{
														this.BackDateInv(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Sale_Date"].Value), MyProject.Forms.Form1.backdatevalue, MyProject.Forms.Form1.username, Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")), DateTime.Now.ToString("HH: mm"), MyProject.Forms.Form1.coid, Conversions.ToString(this.cboBranch.SelectedValue));
													}
													else
													{
														MessageBox.Show("User does not have permission.");
													}
												}
												else
												{
													MessageBox.Show("Backdate is not allowed in global settings.");
												}
												DataTable dataTable4 = new DataTable();
												this.dgvDetails.DataSource = dataTable4;
												this.LoadSales();
												MessageBox.Show("Invoice Back-dated.");
											}
										}
										else
										{
											bool flag46 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Reprint DNote", false) == 0;
											if (flag46)
											{
												bool flag47 = MyProject.Forms.Form1.PrintReceipt == 1;
												if (flag47)
												{
													this.printDeliveryNote80mm(this.pf.GetInvoiceDetails(MyProject.Forms.Form1.coid, this.cboBranch.Text, Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), this._cnn), 72);
												}
												else
												{
													DeliveryNoteWarehouse deliveryNoteWarehouse = new DeliveryNoteWarehouse();
													deliveryNoteWarehouse.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
													deliveryNoteWarehouse.ShowDialog(this);
													deliveryNoteWarehouse.Dispose();
												}
											}
											else
											{
												bool flag48 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Consultant", false) == 0;
												if (flag48)
												{
													bool flag49 = MyProject.Forms.Form1.IsSupervisor | MyProject.Forms.Form1.IsAdmin;
													if (flag49)
													{
														SelectUserForm selectUserForm = new SelectUserForm();
														selectUserForm.ShowDialog();
														selectUserForm.Dispose();
														bool flag50 = Operators.CompareString(MyProject.Forms.Form1.new_consultant, "", false) != 0;
														if (flag50)
														{
															this.ChangeConsultant(MyProject.Forms.Form1.new_consultant, Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value), Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Consultant"].Value), "");
															MessageBox.Show("Consultant changed for invoice number: " + dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value.ToString() + ". Reloading sales.");
															this.LoadSales();
														}
														else
														{
															MessageBox.Show("New consultant was not selected. Update NOT done.");
														}
													}
													else
													{
														MessageBox.Show("You do not have permission to make this change.");
													}
												}
												else
												{
													bool flag51 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "RevmaxRetry", false) == 0;
													if (flag51)
													{
														MessageBox.Show("Work in progress.");
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occured on Invoice Grid. Detail: " + ex.Message);
				this.LoadSales();
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00061B2C File Offset: 0x0005FD2C
		private void ChangeConsultant(string newconsultant, int invoicenum, string oldconsultant, string comment)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateConsultant";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("audit_type", "Invoice Consultant Change");
			sqlCommand.Parameters.AddWithValue("old_consultant", oldconsultant);
			sqlCommand.Parameters.AddWithValue("new_consultant", newconsultant);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donetime", DateTime.Now.ToString("HH:mm"));
			sqlCommand.Parameters.AddWithValue("comment", comment);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00061CB8 File Offset: 0x0005FEB8
		private void BackDateInv(int invnum, int currdate, int newdate, string doneby, int donewhen, string donetime, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BackDateInvoice";
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			sqlCommand.Parameters.AddWithValue("newdate", newdate);
			sqlCommand.Parameters.AddWithValue("currdate", currdate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("doneby", doneby);
			sqlCommand.Parameters.AddWithValue("donewhen", donewhen);
			sqlCommand.Parameters.AddWithValue("donetime", donetime);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00061DD4 File Offset: 0x0005FFD4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.LoadSales();
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00061E3C File Offset: 0x0006003C
		private void PrintReceipt(int invnumber, DataTable invDetails, DataTable payDetails, DataTable customerDetails, bool IsCancelledREceipt, bool isdebitnote)
		{
			this.datInvDetails = invDetails;
			IEnumerable<string> enumerable = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I144-0 == null) ? (CreditNote._Closure$__.$I144-0 = (DataRow row) => row.Field<string>("DigSig")) : CreditNote._Closure$__.$I144-0).Distinct<string>();
			string text = enumerable.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable2 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I144-1 == null) ? (CreditNote._Closure$__.$I144-1 = (DataRow row) => row.Field<string>("Invoice_Number_Display")) : CreditNote._Closure$__.$I144-1).Distinct<string>();
			string text2 = enumerable2.ElementAtOrDefault<string>(0);
			IEnumerable<decimal> enumerable3 = this.datInvDetails.AsEnumerable().Select<DataRow, decimal>((CreditNote._Closure$__.$I144-2 == null) ? (CreditNote._Closure$__.$I144-2 = (DataRow row) => row.Field<decimal>("invdiscount")) : CreditNote._Closure$__.$I144-2).Distinct<decimal>();
			decimal num = enumerable3.ElementAtOrDefault<decimal>(0);
			IEnumerable<decimal> enumerable4 = this.datInvDetails.AsEnumerable().Select<DataRow, decimal>((CreditNote._Closure$__.$I144-3 == null) ? (CreditNote._Closure$__.$I144-3 = (DataRow row) => row.Field<decimal>("therate")) : CreditNote._Closure$__.$I144-3).Distinct<decimal>();
			decimal num2 = enumerable4.ElementAtOrDefault<decimal>(0);
			IEnumerable<string> enumerable5 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I144-4 == null) ? (CreditNote._Closure$__.$I144-4 = (DataRow row) => row.Field<string>("Ref")) : CreditNote._Closure$__.$I144-4).Distinct<string>();
			string text3 = enumerable5.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable6 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I144-5 == null) ? (CreditNote._Closure$__.$I144-5 = (DataRow row) => row.Field<string>("Done_By")) : CreditNote._Closure$__.$I144-5).Distinct<string>();
			string text4 = enumerable6.ElementAtOrDefault<string>(0);
			IEnumerable<int> enumerable7 = this.datInvDetails.AsEnumerable().Select<DataRow, int>((CreditNote._Closure$__.$I144-6 == null) ? (CreditNote._Closure$__.$I144-6 = (DataRow row) => row.Field<int>("paymentmethod")) : CreditNote._Closure$__.$I144-6).Distinct<int>();
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
			this.datPayDetails = payDetails;
			this.datCustomerDetails = customerDetails;
			IEnumerable<string> enumerable8 = this.datCustomerDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I144-7 == null) ? (CreditNote._Closure$__.$I144-7 = (DataRow row) => row.Field<string>("Address")) : CreditNote._Closure$__.$I144-7).Distinct<string>();
			string text6 = enumerable8.ElementAtOrDefault<string>(0);
			decimal num4 = this.datInvDetails.AsEnumerable().Sum<DataRow>((CreditNote._Closure$__.$I144-8 == null) ? (CreditNote._Closure$__.$I144-8 = (DataRow row) => row.Field<decimal>("Tax")) : CreditNote._Closure$__.$I144-8);
			decimal num5 = this.datInvDetails.AsEnumerable().Sum<DataRow>((CreditNote._Closure$__.$I144-9 == null) ? (CreditNote._Closure$__.$I144-9 = (DataRow row) => row.Field<decimal>("Sub_Total")) : CreditNote._Closure$__.$I144-9);
			num5 = decimal.Add(num5, num4);
			bool flag2 = MyProject.Forms.Form1.useOldPrintingService == 1;
			checked
			{
				if (flag2)
				{
					this.PrintHeader(text4, IsCancelledREceipt, isdebitnote);
					this.ItemsToBePrinted(invnumber, text5, text3, text6, IsCancelledREceipt, num2, num, text2, isdebitnote, IsCancelledREceipt);
					this.PrintFooter(num4.ToString(), text5, num5, num, "", this.qrveri_code, this.qrveri_link);
					this.stringToRead = new StringReader(this.TextToPrint);
					try
					{
						StandardPrintController standardPrintController = new StandardPrintController();
						bool flag3 = Operators.CompareString(MyProject.Forms.Form1.defaultReceiptPrinter, "", false) != 0;
						if (flag3)
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
				else
				{
					try
					{
						PrinterClass printerClass = new PrinterClass(MyProject.Forms.Form1.defaultReceiptPrinter, Application.StartupPath);
						PrinterClass printerClass2 = printerClass;
						bool flag4 = printerClass.Path == null;
						if (flag4)
						{
							MessageBox.Show("Default receipt printer is not selected or there is an error. Cannot print.");
						}
						else
						{
							int num6 = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LogoSpacePadding", MyProject.Forms.Form1.Constring)));
							bool flag5 = File.Exists("C:\\Quantum\\logo.bmp");
							if (flag5)
							{
								printerClass2.RTL = false;
								printerClass2.PrintLogo(num6);
								printerClass2.FeedPaper(3);
							}
							printerClass2.FontName = "Courier New";
							this.PrintHeader(text4, IsCancelledREceipt, isdebitnote);
							this.ItemsToBePrinted(invnumber, text5, text3, text6, IsCancelledREceipt, num2, num, text2, isdebitnote, IsCancelledREceipt);
							this.PrintFooter(num4.ToString(), text5, num5, num, "", this.qrveri_code, this.qrveri_link);
							printerClass2.NormalFont();
							printerClass2.FontSize = (float)MyProject.Forms.Form1.ReceiptFontSize;
							printerClass2.WriteChars(this.TextToPrint);
							bool flag6 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
							if (flag6)
							{
								try
								{
									Image image = this.PictureBox1.Image;
									BarcodeSymbology barcodeSymbology = BarcodeSymbology.Code39C;
									SymbologyTestCase symbologyTestCase = new SymbologyTestCase(barcodeSymbology, invnumber.ToString(), 20);
									this.PictureBox1.Image = symbologyTestCase.BarcodeImage;
									printerClass2.PrintBarcodeImage(this.PictureBox1, num6);
								}
								catch (Exception ex)
								{
									MessageBox.Show("Failed to print barcode on receipt. Error: " + ex.Message);
								}
							}
							bool flag7 = !Information.IsNothing(this.PicQRCode.Image);
							if (flag7)
							{
								string text7 = "";
								string text8 = "";
								string text9 = "";
								string text10 = string.Concat(new string[]
								{
									"Verification Code: ",
									this.qrveri_code,
									Environment.NewLine,
									"You can verifty this receipt manually at: ",
									Environment.NewLine,
									this.qrveri_link,
									Environment.NewLine,
									"Fiscal Day: ",
									text7,
									Environment.NewLine,
									"Receipt Global No: ",
									text8,
									Environment.NewLine,
									"Device ID: ",
									text9
								});
								printerClass2.WriteChars(text10);
								printerClass2.WriteLine(" ");
								printerClass2.PrintBarcodeImage(this.PicQRCode, (int)Math.Round(unchecked((double)num6 - (double)num6 / 2.0)));
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
								printerClass2.WriteLine(" ");
							}
							bool flag8 = Operators.CompareString(this.website_og, "", false) != 0;
							if (flag8)
							{
								try
								{
									Bitmap bitmap = this.pf.GenerateQrImage(this.website_og, MyProject.Forms.Form1.QRCodeSize);
									this.PicQRCode.Image = bitmap;
									printerClass2.WriteChars(this.website_comment);
									printerClass2.WriteLine(" ");
									printerClass2.WriteLine(" ");
									printerClass2.WriteLine(" ");
									printerClass2.PrintBarcodeImage(this.PicQRCode, num6);
								}
								catch (Exception ex2)
								{
									MessageBox.Show("error with website url qr code. Details: " + ex2.Message);
								}
							}
							printerClass2.CutPaper();
							printerClass2.EndDoc();
							printerClass2 = null;
						}
					}
					catch (Exception ex3)
					{
						MessageBox.Show("Error printing. Detail: " + ex3.Message);
					}
				}
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0006268C File Offset: 0x0006088C
		private void PrintReceiptnutNOTPrint(int invnumber, DataTable invDetails, DataTable payDetails, DataTable customerDetails, bool IsCancelledREceipt, bool isdebitnote)
		{
			this.datInvDetails = invDetails;
			IEnumerable<string> enumerable = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-0 == null) ? (CreditNote._Closure$__.$I145-0 = (DataRow row) => row.Field<string>("DigSig")) : CreditNote._Closure$__.$I145-0).Distinct<string>();
			string text = enumerable.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable2 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-1 == null) ? (CreditNote._Closure$__.$I145-1 = (DataRow row) => row.Field<string>("Invoice_Number_Display")) : CreditNote._Closure$__.$I145-1).Distinct<string>();
			string text2 = enumerable2.ElementAtOrDefault<string>(0);
			IEnumerable<decimal> enumerable3 = this.datInvDetails.AsEnumerable().Select<DataRow, decimal>((CreditNote._Closure$__.$I145-2 == null) ? (CreditNote._Closure$__.$I145-2 = (DataRow row) => row.Field<decimal>("invdiscount")) : CreditNote._Closure$__.$I145-2).Distinct<decimal>();
			decimal num = enumerable3.ElementAtOrDefault<decimal>(0);
			IEnumerable<decimal> enumerable4 = this.datInvDetails.AsEnumerable().Select<DataRow, decimal>((CreditNote._Closure$__.$I145-3 == null) ? (CreditNote._Closure$__.$I145-3 = (DataRow row) => row.Field<decimal>("therate")) : CreditNote._Closure$__.$I145-3).Distinct<decimal>();
			decimal num2 = enumerable4.ElementAtOrDefault<decimal>(0);
			IEnumerable<string> enumerable5 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-4 == null) ? (CreditNote._Closure$__.$I145-4 = (DataRow row) => row.Field<string>("Ref")) : CreditNote._Closure$__.$I145-4).Distinct<string>();
			string text3 = enumerable5.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable6 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-5 == null) ? (CreditNote._Closure$__.$I145-5 = (DataRow row) => row.Field<string>("Done_By")) : CreditNote._Closure$__.$I145-5).Distinct<string>();
			string text4 = enumerable6.ElementAtOrDefault<string>(0);
			IEnumerable<string> enumerable7 = this.datInvDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-6 == null) ? (CreditNote._Closure$__.$I145-6 = (DataRow row) => row.Field<string>("Comments")) : CreditNote._Closure$__.$I145-6).Distinct<string>();
			string text5 = enumerable7.ElementAtOrDefault<string>(0);
			IEnumerable<int> enumerable8 = this.datInvDetails.AsEnumerable().Select<DataRow, int>((CreditNote._Closure$__.$I145-7 == null) ? (CreditNote._Closure$__.$I145-7 = (DataRow row) => row.Field<int>("paymentmethod")) : CreditNote._Closure$__.$I145-7).Distinct<int>();
			int num3 = enumerable8.ElementAtOrDefault<int>(0);
			bool flag = num3 == 10;
			string text6;
			if (flag)
			{
				text6 = "True";
			}
			else
			{
				text6 = "False";
			}
			this.datPayDetails = payDetails;
			this.datCustomerDetails = customerDetails;
			IEnumerable<string> enumerable9 = this.datCustomerDetails.AsEnumerable().Select<DataRow, string>((CreditNote._Closure$__.$I145-8 == null) ? (CreditNote._Closure$__.$I145-8 = (DataRow row) => row.Field<string>("Address")) : CreditNote._Closure$__.$I145-8).Distinct<string>();
			string text7 = enumerable9.ElementAtOrDefault<string>(0);
			decimal num4 = this.datInvDetails.AsEnumerable().Sum<DataRow>((CreditNote._Closure$__.$I145-9 == null) ? (CreditNote._Closure$__.$I145-9 = (DataRow row) => row.Field<decimal>("Tax")) : CreditNote._Closure$__.$I145-9);
			decimal num5 = this.datInvDetails.AsEnumerable().Sum<DataRow>((CreditNote._Closure$__.$I145-10 == null) ? (CreditNote._Closure$__.$I145-10 = (DataRow row) => row.Field<decimal>("Sub_Total")) : CreditNote._Closure$__.$I145-10);
			num5 = decimal.Add(num5, num4);
			this.PrintHeader(text4, IsCancelledREceipt, isdebitnote);
			this.ItemsToBePrinted(invnumber, text6, text3, text7, IsCancelledREceipt, num2, num, text2, isdebitnote, IsCancelledREceipt);
			this.PrintFooter(num4.ToString(), text6, num5, num, text, "", "");
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000629F4 File Offset: 0x00060BF4
		private void PrintAirtimeVoucher(int invnum, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from EconetAirtime where InvNum = ",
				invnum.ToString(),
				" and coid= ",
				coid.ToString(),
				" and branch = '",
				branch,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				string text = this.pf.AirtimeVoucherTEXT(dataTable, "ECONET AIRTIME");
				this.stringToRead = new StringReader(text);
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
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00062B38 File Offset: 0x00060D38
		public void PrintHeader(string tellername, bool iscreditnote, bool isdebitnote)
		{
			bool flag = MyProject.Forms.Form1.ReceiptSize80 == 1;
			checked
			{
				int num;
				if (flag)
				{
					num = MyProject.Forms.Form1.ReceiptSpacingSize;
				}
				else
				{
					num = (int)Math.Round(unchecked(0.6666666666666666 * (double)MyProject.Forms.Form1.ReceiptSpacingSize));
				}
				this.TextToPrint = "";
				string text;
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
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag2 = !isdebitnote & !iscreditnote;
				if (flag2)
				{
					text = "FISCAL TAX INVOICE";
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag3 = MyProject.Forms.Form1.PrintBarcodeInvNumber == 1;
				if (flag3)
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
				bool flag4 = this.coname.Length > 80;
				if (flag4)
				{
					this.coname = this.coname;
				}
				else
				{
					this.coname = this.pf.StringPadCentre(this.coname, num);
				}
				text = this.coname;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag5 = Operators.CompareString(this.cobpnum, "", false) != 0;
				if (flag5)
				{
					text = this.bpnum_name + " " + this.cobpnum;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag6 = Operators.CompareString(this.coVATNum, "", false) != 0;
				if (flag6)
				{
					text = this.vatnum_name + " " + this.coVATNum;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				text = this.coadd;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				text = this.coadd2;
				text = this.pf.StringPadCentre(text, num);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
				bool flag7 = Operators.CompareString(this.coemail, "", false) != 0;
				if (flag7)
				{
					text = this.coemail;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag8 = Operators.CompareString(this.cotel, "", false) != 0;
				if (flag8)
				{
					text = this.cotel;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				bool flag9 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
				if (flag9)
				{
					text = this.cotel2 + "  " + this.cotel3;
					text = this.pf.StringPadCentre(text, num);
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + text + Environment.NewLine;
				}
				text = "Teller: " + tellername;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text + Environment.NewLine;
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00062F44 File Offset: 0x00061144
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
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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
			bool flag2 = this.isReprint == 1;
			if (flag2)
			{
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + "RE-PRINT" + Environment.NewLine;
				bool flag3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["PaymentMethod"])) == 10.0;
				if (flag3)
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "ACCOUNT SALE" + Environment.NewLine;
				}
				else
				{
					ptr = ref this.TextToPrint;
					this.TextToPrint = ptr + "CASH SALE" + Environment.NewLine;
				}
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
			bool flag4 = (Operators.CompareString(dataRow["ref"].ToString(), "Cash", false) != 0) & (customerDetails.Rows.Count > 0);
			string text5;
			if (flag4)
			{
				bool flag5 = Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", MyProject.Forms.Form1.Constring), "1", false) == 0;
				if (flag5)
				{
					text5 = string.Concat(new string[]
					{
						text5,
						Environment.NewLine,
						"Customer Address: ",
						dataRow2["StreetNumber"].ToString(),
						", ",
						dataRow2["Address"].ToString(),
						", ",
						dataRow2["City"].ToString(),
						", ",
						dataRow2["Province"].ToString()
					});
					bool flag6 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
					if (flag6)
					{
						text5 = text5 + Environment.NewLine + "Customer Phone #: " + dataRow2["Mobile"].ToString();
					}
					bool flag7 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
					if (flag7)
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
					bool flag8 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
					if (flag8)
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
					bool flag9 = Operators.CompareString(dataRow2["Email"].ToString(), "", false) != 0;
					if (flag9)
					{
						text5 = text5 + Environment.NewLine + "Customer Email: " + dataRow2["Email"].ToString();
					}
				}
				else
				{
					bool flag10 = Operators.CompareString(dataRow2["StreetNumber"].ToString(), "", false) != 0;
					if (flag10)
					{
						text5 = text5 + Environment.NewLine + "Customer Street Number: " + dataRow2["StreetNumber"].ToString();
					}
					bool flag11 = Operators.CompareString(dataRow2["Address"].ToString(), "", false) != 0;
					if (flag11)
					{
						text5 = text5 + Environment.NewLine + "Customer Address: " + dataRow2["Address"].ToString();
					}
					bool flag12 = Operators.CompareString(dataRow2["City"].ToString(), "", false) != 0;
					if (flag12)
					{
						text5 = text5 + Environment.NewLine + "Customer City: " + dataRow2["City"].ToString();
					}
					bool flag13 = Operators.CompareString(dataRow2["Province"].ToString(), "", false) != 0;
					if (flag13)
					{
						text5 = text5 + Environment.NewLine + "Customer Province: " + dataRow2["Province"].ToString();
					}
					bool flag14 = Operators.CompareString(dataRow2["Mobile"].ToString(), "", false) != 0;
					if (flag14)
					{
						text5 = text5 + Environment.NewLine + "Customer Phone #: " + dataRow2["Mobile"].ToString();
					}
					bool flag15 = Operators.CompareString(dataRow2["BPNumber"].ToString(), "", false) != 0;
					if (flag15)
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
					bool flag16 = Operators.CompareString(dataRow2["VATNumber"].ToString(), "", false) != 0;
					if (flag16)
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
					bool flag17 = Operators.CompareString(dataRow2["Email"].ToString(), "", false) != 0;
					if (flag17)
					{
						text5 = text5 + Environment.NewLine + "Customer Email: " + dataRow2["Email"].ToString();
					}
				}
				text5 = text5 + Environment.NewLine + Environment.NewLine;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text5;
			}
			string text6 = Conversions.ToString(Operators.ConcatenateObject(dataRow["Currency"], Environment.NewLine));
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + "HS Code : Description " + text6;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine + this.LINE;
			decimal num2 = 0m;
			string text7 = "Qty";
			string text8 = "UnitPrice";
			string text9 = "VAT";
			string text10 = "Amount(Incl)";
			bool flag18 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
			if (flag18)
			{
				text5 = Environment.NewLine + text7.PadLeft(this.qty_spacing, ' ') + text8.PadLeft(this.unitprice_spacing, ' ') + text10.PadLeft(this.total_spacing, ' ');
			}
			else
			{
				text5 = string.Concat(new string[]
				{
					Environment.NewLine,
					text7.PadLeft(this.qty_spacing, ' '),
					text8.PadLeft(this.unitprice_spacing, ' '),
					text9.PadLeft(this.tax_spacing, ' '),
					text10.PadLeft(this.total_spacing, ' ')
				});
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text5 + Environment.NewLine;
			bool flag19 = num > 0;
			checked
			{
				if (flag19)
				{
					int num3 = 0;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow3 = (DataRow)obj;
							num3++;
							text5 = "";
							bool flag20 = decimal.Compare(Conversions.ToDecimal(dataRow3["Unit_Selling_Price"]), 0m) != 0;
							if (flag20)
							{
								string text11 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["HSCode"], " - "), dataRow3["Description"]));
								string text12 = Conversions.ToString(dataRow3["UOM"]);
								bool flag21 = Operators.CompareString(text12, "EA", false) == 0;
								if (flag21)
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
								bool flag22 = MyProject.Forms.Form1.PricesAreAfterTax == 1;
								double num4;
								if (flag22)
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
								bool flag23 = num6 >= 51;
								if (flag23)
								{
									text11 = text11.Substring(0, 50);
								}
								int length = text11.Length;
								bool flag24 = MyProject.Forms.Form1.FiscalEltradeESD == 1;
								if (flag24)
								{
									DataTable productDetailsByBarCode = this.pf.GetProductDetailsByBarCode(dataRow3["Product_Code"].ToString(), this._cnn);
									DataRow dataRow5 = productDetailsByBarCode.Rows[0];
									decimal num7 = Conversions.ToDecimal(dataRow5["TaxRate"]);
									int num8 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow5["taxexempt"])));
									bool flag25 = decimal.Compare(num7, 0m) > 0;
									if (flag25)
									{
										text11 = "T: " + text11;
									}
									else
									{
										bool flag26 = num8 == 1;
										if (flag26)
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
								bool flag27 = dataRow3["DiscountAmt"].ToString().Length > 0;
								if (flag27)
								{
									bool flag28 = Operators.CompareString(dataRow3["DiscountAmt"].ToString(), "0.00", false) == 0;
									if (!flag28)
									{
										this.ProdtDiscTotal = Conversions.ToDecimal(Operators.MultiplyObject(dataRow3["DiscountAmt"], dataRow3["Quantity"]));
										text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Discount Given per unit: ", dataRow3["DiscountAmt"]), Environment.NewLine));
										ptr = ref this.TextToPrint;
										this.TextToPrint = ptr + text5;
									}
								}
								bool flag29 = dataRow3["Comments"].ToString().Length > 50;
								if (flag29)
								{
									text5 = dataRow3["Comments"].ToString().Substring(0, 49) + Environment.NewLine;
									text5 = text5 + dataRow3["Comments"].ToString().Substring(50, 50) + Environment.NewLine;
									ptr = ref this.TextToPrint;
									this.TextToPrint = ptr + text5;
								}
								else
								{
									bool flag30 = dataRow3["Comments"].ToString().Length > 0;
									if (flag30)
									{
										bool flag31 = Operators.CompareString(dataRow3["comments"].ToString(), "", false) == 0;
										if (!flag31)
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
								bool flag32 = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["taxexempt"])), 1, false);
								string text18;
								if (flag32)
								{
									text18 = this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "TaxExemptSymbol", MyProject.Forms.Form1.Constring);
								}
								else
								{
									text18 = Strings.Format(RuntimeHelpers.GetObjectValue(dataRow3["Tax"]), "N2");
								}
								string text19 = num2.ToString();
								text5 = text11 + Environment.NewLine;
								bool flag33 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
								if (flag33)
								{
									text5 = text5 + text19.ToString().PadLeft(this.qty_spacing, ' ') + text16.PadLeft(this.unitprice_spacing, ' ') + text17.PadLeft(this.total_spacing, ' ');
								}
								else
								{
									text5 = string.Concat(new string[]
									{
										text5,
										text19.ToString().PadLeft(this.qty_spacing, ' '),
										text16.PadLeft(this.unitprice_spacing, ' '),
										text18.PadLeft(this.tax_spacing, ' '),
										text17.PadLeft(this.total_spacing, ' ')
									});
								}
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x000640B8 File Offset: 0x000622B8
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
			string text = new string(' ', Convert.ToInt32(Math.Round(new decimal(checked(26 - num2)))));
			string text2 = "     ";
			int num3 = 20;
			int num4 = 10;
			bool flag = MyProject.Forms.Form1.UseReceiptDisplay == 1;
			string text4;
			if (flag)
			{
				decimal num5 = Convert.ToDecimal(subtotal);
				string text3 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Inv. Subtotal:", num5.ToString("N2"));
				text4 = text3;
			}
			else
			{
				decimal num6 = Math.Round(subtotal, 2, MidpointRounding.AwayFromZero);
				string text5 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Inv. Subtotal:", num6.ToString("N2"));
				text4 = text5;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + text4 + Environment.NewLine;
			bool flag2 = Operators.CompareString(MyProject.Forms.Form1.receipt_template, "NO VAT COLUMN", false) == 0;
			if (!flag2)
			{
				decimal num7 = new decimal(Math.Round(Conversion.Val(tax), 2, MidpointRounding.AwayFromZero));
				string text6 = string.Format(string.Concat(new string[]
				{
					"{0,-",
					Conversions.ToString(num3),
					"}{1,",
					Conversions.ToString(num4),
					"}"
				}), "Total VAT:", num7.ToString("N2"));
				text4 = text6;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + text4 + Environment.NewLine;
			}
			decimal num8 = Math.Round(discamt, 2, MidpointRounding.AwayFromZero);
			decimal num9 = Math.Round(decimal.Subtract(subtotal, discamt), 2, MidpointRounding.AwayFromZero);
			string text7 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(num3),
				"}{1,",
				Conversions.ToString(num4),
				"}"
			}), "Inv. Discount:", num8.ToString("N2"));
			string text8 = string.Format(string.Concat(new string[]
			{
				"{0,-",
				Conversions.ToString(num3),
				"}{1,",
				Conversions.ToString(num4),
				"}"
			}), "Invoice Total:", num9.ToString("N2"));
			text4 = text2 + text7 + Environment.NewLine;
			text4 = string.Concat(new string[]
			{
				text4,
				text2,
				text8,
				Environment.NewLine,
				Environment.NewLine
			});
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text4;
			bool flag3 = MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt == 1;
			if (flag3)
			{
				bool flag4 = Conversions.ToBoolean(saletype);
				string text9;
				if (flag4)
				{
					text9 = "Account";
				}
				else
				{
					text9 = "COD";
				}
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + Environment.NewLine;
				text4 = "Payment Method:" + text9;
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text4 + Environment.NewLine;
				bool flag5 = Operators.CompareString(text9, "COD", false) == 0;
				if (flag5)
				{
					try
					{
						foreach (object obj in this.datPayDetails.Rows)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj);
							string text10 = NewLateBinding.LateIndexGet(objectValue, new object[] { "PaymentMethodDesc" }, null).ToString();
							string text11 = ": ";
							object obj2 = null;
							Type typeFromHandle = typeof(Math);
							string text12 = "Round";
							object[] array = new object[3];
							int num10 = 0;
							object obj3 = objectValue;
							object obj4 = obj3;
							object[] array2 = new object[1];
							object obj5 = (array2[0] = "AmountPaid");
							array[num10] = NewLateBinding.LateIndexGet(obj4, array2, null);
							array[1] = 2;
							array[2] = MidpointRounding.AwayFromZero;
							object[] array3 = array;
							string[] array4 = null;
							Type[] array5 = null;
							bool[] array6 = new bool[3];
							array6[0] = true;
							bool[] array7 = array6;
							object obj6 = NewLateBinding.LateGet(obj2, typeFromHandle, text12, array, array4, array5, array6);
							if (array7[0])
							{
								NewLateBinding.LateIndexSetComplex(obj3, new object[]
								{
									obj5,
									array3[0]
								}, null, true, false);
							}
							text4 = text10 + text11 + obj6.ToString();
							ptr = ref this.TextToPrint;
							this.TextToPrint = ptr + text4 + Environment.NewLine;
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
			text4 = this.footnote;
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text4 + Environment.NewLine + Environment.NewLine;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00064600 File Offset: 0x00062800
		private void CreditNote_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.GetBranchDetails();
				bool isAdmin = MyProject.Forms.Form1.IsAdmin;
				if (isAdmin)
				{
					this.cboBranch.Enabled = true;
				}
				else
				{
					this.cboBranch.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00064688 File Offset: 0x00062888
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0006474C File Offset: 0x0006294C
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

		// Token: 0x06000A25 RID: 2597 RVA: 0x000649AC File Offset: 0x00062BAC
		private void GetBranchDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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
					this.coadd2 = dataRow["Address2"].ToString();
					this.cotel = dataRow["Tel"].ToString();
					this.cotel2 = dataRow["Tel2"].ToString();
					this.cotel3 = dataRow["Tel3"].ToString();
					this.coemail = dataRow["Email"].ToString();
					this.cobpnum = dataRow["BPNumber"].ToString();
					this.footnote = dataRow["Footnote"].ToString();
					this.coVATNum = dataRow["VATNumber"].ToString();
					this.bpnum_name = Conversions.ToString(dataRow["BPNumber_name"]);
					this.vatnum_name = Conversions.ToString(dataRow["VATNumber_name"]);
					this.website_og = dataRow["websiteadd"].ToString();
					this.website_comment = dataRow["websitecomment"].ToString();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00064BD4 File Offset: 0x00062DD4
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					this.Cursor = Cursors.WaitCursor;
					this.loadSalesbyInvNumber(checked((int)Math.Round(Conversion.Val(this.txtinvnum.Text))));
					this.Cursor = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Please select the branch first.");
					this.cboBranch.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtinvnum_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00064C8C File Offset: 0x00062E8C
		private void txtinvnum_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.loadSalesbyInvNumber(checked((int)Math.Round(Conversion.Val(this.txtinvnum.Text))));
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore" + ex.Message);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00002A30 File Offset: 0x00000C30
		private void CreditNote_Disposed(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00064D08 File Offset: 0x00062F08
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvInvoices.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.Cursor = Cursors.WaitCursor;
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvInvoices, this.SaveFileDialog1.FileName);
						this.Cursor = Cursors.Default;
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00064DD8 File Offset: 0x00062FD8
		private void printDeliveryNote80mm(DataTable invoicedetailsDAT, int papersize)
		{
			string text = "DELIVERY NOTE";
			string text2 = this.pf.StringPadCentre(text, papersize);
			DataRow dataRow = invoicedetailsDAT.Rows[0];
			DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, Conversions.ToString(dataRow["Ref"]), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			text2 = text2 + this.pf.StringPadCentre(text2, papersize) + Environment.NewLine;
			this.TextToPrint = text2;
			this.coname = this.pf.StringPadCentre(this.coname, papersize);
			text2 = this.coname;
			ref string ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			bool flag = Operators.CompareString(this.cobpnum, "", false) != 0;
			if (flag)
			{
				text2 = this.bpnum_name + " " + this.cobpnum;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag2 = Operators.CompareString(this.coVATNum, "", false) != 0;
			if (flag2)
			{
				text2 = this.vatnum_name + " " + this.coVATNum;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			text2 = this.coadd;
			text2 = this.pf.StringPadCentre(text2, papersize);
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			bool flag3 = Operators.CompareString(this.coemail, "", false) != 0;
			if (flag3)
			{
				text2 = this.coemail;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag4 = Operators.CompareString(this.cotel, "", false) != 0;
			if (flag4)
			{
				text2 = this.cotel;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			bool flag5 = (Operators.CompareString(this.cotel2, "", false) != 0) | (Operators.CompareString(this.cotel3, "", false) != 0);
			if (flag5)
			{
				text2 = this.cotel2 + "  " + this.cotel3;
				text2 = this.pf.StringPadCentre(text2, papersize);
				ptr = ref this.TextToPrint;
				this.TextToPrint = ptr + text2 + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + Environment.NewLine;
			text2 = DateTime.Today.ToShortDateString() + " " + DateAndTime.TimeOfDay.ToShortTimeString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = "Teller: " + MyProject.Forms.Form1.username + Environment.NewLine + Environment.NewLine;
			text2 = text2 + "Delivery note number: D" + dataRow["Invoice_Number"].ToString();
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine + Environment.NewLine;
			DataRow dataRow2 = customerDetails.Rows[0];
			text2 = "CUSTOMER DETAILS" + Environment.NewLine;
			string text3 = dataRow2["CustomerName"].ToString();
			string text4 = dataRow2["ContactName"].ToString();
			string text5 = dataRow2["Address"].ToString();
			string text6 = dataRow2["Mobile"].ToString();
			bool flag6 = Operators.CompareString(text3, "", false) != 0;
			if (flag6)
			{
				text2 = text2 + text3 + Environment.NewLine;
			}
			bool flag7 = Operators.CompareString(text4, "", false) != 0;
			if (flag7)
			{
				text2 = text2 + text4 + Environment.NewLine;
			}
			bool flag8 = Operators.CompareString(text5, "", false) != 0;
			if (flag8)
			{
				text2 = text2 + text5 + Environment.NewLine;
			}
			bool flag9 = Operators.CompareString(text6, "", false) != 0;
			if (flag9)
			{
				text2 = text2 + text6 + Environment.NewLine;
			}
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = "DELIVERY ITEMS" + Environment.NewLine;
			string text7 = "Quantity";
			text2 = text2 + "Description" + text7.PadLeft(60, ' ') + Environment.NewLine;
			try
			{
				foreach (object obj in invoicedetailsDAT.Rows)
				{
					dataRow = (DataRow)obj;
					string text8 = dataRow["Description"].ToString();
					text8 = text8.PadRight(50);
					bool flag10 = text8.Length >= 50;
					if (flag10)
					{
						text8 = text8.Substring(0, 50);
					}
					string text9 = Conversions.ToString(dataRow["uom"]);
					bool flag11 = Operators.CompareString(text9, "EA", false) == 0;
					string text10;
					if (flag11)
					{
						DataRow dataRow3;
						object[] array;
						bool[] array2;
						object obj2 = NewLateBinding.LateGet(null, typeof(Math), "Floor", array = new object[] { (dataRow3 = dataRow)["Quantity"] }, null, null, array2 = new bool[] { true });
						if (array2[0])
						{
							dataRow3["Quantity"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						text10 = obj2.ToString();
					}
					else
					{
						text10 = dataRow["Quantity"].ToString();
					}
					text2 = text2 + text8 + text10.PadLeft(10, ' ') + Environment.NewLine;
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
			this.TextToPrint = ptr + text2 + Environment.NewLine;
			text2 = Environment.NewLine + "Received by:__________________________________" + Environment.NewLine + Environment.NewLine;
			text2 += "Signature:____________________________________";
			ptr = ref this.TextToPrint;
			this.TextToPrint = ptr + text2;
			this.stringToRead = new StringReader(this.TextToPrint);
			try
			{
				StandardPrintController standardPrintController = new StandardPrintController();
				this.PrintDocument1.PrinterSettings.PrinterName = MyProject.Forms.Form1.defaultReceiptPrinter;
				this.PrintDocument1.PrintController = standardPrintController;
				this.PrintDocument1.Print();
			}
			finally
			{
				this.stringToRead.Close();
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000654C0 File Offset: 0x000636C0
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
						decimal num5 = Conversions.ToDecimal(dataRow["Tax"]);
						num = Conversions.ToDecimal(Operators.AddObject(Operators.AddObject(num, dataRow["Sub_Total"]), dataRow["Tax"]));
						decimal num6 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
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
							Operators.AddObject(dataRow["UnitPrice"], Operators.MultiplyObject(dataRow["taxrate"], dataRow["UnitPrice"])),
							3,
							MidpointRounding.AwayFromZero
						}, null, null, null);
						array7[4] = NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(dataRow["Sub_Total"], dataRow["Tax"]),
							2,
							MidpointRounding.AwayFromZero
						}, null, null, null);
						int num7 = 5;
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
						array7[num7] = obj3;
						array7[6] = num6;
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
				this.SaveDigSigCreditNote(qrcodeImageFromRevmaxJSON, invnum, this.cboBranch.Text, MyProject.Forms.Form1.coid, this.qrveri_code, this.qrveri_link, text15);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing revmax credit note. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00065C14 File Offset: 0x00063E14
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

		// Token: 0x040004B5 RID: 1205
		private string TextToPrint;

		// Token: 0x040004B6 RID: 1206
		private string coname;

		// Token: 0x040004B7 RID: 1207
		private string coadd;

		// Token: 0x040004B8 RID: 1208
		private string coadd2;

		// Token: 0x040004B9 RID: 1209
		private string cotel;

		// Token: 0x040004BA RID: 1210
		private string coemail;

		// Token: 0x040004BB RID: 1211
		private string cobpnum;

		// Token: 0x040004BC RID: 1212
		private string cotel2;

		// Token: 0x040004BD RID: 1213
		private string cotel3;

		// Token: 0x040004BE RID: 1214
		private string footnote;

		// Token: 0x040004BF RID: 1215
		private int invnum;

		// Token: 0x040004C0 RID: 1216
		private string _cnn;

		// Token: 0x040004C1 RID: 1217
		private DataTable datInvDetails;

		// Token: 0x040004C2 RID: 1218
		private DataTable datPayDetails;

		// Token: 0x040004C3 RID: 1219
		private DataTable datCustomerDetails;

		// Token: 0x040004C4 RID: 1220
		private PublicFunctions pf;

		// Token: 0x040004C5 RID: 1221
		private StringReader stringToRead;

		// Token: 0x040004C6 RID: 1222
		private int isReprint;

		// Token: 0x040004C7 RID: 1223
		private string coVATNum;

		// Token: 0x040004C8 RID: 1224
		private string bpnum_name;

		// Token: 0x040004C9 RID: 1225
		private string vatnum_name;

		// Token: 0x040004CA RID: 1226
		private string website_og;

		// Token: 0x040004CB RID: 1227
		private string website_comment;

		// Token: 0x040004CC RID: 1228
		private decimal ProdtDiscTotal;

		// Token: 0x040004CD RID: 1229
		private string LINE;

		// Token: 0x040004CE RID: 1230
		private int qty_spacing;

		// Token: 0x040004CF RID: 1231
		private int desc_spacing;

		// Token: 0x040004D0 RID: 1232
		private int unitprice_spacing;

		// Token: 0x040004D1 RID: 1233
		private int total_spacing;

		// Token: 0x040004D2 RID: 1234
		private int tax_spacing;

		// Token: 0x040004D3 RID: 1235
		private PublicFunctions2 pf2;

		// Token: 0x040004D4 RID: 1236
		private string qrveri_code;

		// Token: 0x040004D5 RID: 1237
		private string qrveri_link;

		// Token: 0x040004D6 RID: 1238
		private Bitmap QRCodeVariable;
	}
}

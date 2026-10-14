using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000066 RID: 102
	[DesignerGenerated]
	public partial class InvoiceCheck : UserControl
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x000CB734 File Offset: 0x000C9934
		public InvoiceCheck()
		{
			base.Load += this.InvoiceCheck_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000CC3C8 File Offset: 0x000CA5C8
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x000CC3D2 File Offset: 0x000CA5D2
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000CC3DB File Offset: 0x000CA5DB
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x000CC3E8 File Offset: 0x000CA5E8
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000CC42B File Offset: 0x000CA62B
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x000CC438 File Offset: 0x000CA638
		internal virtual TextBox txtInvoiceNumber
		{
			[CompilerGenerated]
			get
			{
				return this._txtInvoiceNumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.TextBox1_KeyDown);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
				TextBox textBox = this._txtInvoiceNumber;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtInvoiceNumber = value;
				textBox = this._txtInvoiceNumber;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000CC4B1 File Offset: 0x000CA6B1
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x000CC4BB File Offset: 0x000CA6BB
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000CC4C4 File Offset: 0x000CA6C4
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x000CC4CE File Offset: 0x000CA6CE
		internal virtual Panel PanelStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000CC4D7 File Offset: 0x000CA6D7
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x000CC4E4 File Offset: 0x000CA6E4
		internal virtual Label lblStatus
		{
			[CompilerGenerated]
			get
			{
				return this._lblStatus;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblStatus_Click);
				Label label = this._lblStatus;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._lblStatus = value;
				label = this._lblStatus;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000CC527 File Offset: 0x000CA727
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x000CC531 File Offset: 0x000CA731
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000CC53A File Offset: 0x000CA73A
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x000CC544 File Offset: 0x000CA744
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000CC54D File Offset: 0x000CA74D
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x000CC557 File Offset: 0x000CA757
		internal virtual DataGridView dgvInvoices
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000CC560 File Offset: 0x000CA760
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000CC56A File Offset: 0x000CA76A
		internal virtual Label lblInvTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000CC573 File Offset: 0x000CA773
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x000CC57D File Offset: 0x000CA77D
		internal virtual Label lblPayMethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000CC586 File Offset: 0x000CA786
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x000CC590 File Offset: 0x000CA790
		internal virtual Label lblInvDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x000CC599 File Offset: 0x000CA799
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x000CC5A3 File Offset: 0x000CA7A3
		internal virtual Label lblInvNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000CC5AC File Offset: 0x000CA7AC
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x000CC5B8 File Offset: 0x000CA7B8
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x000CC5FB File Offset: 0x000CA7FB
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x000CC605 File Offset: 0x000CA805
		internal virtual Label lblInvTime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x000CC60E File Offset: 0x000CA80E
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x000CC618 File Offset: 0x000CA818
		internal virtual Label lblDoneBY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000CC621 File Offset: 0x000CA821
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x000CC62B File Offset: 0x000CA82B
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000CC634 File Offset: 0x000CA834
		private void loadSalesbyInvNumber(int invoicenumber)
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumberEntered";
			sqlCommand.Parameters.AddWithValue("invoicenumber", invoicenumber);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				DateTime dateTime = Conversions.ToDate(DateTime.ParseExact(dataRow["Sale_Date"].ToString(), "yyyyMMdd", invariantCulture).ToString());
				this.lblInvDate.Text = dateTime.ToShortDateString();
				this.lblInvTotal.Text = MyProject.Forms.Form1.basecurrency + dataRow["Invoice_Value"].ToString();
				this.lblInvNum.Text = "Inv Num: " + dataRow["Invoice_Number"].ToString();
				this.lblInvTime.Text = dataRow["Tran_Time"].ToString() + "hrs";
				this.lblDoneBY.Text = Conversions.ToString(dataRow["Done_By"]);
				bool flag2 = DateTime.Compare(dateTime, DateTime.Today) == 0;
				if (flag2)
				{
					this.PanelStatus.BackColor = Color.LightGreen;
					this.lblStatus.Text = "VALID";
				}
				else
				{
					this.PanelStatus.BackColor = Color.Orange;
					this.lblStatus.Text = "OLD INVOICE";
				}
				this.LoadDetails(Conversions.ToInteger(dataRow["Invoice_Number"]));
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
				bool flag3 = num2 > 0;
				if (flag3)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
					string text = DateTime.ParseExact(dataRow2["trandate"].ToString(), "yyyyMMdd", invariantCulture2).ToString();
					string text2 = DateTime.ParseExact(dataRow2["DateCancelled"].ToString(), "yyyyMMdd", invariantCulture2).ToString();
					MessageBox.Show("This invoice has been cancelled. Sale date: " + text.Substring(0, 10) + ", Date cancelled: " + text2.Substring(0, 10));
					this.PanelStatus.BackColor = Color.Red;
					this.lblStatus.Text = "CANCELLED INVOICE";
					this.LoadDetails(Conversions.ToInteger(this.lblInvNum.Text));
				}
				else
				{
					MessageBox.Show("Invoice not found.");
					this.PanelStatus.BackColor = Color.Red;
					this.lblStatus.Text = "INVOICE NOT FOUND";
					DataTable dataTable3 = new DataTable();
					this.dgvInvoices.DataSource = dataTable3;
				}
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002A30 File Offset: 0x00000C30
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000CCA0C File Offset: 0x000CAC0C
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.loadSalesbyInvNumber(Conversions.ToInteger(this.txtInvoiceNumber.Text));
				e.Handled = true;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000CCA4C File Offset: 0x000CAC4C
		private void Label4_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000CCA84 File Offset: 0x000CAC84
		private void InvoiceCheck_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtInvoiceNumber.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000CCAD8 File Offset: 0x000CACD8
		private void LoadDetails(int inv)
		{
			this.lblinfo.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", inv);
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
				this.dgvInvoices.Columns["Done_By"].Visible = false;
				this.dgvInvoices.Columns["Invoice_Number"].Visible = false;
				this.dgvInvoices.Columns["Tran_Time"].Visible = false;
				this.dgvInvoices.Columns["Product_ID"].Visible = false;
				this.dgvInvoices.Columns["therate"].Visible = false;
				this.dgvInvoices.Columns["PaymentMethod"].Visible = false;
				this.dgvInvoices.Columns["Sale_Date"].Visible = false;
				this.lblinfo.Text = "Showing details for invoice: " + Conversions.ToString(inv);
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				this.dgvInvoices.DataSource = dataTable2;
				this.lblinfo.Text = "No details availablefor invoice: " + Conversions.ToString(inv);
			}
		}

		// Token: 0x04000AF8 RID: 2808
		private string _cnn;
	}
}

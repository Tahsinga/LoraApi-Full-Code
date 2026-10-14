using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000211 RID: 529
	[DesignerGenerated]
	public partial class ViewProductCreditNotes : Form
	{
		// Token: 0x06005EF9 RID: 24313 RVA: 0x00366AC0 File Offset: 0x00364CC0
		public ViewProductCreditNotes()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06005EFC RID: 24316 RVA: 0x00367028 File Offset: 0x00365228
		// (set) Token: 0x06005EFD RID: 24317 RVA: 0x00367032 File Offset: 0x00365232
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x0036703B File Offset: 0x0036523B
		// (set) Token: 0x06005EFF RID: 24319 RVA: 0x00367045 File Offset: 0x00365245
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x0036704E File Offset: 0x0036524E
		// (set) Token: 0x06005F01 RID: 24321 RVA: 0x00367058 File Offset: 0x00365258
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06005F02 RID: 24322 RVA: 0x00367061 File Offset: 0x00365261
		// (set) Token: 0x06005F03 RID: 24323 RVA: 0x0036706C File Offset: 0x0036526C
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

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x003670AF File Offset: 0x003652AF
		// (set) Token: 0x06005F05 RID: 24325 RVA: 0x003670B9 File Offset: 0x003652B9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06005F06 RID: 24326 RVA: 0x003670C2 File Offset: 0x003652C2
		// (set) Token: 0x06005F07 RID: 24327 RVA: 0x003670CC File Offset: 0x003652CC
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06005F08 RID: 24328 RVA: 0x003670D5 File Offset: 0x003652D5
		// (set) Token: 0x06005F09 RID: 24329 RVA: 0x003670E0 File Offset: 0x003652E0
		internal virtual DataGridView dgvCredits
		{
			[CompilerGenerated]
			get
			{
				return this._dgvCredits;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvCredits_CellContentClick);
				DataGridView dataGridView = this._dgvCredits;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvCredits = value;
				dataGridView = this._dgvCredits;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x00367123 File Offset: 0x00365323
		// (set) Token: 0x06005F0B RID: 24331 RVA: 0x0036712D File Offset: 0x0036532D
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x00367138 File Offset: 0x00365338
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadCreditNotes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTStartDate.Value, this.DTEndDate.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying credits. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x003671BC File Offset: 0x003653BC
		private void LoadCreditNotes(int coid, string branch, DateTime sdate, DateTime edate)
		{
			this.dgvCredits.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ViewProductsCredited";
			sqlCommand.Parameters.AddWithValue("startdate", this.DTStartDate.Value);
			sqlCommand.Parameters.AddWithValue("enddate", this.DTEndDate.Value);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvCredits.DataSource = dataTable;
				this.dgvCredits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvCredits.Columns["RefID"].Visible = false;
				this.dgvCredits.Columns["Entry_No"].Visible = false;
				this.dgvCredits.Columns["Done_By"].Visible = false;
				this.dgvCredits.Columns["Product_ID"].Visible = false;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Cancel Credit Note";
				dataGridViewButtonColumn.Text = "Cancel";
				dataGridViewButtonColumn.Name = "cancel";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvCredits.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Reprint Credit Note";
				dataGridViewButtonColumn2.Text = "Reprint";
				dataGridViewButtonColumn2.Name = "Reprint";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvCredits.Columns.Add(dataGridViewButtonColumn2);
			}
			else
			{
				MessageBox.Show("There are no product credits for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvCredits.DataSource = dataTable2;
			}
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x003673F4 File Offset: 0x003655F4
		private void dgvCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "cancel", false) == 0;
				if (flag)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to cancel this selected credit note? " + dataGridView.Rows[e.RowIndex].Cells["RefID"].Value.ToString(), MsgBoxStyle.YesNo, null);
					bool flag2 = dialogResult == DialogResult.Yes;
					if (flag2)
					{
						DateTime dateTime = Conversions.ToDate(dataGridView.Rows[e.RowIndex].Cells["Tran_Date"].Value);
						int num = Convert.ToInt32(dateTime.ToString("yyyyMMdd"));
						this.CancelCreditNote(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["RefID"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Entry_No"].Value), dataGridView.Rows[e.RowIndex].Cells["Credit_Note_Type"].Value.ToString(), Environment.MachineName, num, dateTime, Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value));
						MessageBox.Show("Credit note cancelled successfully.");
						this.LoadCreditNotes(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this.DTStartDate.Value, this.DTEndDate.Value);
					}
				}
				else
				{
					bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Reprint", false) == 0;
					if (flag3)
					{
						ProductsCreditedReport productsCreditedReport = new ProductsCreditedReport();
						productsCreditedReport.invnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Entry_No"].Value);
						productsCreditedReport.revmax_sign = "";
						productsCreditedReport.isEltradeESDfiscal = MyProject.Forms.Form1.FiscalEltradeESD;
						productsCreditedReport.reprint = 0;
						productsCreditedReport.donotlinkinv = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["donotlinkinvStatus"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["donotlinkinvStatus"].Value)));
						productsCreditedReport.oginvnum = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Original_InvoiceNum"].Value);
						productsCreditedReport.ShowDialog(this);
						productsCreditedReport.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing request. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x00367768 File Offset: 0x00365968
		private void CancelCreditNote(int refid, int coid, string branch, int entryno, string paytype, string machinename, int trandate, DateTime trandated, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ReverseProductCreditNote";
			sqlCommand.Parameters.AddWithValue("refid", refid);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("paytype", paytype);
			sqlCommand.Parameters.AddWithValue("cancelledmachinename", machinename);
			sqlCommand.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("trandated", trandated);
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x040029BD RID: 10685
		private string _cnn;
	}
}

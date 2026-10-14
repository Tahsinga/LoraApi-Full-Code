using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000217 RID: 535
	[DesignerGenerated]
	public partial class ViewSMSSent : Form
	{
		// Token: 0x0600601C RID: 24604 RVA: 0x0036EA7C File Offset: 0x0036CC7C
		public ViewSMSSent()
		{
			base.Load += this.ViewSMSSent_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x0036F01B File Offset: 0x0036D21B
		// (set) Token: 0x06006020 RID: 24608 RVA: 0x0036F025 File Offset: 0x0036D225
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x0036F02E File Offset: 0x0036D22E
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x0036F038 File Offset: 0x0036D238
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x0036F041 File Offset: 0x0036D241
		// (set) Token: 0x06006024 RID: 24612 RVA: 0x0036F04C File Offset: 0x0036D24C
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

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06006025 RID: 24613 RVA: 0x0036F08F File Offset: 0x0036D28F
		// (set) Token: 0x06006026 RID: 24614 RVA: 0x0036F09C File Offset: 0x0036D29C
		internal virtual DateTimePicker DTdate
		{
			[CompilerGenerated]
			get
			{
				return this._DTdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTdate_ValueChanged);
				DateTimePicker dateTimePicker = this._DTdate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTdate = value;
				dateTimePicker = this._DTdate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06006027 RID: 24615 RVA: 0x0036F0DF File Offset: 0x0036D2DF
		// (set) Token: 0x06006028 RID: 24616 RVA: 0x0036F0E9 File Offset: 0x0036D2E9
		internal virtual ComboBox cboSMSSubject
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06006029 RID: 24617 RVA: 0x0036F0F2 File Offset: 0x0036D2F2
		// (set) Token: 0x0600602A RID: 24618 RVA: 0x0036F0FC File Offset: 0x0036D2FC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600602B RID: 24619 RVA: 0x0036F105 File Offset: 0x0036D305
		// (set) Token: 0x0600602C RID: 24620 RVA: 0x0036F10F File Offset: 0x0036D30F
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600602D RID: 24621 RVA: 0x0036F118 File Offset: 0x0036D318
		// (set) Token: 0x0600602E RID: 24622 RVA: 0x0036F122 File Offset: 0x0036D322
		internal virtual DataGridView dgvSMSs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x0036F12C File Offset: 0x0036D32C
		private void ViewSMSSent_Load(object sender, EventArgs e)
		{
			try
			{
				this.ListSMSBatches(10, Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occurred loading page. Detail: " + ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x0036F1A0 File Offset: 0x0036D3A0
		private void listSMS(int batchno, string batchSubject)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SP_ViewSMSSent";
			sqlCommand.Parameters.AddWithValue("batchNo", batchno);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvSMSs.DataSource = dataTable;
			this.dgvSMSs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox2.Text = batchSubject;
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x0036F22C File Offset: 0x0036D42C
		private void ListSMSBatches(int schoolid, int dateb4)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SP_ViewSMSBatches";
			sqlCommand.Parameters.AddWithValue("OrgID", schoolid);
			sqlCommand.Parameters.AddWithValue("DateBefore", dateb4);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboSMSSubject.DataSource = dataTable;
			this.cboSMSSubject.ValueMember = "SMSBatch";
			this.cboSMSSubject.DisplayMember = "Subject";
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x0036F2D4 File Offset: 0x0036D4D4
		private void DTdate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.ListSMSBatches(10, Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error listing sms batches. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0036F344 File Offset: 0x0036D544
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.listSMS(Conversions.ToInteger(this.cboSMSSubject.SelectedValue), this.cboSMSSubject.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("AN error occurred while loading the page. Detail: " + ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x04002A48 RID: 10824
		private string _cnn;
	}
}

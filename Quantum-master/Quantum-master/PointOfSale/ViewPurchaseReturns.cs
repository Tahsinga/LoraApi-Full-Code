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
	// Token: 0x02000214 RID: 532
	[DesignerGenerated]
	public partial class ViewPurchaseReturns : Form
	{
		// Token: 0x06005F3C RID: 24380 RVA: 0x00368AF0 File Offset: 0x00366CF0
		public ViewPurchaseReturns()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x00368FD2 File Offset: 0x003671D2
		// (set) Token: 0x06005F40 RID: 24384 RVA: 0x00368FDC File Offset: 0x003671DC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x00368FE5 File Offset: 0x003671E5
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x00368FF0 File Offset: 0x003671F0
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

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x00369033 File Offset: 0x00367233
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x0036903D File Offset: 0x0036723D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06005F45 RID: 24389 RVA: 0x00369046 File Offset: 0x00367246
		// (set) Token: 0x06005F46 RID: 24390 RVA: 0x00369050 File Offset: 0x00367250
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x00369059 File Offset: 0x00367259
		// (set) Token: 0x06005F48 RID: 24392 RVA: 0x00369063 File Offset: 0x00367263
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06005F49 RID: 24393 RVA: 0x0036906C File Offset: 0x0036726C
		// (set) Token: 0x06005F4A RID: 24394 RVA: 0x00369076 File Offset: 0x00367276
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x0036907F File Offset: 0x0036727F
		// (set) Token: 0x06005F4C RID: 24396 RVA: 0x00369089 File Offset: 0x00367289
		internal virtual DataGridView dgvReturns
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x00369094 File Offset: 0x00367294
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.GetReturns((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error viewing purchase returns. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x00369128 File Offset: 0x00367328
		private void GetReturns(int startdate, int enddate)
		{
			DataTable dataTable = new DataTable();
			this.dgvReturns.DataSource = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPurchaseReturns";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable2);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvReturns.DataSource = dataTable2;
				this.dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				MessageBox.Show("There are no returns for the selected period.");
			}
		}

		// Token: 0x040029D8 RID: 10712
		private string _cnn;
	}
}

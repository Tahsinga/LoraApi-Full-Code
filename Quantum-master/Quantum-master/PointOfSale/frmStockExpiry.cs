using System;
using System.Collections;
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
	// Token: 0x02000062 RID: 98
	[DesignerGenerated]
	public partial class frmStockExpiry : Form
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x000BEA24 File Offset: 0x000BCC24
		public frmStockExpiry()
		{
			base.Load += this.frmStockExpiry_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x000BF179 File Offset: 0x000BD379
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x000BF184 File Offset: 0x000BD384
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000BF1C7 File Offset: 0x000BD3C7
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x000BF1D1 File Offset: 0x000BD3D1
		internal virtual DataGridView dgvBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x000BF1DA File Offset: 0x000BD3DA
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x000BF1E4 File Offset: 0x000BD3E4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x000BF1ED File Offset: 0x000BD3ED
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x000BF1F8 File Offset: 0x000BD3F8
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

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000BF23B File Offset: 0x000BD43B
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x000BF245 File Offset: 0x000BD445
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x000BF24E File Offset: 0x000BD44E
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x000BF258 File Offset: 0x000BD458
		internal virtual DateTimePicker dtExp
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000BF261 File Offset: 0x000BD461
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x000BF26B File Offset: 0x000BD46B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x000BF274 File Offset: 0x000BD474
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x000BF27E File Offset: 0x000BD47E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x000BF287 File Offset: 0x000BD487
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x000BF294 File Offset: 0x000BD494
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x000BF2D7 File Offset: 0x000BD4D7
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x000BF2E1 File Offset: 0x000BD4E1
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000BF2EC File Offset: 0x000BD4EC
		private void frmStockExpiry_Load(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000BF334 File Offset: 0x000BD534
		private DataTable GetExpBatchDetails(int prodtid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectBatchExpiry";
			sqlCommand.Parameters.AddWithValue("prodtid", prodtid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000BF39C File Offset: 0x000BD59C
		private decimal GetTotalSales(int prodtid)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockOut";
			sqlCommand.Parameters.AddWithValue("productid", prodtid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0m;
				}
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000BF4E0 File Offset: 0x000BD6E0
		private string GetProdtDesc(int prodtid)
		{
			string text = "";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["ProductDesc"]);
			}
			return text;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000BF5A4 File Offset: 0x000BD7A4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetProductsExpiringCurrent";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.Parameters.AddWithValue("expdate", Convert.ToInt32(this.dtExp.Value.ToString("yyyyMMdd")));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.dgvBal.DataSource = dataTable;
				this.ColorCode();
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Report loaded.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. detail: " + ex.Message);
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000BF6D8 File Offset: 0x000BD8D8
		private void ColorCode()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvBal.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectLessEqual(dataGridViewRow.Cells["ExpiryDate"].Value, DateTime.Today.ToString("yyyyMMdd"), false);
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
					}
					else
					{
						bool flag2 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(dataGridViewRow.Cells["ExpiryDate"].Value, DateTime.Today.ToString("yyyyMMdd"), false), Operators.CompareObjectLessEqual(dataGridViewRow.Cells["ExpiryDate"].Value, DateAndTime.DateAdd(DateInterval.Month, 1.0, DateTime.Today).ToString("yyyyMMdd"), false)));
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
						}
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

		// Token: 0x0600144B RID: 5195 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000BF820 File Offset: 0x000BDA20
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvBal.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvBal, this.SaveFileDialog1.FileName);
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

		// Token: 0x04000A47 RID: 2631
		private string _cnn;

		// Token: 0x04000A48 RID: 2632
		private PublicFunctions pf;
	}
}

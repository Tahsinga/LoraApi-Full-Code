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
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	public partial class CS_EODEnter : Form
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x00074B3C File Offset: 0x00072D3C
		public CS_EODEnter()
		{
			base.Load += this.CS_EODEnter_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000751BE File Offset: 0x000733BE
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000751C8 File Offset: 0x000733C8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000751D1 File Offset: 0x000733D1
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000751DB File Offset: 0x000733DB
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000751E4 File Offset: 0x000733E4
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000751EE File Offset: 0x000733EE
		internal virtual DateTimePicker dtTranDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000751F7 File Offset: 0x000733F7
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00075201 File Offset: 0x00073401
		internal virtual Label lblBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0007520A File Offset: 0x0007340A
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00075214 File Offset: 0x00073414
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0007521D File Offset: 0x0007341D
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00075227 File Offset: 0x00073427
		internal virtual Label lblTeller
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00075230 File Offset: 0x00073430
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0007523A File Offset: 0x0007343A
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00075243 File Offset: 0x00073443
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00075250 File Offset: 0x00073450
		internal virtual DataGridView dgvCashUp
		{
			[CompilerGenerated]
			get
			{
				return this._dgvCashUp;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.dgvBatches_EditingControlShowing);
				DataGridView dataGridView = this._dgvCashUp;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
				}
				this._dgvCashUp = value;
				dataGridView = this._dgvCashUp;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
				}
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00075293 File Offset: 0x00073493
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x000752A0 File Offset: 0x000734A0
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000752E3 File Offset: 0x000734E3
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x000752F0 File Offset: 0x000734F0
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00075334 File Offset: 0x00073534
		private void CS_EODEnter_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.backdatevalue == 1;
				if (flag)
				{
					this.dtTranDate.Enabled = true;
				}
				else
				{
					this.dtTranDate.Enabled = false;
				}
				this.lblBranch.Text = MyProject.Forms.Form1.branch;
				this.lblTeller.Text = MyProject.Forms.Form1.username;
				this.LoadPayMethods();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000753F0 File Offset: 0x000735F0
		private void LoadPayMethods()
		{
			this.dgvCashUp.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvCashUp.DataSource = dataTable;
			this.dgvCashUp.Columns["PaymentMethodID"].ReadOnly = true;
			this.dgvCashUp.Columns["PaymentMethodID"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvCashUp.Columns["PaymentMethodID"].HeaderText = "ID";
			this.dgvCashUp.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			this.dgvCashUp.Columns["PaymentMethodDesc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvCashUp.Columns["PaymentMethodDesc"].ReadOnly = true;
			this.dgvCashUp.Columns["Uploaded"].Visible = false;
			this.dgvCashUp.Columns["DiscountPerc"].Visible = false;
			this.dgvCashUp.Columns["FiscalGroup"].Visible = false;
			this.dgvCashUp.Columns["rate"].Visible = false;
			this.dgvCashUp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.Name = "colAmtSaved";
			dataGridViewTextBoxColumn.ReadOnly = true;
			dataGridViewTextBoxColumn.DefaultCellStyle.BackColor = Color.LightBlue;
			dataGridViewTextBoxColumn.HeaderText = "Total Saved for Cash Box For Day";
			this.dgvCashUp.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2.Name = "colAmtEntered";
			dataGridViewTextBoxColumn2.HeaderText = "Enter Cash in Cash Box For Day";
			this.dgvCashUp.Columns.Add(dataGridViewTextBoxColumn2);
			DataTable dataTable2 = this.LoadSavedAmts();
			try
			{
				foreach (object obj in dataTable2.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvCashUp.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["paymentmethodid"].Value, dataRow["paymentmethodid"], false);
							if (flag)
							{
								dataGridViewRow.Cells["colAmtSaved"].Value = RuntimeHelpers.GetObjectValue(dataRow["sum_amount"]);
							}
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

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00075750 File Offset: 0x00073950
		private DataTable LoadSavedAmts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CS_SelectEODEntered";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.lblBranch.Text);
			sqlCommand.Parameters.AddWithValue("trandate", this.dtTranDate.Value.Date);
			sqlCommand.Parameters.AddWithValue("enteredby", this.lblTeller.Text);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0007582C File Offset: 0x00073A2C
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			try
			{
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunCSEntered");
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.StoredProcedure;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvCashUp.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["colAmtEntered"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["colAmtEntered"].Value)));
						bool flag = decimal.Compare(num, 0m) != 0;
						if (flag)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "CS_InsertEODCash";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", this.lblBranch.Text);
							sqlCommand.Parameters.AddWithValue("paymentmethodid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["paymentmethodid"].Value));
							sqlCommand.Parameters.AddWithValue("rate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["rate"].Value));
							sqlCommand.Parameters.AddWithValue("amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["colAmtEntered"].Value));
							sqlCommand.Parameters.AddWithValue("teller", this.lblTeller.Text);
							sqlCommand.Parameters.AddWithValue("trandate", this.dtTranDate.Value);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.ExecuteNonQuery();
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
				sqlTransaction.Commit();
				sqlConnection.Close();
				MessageBox.Show("Details saved.");
				this.LoadPayMethods();
			}
			catch (SqlException ex)
			{
				bool flag2 = ex.Number == 2627;
				if (flag2)
				{
					MessageBox.Show("Cannot enter duplicate values For the same day.");
				}
				else
				{
					MessageBox.Show("Error. Detail:  " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving cash up details. " + ex2.Message);
				SqlTransaction sqlTransaction;
				sqlTransaction.Rollback();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00075B54 File Offset: 0x00073D54
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete cash up entered for the " + this.dtTranDate.Value.ToShortDateString(), MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "CS_DeleteCashUp";
					sqlCommand.Parameters.AddWithValue("trandate", this.dtTranDate.Value);
					sqlCommand.Parameters.AddWithValue("teller", this.lblTeller.Text);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", this.lblBranch.Text);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					MessageBox.Show("Cash Up entered deleted.");
					this.LoadPayMethods();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting. Detail:  " + ex.Message);
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00075CDC File Offset: 0x00073EDC
		private void dgvBatches_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			bool flag = e.Control is TextBox;
			if (flag)
			{
				TextBox textBox = e.Control as TextBox;
				textBox.KeyPress -= this.tb_KeyPress;
				bool flag2 = this.dgvCashUp.CurrentCell.ColumnIndex == 6;
				if (flag2)
				{
					textBox.KeyPress += this.tb_KeyPress;
				}
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00075D4C File Offset: 0x00073F4C
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000585 RID: 1413
		private string _cnn;
	}
}

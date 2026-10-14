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
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Approvals : UserControl
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00015AD8 File Offset: 0x00013CD8
		public Approvals()
		{
			base.Load += this.Approvals_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.sales_cancellations_pending_dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00016265 File Offset: 0x00014465
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0001626F File Offset: 0x0001446F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00016278 File Offset: 0x00014478
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00016282 File Offset: 0x00014482
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001628B File Offset: 0x0001448B
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00016298 File Offset: 0x00014498
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000162DB File Offset: 0x000144DB
		// (set) Token: 0x0600027C RID: 636 RVA: 0x000162E8 File Offset: 0x000144E8
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0001632B File Offset: 0x0001452B
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00016338 File Offset: 0x00014538
		internal virtual DataGridView dgvApprovals
		{
			[CompilerGenerated]
			get
			{
				return this._dgvApprovals;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvApprovals_CellContentClick);
				DataGridView dataGridView = this._dgvApprovals;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvApprovals = value;
				dataGridView = this._dgvApprovals;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0001637B File Offset: 0x0001457B
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00016388 File Offset: 0x00014588
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000163CB File Offset: 0x000145CB
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000163D8 File Offset: 0x000145D8
		internal virtual DataGridView dgvSummary
		{
			[CompilerGenerated]
			get
			{
				return this._dgvSummary;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvSummary_CellContentClick);
				DataGridView dataGridView = this._dgvSummary;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvSummary = value;
				dataGridView = this._dgvSummary;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001641B File Offset: 0x0001461B
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00016425 File Offset: 0x00014625
		internal virtual Label lblinfor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001642E File Offset: 0x0001462E
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00016438 File Offset: 0x00014638
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00016441 File Offset: 0x00014641
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0001644B File Offset: 0x0001464B
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00016454 File Offset: 0x00014654
		private void Approvals_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadSummary();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000164AC File Offset: 0x000146AC
		private void GetPendingProductChanges()
		{
			DataTable dataTable = new DataTable();
			this.dat = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ViewPendingApproval";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00016528 File Offset: 0x00014728
		private void FetchAllProducts2()
		{
			Cursor.Current = Cursors.WaitCursor;
			this.dgvApprovals.Columns.Clear();
			int count = this.dat.Rows.Count;
			bool flag = count > 0;
			if (flag)
			{
				this.dgvApprovals.DataSource = this.dat;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Approve";
				dataGridViewButtonColumn.Text = "Approve";
				dataGridViewButtonColumn.Name = "Approve";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvApprovals.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Deny";
				dataGridViewButtonColumn2.Text = "Deny";
				dataGridViewButtonColumn2.Name = "Deny";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvApprovals.Columns.Add(dataGridViewButtonColumn2);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Select?";
				dataGridViewCheckBoxColumn.Name = "Select";
				this.dgvApprovals.Columns.Insert(1, dataGridViewCheckBoxColumn);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvApprovals.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["Select"].Value = 0;
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
				Cursor.Current = Cursors.Default;
				this.lblinfor.Text = "VIEWING PRODUCT DETAIL PENDING CHANGES";
			}
			else
			{
				this.lblinfor.Text = "No product detail pending changes to view";
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000166E8 File Offset: 0x000148E8
		private void dgvApprovals_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Approve", false) == 0;
					if (flag2)
					{
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.Connection = sqlConnection;
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
						sqlCommand.Transaction = sqlTransaction;
						try
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "EffectApproval";
							sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["ProductID"].Value));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", "");
							sqlCommand.Parameters.AddWithValue("date_approved", DateTime.Now);
							sqlCommand.Parameters.AddWithValue("approved_by", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("audit_entryno", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["approval_audit"].Value));
							sqlCommand.Parameters.AddWithValue("approved", 1);
							sqlCommand.ExecuteNonQuery();
							sqlTransaction.Commit();
							sqlCommand.Connection.Close();
							MessageBox.Show("Product: " + this.dgvApprovals.Rows[e.RowIndex].Cells["new_productdesc"].Value.ToString() + " changes approved.");
							this.LoadSummary();
							this.FetchAllProducts2();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error effecting change. Detail: " + ex.Message);
						}
					}
					else
					{
						bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Deny", false) == 0;
						if (flag3)
						{
							SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
							SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
							sqlCommand2.Connection = sqlConnection2;
							sqlConnection2.Open();
							SqlTransaction sqlTransaction2 = sqlConnection2.BeginTransaction("RunProductDetailsSaveAll");
							sqlCommand2.Transaction = sqlTransaction2;
							try
							{
								sqlCommand2.Parameters.Clear();
								sqlCommand2.CommandType = CommandType.StoredProcedure;
								sqlCommand2.CommandText = "EffectApprovalDeny";
								sqlCommand2.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["ProductID"].Value));
								sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand2.Parameters.AddWithValue("branch", "");
								sqlCommand2.Parameters.AddWithValue("date_approved", DateTime.Now);
								sqlCommand2.Parameters.AddWithValue("approved_by", MyProject.Forms.Form1.username);
								sqlCommand2.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand2.Parameters.AddWithValue("audit_entryno", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["approval_audit"].Value));
								sqlCommand2.Parameters.AddWithValue("approved", 0);
								sqlCommand2.ExecuteNonQuery();
								sqlTransaction2.Commit();
								sqlCommand2.Connection.Close();
								MessageBox.Show("Product: " + this.dgvApprovals.Rows[e.RowIndex].Cells["new_productdesc"].Value.ToString() + " changes denied.");
								this.LoadSummary();
								this.FetchAllProducts2();
							}
							catch (Exception ex2)
							{
								MessageBox.Show("Error effecting change. Detail: " + ex2.Message);
							}
						}
						else
						{
							bool flag4 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Approve_Cancel", false) == 0;
							if (flag4)
							{
								SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
								SqlCommand sqlCommand3 = sqlConnection3.CreateCommand();
								sqlCommand3.CommandType = CommandType.StoredProcedure;
								sqlCommand3.CommandText = "ApproveCancelSale";
								sqlCommand3.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
								sqlCommand3.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
								sqlCommand3.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
								sqlCommand3.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand3.Parameters.AddWithValue("branch", this.cboBranch.Text);
								sqlCommand3.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand3.Parameters.AddWithValue("approved", 1);
								using (sqlConnection3)
								{
									sqlConnection3.Open();
									sqlCommand3.ExecuteNonQuery();
									sqlConnection3.Close();
								}
								MessageBox.Show("Sales cancellation approved.");
								this.LoadSummary();
								this.LoadSalesCancellations();
							}
							else
							{
								bool flag5 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Deny_Cancel", false) == 0;
								if (flag5)
								{
									SqlConnection sqlConnection5 = new SqlConnection(this._cnn);
									SqlCommand sqlCommand4 = sqlConnection5.CreateCommand();
									sqlCommand4.CommandType = CommandType.StoredProcedure;
									sqlCommand4.CommandText = "ApproveCancelSale";
									sqlCommand4.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(this.dgvApprovals.Rows[e.RowIndex].Cells["Invoice_Number"].Value));
									sqlCommand4.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
									sqlCommand4.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand4.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand4.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand4.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand4.Parameters.AddWithValue("approved", 0);
									using (sqlConnection5)
									{
										sqlConnection5.Open();
										sqlCommand4.ExecuteNonQuery();
										sqlConnection5.Close();
									}
									MessageBox.Show("Sales cancellation denied.");
									this.LoadSummary();
									this.LoadSalesCancellations();
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error processing button click. Detail: " + ex3.Message);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00016FD8 File Offset: 0x000151D8
		private void Label2_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to dispose form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00017028 File Offset: 0x00015228
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvApprovals.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text = Conversions.ToString(dataGridViewRow.Cells[1].Value);
						bool flag = (text == null) | (Operators.CompareString(text, "False", false) == 0);
						if (!flag)
						{
							bool flag2 = Operators.CompareString(this.lblinfor.Text, "VIEWING PRODUCT DETAIL PENDING CHANGES", false) == 0;
							if (flag2)
							{
								SqlConnection sqlConnection = new SqlConnection(this._cnn);
								SqlCommand sqlCommand = sqlConnection.CreateCommand();
								sqlCommand.Connection = sqlConnection;
								sqlConnection.Open();
								SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
								sqlCommand.Transaction = sqlTransaction;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "EffectApproval";
								sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", "");
								sqlCommand.Parameters.AddWithValue("date_approved", DateTime.Now);
								sqlCommand.Parameters.AddWithValue("approved_by", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("audit_entryno", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["approval_audit"].Value));
								sqlCommand.Parameters.AddWithValue("approved", 1);
								sqlCommand.ExecuteNonQuery();
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
							}
							else
							{
								bool flag3 = Operators.CompareString(this.lblinfor.Text, "VIEWING CANCELLED SALES PENDING APPROVAL", false) == 0;
								if (flag3)
								{
									SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
									SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
									sqlCommand2.CommandType = CommandType.StoredProcedure;
									sqlCommand2.CommandText = "ApproveCancelSale";
									sqlCommand2.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Invoice_Number"].Value));
									sqlCommand2.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
									sqlCommand2.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand2.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand2.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand2.Parameters.AddWithValue("approved", 1);
									sqlCommand2.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
									using (sqlConnection2)
									{
										sqlConnection2.Open();
										sqlCommand2.ExecuteNonQuery();
										sqlConnection2.Close();
									}
								}
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
				MessageBox.Show("Changes approved successfully.");
				bool flag4 = Operators.CompareString(this.lblinfor.Text, "VIEWING PRODUCT DETAIL PENDING CHANGES", false) == 0;
				if (flag4)
				{
					this.GetPendingProductChanges();
					this.FetchAllProducts2();
				}
				else
				{
					bool flag5 = Operators.CompareString(this.lblinfor.Text, "VIEWING CANCELLED SALES PENDING APPROVAL", false) == 0;
					if (flag5)
					{
						this.GetSalesCancelledPendingApproval();
						this.LoadSalesCancellations();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000174D0 File Offset: 0x000156D0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvApprovals.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text = Conversions.ToString(dataGridViewRow.Cells[1].Value);
						bool flag = (text == null) | (Operators.CompareString(text, "False", false) == 0);
						if (!flag)
						{
							bool flag2 = Operators.CompareString(this.lblinfor.Text, "VIEWING PRODUCT DETAIL PENDING CHANGES", false) == 0;
							if (flag2)
							{
								SqlConnection sqlConnection = new SqlConnection(this._cnn);
								SqlCommand sqlCommand = sqlConnection.CreateCommand();
								sqlCommand.Connection = sqlConnection;
								sqlConnection.Open();
								SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
								sqlCommand.Transaction = sqlTransaction;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "EffectApprovalDeny";
								sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", "");
								sqlCommand.Parameters.AddWithValue("date_approved", DateTime.Now);
								sqlCommand.Parameters.AddWithValue("approved_by", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("audit_entryno", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["approval_audit"].Value));
								sqlCommand.Parameters.AddWithValue("approved", 0);
								sqlCommand.ExecuteNonQuery();
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
							}
							else
							{
								bool flag3 = Operators.CompareString(this.lblinfor.Text, "VIEWING CANCELLED SALES PENDING APPROVAL", false) == 0;
								if (flag3)
								{
									SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
									SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
									sqlCommand2.CommandType = CommandType.StoredProcedure;
									sqlCommand2.CommandText = "ApproveCancelSale";
									sqlCommand2.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Invoice_Number"].Value));
									sqlCommand2.Parameters.AddWithValue("Cancelledby", MyProject.Forms.Form1.username);
									sqlCommand2.Parameters.AddWithValue("datecancelled", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand2.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand2.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand2.Parameters.AddWithValue("approved", 0);
									using (sqlConnection2)
									{
										sqlConnection2.Open();
										sqlCommand2.ExecuteNonQuery();
										sqlConnection2.Close();
									}
								}
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
				MessageBox.Show("Changes denied approval successfully.");
				bool flag4 = Operators.CompareString(this.lblinfor.Text, "VIEWING PRODUCT DETAIL PENDING CHANGES", false) == 0;
				if (flag4)
				{
					this.LoadSummary();
					this.FetchAllProducts2();
				}
				else
				{
					bool flag5 = Operators.CompareString(this.lblinfor.Text, "VIEWING CANCELLED SALES PENDING APPROVAL", false) == 0;
					if (flag5)
					{
						this.LoadSummary();
						this.LoadSalesCancellations();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00017948 File Offset: 0x00015B48
		private void LoadSummary()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Transaction_Type");
			dataTable.Columns.Add("Pending_Approval");
			this.GetSalesCancelledPendingApproval();
			this.GetPendingProductChanges();
			string[] array = new string[]
			{
				"Product Details Change",
				Conversions.ToString(this.dat.Rows.Count)
			};
			dataTable.Rows.Add(array);
			string[] array2 = new string[]
			{
				"Sales Cancellations",
				Conversions.ToString(this.sales_cancellations_pending_dat.Rows.Count)
			};
			dataTable.Rows.Add(array2);
			this.dgvSummary.DataSource = dataTable;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "View";
			dataGridViewButtonColumn.Text = "View";
			dataGridViewButtonColumn.Name = "View";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvSummary.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00017A48 File Offset: 0x00015C48
		private void GetSalesCancelledPendingApproval()
		{
			DataTable dataTable = new DataTable();
			this.sales_cancellations_pending_dat = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingSalesCancellations";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.sales_cancellations_pending_dat);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00017AE0 File Offset: 0x00015CE0
		private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
					if (flag2)
					{
						string text = Conversions.ToString(this.dgvSummary.Rows[e.RowIndex].Cells[1].Value);
						bool flag3 = Operators.CompareString(text, "Product Details Change", false) == 0;
						if (flag3)
						{
							this.FetchAllProducts2();
						}
						else
						{
							bool flag4 = Operators.CompareString(text, "Sales Cancellations", false) == 0;
							if (flag4)
							{
								this.LoadSalesCancellations();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form.");
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00017BE8 File Offset: 0x00015DE8
		private void LoadSalesCancellations()
		{
			Cursor.Current = Cursors.WaitCursor;
			this.dgvApprovals.Columns.Clear();
			int count = this.sales_cancellations_pending_dat.Rows.Count;
			bool flag = count > 0;
			if (flag)
			{
				this.dgvApprovals.DataSource = this.sales_cancellations_pending_dat;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Cancel Sale";
				dataGridViewButtonColumn.Text = "Approve_Cancel";
				dataGridViewButtonColumn.Name = "Approve_Cancel";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvApprovals.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Deny_Cancel";
				dataGridViewButtonColumn2.Text = "Deny_Cancel";
				dataGridViewButtonColumn2.Name = "Deny_Cancel";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.dgvApprovals.Columns.Add(dataGridViewButtonColumn2);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Select?";
				dataGridViewCheckBoxColumn.Name = "Select";
				this.dgvApprovals.Columns.Insert(1, dataGridViewCheckBoxColumn);
				Cursor.Current = Cursors.Default;
				this.lblinfor.Text = "VIEWING CANCELLED SALES PENDING APPROVAL";
			}
			else
			{
				this.lblinfor.Text = "No pending cancelled sales to view";
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00017D30 File Offset: 0x00015F30
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

		// Token: 0x0400011B RID: 283
		private string _cnn;

		// Token: 0x0400011C RID: 284
		private DataTable dat;

		// Token: 0x0400011D RID: 285
		private DataTable sales_cancellations_pending_dat;
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x02000150 RID: 336
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class BillingCustomerTransactionsTableAdapter : Component
	{
		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x0018793D File Offset: 0x00185B3D
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x00187947 File Offset: 0x00185B47
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00187950 File Offset: 0x00185B50
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BillingCustomerTransactionsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00187964 File Offset: 0x00185B64
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				bool flag = this._adapter == null;
				if (flag)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x00187994 File Offset: 0x00185B94
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x001879C4 File Offset: 0x00185BC4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				bool flag = this._connection == null;
				if (flag)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				bool flag = this.Adapter.InsertCommand != null;
				if (flag)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				bool flag2 = this.Adapter.DeleteCommand != null;
				if (flag2)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				bool flag3 = this.Adapter.UpdateCommand != null;
				if (flag3)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						bool flag4 = this.CommandCollection[i] != null;
						if (flag4)
						{
							this.CommandCollection[i].Connection = value;
						}
					}
				}
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x00187A88 File Offset: 0x00185C88
		// (set) Token: 0x06002DAC RID: 11692 RVA: 0x00187AA0 File Offset: 0x00185CA0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						this.CommandCollection[i].Transaction = this._transaction;
					}
					bool flag = this.Adapter != null && this.Adapter.DeleteCommand != null;
					if (flag)
					{
						this.Adapter.DeleteCommand.Transaction = this._transaction;
					}
					bool flag2 = this.Adapter != null && this.Adapter.InsertCommand != null;
					if (flag2)
					{
						this.Adapter.InsertCommand.Transaction = this._transaction;
					}
					bool flag3 = this.Adapter != null && this.Adapter.UpdateCommand != null;
					if (flag3)
					{
						this.Adapter.UpdateCommand.Transaction = this._transaction;
					}
				}
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x00187B88 File Offset: 0x00185D88
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				bool flag = this._commandCollection == null;
				if (flag)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x00187BB8 File Offset: 0x00185DB8
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x00187BD0 File Offset: 0x00185DD0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00187BDC File Offset: 0x00185DDC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "BillingCustomerTransactions";
			dataTableMapping.ColumnMappings.Add("Customer_Name", "Customer_Name");
			dataTableMapping.ColumnMappings.Add("Transaction_Type", "Transaction_Type");
			dataTableMapping.ColumnMappings.Add("Sales_Inv_Number", "Sales_Inv_Number");
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("TranTime", "TranTime");
			dataTableMapping.ColumnMappings.Add("Teller", "Teller");
			dataTableMapping.ColumnMappings.Add("Terms", "Terms");
			dataTableMapping.ColumnMappings.Add("Due_Date", "Due_Date");
			dataTableMapping.ColumnMappings.Add("Payment_Method", "Payment_Method");
			dataTableMapping.ColumnMappings.Add("Payment_Receipt_Num", "Payment_Receipt_Num");
			dataTableMapping.ColumnMappings.Add("Comment", "Comment");
			dataTableMapping.ColumnMappings.Add("rate", "rate");
			dataTableMapping.ColumnMappings.Add("Amount_Billed", "Amount_Billed");
			dataTableMapping.ColumnMappings.Add("Amount_Paid", "Amount_Paid");
			dataTableMapping.ColumnMappings.Add("Actual_Billed", "Actual_Billed");
			dataTableMapping.ColumnMappings.Add("Actual_Paid", "Actual_Paid");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00187D86 File Offset: 0x00185F86
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00187DAC File Offset: 0x00185FAC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.BillingCustomerTransactions";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@customerentryno", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@saletype", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00187FA0 File Offset: 0x001861A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.BillingCustomerTransactionsDataTable dataTable, int? customerentryno, int? coid, string branch, int? startdate, int? enddate, int? saletype)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = customerentryno != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = customerentryno.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool flag4 = startdate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = enddate != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = saletype != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = saletype.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x001881FC File Offset: 0x001863FC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.BillingCustomerTransactionsDataTable GetData(int? customerentryno, int? coid, string branch, int? startdate, int? enddate, int? saletype)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = customerentryno != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = customerentryno.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool flag4 = startdate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = enddate != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = saletype != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = saletype.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			POSDataSet.BillingCustomerTransactionsDataTable billingCustomerTransactionsDataTable = new POSDataSet.BillingCustomerTransactionsDataTable();
			this.Adapter.Fill(billingCustomerTransactionsDataTable);
			return billingCustomerTransactionsDataTable;
		}

		// Token: 0x040013B4 RID: 5044
		private SqlConnection _connection;

		// Token: 0x040013B5 RID: 5045
		private SqlTransaction _transaction;

		// Token: 0x040013B6 RID: 5046
		private SqlCommand[] _commandCollection;

		// Token: 0x040013B7 RID: 5047
		private bool _clearBeforeFill;
	}
}

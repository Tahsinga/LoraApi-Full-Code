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
	// Token: 0x0200012C RID: 300
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForPeriodInvoiceNumbersTableAdapter : Component
	{
		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x0017494D File Offset: 0x00172B4D
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x00174957 File Offset: 0x00172B57
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00174960 File Offset: 0x00172B60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForPeriodInvoiceNumbersTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x00174974 File Offset: 0x00172B74
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

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x001749A4 File Offset: 0x00172BA4
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x001749D4 File Offset: 0x00172BD4
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

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x00174A98 File Offset: 0x00172C98
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x00174AB0 File Offset: 0x00172CB0
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00174B98 File Offset: 0x00172D98
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x00174BC8 File Offset: 0x00172DC8
		// (set) Token: 0x06002B6B RID: 11115 RVA: 0x00174BE0 File Offset: 0x00172DE0
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

		// Token: 0x06002B6C RID: 11116 RVA: 0x00174BEC File Offset: 0x00172DEC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForPeriodInvoiceNumbers";
			dataTableMapping.ColumnMappings.Add("InvoiceNum", "InvoiceNum");
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("Customer", "Customer");
			dataTableMapping.ColumnMappings.Add("SaleType", "SaleType");
			dataTableMapping.ColumnMappings.Add("DoneBy", "DoneBy");
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("TaxAmount", "TaxAmount");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			dataTableMapping.ColumnMappings.Add("Subtotal", "Subtotal");
			dataTableMapping.ColumnMappings.Add("ProductDesc2", "ProductDesc2");
			dataTableMapping.ColumnMappings.Add("UOM", "UOM");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00174D80 File Offset: 0x00172F80
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00174DA4 File Offset: 0x00172FA4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForPeriodInvoiceNumbers";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00174F60 File Offset: 0x00173160
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForPeriodInvoiceNumbersDataTable dataTable, int? coid, string branch, int? startdate, int? enddate, string doneby)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			bool flag3 = startdate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = enddate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = doneby == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = doneby;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00175154 File Offset: 0x00173354
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForPeriodInvoiceNumbersDataTable GetData(int? coid, string branch, int? startdate, int? enddate, string doneby)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			bool flag3 = startdate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = enddate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = doneby == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = doneby;
			}
			POSDataSet.SalesForPeriodInvoiceNumbersDataTable salesForPeriodInvoiceNumbersDataTable = new POSDataSet.SalesForPeriodInvoiceNumbersDataTable();
			this.Adapter.Fill(salesForPeriodInvoiceNumbersDataTable);
			return salesForPeriodInvoiceNumbersDataTable;
		}

		// Token: 0x04001300 RID: 4864
		private SqlConnection _connection;

		// Token: 0x04001301 RID: 4865
		private SqlTransaction _transaction;

		// Token: 0x04001302 RID: 4866
		private SqlCommand[] _commandCollection;

		// Token: 0x04001303 RID: 4867
		private bool _clearBeforeFill;
	}
}

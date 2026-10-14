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
	// Token: 0x020000BA RID: 186
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class StockMovementByValuePerBranchTableAdapter : Component
	{
		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x0013C32F File Offset: 0x0013A52F
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0013C339 File Offset: 0x0013A539
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0013C342 File Offset: 0x0013A542
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public StockMovementByValuePerBranchTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x0013C354 File Offset: 0x0013A554
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

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0013C384 File Offset: 0x0013A584
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x0013C3B4 File Offset: 0x0013A5B4
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x0013C478 File Offset: 0x0013A678
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x0013C490 File Offset: 0x0013A690
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0013C578 File Offset: 0x0013A778
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

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0013C5A8 File Offset: 0x0013A7A8
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0013C5C0 File Offset: 0x0013A7C0
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

		// Token: 0x06002447 RID: 9287 RVA: 0x0013C5CC File Offset: 0x0013A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "StockMovementByValuePerBranch";
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("Product_Code", "Product_Code");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Qty_Sold", "Qty_Sold");
			dataTableMapping.ColumnMappings.Add("Gross_Profit", "Gross_Profit");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0013C684 File Offset: 0x0013A884
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0013C6A8 File Offset: 0x0013A8A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.StockMovementByValuePerBranch";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0013C828 File Offset: 0x0013AA28
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.StockMovementByValuePerBranchDataTable dataTable, int? startdate, int? enddate, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0013C9D0 File Offset: 0x0013ABD0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.StockMovementByValuePerBranchDataTable GetData(int? startdate, int? enddate, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			POSDataSet.StockMovementByValuePerBranchDataTable stockMovementByValuePerBranchDataTable = new POSDataSet.StockMovementByValuePerBranchDataTable();
			this.Adapter.Fill(stockMovementByValuePerBranchDataTable);
			return stockMovementByValuePerBranchDataTable;
		}

		// Token: 0x040010C6 RID: 4294
		private SqlConnection _connection;

		// Token: 0x040010C7 RID: 4295
		private SqlTransaction _transaction;

		// Token: 0x040010C8 RID: 4296
		private SqlCommand[] _commandCollection;

		// Token: 0x040010C9 RID: 4297
		private bool _clearBeforeFill;
	}
}

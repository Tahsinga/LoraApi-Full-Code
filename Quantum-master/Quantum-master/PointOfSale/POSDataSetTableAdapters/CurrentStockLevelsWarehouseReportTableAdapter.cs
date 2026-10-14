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
	// Token: 0x0200013F RID: 319
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class CurrentStockLevelsWarehouseReportTableAdapter : Component
	{
		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x0017EA09 File Offset: 0x0017CC09
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x0017EA13 File Offset: 0x0017CC13
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0017EA1C File Offset: 0x0017CC1C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CurrentStockLevelsWarehouseReportTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0017EA30 File Offset: 0x0017CC30
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

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x0017EA60 File Offset: 0x0017CC60
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x0017EA90 File Offset: 0x0017CC90
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

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x0017EB54 File Offset: 0x0017CD54
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x0017EB6C File Offset: 0x0017CD6C
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x0017EC54 File Offset: 0x0017CE54
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x0017EC84 File Offset: 0x0017CE84
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x0017EC9C File Offset: 0x0017CE9C
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

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0017ECA8 File Offset: 0x0017CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "CurrentStockLevelsWarehouseReport";
			dataTableMapping.ColumnMappings.Add("BinLocation", "BinLocation");
			dataTableMapping.ColumnMappings.Add("productid", "productid");
			dataTableMapping.ColumnMappings.Add("productdesc", "productdesc");
			dataTableMapping.ColumnMappings.Add("batchnumber", "batchnumber");
			dataTableMapping.ColumnMappings.Add("expirydate", "expirydate");
			dataTableMapping.ColumnMappings.Add("bal", "bal");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0017ED76 File Offset: 0x0017CF76
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0017ED9C File Offset: 0x0017CF9C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.CurrentStockLevelsWarehouseReport";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@binloc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@allbalances", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0017EF20 File Offset: 0x0017D120
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.CurrentStockLevelsWarehouseReportDataTable dataTable, int? coid, string branch, string binloc, int? allbalances)
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
			bool flag3 = binloc == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = binloc;
			}
			bool flag4 = allbalances != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = allbalances.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0017F0B8 File Offset: 0x0017D2B8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.CurrentStockLevelsWarehouseReportDataTable GetData(int? coid, string branch, string binloc, int? allbalances)
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
			bool flag3 = binloc == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = binloc;
			}
			bool flag4 = allbalances != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = allbalances.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			POSDataSet.CurrentStockLevelsWarehouseReportDataTable currentStockLevelsWarehouseReportDataTable = new POSDataSet.CurrentStockLevelsWarehouseReportDataTable();
			this.Adapter.Fill(currentStockLevelsWarehouseReportDataTable);
			return currentStockLevelsWarehouseReportDataTable;
		}

		// Token: 0x0400135F RID: 4959
		private SqlConnection _connection;

		// Token: 0x04001360 RID: 4960
		private SqlTransaction _transaction;

		// Token: 0x04001361 RID: 4961
		private SqlCommand[] _commandCollection;

		// Token: 0x04001362 RID: 4962
		private bool _clearBeforeFill;
	}
}

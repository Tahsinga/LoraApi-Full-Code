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
	// Token: 0x0200013C RID: 316
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchTransferDetailsToForPeriodTableAdapter : Component
	{
		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0017CFC6 File Offset: 0x0017B1C6
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x0017CFD0 File Offset: 0x0017B1D0
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0017CFD9 File Offset: 0x0017B1D9
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchTransferDetailsToForPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0017CFEC File Offset: 0x0017B1EC
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0017D01C File Offset: 0x0017B21C
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x0017D04C File Offset: 0x0017B24C
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x0017D110 File Offset: 0x0017B310
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x0017D128 File Offset: 0x0017B328
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

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x0017D210 File Offset: 0x0017B410
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

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x0017D240 File Offset: 0x0017B440
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0017D258 File Offset: 0x0017B458
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

		// Token: 0x06002C70 RID: 11376 RVA: 0x0017D264 File Offset: 0x0017B464
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchTransferDetailsToForPeriod";
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("Reference", "Reference");
			dataTableMapping.ColumnMappings.Add("BranchFrom", "BranchFrom");
			dataTableMapping.ColumnMappings.Add("BranchTo", "BranchTo");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("ProductDescription", "ProductDescription");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("TransferDoneBy", "TransferDoneBy");
			dataTableMapping.ColumnMappings.Add("cost", "cost");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x0017D374 File Offset: 0x0017B574
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x0017D398 File Offset: 0x0017B598
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchTransferDetailsToForPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branchto", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branchfrom", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x0017D554 File Offset: 0x0017B754
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchTransferDetailsToForPeriodDataTable dataTable, int? coid, int? startdate, int? enddate, string branchto, string branchfrom)
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
			bool flag2 = startdate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = enddate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branchto == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branchto;
			}
			bool flag5 = branchfrom == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = branchfrom;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0017D748 File Offset: 0x0017B948
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchTransferDetailsToForPeriodDataTable GetData(int? coid, int? startdate, int? enddate, string branchto, string branchfrom)
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
			bool flag2 = startdate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = enddate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branchto == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branchto;
			}
			bool flag5 = branchfrom == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = branchfrom;
			}
			POSDataSet.FetchTransferDetailsToForPeriodDataTable fetchTransferDetailsToForPeriodDataTable = new POSDataSet.FetchTransferDetailsToForPeriodDataTable();
			this.Adapter.Fill(fetchTransferDetailsToForPeriodDataTable);
			return fetchTransferDetailsToForPeriodDataTable;
		}

		// Token: 0x04001350 RID: 4944
		private SqlConnection _connection;

		// Token: 0x04001351 RID: 4945
		private SqlTransaction _transaction;

		// Token: 0x04001352 RID: 4946
		private SqlCommand[] _commandCollection;

		// Token: 0x04001353 RID: 4947
		private bool _clearBeforeFill;
	}
}

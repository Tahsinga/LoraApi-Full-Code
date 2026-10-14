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
	// Token: 0x020000CF RID: 207
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchBranchFromforTransferTableAdapter : Component
	{
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x00145885 File Offset: 0x00143A85
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0014588F File Offset: 0x00143A8F
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00145898 File Offset: 0x00143A98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchBranchFromforTransferTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x001458AC File Offset: 0x00143AAC
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x001458DC File Offset: 0x00143ADC
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0014590C File Offset: 0x00143B0C
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x001459D0 File Offset: 0x00143BD0
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x001459E8 File Offset: 0x00143BE8
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00145AD0 File Offset: 0x00143CD0
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00145B00 File Offset: 0x00143D00
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00145B18 File Offset: 0x00143D18
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

		// Token: 0x06002597 RID: 9623 RVA: 0x00145B24 File Offset: 0x00143D24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchBranchFromforTransfer";
			dataTableMapping.ColumnMappings.Add("BranchFrom", "BranchFrom");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00145B84 File Offset: 0x00143D84
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00145BA8 File Offset: 0x00143DA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchBranchFromforTransfer";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00145CB4 File Offset: 0x00143EB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchBranchFromforTransferDataTable dataTable, int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00145DB0 File Offset: 0x00143FB0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchBranchFromforTransferDataTable GetData(int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			POSDataSet.FetchBranchFromforTransferDataTable fetchBranchFromforTransferDataTable = new POSDataSet.FetchBranchFromforTransferDataTable();
			this.Adapter.Fill(fetchBranchFromforTransferDataTable);
			return fetchBranchFromforTransferDataTable;
		}

		// Token: 0x0400112F RID: 4399
		private SqlConnection _connection;

		// Token: 0x04001130 RID: 4400
		private SqlTransaction _transaction;

		// Token: 0x04001131 RID: 4401
		private SqlCommand[] _commandCollection;

		// Token: 0x04001132 RID: 4402
		private bool _clearBeforeFill;
	}
}

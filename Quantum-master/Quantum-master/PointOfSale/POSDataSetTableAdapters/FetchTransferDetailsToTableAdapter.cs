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
	// Token: 0x02000131 RID: 305
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchTransferDetailsToTableAdapter : Component
	{
		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x001774A4 File Offset: 0x001756A4
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x001774AE File Offset: 0x001756AE
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x001774B7 File Offset: 0x001756B7
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchTransferDetailsToTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x001774CC File Offset: 0x001756CC
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

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x001774FC File Offset: 0x001756FC
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x0017752C File Offset: 0x0017572C
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x001775F0 File Offset: 0x001757F0
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x00177608 File Offset: 0x00175808
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

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x001776F0 File Offset: 0x001758F0
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00177720 File Offset: 0x00175920
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00177738 File Offset: 0x00175938
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

		// Token: 0x06002BBC RID: 11196 RVA: 0x00177744 File Offset: 0x00175944
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchTransferDetailsTo";
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("Ref", "Ref");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("BatchNumber", "BatchNumber");
			dataTableMapping.ColumnMappings.Add("ExpiryDate", "ExpiryDate");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("UOM", "UOM");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x0017786A File Offset: 0x00175A6A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00177890 File Offset: 0x00175A90
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchTransferDetailsTo";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0017799C File Offset: 0x00175B9C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchTransferDetailsToDataTable dataTable, int? invoicenum, int? coid)
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

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00177A98 File Offset: 0x00175C98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchTransferDetailsToDataTable GetData(int? invoicenum, int? coid)
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
			POSDataSet.FetchTransferDetailsToDataTable fetchTransferDetailsToDataTable = new POSDataSet.FetchTransferDetailsToDataTable();
			this.Adapter.Fill(fetchTransferDetailsToDataTable);
			return fetchTransferDetailsToDataTable;
		}

		// Token: 0x04001319 RID: 4889
		private SqlConnection _connection;

		// Token: 0x0400131A RID: 4890
		private SqlTransaction _transaction;

		// Token: 0x0400131B RID: 4891
		private SqlCommand[] _commandCollection;

		// Token: 0x0400131C RID: 4892
		private bool _clearBeforeFill;
	}
}

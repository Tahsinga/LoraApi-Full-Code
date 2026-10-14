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
	// Token: 0x02000142 RID: 322
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetBranchDetails1TableAdapter : Component
	{
		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x001802C9 File Offset: 0x0017E4C9
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x001802D3 File Offset: 0x0017E4D3
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x001802DC File Offset: 0x0017E4DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetBranchDetails1TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x001802F0 File Offset: 0x0017E4F0
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

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00180320 File Offset: 0x0017E520
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00180350 File Offset: 0x0017E550
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x00180414 File Offset: 0x0017E614
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0018042C File Offset: 0x0017E62C
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x00180514 File Offset: 0x0017E714
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

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00180544 File Offset: 0x0017E744
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x0018055C File Offset: 0x0017E75C
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

		// Token: 0x06002CD0 RID: 11472 RVA: 0x00180568 File Offset: 0x0017E768
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetBranchDetails1";
			dataTableMapping.ColumnMappings.Add("Branch", "Branch");
			dataTableMapping.ColumnMappings.Add("Coid", "Coid");
			dataTableMapping.ColumnMappings.Add("Visible", "Visible");
			dataTableMapping.ColumnMappings.Add("Colour", "Colour");
			dataTableMapping.ColumnMappings.Add("Tel", "Tel");
			dataTableMapping.ColumnMappings.Add("Tel2", "Tel2");
			dataTableMapping.ColumnMappings.Add("Tel3", "Tel3");
			dataTableMapping.ColumnMappings.Add("Email", "Email");
			dataTableMapping.ColumnMappings.Add("Address", "Address");
			dataTableMapping.ColumnMappings.Add("Address2", "Address2");
			dataTableMapping.ColumnMappings.Add("BPNumber", "BPNumber");
			dataTableMapping.ColumnMappings.Add("CompanyName", "CompanyName");
			dataTableMapping.ColumnMappings.Add("Footnote", "Footnote");
			dataTableMapping.ColumnMappings.Add("VatNumber", "VatNumber");
			dataTableMapping.ColumnMappings.Add("VendorNumber", "VendorNumber");
			dataTableMapping.ColumnMappings.Add("BPNumber_name", "BPNumber_name");
			dataTableMapping.ColumnMappings.Add("VATNumber_name", "VATNumber_name");
			dataTableMapping.ColumnMappings.Add("scalemaxdiff", "scalemaxdiff");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0018073E File Offset: 0x0017E93E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00180764 File Offset: 0x0017E964
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetBranchDetails";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@paymentmethodid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x001808AC File Offset: 0x0017EAAC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetBranchDetails1DataTable dataTable, string branch, int? coid, int? paymentmethodid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = branch == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = branch;
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
			bool flag3 = paymentmethodid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = paymentmethodid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x001809F4 File Offset: 0x0017EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetBranchDetails1DataTable GetData(string branch, int? coid, int? paymentmethodid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = branch == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = branch;
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
			bool flag3 = paymentmethodid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = paymentmethodid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			POSDataSet.GetBranchDetails1DataTable getBranchDetails1DataTable = new POSDataSet.GetBranchDetails1DataTable();
			this.Adapter.Fill(getBranchDetails1DataTable);
			return getBranchDetails1DataTable;
		}

		// Token: 0x0400136E RID: 4974
		private SqlConnection _connection;

		// Token: 0x0400136F RID: 4975
		private SqlTransaction _transaction;

		// Token: 0x04001370 RID: 4976
		private SqlCommand[] _commandCollection;

		// Token: 0x04001371 RID: 4977
		private bool _clearBeforeFill;
	}
}

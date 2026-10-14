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
	// Token: 0x02000149 RID: 329
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCustomerDetailsFromDespatchTableAdapter : Component
	{
		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00183C82 File Offset: 0x00181E82
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x00183C8C File Offset: 0x00181E8C
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00183C95 File Offset: 0x00181E95
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCustomerDetailsFromDespatchTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00183CA8 File Offset: 0x00181EA8
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

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x00183CD8 File Offset: 0x00181ED8
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x00183D08 File Offset: 0x00181F08
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

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x00183DCC File Offset: 0x00181FCC
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x00183DE4 File Offset: 0x00181FE4
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

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00183ECC File Offset: 0x001820CC
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x00183EFC File Offset: 0x001820FC
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x00183F14 File Offset: 0x00182114
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

		// Token: 0x06002D40 RID: 11584 RVA: 0x00183F20 File Offset: 0x00182120
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCustomerDetailsFromDespatch";
			dataTableMapping.ColumnMappings.Add("CustomerName", "CustomerName");
			dataTableMapping.ColumnMappings.Add("Address", "Address");
			dataTableMapping.ColumnMappings.Add("ContactName", "ContactName");
			dataTableMapping.ColumnMappings.Add("Mobile", "Mobile");
			dataTableMapping.ColumnMappings.Add("Email", "Email");
			dataTableMapping.ColumnMappings.Add("Uploaded", "Uploaded");
			dataTableMapping.ColumnMappings.Add("EntryNo", "EntryNo");
			dataTableMapping.ColumnMappings.Add("coid", "coid");
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			dataTableMapping.ColumnMappings.Add("InvoiceDetails1", "InvoiceDetails1");
			dataTableMapping.ColumnMappings.Add("InvoiceDetails2", "InvoiceDetails2");
			dataTableMapping.ColumnMappings.Add("Tel", "Tel");
			dataTableMapping.ColumnMappings.Add("IDNumber", "IDNumber");
			dataTableMapping.ColumnMappings.Add("DOB", "DOB");
			dataTableMapping.ColumnMappings.Add("Sex", "Sex");
			dataTableMapping.ColumnMappings.Add("DateCreated", "DateCreated");
			dataTableMapping.ColumnMappings.Add("CreatedBy", "CreatedBy");
			dataTableMapping.ColumnMappings.Add("VATNumber", "VATNumber");
			dataTableMapping.ColumnMappings.Add("BPNumber", "BPNumber");
			dataTableMapping.ColumnMappings.Add("RegisteredCoName", "RegisteredCoName");
			dataTableMapping.ColumnMappings.Add("AccountLimit", "AccountLimit");
			dataTableMapping.ColumnMappings.Add("IsActive", "IsActive");
			dataTableMapping.ColumnMappings.Add("CustomerGroupID", "CustomerGroupID");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00184164 File Offset: 0x00182364
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00184188 File Offset: 0x00182388
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCustomerDetailsFromDespatch";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x001842D0 File Offset: 0x001824D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCustomerDetailsFromDespatchDataTable dataTable, int? invnum, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invnum.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x0018441C File Offset: 0x0018261C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCustomerDetailsFromDespatchDataTable GetData(int? invnum, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invnum.Value;
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
			POSDataSet.FetchCustomerDetailsFromDespatchDataTable fetchCustomerDetailsFromDespatchDataTable = new POSDataSet.FetchCustomerDetailsFromDespatchDataTable();
			this.Adapter.Fill(fetchCustomerDetailsFromDespatchDataTable);
			return fetchCustomerDetailsFromDespatchDataTable;
		}

		// Token: 0x04001391 RID: 5009
		private SqlConnection _connection;

		// Token: 0x04001392 RID: 5010
		private SqlTransaction _transaction;

		// Token: 0x04001393 RID: 5011
		private SqlCommand[] _commandCollection;

		// Token: 0x04001394 RID: 5012
		private bool _clearBeforeFill;
	}
}

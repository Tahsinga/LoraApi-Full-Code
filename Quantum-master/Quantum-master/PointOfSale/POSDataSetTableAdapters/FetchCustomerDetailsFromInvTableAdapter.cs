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
	// Token: 0x0200014D RID: 333
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCustomerDetailsFromInvTableAdapter : Component
	{
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00185FF0 File Offset: 0x001841F0
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00185FFA File Offset: 0x001841FA
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00186003 File Offset: 0x00184203
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCustomerDetailsFromInvTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x00186018 File Offset: 0x00184218
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

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x00186048 File Offset: 0x00184248
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x00186078 File Offset: 0x00184278
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

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0018613C File Offset: 0x0018433C
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00186154 File Offset: 0x00184354
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

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x0018623C File Offset: 0x0018443C
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

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x0018626C File Offset: 0x0018446C
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00186284 File Offset: 0x00184484
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

		// Token: 0x06002D80 RID: 11648 RVA: 0x00186290 File Offset: 0x00184490
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCustomerDetailsFromInv";
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
			dataTableMapping.ColumnMappings.Add("province", "province");
			dataTableMapping.ColumnMappings.Add("streetnumber", "streetnumber");
			dataTableMapping.ColumnMappings.Add("city", "city");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00186516 File Offset: 0x00184716
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0018653C File Offset: 0x0018473C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCustomerDetailsFromInv";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00186684 File Offset: 0x00184884
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCustomerDetailsFromInvDataTable dataTable, int? invnum, int? coid, string branch)
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

		// Token: 0x06002D84 RID: 11652 RVA: 0x001867D0 File Offset: 0x001849D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCustomerDetailsFromInvDataTable GetData(int? invnum, int? coid, string branch)
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
			POSDataSet.FetchCustomerDetailsFromInvDataTable fetchCustomerDetailsFromInvDataTable = new POSDataSet.FetchCustomerDetailsFromInvDataTable();
			this.Adapter.Fill(fetchCustomerDetailsFromInvDataTable);
			return fetchCustomerDetailsFromInvDataTable;
		}

		// Token: 0x040013A5 RID: 5029
		private SqlConnection _connection;

		// Token: 0x040013A6 RID: 5030
		private SqlTransaction _transaction;

		// Token: 0x040013A7 RID: 5031
		private SqlCommand[] _commandCollection;

		// Token: 0x040013A8 RID: 5032
		private bool _clearBeforeFill;
	}
}

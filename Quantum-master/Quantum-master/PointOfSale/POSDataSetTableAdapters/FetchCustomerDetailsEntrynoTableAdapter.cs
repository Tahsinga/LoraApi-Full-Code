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
	// Token: 0x02000156 RID: 342
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCustomerDetailsEntrynoTableAdapter : Component
	{
		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x0018BA0B File Offset: 0x00189C0B
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x0018BA15 File Offset: 0x00189C15
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x0018BA1E File Offset: 0x00189C1E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCustomerDetailsEntrynoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x0018BA30 File Offset: 0x00189C30
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

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x0018BA60 File Offset: 0x00189C60
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0018BA90 File Offset: 0x00189C90
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

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x0018BB54 File Offset: 0x00189D54
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x0018BB6C File Offset: 0x00189D6C
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

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x0018BC54 File Offset: 0x00189E54
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

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x0018BC84 File Offset: 0x00189E84
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x0018BC9C File Offset: 0x00189E9C
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

		// Token: 0x06002E10 RID: 11792 RVA: 0x0018BCA8 File Offset: 0x00189EA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCustomerDetailsEntryno";
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
			dataTableMapping.ColumnMappings.Add("Province", "Province");
			dataTableMapping.ColumnMappings.Add("city", "city");
			dataTableMapping.ColumnMappings.Add("streetnumber", "streetnumber");
			dataTableMapping.ColumnMappings.Add("CustomerGroupID", "CustomerGroupID");
			dataTableMapping.ColumnMappings.Add("CategoryName", "CategoryName");
			dataTableMapping.ColumnMappings.Add("bal", "bal");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0018BF5A File Offset: 0x0018A15A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0018BF80 File Offset: 0x0018A180
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCustomerDetailsEntryno";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@CustomerEntryNo", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0018C0C8 File Offset: 0x0018A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCustomerDetailsEntrynoDataTable dataTable, int? CustomerEntryNo, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = CustomerEntryNo != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = CustomerEntryNo.Value;
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

		// Token: 0x06002E14 RID: 11796 RVA: 0x0018C214 File Offset: 0x0018A414
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCustomerDetailsEntrynoDataTable GetData(int? CustomerEntryNo, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = CustomerEntryNo != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = CustomerEntryNo.Value;
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
			POSDataSet.FetchCustomerDetailsEntrynoDataTable fetchCustomerDetailsEntrynoDataTable = new POSDataSet.FetchCustomerDetailsEntrynoDataTable();
			this.Adapter.Fill(fetchCustomerDetailsEntrynoDataTable);
			return fetchCustomerDetailsEntrynoDataTable;
		}

		// Token: 0x040013D2 RID: 5074
		private SqlConnection _connection;

		// Token: 0x040013D3 RID: 5075
		private SqlTransaction _transaction;

		// Token: 0x040013D4 RID: 5076
		private SqlCommand[] _commandCollection;

		// Token: 0x040013D5 RID: 5077
		private bool _clearBeforeFill;
	}
}

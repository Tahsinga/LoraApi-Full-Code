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
	// Token: 0x0200014E RID: 334
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCustomerDetailsFromInvCNTableAdapter : Component
	{
		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x00186909 File Offset: 0x00184B09
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x00186913 File Offset: 0x00184B13
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0018691C File Offset: 0x00184B1C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCustomerDetailsFromInvCNTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x00186930 File Offset: 0x00184B30
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

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x00186960 File Offset: 0x00184B60
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00186990 File Offset: 0x00184B90
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

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00186A54 File Offset: 0x00184C54
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00186A6C File Offset: 0x00184C6C
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

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00186B54 File Offset: 0x00184D54
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

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x00186B84 File Offset: 0x00184D84
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00186B9C File Offset: 0x00184D9C
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

		// Token: 0x06002D90 RID: 11664 RVA: 0x00186BA8 File Offset: 0x00184DA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCustomerDetailsFromInvCN";
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

		// Token: 0x06002D91 RID: 11665 RVA: 0x00186E2E File Offset: 0x0018502E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00186E54 File Offset: 0x00185054
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCustomerDetailsFromInvCN";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00186F9C File Offset: 0x0018519C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCustomerDetailsFromInvCNDataTable dataTable, int? invnum, int? coid, string branch)
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

		// Token: 0x06002D94 RID: 11668 RVA: 0x001870E8 File Offset: 0x001852E8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCustomerDetailsFromInvCNDataTable GetData(int? invnum, int? coid, string branch)
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
			POSDataSet.FetchCustomerDetailsFromInvCNDataTable fetchCustomerDetailsFromInvCNDataTable = new POSDataSet.FetchCustomerDetailsFromInvCNDataTable();
			this.Adapter.Fill(fetchCustomerDetailsFromInvCNDataTable);
			return fetchCustomerDetailsFromInvCNDataTable;
		}

		// Token: 0x040013AA RID: 5034
		private SqlConnection _connection;

		// Token: 0x040013AB RID: 5035
		private SqlTransaction _transaction;

		// Token: 0x040013AC RID: 5036
		private SqlCommand[] _commandCollection;

		// Token: 0x040013AD RID: 5037
		private bool _clearBeforeFill;
	}
}

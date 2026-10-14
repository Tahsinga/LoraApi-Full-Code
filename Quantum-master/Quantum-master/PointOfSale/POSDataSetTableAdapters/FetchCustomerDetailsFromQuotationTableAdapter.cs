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
	// Token: 0x020000F4 RID: 244
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCustomerDetailsFromQuotationTableAdapter : Component
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00157CA4 File Offset: 0x00155EA4
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x00157CAE File Offset: 0x00155EAE
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00157CB7 File Offset: 0x00155EB7
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCustomerDetailsFromQuotationTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00157CCC File Offset: 0x00155ECC
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

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x00157CFC File Offset: 0x00155EFC
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x00157D2C File Offset: 0x00155F2C
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

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x00157DF0 File Offset: 0x00155FF0
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00157E08 File Offset: 0x00156008
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

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x00157EF0 File Offset: 0x001560F0
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x00157F20 File Offset: 0x00156120
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x00157F38 File Offset: 0x00156138
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

		// Token: 0x060027E7 RID: 10215 RVA: 0x00157F44 File Offset: 0x00156144
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCustomerDetailsFromQuotation";
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
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00158096 File Offset: 0x00156296
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x001580BC File Offset: 0x001562BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCustomerDetailsFromQuotation";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@quotationnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00158204 File Offset: 0x00156404
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCustomerDetailsFromQuotationDataTable dataTable, int? quotationnumber, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnumber != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnumber.Value;
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

		// Token: 0x060027EB RID: 10219 RVA: 0x00158350 File Offset: 0x00156550
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCustomerDetailsFromQuotationDataTable GetData(int? quotationnumber, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnumber != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnumber.Value;
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
			POSDataSet.FetchCustomerDetailsFromQuotationDataTable fetchCustomerDetailsFromQuotationDataTable = new POSDataSet.FetchCustomerDetailsFromQuotationDataTable();
			this.Adapter.Fill(fetchCustomerDetailsFromQuotationDataTable);
			return fetchCustomerDetailsFromQuotationDataTable;
		}

		// Token: 0x040011E8 RID: 4584
		private SqlConnection _connection;

		// Token: 0x040011E9 RID: 4585
		private SqlTransaction _transaction;

		// Token: 0x040011EA RID: 4586
		private SqlCommand[] _commandCollection;

		// Token: 0x040011EB RID: 4587
		private bool _clearBeforeFill;
	}
}

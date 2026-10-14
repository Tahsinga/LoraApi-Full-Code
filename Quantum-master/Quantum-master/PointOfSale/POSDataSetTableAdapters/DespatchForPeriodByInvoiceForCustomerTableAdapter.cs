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
	// Token: 0x0200014B RID: 331
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class DespatchForPeriodByInvoiceForCustomerTableAdapter : Component
	{
		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x00184E51 File Offset: 0x00183051
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x00184E5B File Offset: 0x0018305B
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00184E64 File Offset: 0x00183064
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DespatchForPeriodByInvoiceForCustomerTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x00184E78 File Offset: 0x00183078
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

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x00184EA8 File Offset: 0x001830A8
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x00184ED8 File Offset: 0x001830D8
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x00184F9C File Offset: 0x0018319C
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x00184FB4 File Offset: 0x001831B4
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

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x0018509C File Offset: 0x0018329C
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

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x001850CC File Offset: 0x001832CC
		// (set) Token: 0x06002D5F RID: 11615 RVA: 0x001850E4 File Offset: 0x001832E4
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

		// Token: 0x06002D60 RID: 11616 RVA: 0x001850F0 File Offset: 0x001832F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "DespatchForPeriodByInvoiceForCustomer";
			dataTableMapping.ColumnMappings.Add("Despatch_Date", "Despatch_Date");
			dataTableMapping.ColumnMappings.Add("Tran_Time", "Tran_Time");
			dataTableMapping.ColumnMappings.Add("Done_By", "Done_By");
			dataTableMapping.ColumnMappings.Add("Invoice_Number", "Invoice_Number");
			dataTableMapping.ColumnMappings.Add("Customer", "Customer");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("OtherDetail", "OtherDetail");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x001851EA File Offset: 0x001833EA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00185210 File Offset: 0x00183410
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.DespatchForPeriodByInvoiceForCustomer";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@customerentryno", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x001853CC File Offset: 0x001835CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.DespatchForPeriodByInvoiceForCustomerDataTable dataTable, int? startdate, int? enddate, int? coid, string branch, int? customerentryno)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			bool flag5 = customerentryno != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = customerentryno.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x001855CC File Offset: 0x001837CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.DespatchForPeriodByInvoiceForCustomerDataTable GetData(int? startdate, int? enddate, int? coid, string branch, int? customerentryno)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			bool flag5 = customerentryno != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = customerentryno.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			POSDataSet.DespatchForPeriodByInvoiceForCustomerDataTable despatchForPeriodByInvoiceForCustomerDataTable = new POSDataSet.DespatchForPeriodByInvoiceForCustomerDataTable();
			this.Adapter.Fill(despatchForPeriodByInvoiceForCustomerDataTable);
			return despatchForPeriodByInvoiceForCustomerDataTable;
		}

		// Token: 0x0400139B RID: 5019
		private SqlConnection _connection;

		// Token: 0x0400139C RID: 5020
		private SqlTransaction _transaction;

		// Token: 0x0400139D RID: 5021
		private SqlCommand[] _commandCollection;

		// Token: 0x0400139E RID: 5022
		private bool _clearBeforeFill;
	}
}

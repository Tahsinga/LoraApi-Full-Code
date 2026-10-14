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
	// Token: 0x02000136 RID: 310
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForCompanyCategoriesTableAdapter : Component
	{
		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x00179CA7 File Offset: 0x00177EA7
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00179CB1 File Offset: 0x00177EB1
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00179CBA File Offset: 0x00177EBA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForCompanyCategoriesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x00179CCC File Offset: 0x00177ECC
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x00179CFC File Offset: 0x00177EFC
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x00179D2C File Offset: 0x00177F2C
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x00179DF0 File Offset: 0x00177FF0
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x00179E08 File Offset: 0x00178008
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00179EF0 File Offset: 0x001780F0
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

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x00179F20 File Offset: 0x00178120
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x00179F38 File Offset: 0x00178138
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

		// Token: 0x06002C0C RID: 11276 RVA: 0x00179F44 File Offset: 0x00178144
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForCompanyCategories";
			dataTableMapping.ColumnMappings.Add("Catid", "Catid");
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00179FD0 File Offset: 0x001781D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00179FF4 File Offset: 0x001781F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForCompanyCategories";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0017A13C File Offset: 0x0017833C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForCompanyCategoriesDataTable dataTable, int? shiftdateStart, int? shiftdateEnd, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdateStart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateEnd != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateEnd.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0017A294 File Offset: 0x00178494
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForCompanyCategoriesDataTable GetData(int? shiftdateStart, int? shiftdateEnd, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdateStart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateEnd != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateEnd.Value;
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
			POSDataSet.SalesForCompanyCategoriesDataTable salesForCompanyCategoriesDataTable = new POSDataSet.SalesForCompanyCategoriesDataTable();
			this.Adapter.Fill(salesForCompanyCategoriesDataTable);
			return salesForCompanyCategoriesDataTable;
		}

		// Token: 0x04001332 RID: 4914
		private SqlConnection _connection;

		// Token: 0x04001333 RID: 4915
		private SqlTransaction _transaction;

		// Token: 0x04001334 RID: 4916
		private SqlCommand[] _commandCollection;

		// Token: 0x04001335 RID: 4917
		private bool _clearBeforeFill;
	}
}

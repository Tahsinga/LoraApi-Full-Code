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
	// Token: 0x020000A9 RID: 169
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesByCustomerForPeriodTableAdapter : Component
	{
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x001356D3 File Offset: 0x001338D3
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x001356DD File Offset: 0x001338DD
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x001356E6 File Offset: 0x001338E6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesByCustomerForPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x001356F8 File Offset: 0x001338F8
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

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x00135728 File Offset: 0x00133928
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x00135758 File Offset: 0x00133958
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x0013581C File Offset: 0x00133A1C
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x00135834 File Offset: 0x00133A34
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x0013591C File Offset: 0x00133B1C
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

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0013594C File Offset: 0x00133B4C
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00135964 File Offset: 0x00133B64
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

		// Token: 0x06002337 RID: 9015 RVA: 0x00135970 File Offset: 0x00133B70
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesByCustomerForPeriod";
			dataTableMapping.ColumnMappings.Add("Company", "Company");
			dataTableMapping.ColumnMappings.Add("ContactName", "ContactName");
			dataTableMapping.ColumnMappings.Add("Mobile", "Mobile");
			dataTableMapping.ColumnMappings.Add("Email", "Email");
			dataTableMapping.ColumnMappings.Add("Address", "Address");
			dataTableMapping.ColumnMappings.Add("TotalSales", "TotalSales");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00135A3E File Offset: 0x00133C3E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00135A64 File Offset: 0x00133C64
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesByCustomerForPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00135B70 File Offset: 0x00133D70
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesByCustomerForPeriodDataTable dataTable, int? startdate, int? enddate)
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00135C6C File Offset: 0x00133E6C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesByCustomerForPeriodDataTable GetData(int? startdate, int? enddate)
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
			POSDataSet.SalesByCustomerForPeriodDataTable salesByCustomerForPeriodDataTable = new POSDataSet.SalesByCustomerForPeriodDataTable();
			this.Adapter.Fill(salesByCustomerForPeriodDataTable);
			return salesByCustomerForPeriodDataTable;
		}

		// Token: 0x04001071 RID: 4209
		private SqlConnection _connection;

		// Token: 0x04001072 RID: 4210
		private SqlTransaction _transaction;

		// Token: 0x04001073 RID: 4211
		private SqlCommand[] _commandCollection;

		// Token: 0x04001074 RID: 4212
		private bool _clearBeforeFill;
	}
}

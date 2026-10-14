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
	// Token: 0x020000A1 RID: 161
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchStockValuationMethodsTableAdapter : Component
	{
		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x00131623 File Offset: 0x0012F823
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0013162D File Offset: 0x0012F82D
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00131636 File Offset: 0x0012F836
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchStockValuationMethodsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x00131648 File Offset: 0x0012F848
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

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00131678 File Offset: 0x0012F878
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x001316A8 File Offset: 0x0012F8A8
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0013176C File Offset: 0x0012F96C
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x00131784 File Offset: 0x0012F984
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

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0013186C File Offset: 0x0012FA6C
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0013189C File Offset: 0x0012FA9C
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x001318B4 File Offset: 0x0012FAB4
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

		// Token: 0x060022B7 RID: 8887 RVA: 0x001318C0 File Offset: 0x0012FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchStockValuationMethods";
			dataTableMapping.ColumnMappings.Add("Method", "Method");
			dataTableMapping.ColumnMappings.Add("MethodID", "MethodID");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00131936 File Offset: 0x0012FB36
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0013195C File Offset: 0x0012FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchStockValuationMethods";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x001319F4 File Offset: 0x0012FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchStockValuationMethodsDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00131A3C File Offset: 0x0012FC3C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchStockValuationMethodsDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.FetchStockValuationMethodsDataTable fetchStockValuationMethodsDataTable = new POSDataSet.FetchStockValuationMethodsDataTable();
			this.Adapter.Fill(fetchStockValuationMethodsDataTable);
			return fetchStockValuationMethodsDataTable;
		}

		// Token: 0x04001049 RID: 4169
		private SqlConnection _connection;

		// Token: 0x0400104A RID: 4170
		private SqlTransaction _transaction;

		// Token: 0x0400104B RID: 4171
		private SqlCommand[] _commandCollection;

		// Token: 0x0400104C RID: 4172
		private bool _clearBeforeFill;
	}
}

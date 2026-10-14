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
	// Token: 0x020000B0 RID: 176
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectAllProductsTableAdapter : Component
	{
		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x00138489 File Offset: 0x00136689
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x00138493 File Offset: 0x00136693
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0013849C File Offset: 0x0013669C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectAllProductsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x001384B0 File Offset: 0x001366B0
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x001384E0 File Offset: 0x001366E0
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x00138510 File Offset: 0x00136710
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x001385D4 File Offset: 0x001367D4
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x001385EC File Offset: 0x001367EC
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x001386D4 File Offset: 0x001368D4
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x00138704 File Offset: 0x00136904
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0013871C File Offset: 0x0013691C
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

		// Token: 0x060023A7 RID: 9127 RVA: 0x00138728 File Offset: 0x00136928
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectAllProducts";
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("Product_Description", "Product_Description");
			dataTableMapping.ColumnMappings.Add("Reorder_Level", "Reorder_Level");
			dataTableMapping.ColumnMappings.Add("Unit_Selling_Price", "Unit_Selling_Price");
			dataTableMapping.ColumnMappings.Add("Unit_Cost", "Unit_Cost");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x001387F6 File Offset: 0x001369F6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0013881C File Offset: 0x00136A1C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectAllProducts";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x001388B4 File Offset: 0x00136AB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectAllProductsDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x001388FC File Offset: 0x00136AFC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectAllProductsDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.SelectAllProductsDataTable selectAllProductsDataTable = new POSDataSet.SelectAllProductsDataTable();
			this.Adapter.Fill(selectAllProductsDataTable);
			return selectAllProductsDataTable;
		}

		// Token: 0x04001094 RID: 4244
		private SqlConnection _connection;

		// Token: 0x04001095 RID: 4245
		private SqlTransaction _transaction;

		// Token: 0x04001096 RID: 4246
		private SqlCommand[] _commandCollection;

		// Token: 0x04001097 RID: 4247
		private bool _clearBeforeFill;
	}
}

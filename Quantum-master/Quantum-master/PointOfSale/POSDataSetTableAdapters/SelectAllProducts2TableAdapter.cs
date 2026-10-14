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
	// Token: 0x020000B1 RID: 177
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectAllProducts2TableAdapter : Component
	{
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x00138936 File Offset: 0x00136B36
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x00138940 File Offset: 0x00136B40
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00138949 File Offset: 0x00136B49
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectAllProducts2TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0013895C File Offset: 0x00136B5C
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

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0013898C File Offset: 0x00136B8C
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x001389BC File Offset: 0x00136BBC
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x00138A80 File Offset: 0x00136C80
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x00138A98 File Offset: 0x00136C98
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

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x00138B80 File Offset: 0x00136D80
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

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x00138BB0 File Offset: 0x00136DB0
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x00138BC8 File Offset: 0x00136DC8
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

		// Token: 0x060023B7 RID: 9143 RVA: 0x00138BD4 File Offset: 0x00136DD4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectAllProducts2";
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("Product_Description", "Product_Description");
			dataTableMapping.ColumnMappings.Add("Reorder_Level", "Reorder_Level");
			dataTableMapping.ColumnMappings.Add("Unit_Selling_Price", "Unit_Selling_Price");
			dataTableMapping.ColumnMappings.Add("Unit_Cost", "Unit_Cost");
			dataTableMapping.ColumnMappings.Add("Tax_Percentage", "Tax_Percentage");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00138CCE File Offset: 0x00136ECE
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00138CF4 File Offset: 0x00136EF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectAllProducts2";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00138D8C File Offset: 0x00136F8C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectAllProducts2DataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00138DD4 File Offset: 0x00136FD4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectAllProducts2DataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.SelectAllProducts2DataTable selectAllProducts2DataTable = new POSDataSet.SelectAllProducts2DataTable();
			this.Adapter.Fill(selectAllProducts2DataTable);
			return selectAllProducts2DataTable;
		}

		// Token: 0x04001099 RID: 4249
		private SqlConnection _connection;

		// Token: 0x0400109A RID: 4250
		private SqlTransaction _transaction;

		// Token: 0x0400109B RID: 4251
		private SqlCommand[] _commandCollection;

		// Token: 0x0400109C RID: 4252
		private bool _clearBeforeFill;
	}
}

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
	// Token: 0x020000A0 RID: 160
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchProductsByCategoryTableAdapter : Component
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00130FF3 File Offset: 0x0012F1F3
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00130FFD File Offset: 0x0012F1FD
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00131006 File Offset: 0x0012F206
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchProductsByCategoryTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00131018 File Offset: 0x0012F218
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

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00131048 File Offset: 0x0012F248
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x00131078 File Offset: 0x0012F278
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0013113C File Offset: 0x0012F33C
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00131154 File Offset: 0x0012F354
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

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0013123C File Offset: 0x0012F43C
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0013126C File Offset: 0x0012F46C
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00131284 File Offset: 0x0012F484
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

		// Token: 0x060022A7 RID: 8871 RVA: 0x00131290 File Offset: 0x0012F490
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchProductsByCategory";
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("CatID", "CatID");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("UnitsPerPack", "UnitsPerPack");
			dataTableMapping.ColumnMappings.Add("ReorderLevel", "ReorderLevel");
			dataTableMapping.ColumnMappings.Add("DoneBy", "DoneBy");
			dataTableMapping.ColumnMappings.Add("DoneWhen", "DoneWhen");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("BarCode", "BarCode");
			dataTableMapping.ColumnMappings.Add("Uploaded", "Uploaded");
			dataTableMapping.ColumnMappings.Add("TaxRate", "TaxRate");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x001313F8 File Offset: 0x0012F5F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0013141C File Offset: 0x0012F61C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchProductsByCategory";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@category", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x001314F0 File Offset: 0x0012F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchProductsByCategoryDataTable dataTable, int? category)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = category != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = category.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00131590 File Offset: 0x0012F790
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchProductsByCategoryDataTable GetData(int? category)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = category != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = category.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.FetchProductsByCategoryDataTable fetchProductsByCategoryDataTable = new POSDataSet.FetchProductsByCategoryDataTable();
			this.Adapter.Fill(fetchProductsByCategoryDataTable);
			return fetchProductsByCategoryDataTable;
		}

		// Token: 0x04001044 RID: 4164
		private SqlConnection _connection;

		// Token: 0x04001045 RID: 4165
		private SqlTransaction _transaction;

		// Token: 0x04001046 RID: 4166
		private SqlCommand[] _commandCollection;

		// Token: 0x04001047 RID: 4167
		private bool _clearBeforeFill;
	}
}

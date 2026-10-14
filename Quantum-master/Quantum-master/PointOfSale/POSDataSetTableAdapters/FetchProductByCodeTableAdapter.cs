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
	// Token: 0x0200009E RID: 158
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchProductByCodeTableAdapter : Component
	{
		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x001303AA File Offset: 0x0012E5AA
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x001303B4 File Offset: 0x0012E5B4
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x001303BD File Offset: 0x0012E5BD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchProductByCodeTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x001303D0 File Offset: 0x0012E5D0
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00130400 File Offset: 0x0012E600
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00130430 File Offset: 0x0012E630
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x001304F4 File Offset: 0x0012E6F4
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x0013050C File Offset: 0x0012E70C
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x001305F4 File Offset: 0x0012E7F4
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x00130624 File Offset: 0x0012E824
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0013063C File Offset: 0x0012E83C
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

		// Token: 0x06002287 RID: 8839 RVA: 0x00130648 File Offset: 0x0012E848
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchProductByCode";
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

		// Token: 0x06002288 RID: 8840 RVA: 0x001307B0 File Offset: 0x0012E9B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x001307D4 File Offset: 0x0012E9D4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchProductByCode";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productcode", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x001308A8 File Offset: 0x0012EAA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchProductByCodeDataTable dataTable, string productcode)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productcode == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productcode;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0013093C File Offset: 0x0012EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchProductByCodeDataTable GetData(string productcode)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productcode == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productcode;
			}
			POSDataSet.FetchProductByCodeDataTable fetchProductByCodeDataTable = new POSDataSet.FetchProductByCodeDataTable();
			this.Adapter.Fill(fetchProductByCodeDataTable);
			return fetchProductByCodeDataTable;
		}

		// Token: 0x0400103A RID: 4154
		private SqlConnection _connection;

		// Token: 0x0400103B RID: 4155
		private SqlTransaction _transaction;

		// Token: 0x0400103C RID: 4156
		private SqlCommand[] _commandCollection;

		// Token: 0x0400103D RID: 4157
		private bool _clearBeforeFill;
	}
}

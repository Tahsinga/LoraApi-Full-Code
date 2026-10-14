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
	// Token: 0x0200009F RID: 159
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchProductByIDTableAdapter : Component
	{
		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x001309C1 File Offset: 0x0012EBC1
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x001309CB File Offset: 0x0012EBCB
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x001309D4 File Offset: 0x0012EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchProductByIDTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x001309E8 File Offset: 0x0012EBE8
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

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00130A18 File Offset: 0x0012EC18
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x00130A48 File Offset: 0x0012EC48
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00130B0C File Offset: 0x0012ED0C
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x00130B24 File Offset: 0x0012ED24
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

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x00130C0C File Offset: 0x0012EE0C
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

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x00130C3C File Offset: 0x0012EE3C
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x00130C54 File Offset: 0x0012EE54
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

		// Token: 0x06002297 RID: 8855 RVA: 0x00130C60 File Offset: 0x0012EE60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchProductByID";
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

		// Token: 0x06002298 RID: 8856 RVA: 0x00130DC8 File Offset: 0x0012EFC8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00130DEC File Offset: 0x0012EFEC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchProductByID";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@prodtID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00130EC0 File Offset: 0x0012F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchProductByIDDataTable dataTable, int? prodtID)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = prodtID != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = prodtID.Value;
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

		// Token: 0x0600229B RID: 8859 RVA: 0x00130F60 File Offset: 0x0012F160
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchProductByIDDataTable GetData(int? prodtID)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = prodtID != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = prodtID.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.FetchProductByIDDataTable fetchProductByIDDataTable = new POSDataSet.FetchProductByIDDataTable();
			this.Adapter.Fill(fetchProductByIDDataTable);
			return fetchProductByIDDataTable;
		}

		// Token: 0x0400103F RID: 4159
		private SqlConnection _connection;

		// Token: 0x04001040 RID: 4160
		private SqlTransaction _transaction;

		// Token: 0x04001041 RID: 4161
		private SqlCommand[] _commandCollection;

		// Token: 0x04001042 RID: 4162
		private bool _clearBeforeFill;
	}
}

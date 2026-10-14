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
	// Token: 0x0200009C RID: 156
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchCategoriesTableAdapter : Component
	{
		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x0012F71E File Offset: 0x0012D91E
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0012F728 File Offset: 0x0012D928
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0012F731 File Offset: 0x0012D931
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchCategoriesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x0012F744 File Offset: 0x0012D944
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x0012F774 File Offset: 0x0012D974
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0012F7A4 File Offset: 0x0012D9A4
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

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0012F868 File Offset: 0x0012DA68
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x0012F880 File Offset: 0x0012DA80
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0012F968 File Offset: 0x0012DB68
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x0012F998 File Offset: 0x0012DB98
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x0012F9B0 File Offset: 0x0012DBB0
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

		// Token: 0x06002267 RID: 8807 RVA: 0x0012F9BC File Offset: 0x0012DBBC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchCategories";
			dataTableMapping.ColumnMappings.Add("CatID", "CatID");
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("Uploaded", "Uploaded");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0012FA48 File Offset: 0x0012DC48
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0012FA6C File Offset: 0x0012DC6C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchCategories";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0012FB04 File Offset: 0x0012DD04
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchCategoriesDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0012FB4C File Offset: 0x0012DD4C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchCategoriesDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.FetchCategoriesDataTable fetchCategoriesDataTable = new POSDataSet.FetchCategoriesDataTable();
			this.Adapter.Fill(fetchCategoriesDataTable);
			return fetchCategoriesDataTable;
		}

		// Token: 0x04001030 RID: 4144
		private SqlConnection _connection;

		// Token: 0x04001031 RID: 4145
		private SqlTransaction _transaction;

		// Token: 0x04001032 RID: 4146
		private SqlCommand[] _commandCollection;

		// Token: 0x04001033 RID: 4147
		private bool _clearBeforeFill;
	}
}

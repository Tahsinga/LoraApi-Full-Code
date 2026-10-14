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
	// Token: 0x020000DA RID: 218
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ReportFetchAllProductBalsTableAdapter : Component
	{
		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0014AA5A File Offset: 0x00148C5A
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0014AA64 File Offset: 0x00148C64
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0014AA6D File Offset: 0x00148C6D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ReportFetchAllProductBalsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x0014AA80 File Offset: 0x00148C80
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x0014AAB0 File Offset: 0x00148CB0
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0014AAE0 File Offset: 0x00148CE0
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

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x0014ABA4 File Offset: 0x00148DA4
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0014ABBC File Offset: 0x00148DBC
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

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x0014ACA4 File Offset: 0x00148EA4
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

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x0014ACD4 File Offset: 0x00148ED4
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0014ACEC File Offset: 0x00148EEC
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

		// Token: 0x06002647 RID: 9799 RVA: 0x0014ACF8 File Offset: 0x00148EF8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ReportFetchAllProductBals";
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("StockBalance", "StockBalance");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("AssetCostValue", "AssetCostValue");
			dataTableMapping.ColumnMappings.Add("AssetSalesValue", "AssetSalesValue");
			dataTableMapping.ColumnMappings.Add("catid", "catid");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0014AE08 File Offset: 0x00149008
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0014AE2C File Offset: 0x0014902C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ReportFetchAllProductBals";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0014AF38 File Offset: 0x00149138
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ReportFetchAllProductBalsDataTable dataTable, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0014B028 File Offset: 0x00149228
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ReportFetchAllProductBalsDataTable GetData(int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			POSDataSet.ReportFetchAllProductBalsDataTable reportFetchAllProductBalsDataTable = new POSDataSet.ReportFetchAllProductBalsDataTable();
			this.Adapter.Fill(reportFetchAllProductBalsDataTable);
			return reportFetchAllProductBalsDataTable;
		}

		// Token: 0x04001166 RID: 4454
		private SqlConnection _connection;

		// Token: 0x04001167 RID: 4455
		private SqlTransaction _transaction;

		// Token: 0x04001168 RID: 4456
		private SqlCommand[] _commandCollection;

		// Token: 0x04001169 RID: 4457
		private bool _clearBeforeFill;
	}
}

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
	// Token: 0x020000A6 RID: 166
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class LatestProductCodeTableAdapter : Component
	{
		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x00134485 File Offset: 0x00132685
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x0013448F File Offset: 0x0013268F
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00134498 File Offset: 0x00132698
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public LatestProductCodeTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x001344AC File Offset: 0x001326AC
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

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x001344DC File Offset: 0x001326DC
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x0013450C File Offset: 0x0013270C
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x001345D0 File Offset: 0x001327D0
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x001345E8 File Offset: 0x001327E8
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x001346D0 File Offset: 0x001328D0
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00134700 File Offset: 0x00132900
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x00134718 File Offset: 0x00132918
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

		// Token: 0x06002307 RID: 8967 RVA: 0x00134724 File Offset: 0x00132924
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "LatestProductCode";
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00134784 File Offset: 0x00132984
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x001347A8 File Offset: 0x001329A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.LatestProductCode";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0013487C File Offset: 0x00132A7C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.LatestProductCodeDataTable dataTable, int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productid.Value;
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

		// Token: 0x0600230B RID: 8971 RVA: 0x0013491C File Offset: 0x00132B1C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.LatestProductCodeDataTable GetData(int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.LatestProductCodeDataTable latestProductCodeDataTable = new POSDataSet.LatestProductCodeDataTable();
			this.Adapter.Fill(latestProductCodeDataTable);
			return latestProductCodeDataTable;
		}

		// Token: 0x04001062 RID: 4194
		private SqlConnection _connection;

		// Token: 0x04001063 RID: 4195
		private SqlTransaction _transaction;

		// Token: 0x04001064 RID: 4196
		private SqlCommand[] _commandCollection;

		// Token: 0x04001065 RID: 4197
		private bool _clearBeforeFill;
	}
}

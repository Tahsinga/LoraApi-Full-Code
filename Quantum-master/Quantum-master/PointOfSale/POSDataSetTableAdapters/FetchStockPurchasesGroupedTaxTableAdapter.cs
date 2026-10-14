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
	// Token: 0x02000133 RID: 307
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchStockPurchasesGroupedTaxTableAdapter : Component
	{
		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x00178410 File Offset: 0x00176610
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x0017841A File Offset: 0x0017661A
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00178423 File Offset: 0x00176623
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchStockPurchasesGroupedTaxTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00178438 File Offset: 0x00176638
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

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00178468 File Offset: 0x00176668
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00178498 File Offset: 0x00176698
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

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x0017855C File Offset: 0x0017675C
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00178574 File Offset: 0x00176774
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x0017865C File Offset: 0x0017685C
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

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x0017868C File Offset: 0x0017688C
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x001786A4 File Offset: 0x001768A4
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

		// Token: 0x06002BDC RID: 11228 RVA: 0x001786B0 File Offset: 0x001768B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchStockPurchasesGroupedTax";
			dataTableMapping.ColumnMappings.Add("TaxRate", "TaxRate");
			dataTableMapping.ColumnMappings.Add("Amount", "Amount");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00178726 File Offset: 0x00176926
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0017874C File Offset: 0x0017694C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchStockPurchasesGroupedTax";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x001788CC File Offset: 0x00176ACC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchStockPurchasesGroupedTaxDataTable dataTable, int? coid, string branch, int? startdate, int? enddate)
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
			bool flag3 = startdate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = enddate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00178A70 File Offset: 0x00176C70
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchStockPurchasesGroupedTaxDataTable GetData(int? coid, string branch, int? startdate, int? enddate)
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
			bool flag3 = startdate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = enddate != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			POSDataSet.FetchStockPurchasesGroupedTaxDataTable fetchStockPurchasesGroupedTaxDataTable = new POSDataSet.FetchStockPurchasesGroupedTaxDataTable();
			this.Adapter.Fill(fetchStockPurchasesGroupedTaxDataTable);
			return fetchStockPurchasesGroupedTaxDataTable;
		}

		// Token: 0x04001323 RID: 4899
		private SqlConnection _connection;

		// Token: 0x04001324 RID: 4900
		private SqlTransaction _transaction;

		// Token: 0x04001325 RID: 4901
		private SqlCommand[] _commandCollection;

		// Token: 0x04001326 RID: 4902
		private bool _clearBeforeFill;
	}
}

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
	// Token: 0x02000135 RID: 309
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForCompanyBranchSummaryTableAdapter : Component
	{
		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x00179559 File Offset: 0x00177759
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00179563 File Offset: 0x00177763
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0017956C File Offset: 0x0017776C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForCompanyBranchSummaryTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x00179580 File Offset: 0x00177780
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

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x001795B0 File Offset: 0x001777B0
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x001795E0 File Offset: 0x001777E0
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

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x001796A4 File Offset: 0x001778A4
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x001796BC File Offset: 0x001778BC
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

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x001797A4 File Offset: 0x001779A4
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

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x001797D4 File Offset: 0x001779D4
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x001797EC File Offset: 0x001779EC
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

		// Token: 0x06002BFC RID: 11260 RVA: 0x001797F8 File Offset: 0x001779F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForCompanyBranchSummary";
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			dataTableMapping.ColumnMappings.Add("TaxAmount", "TaxAmount");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			dataTableMapping.ColumnMappings.Add("Subtotal", "Subtotal");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0017989A File Offset: 0x00177A9A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x001798C0 File Offset: 0x00177AC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForCompanyBranchSummary";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00179A08 File Offset: 0x00177C08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForCompanyBranchSummaryDataTable dataTable, int? coid, int? startdate, int? enddate)
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
			bool flag2 = startdate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = enddate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00179B60 File Offset: 0x00177D60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForCompanyBranchSummaryDataTable GetData(int? coid, int? startdate, int? enddate)
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
			bool flag2 = startdate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = enddate != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			POSDataSet.SalesForCompanyBranchSummaryDataTable salesForCompanyBranchSummaryDataTable = new POSDataSet.SalesForCompanyBranchSummaryDataTable();
			this.Adapter.Fill(salesForCompanyBranchSummaryDataTable);
			return salesForCompanyBranchSummaryDataTable;
		}

		// Token: 0x0400132D RID: 4909
		private SqlConnection _connection;

		// Token: 0x0400132E RID: 4910
		private SqlTransaction _transaction;

		// Token: 0x0400132F RID: 4911
		private SqlCommand[] _commandCollection;

		// Token: 0x04001330 RID: 4912
		private bool _clearBeforeFill;
	}
}

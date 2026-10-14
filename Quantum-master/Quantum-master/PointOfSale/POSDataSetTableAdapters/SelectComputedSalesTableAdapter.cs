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
	// Token: 0x020000D1 RID: 209
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectComputedSalesTableAdapter : Component
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x001464B4 File Offset: 0x001446B4
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x001464BE File Offset: 0x001446BE
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x001464C7 File Offset: 0x001446C7
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectComputedSalesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x001464DC File Offset: 0x001446DC
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0014650C File Offset: 0x0014470C
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0014653C File Offset: 0x0014473C
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00146600 File Offset: 0x00144800
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00146618 File Offset: 0x00144818
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

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00146700 File Offset: 0x00144900
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x00146730 File Offset: 0x00144930
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00146748 File Offset: 0x00144948
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

		// Token: 0x060025B7 RID: 9655 RVA: 0x00146754 File Offset: 0x00144954
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectComputedSales";
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("DayShiftSales1", "DayShiftSales1");
			dataTableMapping.ColumnMappings.Add("NightShiftSales1", "NightShiftSales1");
			dataTableMapping.ColumnMappings.Add("DayShiftSales2", "DayShiftSales2");
			dataTableMapping.ColumnMappings.Add("NightShiftSales2", "NightShiftSales2");
			dataTableMapping.ColumnMappings.Add("DayShiftSales3", "DayShiftSales3");
			dataTableMapping.ColumnMappings.Add("NightShiftSales3", "NightShiftSales3");
			dataTableMapping.ColumnMappings.Add("TotalSales1", "TotalSales1");
			dataTableMapping.ColumnMappings.Add("TotalSales2", "TotalSales2");
			dataTableMapping.ColumnMappings.Add("TotalSales3", "TotalSales3");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00146890 File Offset: 0x00144A90
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x001468B4 File Offset: 0x00144AB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectComputedSales";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x001469C0 File Offset: 0x00144BC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectComputedSalesDataTable dataTable, int? startdate, int? enddate)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00146ABC File Offset: 0x00144CBC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectComputedSalesDataTable GetData(int? startdate, int? enddate)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			POSDataSet.SelectComputedSalesDataTable selectComputedSalesDataTable = new POSDataSet.SelectComputedSalesDataTable();
			this.Adapter.Fill(selectComputedSalesDataTable);
			return selectComputedSalesDataTable;
		}

		// Token: 0x04001139 RID: 4409
		private SqlConnection _connection;

		// Token: 0x0400113A RID: 4410
		private SqlTransaction _transaction;

		// Token: 0x0400113B RID: 4411
		private SqlCommand[] _commandCollection;

		// Token: 0x0400113C RID: 4412
		private bool _clearBeforeFill;
	}
}

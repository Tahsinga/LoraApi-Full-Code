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
	// Token: 0x0200014C RID: 332
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForPeriodGroupedByDayTableAdapter : Component
	{
		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x001857BD File Offset: 0x001839BD
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x001857C7 File Offset: 0x001839C7
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x001857D0 File Offset: 0x001839D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForPeriodGroupedByDayTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x001857E4 File Offset: 0x001839E4
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

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00185814 File Offset: 0x00183A14
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00185844 File Offset: 0x00183A44
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

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x00185908 File Offset: 0x00183B08
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x00185920 File Offset: 0x00183B20
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

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x00185A08 File Offset: 0x00183C08
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

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x00185A38 File Offset: 0x00183C38
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x00185A50 File Offset: 0x00183C50
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

		// Token: 0x06002D70 RID: 11632 RVA: 0x00185A5C File Offset: 0x00183C5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForPeriodGroupedByDay";
			dataTableMapping.ColumnMappings.Add("TranDate", "TranDate");
			dataTableMapping.ColumnMappings.Add("SalesTotal", "SalesTotal");
			dataTableMapping.ColumnMappings.Add("TaxTotal", "TaxTotal");
			dataTableMapping.ColumnMappings.Add("ProductDiscountTotal", "ProductDiscountTotal");
			dataTableMapping.ColumnMappings.Add("GrossTotal", "GrossTotal");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00185B14 File Offset: 0x00183D14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00185B38 File Offset: 0x00183D38
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForPeriodGroupedByDay";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00185CB8 File Offset: 0x00183EB8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForPeriodGroupedByDayDataTable dataTable, int? coid, string branch, int? startdate, int? enddate)
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

		// Token: 0x06002D74 RID: 11636 RVA: 0x00185E5C File Offset: 0x0018405C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForPeriodGroupedByDayDataTable GetData(int? coid, string branch, int? startdate, int? enddate)
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
			POSDataSet.SalesForPeriodGroupedByDayDataTable salesForPeriodGroupedByDayDataTable = new POSDataSet.SalesForPeriodGroupedByDayDataTable();
			this.Adapter.Fill(salesForPeriodGroupedByDayDataTable);
			return salesForPeriodGroupedByDayDataTable;
		}

		// Token: 0x040013A0 RID: 5024
		private SqlConnection _connection;

		// Token: 0x040013A1 RID: 5025
		private SqlTransaction _transaction;

		// Token: 0x040013A2 RID: 5026
		private SqlCommand[] _commandCollection;

		// Token: 0x040013A3 RID: 5027
		private bool _clearBeforeFill;
	}
}

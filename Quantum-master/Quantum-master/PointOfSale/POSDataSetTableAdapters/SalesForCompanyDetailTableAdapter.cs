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
	// Token: 0x02000137 RID: 311
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForCompanyDetailTableAdapter : Component
	{
		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x0017A3DB File Offset: 0x001785DB
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0017A3E5 File Offset: 0x001785E5
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0017A3EE File Offset: 0x001785EE
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForCompanyDetailTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x0017A400 File Offset: 0x00178600
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

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x0017A430 File Offset: 0x00178630
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x0017A460 File Offset: 0x00178660
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

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x0017A524 File Offset: 0x00178724
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x0017A53C File Offset: 0x0017873C
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

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0017A624 File Offset: 0x00178824
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

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0017A654 File Offset: 0x00178854
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0017A66C File Offset: 0x0017886C
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

		// Token: 0x06002C1C RID: 11292 RVA: 0x0017A678 File Offset: 0x00178878
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForCompanyDetail";
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("TaxAmount", "TaxAmount");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			dataTableMapping.ColumnMappings.Add("Subtotal", "Subtotal");
			dataTableMapping.ColumnMappings.Add("ProductDesc2", "ProductDesc2");
			dataTableMapping.ColumnMappings.Add("UOM", "UOM");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x0017A788 File Offset: 0x00178988
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x0017A7AC File Offset: 0x001789AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForCompanyDetail";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x0017A8F4 File Offset: 0x00178AF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForCompanyDetailDataTable dataTable, int? coid, int? startdate, int? enddate)
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

		// Token: 0x06002C20 RID: 11296 RVA: 0x0017AA4C File Offset: 0x00178C4C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForCompanyDetailDataTable GetData(int? coid, int? startdate, int? enddate)
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
			POSDataSet.SalesForCompanyDetailDataTable salesForCompanyDetailDataTable = new POSDataSet.SalesForCompanyDetailDataTable();
			this.Adapter.Fill(salesForCompanyDetailDataTable);
			return salesForCompanyDetailDataTable;
		}

		// Token: 0x04001337 RID: 4919
		private SqlConnection _connection;

		// Token: 0x04001338 RID: 4920
		private SqlTransaction _transaction;

		// Token: 0x04001339 RID: 4921
		private SqlCommand[] _commandCollection;

		// Token: 0x0400133A RID: 4922
		private bool _clearBeforeFill;
	}
}

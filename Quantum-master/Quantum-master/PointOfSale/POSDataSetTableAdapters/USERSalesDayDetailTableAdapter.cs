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
	// Token: 0x020000FE RID: 254
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class USERSalesDayDetailTableAdapter : Component
	{
		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x0015D125 File Offset: 0x0015B325
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x0015D12F File Offset: 0x0015B32F
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0015D138 File Offset: 0x0015B338
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public USERSalesDayDetailTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0015D14C File Offset: 0x0015B34C
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

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x0015D17C File Offset: 0x0015B37C
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x0015D1AC File Offset: 0x0015B3AC
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

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x0015D270 File Offset: 0x0015B470
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x0015D288 File Offset: 0x0015B488
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

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x0015D370 File Offset: 0x0015B570
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

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x0015D3A0 File Offset: 0x0015B5A0
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0015D3B8 File Offset: 0x0015B5B8
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

		// Token: 0x0600288C RID: 10380 RVA: 0x0015D3C4 File Offset: 0x0015B5C4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "USERSalesDayDetail";
			dataTableMapping.ColumnMappings.Add("Product_Description", "Product_Description");
			dataTableMapping.ColumnMappings.Add("Product_Code", "Product_Code");
			dataTableMapping.ColumnMappings.Add("Quantity_Sold", "Quantity_Sold");
			dataTableMapping.ColumnMappings.Add("Unit_Price", "Unit_Price");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			dataTableMapping.ColumnMappings.Add("Tax", "Tax");
			dataTableMapping.ColumnMappings.Add("DiscountAmt", "DiscountAmt");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0015D4A8 File Offset: 0x0015B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0015D4CC File Offset: 0x0015B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.USERSalesDayDetail";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0015D650 File Offset: 0x0015B850
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.USERSalesDayDetailDataTable dataTable, int? shiftdate, int? coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool flag4 = theuser == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = theuser;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0015D7EC File Offset: 0x0015B9EC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.USERSalesDayDetailDataTable GetData(int? shiftdate, int? coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool flag4 = theuser == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = theuser;
			}
			POSDataSet.USERSalesDayDetailDataTable usersalesDayDetailDataTable = new POSDataSet.USERSalesDayDetailDataTable();
			this.Adapter.Fill(usersalesDayDetailDataTable);
			return usersalesDayDetailDataTable;
		}

		// Token: 0x0400121A RID: 4634
		private SqlConnection _connection;

		// Token: 0x0400121B RID: 4635
		private SqlTransaction _transaction;

		// Token: 0x0400121C RID: 4636
		private SqlCommand[] _commandCollection;

		// Token: 0x0400121D RID: 4637
		private bool _clearBeforeFill;
	}
}

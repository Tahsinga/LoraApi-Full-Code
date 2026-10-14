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
	// Token: 0x020000D4 RID: 212
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ShiftSalesNightDetailTableAdapter : Component
	{
		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x00147A65 File Offset: 0x00145C65
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x00147A6F File Offset: 0x00145C6F
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00147A78 File Offset: 0x00145C78
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ShiftSalesNightDetailTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00147A8C File Offset: 0x00145C8C
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

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x00147ABC File Offset: 0x00145CBC
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00147AEC File Offset: 0x00145CEC
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

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x00147BB0 File Offset: 0x00145DB0
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00147BC8 File Offset: 0x00145DC8
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00147CB0 File Offset: 0x00145EB0
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

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00147CE0 File Offset: 0x00145EE0
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x00147CF8 File Offset: 0x00145EF8
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

		// Token: 0x060025E7 RID: 9703 RVA: 0x00147D04 File Offset: 0x00145F04
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ShiftSalesNightDetail";
			dataTableMapping.ColumnMappings.Add("Product_ID", "Product_ID");
			dataTableMapping.ColumnMappings.Add("Product_Code", "Product_Code");
			dataTableMapping.ColumnMappings.Add("Product_Description", "Product_Description");
			dataTableMapping.ColumnMappings.Add("Quantity_Sold", "Quantity_Sold");
			dataTableMapping.ColumnMappings.Add("Unit_Cost", "Unit_Cost");
			dataTableMapping.ColumnMappings.Add("Unit_Price", "Unit_Price");
			dataTableMapping.ColumnMappings.Add("Tax", "Tax");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00147E14 File Offset: 0x00146014
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00147E38 File Offset: 0x00146038
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ShiftSalesNightDetail";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theday", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00147F80 File Offset: 0x00146180
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ShiftSalesNightDetailDataTable dataTable, int? theday, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = theday != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = theday.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x001480CC File Offset: 0x001462CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ShiftSalesNightDetailDataTable GetData(int? theday, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = theday != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = theday.Value;
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
			POSDataSet.ShiftSalesNightDetailDataTable shiftSalesNightDetailDataTable = new POSDataSet.ShiftSalesNightDetailDataTable();
			this.Adapter.Fill(shiftSalesNightDetailDataTable);
			return shiftSalesNightDetailDataTable;
		}

		// Token: 0x04001148 RID: 4424
		private SqlConnection _connection;

		// Token: 0x04001149 RID: 4425
		private SqlTransaction _transaction;

		// Token: 0x0400114A RID: 4426
		private SqlCommand[] _commandCollection;

		// Token: 0x0400114B RID: 4427
		private bool _clearBeforeFill;
	}
}

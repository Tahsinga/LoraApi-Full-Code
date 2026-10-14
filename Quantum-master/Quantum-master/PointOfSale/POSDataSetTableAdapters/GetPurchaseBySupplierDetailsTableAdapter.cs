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
	// Token: 0x02000152 RID: 338
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetPurchaseBySupplierDetailsTableAdapter : Component
	{
		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x00188F4F File Offset: 0x0018714F
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00188F59 File Offset: 0x00187159
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00188F62 File Offset: 0x00187162
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetPurchaseBySupplierDetailsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x00188F74 File Offset: 0x00187174
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

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x00188FA4 File Offset: 0x001871A4
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00188FD4 File Offset: 0x001871D4
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

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x00189098 File Offset: 0x00187298
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x001890B0 File Offset: 0x001872B0
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

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x00189198 File Offset: 0x00187398
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

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x001891C8 File Offset: 0x001873C8
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x001891E0 File Offset: 0x001873E0
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

		// Token: 0x06002DD0 RID: 11728 RVA: 0x001891EC File Offset: 0x001873EC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetPurchaseBySupplierDetails";
			dataTableMapping.ColumnMappings.Add("Reference", "Reference");
			dataTableMapping.ColumnMappings.Add("Supplier_Name", "Supplier_Name");
			dataTableMapping.ColumnMappings.Add("Tran_Date", "Tran_Date");
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x001892E6 File Offset: 0x001874E6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x0018930C File Offset: 0x0018750C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetPurchaseBySupplierDetails";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@ref", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@suppliername", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00189504 File Offset: 0x00187704
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetPurchaseBySupplierDetailsDataTable dataTable, int? coid, string branch, string @ref, string suppliername, int? startate, int? enddate)
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
			bool flag3 = @ref == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = @ref;
			}
			bool flag4 = suppliername == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = suppliername;
			}
			bool flag5 = startate != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = startate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = enddate != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00189748 File Offset: 0x00187948
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetPurchaseBySupplierDetailsDataTable GetData(int? coid, string branch, string @ref, string suppliername, int? startate, int? enddate)
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
			bool flag3 = @ref == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = @ref;
			}
			bool flag4 = suppliername == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = suppliername;
			}
			bool flag5 = startate != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = startate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = enddate != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = enddate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			POSDataSet.GetPurchaseBySupplierDetailsDataTable getPurchaseBySupplierDetailsDataTable = new POSDataSet.GetPurchaseBySupplierDetailsDataTable();
			this.Adapter.Fill(getPurchaseBySupplierDetailsDataTable);
			return getPurchaseBySupplierDetailsDataTable;
		}

		// Token: 0x040013BE RID: 5054
		private SqlConnection _connection;

		// Token: 0x040013BF RID: 5055
		private SqlTransaction _transaction;

		// Token: 0x040013C0 RID: 5056
		private SqlCommand[] _commandCollection;

		// Token: 0x040013C1 RID: 5057
		private bool _clearBeforeFill;
	}
}

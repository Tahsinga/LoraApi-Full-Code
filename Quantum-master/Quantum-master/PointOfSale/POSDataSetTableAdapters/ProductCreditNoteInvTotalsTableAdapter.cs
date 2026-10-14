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
	// Token: 0x02000111 RID: 273
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ProductCreditNoteInvTotalsTableAdapter : Component
	{
		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x001669C5 File Offset: 0x00164BC5
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x001669CF File Offset: 0x00164BCF
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x001669D8 File Offset: 0x00164BD8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductCreditNoteInvTotalsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x001669EC File Offset: 0x00164BEC
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

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x00166A1C File Offset: 0x00164C1C
		// (set) Token: 0x060029B6 RID: 10678 RVA: 0x00166A4C File Offset: 0x00164C4C
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

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x00166B10 File Offset: 0x00164D10
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x00166B28 File Offset: 0x00164D28
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

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x00166C10 File Offset: 0x00164E10
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

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x00166C40 File Offset: 0x00164E40
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x00166C58 File Offset: 0x00164E58
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

		// Token: 0x060029BC RID: 10684 RVA: 0x00166C64 File Offset: 0x00164E64
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ProductCreditNoteInvTotals";
			dataTableMapping.ColumnMappings.Add("TotalExcl", "TotalExcl");
			dataTableMapping.ColumnMappings.Add("therate", "therate");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00166CDA File Offset: 0x00164EDA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00166D00 File Offset: 0x00164F00
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ProductCreditNoteInvTotals";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00166E0C File Offset: 0x0016500C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ProductCreditNoteInvTotalsDataTable dataTable, int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00166F08 File Offset: 0x00165108
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ProductCreditNoteInvTotalsDataTable GetData(int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			POSDataSet.ProductCreditNoteInvTotalsDataTable productCreditNoteInvTotalsDataTable = new POSDataSet.ProductCreditNoteInvTotalsDataTable();
			this.Adapter.Fill(productCreditNoteInvTotalsDataTable);
			return productCreditNoteInvTotalsDataTable;
		}

		// Token: 0x04001279 RID: 4729
		private SqlConnection _connection;

		// Token: 0x0400127A RID: 4730
		private SqlTransaction _transaction;

		// Token: 0x0400127B RID: 4731
		private SqlCommand[] _commandCollection;

		// Token: 0x0400127C RID: 4732
		private bool _clearBeforeFill;
	}
}

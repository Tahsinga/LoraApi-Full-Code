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
	// Token: 0x0200010F RID: 271
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetQuotationHeaderTableAdapter : Component
	{
		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x00165AC3 File Offset: 0x00163CC3
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x00165ACD File Offset: 0x00163CCD
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00165AD6 File Offset: 0x00163CD6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetQuotationHeaderTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x00165AE8 File Offset: 0x00163CE8
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

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x00165B18 File Offset: 0x00163D18
		// (set) Token: 0x06002996 RID: 10646 RVA: 0x00165B48 File Offset: 0x00163D48
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x00165C0C File Offset: 0x00163E0C
		// (set) Token: 0x06002998 RID: 10648 RVA: 0x00165C24 File Offset: 0x00163E24
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x00165D0C File Offset: 0x00163F0C
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x00165D3C File Offset: 0x00163F3C
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x00165D54 File Offset: 0x00163F54
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

		// Token: 0x0600299C RID: 10652 RVA: 0x00165D60 File Offset: 0x00163F60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetQuotationHeader";
			dataTableMapping.ColumnMappings.Add("QuotationNum", "QuotationNum");
			dataTableMapping.ColumnMappings.Add("TotalIncl", "TotalIncl");
			dataTableMapping.ColumnMappings.Add("TotalExcl", "TotalExcl");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00165DEC File Offset: 0x00163FEC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00165E10 File Offset: 0x00164010
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetQuotationHeader";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@quotationnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00165F1C File Offset: 0x0016411C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetQuotationHeaderDataTable dataTable, int? quotationnum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnum.Value;
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

		// Token: 0x060029A0 RID: 10656 RVA: 0x00166018 File Offset: 0x00164218
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetQuotationHeaderDataTable GetData(int? quotationnum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnum.Value;
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
			POSDataSet.GetQuotationHeaderDataTable getQuotationHeaderDataTable = new POSDataSet.GetQuotationHeaderDataTable();
			this.Adapter.Fill(getQuotationHeaderDataTable);
			return getQuotationHeaderDataTable;
		}

		// Token: 0x0400126F RID: 4719
		private SqlConnection _connection;

		// Token: 0x04001270 RID: 4720
		private SqlTransaction _transaction;

		// Token: 0x04001271 RID: 4721
		private SqlCommand[] _commandCollection;

		// Token: 0x04001272 RID: 4722
		private bool _clearBeforeFill;
	}
}

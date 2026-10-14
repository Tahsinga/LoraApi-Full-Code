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
	// Token: 0x020000F7 RID: 247
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetBranchDetailsTableAdapter : Component
	{
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0015939C File Offset: 0x0015759C
		// (set) Token: 0x0600280D RID: 10253 RVA: 0x001593A6 File Offset: 0x001575A6
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x001593AF File Offset: 0x001575AF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetBranchDetailsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x001593C4 File Offset: 0x001575C4
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x001593F4 File Offset: 0x001575F4
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x00159424 File Offset: 0x00157624
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x001594E8 File Offset: 0x001576E8
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00159500 File Offset: 0x00157700
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x001595E8 File Offset: 0x001577E8
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00159618 File Offset: 0x00157818
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00159630 File Offset: 0x00157830
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

		// Token: 0x06002817 RID: 10263 RVA: 0x0015963C File Offset: 0x0015783C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetBranchDetails";
			dataTableMapping.ColumnMappings.Add("Branch", "Branch");
			dataTableMapping.ColumnMappings.Add("Coid", "Coid");
			dataTableMapping.ColumnMappings.Add("Visible", "Visible");
			dataTableMapping.ColumnMappings.Add("Colour", "Colour");
			dataTableMapping.ColumnMappings.Add("Tel", "Tel");
			dataTableMapping.ColumnMappings.Add("Tel2", "Tel2");
			dataTableMapping.ColumnMappings.Add("Tel3", "Tel3");
			dataTableMapping.ColumnMappings.Add("Email", "Email");
			dataTableMapping.ColumnMappings.Add("Address", "Address");
			dataTableMapping.ColumnMappings.Add("BPNumber", "BPNumber");
			dataTableMapping.ColumnMappings.Add("CompanyName", "CompanyName");
			dataTableMapping.ColumnMappings.Add("Footnote", "Footnote");
			dataTableMapping.ColumnMappings.Add("VatNumber", "VatNumber");
			dataTableMapping.ColumnMappings.Add("Address2", "Address2");
			dataTableMapping.ColumnMappings.Add("VendorNumber", "VendorNumber");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x001597D0 File Offset: 0x001579D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x001597F4 File Offset: 0x001579F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetBranchDetails";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00159900 File Offset: 0x00157B00
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetBranchDetailsDataTable dataTable, string branch, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = branch == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = branch;
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

		// Token: 0x0600281B RID: 10267 RVA: 0x001599F0 File Offset: 0x00157BF0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetBranchDetailsDataTable GetData(string branch, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = branch == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = branch;
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
			POSDataSet.GetBranchDetailsDataTable getBranchDetailsDataTable = new POSDataSet.GetBranchDetailsDataTable();
			this.Adapter.Fill(getBranchDetailsDataTable);
			return getBranchDetailsDataTable;
		}

		// Token: 0x040011F7 RID: 4599
		private SqlConnection _connection;

		// Token: 0x040011F8 RID: 4600
		private SqlTransaction _transaction;

		// Token: 0x040011F9 RID: 4601
		private SqlCommand[] _commandCollection;

		// Token: 0x040011FA RID: 4602
		private bool _clearBeforeFill;
	}
}

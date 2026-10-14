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
	// Token: 0x02000143 RID: 323
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class RepairsViewTableAdapter : Component
	{
		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x00180B2D File Offset: 0x0017ED2D
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00180B37 File Offset: 0x0017ED37
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00180B40 File Offset: 0x0017ED40
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public RepairsViewTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x00180B54 File Offset: 0x0017ED54
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

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x00180B84 File Offset: 0x0017ED84
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x00180BB4 File Offset: 0x0017EDB4
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x00180C78 File Offset: 0x0017EE78
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00180C90 File Offset: 0x0017EE90
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x00180D78 File Offset: 0x0017EF78
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x00180DA8 File Offset: 0x0017EFA8
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x00180DC0 File Offset: 0x0017EFC0
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

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00180DCC File Offset: 0x0017EFCC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "RepairsView";
			dataTableMapping.ColumnMappings.Add("EntryNo", "EntryNo");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("OwnerName", "OwnerName");
			dataTableMapping.ColumnMappings.Add("Issues", "Issues");
			dataTableMapping.ColumnMappings.Add("OwnerMobile", "OwnerMobile");
			dataTableMapping.ColumnMappings.Add("OwnerAddress", "OwnerAddress");
			dataTableMapping.ColumnMappings.Add("SerialNumber", "SerialNumber");
			dataTableMapping.ColumnMappings.Add("DateIn", "DateIn");
			dataTableMapping.ColumnMappings.Add("Technician", "Technician");
			dataTableMapping.ColumnMappings.Add("TechnicianComments", "TechnicianComments");
			dataTableMapping.ColumnMappings.Add("Photo1", "Photo1");
			dataTableMapping.ColumnMappings.Add("Photo2", "Photo2");
			dataTableMapping.ColumnMappings.Add("Photo3", "Photo3");
			dataTableMapping.ColumnMappings.Add("DateOut", "DateOut");
			dataTableMapping.ColumnMappings.Add("ReceivedBy", "ReceivedBy");
			dataTableMapping.ColumnMappings.Add("PaymentMethodID", "PaymentMethodID");
			dataTableMapping.ColumnMappings.Add("Rate", "Rate");
			dataTableMapping.ColumnMappings.Add("AmountCharged", "AmountCharged");
			dataTableMapping.ColumnMappings.Add("InBy", "InBy");
			dataTableMapping.ColumnMappings.Add("InDate", "InDate");
			dataTableMapping.ColumnMappings.Add("InMachinename", "InMachinename");
			dataTableMapping.ColumnMappings.Add("OutBy", "OutBy");
			dataTableMapping.ColumnMappings.Add("OutDate", "OutDate");
			dataTableMapping.ColumnMappings.Add("OutMachineName", "OutMachineName");
			dataTableMapping.ColumnMappings.Add("coid", "coid");
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00181052 File Offset: 0x0017F252
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00181078 File Offset: 0x0017F278
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.RepairsView";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@entryno", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x001811C0 File Offset: 0x0017F3C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.RepairsViewDataTable dataTable, int? coid, string branch, int? entryno)
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
			bool flag3 = entryno != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = entryno.Value;
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

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00181308 File Offset: 0x0017F508
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.RepairsViewDataTable GetData(int? coid, string branch, int? entryno)
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
			bool flag3 = entryno != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = entryno.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			POSDataSet.RepairsViewDataTable repairsViewDataTable = new POSDataSet.RepairsViewDataTable();
			this.Adapter.Fill(repairsViewDataTable);
			return repairsViewDataTable;
		}

		// Token: 0x04001373 RID: 4979
		private SqlConnection _connection;

		// Token: 0x04001374 RID: 4980
		private SqlTransaction _transaction;

		// Token: 0x04001375 RID: 4981
		private SqlCommand[] _commandCollection;

		// Token: 0x04001376 RID: 4982
		private bool _clearBeforeFill;
	}
}

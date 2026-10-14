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
	// Token: 0x02000146 RID: 326
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class DespatchNoteTableAdapter : Component
	{
		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x00182560 File Offset: 0x00180760
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x0018256A File Offset: 0x0018076A
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00182573 File Offset: 0x00180773
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DespatchNoteTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00182588 File Offset: 0x00180788
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

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x001825B8 File Offset: 0x001807B8
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x001825E8 File Offset: 0x001807E8
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

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x001826AC File Offset: 0x001808AC
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x001826C4 File Offset: 0x001808C4
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

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x001827AC File Offset: 0x001809AC
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

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x001827DC File Offset: 0x001809DC
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x001827F4 File Offset: 0x001809F4
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

		// Token: 0x06002D10 RID: 11536 RVA: 0x00182800 File Offset: 0x00180A00
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "DespatchNote";
			dataTableMapping.ColumnMappings.Add("Sale_Date", "Sale_Date");
			dataTableMapping.ColumnMappings.Add("Despatch_Number", "Despatch_Number");
			dataTableMapping.ColumnMappings.Add("Product_ID", "Product_ID");
			dataTableMapping.ColumnMappings.Add("Product_Code", "Product_Code");
			dataTableMapping.ColumnMappings.Add("Description", "Description");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("DoneBy", "DoneBy");
			dataTableMapping.ColumnMappings.Add("uom", "uom");
			dataTableMapping.ColumnMappings.Add("Ref", "Ref");
			dataTableMapping.ColumnMappings.Add("OtherDetail", "OtherDetail");
			dataTableMapping.ColumnMappings.Add("Comments", "Comments");
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			dataTableMapping.ColumnMappings.Add("ProductWeight", "ProductWeight");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00182968 File Offset: 0x00180B68
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0018298C File Offset: 0x00180B8C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.DespatchNote";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00182AD4 File Offset: 0x00180CD4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.DespatchNoteDataTable dataTable, int? invoicenum, int? coid, string branch)
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

		// Token: 0x06002D14 RID: 11540 RVA: 0x00182C20 File Offset: 0x00180E20
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.DespatchNoteDataTable GetData(int? invoicenum, int? coid, string branch)
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
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			POSDataSet.DespatchNoteDataTable despatchNoteDataTable = new POSDataSet.DespatchNoteDataTable();
			this.Adapter.Fill(despatchNoteDataTable);
			return despatchNoteDataTable;
		}

		// Token: 0x04001382 RID: 4994
		private SqlConnection _connection;

		// Token: 0x04001383 RID: 4995
		private SqlTransaction _transaction;

		// Token: 0x04001384 RID: 4996
		private SqlCommand[] _commandCollection;

		// Token: 0x04001385 RID: 4997
		private bool _clearBeforeFill;
	}
}

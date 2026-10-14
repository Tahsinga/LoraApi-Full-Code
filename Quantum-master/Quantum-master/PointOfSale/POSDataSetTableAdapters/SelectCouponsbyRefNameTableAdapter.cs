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
	// Token: 0x020000CE RID: 206
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectCouponsbyRefNameTableAdapter : Component
	{
		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0014529B File Offset: 0x0014349B
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x001452A5 File Offset: 0x001434A5
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x001452AE File Offset: 0x001434AE
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectCouponsbyRefNameTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x001452C0 File Offset: 0x001434C0
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

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x001452F0 File Offset: 0x001434F0
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00145320 File Offset: 0x00143520
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x001453E4 File Offset: 0x001435E4
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x001453FC File Offset: 0x001435FC
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

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x001454E4 File Offset: 0x001436E4
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

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x00145514 File Offset: 0x00143714
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x0014552C File Offset: 0x0014372C
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

		// Token: 0x06002587 RID: 9607 RVA: 0x00145538 File Offset: 0x00143738
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectCouponsbyRefName";
			dataTableMapping.ColumnMappings.Add("CouponNumber", "CouponNumber");
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("DiscountPercentage", "DiscountPercentage");
			dataTableMapping.ColumnMappings.Add("Used", "Used");
			dataTableMapping.ColumnMappings.Add("CreatedBy", "CreatedBy");
			dataTableMapping.ColumnMappings.Add("CreatedWhen", "CreatedWhen");
			dataTableMapping.ColumnMappings.Add("coid", "coid");
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			dataTableMapping.ColumnMappings.Add("QtyRequired", "QtyRequired");
			dataTableMapping.ColumnMappings.Add("RefName", "RefName");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00145674 File Offset: 0x00143874
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00145698 File Offset: 0x00143898
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectCouponsbyRefName";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RefName", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0014576C File Offset: 0x0014396C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectCouponsbyRefNameDataTable dataTable, string RefName)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = RefName == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = RefName;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00145800 File Offset: 0x00143A00
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectCouponsbyRefNameDataTable GetData(string RefName)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = RefName == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = RefName;
			}
			POSDataSet.SelectCouponsbyRefNameDataTable selectCouponsbyRefNameDataTable = new POSDataSet.SelectCouponsbyRefNameDataTable();
			this.Adapter.Fill(selectCouponsbyRefNameDataTable);
			return selectCouponsbyRefNameDataTable;
		}

		// Token: 0x0400112A RID: 4394
		private SqlConnection _connection;

		// Token: 0x0400112B RID: 4395
		private SqlTransaction _transaction;

		// Token: 0x0400112C RID: 4396
		private SqlCommand[] _commandCollection;

		// Token: 0x0400112D RID: 4397
		private bool _clearBeforeFill;
	}
}

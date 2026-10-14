using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x0200015D RID: 349
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	public class TableAdapterManager : Component
	{
		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00195044 File Offset: 0x00193244
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x0019505C File Offset: 0x0019325C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00195068 File Offset: 0x00193268
		// (set) Token: 0x06002E83 RID: 11907 RVA: 0x00195080 File Offset: 0x00193280
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get
			{
				return this._bankingDetails2TableAdapter;
			}
			set
			{
				this._bankingDetails2TableAdapter = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x0019508C File Offset: 0x0019328C
		// (set) Token: 0x06002E85 RID: 11909 RVA: 0x001950A4 File Offset: 0x001932A4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public ShiftDetailTableAdapter ShiftDetailTableAdapter
		{
			get
			{
				return this._shiftDetailTableAdapter;
			}
			set
			{
				this._shiftDetailTableAdapter = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x001950B0 File Offset: 0x001932B0
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x001950C8 File Offset: 0x001932C8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x001950D4 File Offset: 0x001932D4
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x00195156 File Offset: 0x00193356
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public IDbConnection Connection
		{
			get
			{
				bool flag = this._connection != null;
				IDbConnection dbConnection;
				if (flag)
				{
					dbConnection = this._connection;
				}
				else
				{
					bool flag2 = this._bankingDetails2TableAdapter != null && this._bankingDetails2TableAdapter.Connection != null;
					if (flag2)
					{
						dbConnection = this._bankingDetails2TableAdapter.Connection;
					}
					else
					{
						bool flag3 = this._shiftDetailTableAdapter != null && this._shiftDetailTableAdapter.Connection != null;
						if (flag3)
						{
							dbConnection = this._shiftDetailTableAdapter.Connection;
						}
						else
						{
							dbConnection = null;
						}
					}
				}
				return dbConnection;
			}
			set
			{
				this._connection = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x00195160 File Offset: 0x00193360
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int TableAdapterInstanceCount
		{
			get
			{
				int num = 0;
				bool flag = this._bankingDetails2TableAdapter != null;
				checked
				{
					if (flag)
					{
						num++;
					}
					bool flag2 = this._shiftDetailTableAdapter != null;
					if (flag2)
					{
						num++;
					}
					return num;
				}
			}
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x0019519C File Offset: 0x0019339C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(POSDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int num = 0;
			bool flag = this._bankingDetails2TableAdapter != null;
			checked
			{
				if (flag)
				{
					DataRow[] array = dataSet.BankingDetails2.Select(null, null, DataViewRowState.ModifiedCurrent);
					array = this.GetRealUpdatedRows(array, allAddedRows);
					bool flag2 = array != null && 0 < array.Length;
					if (flag2)
					{
						num += this._bankingDetails2TableAdapter.Update(array);
						allChangedRows.AddRange(array);
					}
				}
				bool flag3 = this._shiftDetailTableAdapter != null;
				if (flag3)
				{
					DataRow[] array2 = dataSet.ShiftDetail.Select(null, null, DataViewRowState.ModifiedCurrent);
					array2 = this.GetRealUpdatedRows(array2, allAddedRows);
					bool flag4 = array2 != null && 0 < array2.Length;
					if (flag4)
					{
						num += this._shiftDetailTableAdapter.Update(array2);
						allChangedRows.AddRange(array2);
					}
				}
				return num;
			}
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00195260 File Offset: 0x00193460
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(POSDataSet dataSet, List<DataRow> allAddedRows)
		{
			int num = 0;
			bool flag = this._bankingDetails2TableAdapter != null;
			checked
			{
				if (flag)
				{
					DataRow[] array = dataSet.BankingDetails2.Select(null, null, DataViewRowState.Added);
					bool flag2 = array != null && 0 < array.Length;
					if (flag2)
					{
						num += this._bankingDetails2TableAdapter.Update(array);
						allAddedRows.AddRange(array);
					}
				}
				bool flag3 = this._shiftDetailTableAdapter != null;
				if (flag3)
				{
					DataRow[] array2 = dataSet.ShiftDetail.Select(null, null, DataViewRowState.Added);
					bool flag4 = array2 != null && 0 < array2.Length;
					if (flag4)
					{
						num += this._shiftDetailTableAdapter.Update(array2);
						allAddedRows.AddRange(array2);
					}
				}
				return num;
			}
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00195310 File Offset: 0x00193510
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(POSDataSet dataSet, List<DataRow> allChangedRows)
		{
			int num = 0;
			bool flag = this._shiftDetailTableAdapter != null;
			checked
			{
				if (flag)
				{
					DataRow[] array = dataSet.ShiftDetail.Select(null, null, DataViewRowState.Deleted);
					bool flag2 = array != null && 0 < array.Length;
					if (flag2)
					{
						num += this._shiftDetailTableAdapter.Update(array);
						allChangedRows.AddRange(array);
					}
				}
				bool flag3 = this._bankingDetails2TableAdapter != null;
				if (flag3)
				{
					DataRow[] array2 = dataSet.BankingDetails2.Select(null, null, DataViewRowState.Deleted);
					bool flag4 = array2 != null && 0 < array2.Length;
					if (flag4)
					{
						num += this._bankingDetails2TableAdapter.Update(array2);
						allChangedRows.AddRange(array2);
					}
				}
				return num;
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x001953C0 File Offset: 0x001935C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			bool flag = updatedRows == null || updatedRows.Length < 1;
			DataRow[] array;
			if (flag)
			{
				array = updatedRows;
			}
			else
			{
				bool flag2 = allAddedRows == null || allAddedRows.Count < 1;
				if (flag2)
				{
					array = updatedRows;
				}
				else
				{
					List<DataRow> list = new List<DataRow>();
					foreach (DataRow dataRow in updatedRows)
					{
						bool flag3 = !allAddedRows.Contains(dataRow);
						if (flag3)
						{
							list.Add(dataRow);
						}
					}
					array = list.ToArray();
				}
			}
			return array;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00195444 File Offset: 0x00193644
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(POSDataSet dataSet)
		{
			bool flag = dataSet == null;
			if (flag)
			{
				throw new ArgumentNullException("dataSet");
			}
			bool flag2 = !dataSet.HasChanges();
			checked
			{
				int num;
				if (flag2)
				{
					num = 0;
				}
				else
				{
					bool flag3 = this._bankingDetails2TableAdapter != null && !this.MatchTableAdapterConnection(this._bankingDetails2TableAdapter.Connection);
					if (flag3)
					{
						throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
					}
					bool flag4 = this._shiftDetailTableAdapter != null && !this.MatchTableAdapterConnection(this._shiftDetailTableAdapter.Connection);
					if (flag4)
					{
						throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
					}
					IDbConnection connection = this.Connection;
					bool flag5 = connection == null;
					if (flag5)
					{
						throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
					}
					bool flag6 = false;
					bool flag7 = (connection.State & ConnectionState.Broken) == ConnectionState.Broken;
					if (flag7)
					{
						connection.Close();
					}
					bool flag8 = connection.State == ConnectionState.Closed;
					if (flag8)
					{
						connection.Open();
						flag6 = true;
					}
					IDbTransaction dbTransaction = connection.BeginTransaction();
					bool flag9 = dbTransaction == null;
					if (flag9)
					{
						throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
					}
					List<DataRow> list = new List<DataRow>();
					List<DataRow> list2 = new List<DataRow>();
					List<DataAdapter> list3 = new List<DataAdapter>();
					Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
					int num2 = 0;
					DataSet dataSet2 = null;
					bool backupDataSetBeforeUpdate = this.BackupDataSetBeforeUpdate;
					if (backupDataSetBeforeUpdate)
					{
						dataSet2 = new DataSet();
						dataSet2.Merge(dataSet);
					}
					try
					{
						bool flag10 = this._bankingDetails2TableAdapter != null;
						if (flag10)
						{
							dictionary.Add(this._bankingDetails2TableAdapter, this._bankingDetails2TableAdapter.Connection);
							this._bankingDetails2TableAdapter.Connection = (SqlConnection)connection;
							this._bankingDetails2TableAdapter.Transaction = (SqlTransaction)dbTransaction;
							bool acceptChangesDuringUpdate = this._bankingDetails2TableAdapter.Adapter.AcceptChangesDuringUpdate;
							if (acceptChangesDuringUpdate)
							{
								this._bankingDetails2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								list3.Add(this._bankingDetails2TableAdapter.Adapter);
							}
						}
						bool flag11 = this._shiftDetailTableAdapter != null;
						if (flag11)
						{
							dictionary.Add(this._shiftDetailTableAdapter, this._shiftDetailTableAdapter.Connection);
							this._shiftDetailTableAdapter.Connection = (SqlConnection)connection;
							this._shiftDetailTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							bool acceptChangesDuringUpdate2 = this._shiftDetailTableAdapter.Adapter.AcceptChangesDuringUpdate;
							if (acceptChangesDuringUpdate2)
							{
								this._shiftDetailTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								list3.Add(this._shiftDetailTableAdapter.Adapter);
							}
						}
						bool flag12 = this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
						if (flag12)
						{
							num2 += this.UpdateUpdatedRows(dataSet, list, list2);
							num2 += this.UpdateInsertedRows(dataSet, list2);
						}
						else
						{
							num2 += this.UpdateInsertedRows(dataSet, list2);
							num2 += this.UpdateUpdatedRows(dataSet, list, list2);
						}
						num2 += this.UpdateDeletedRows(dataSet, list);
						dbTransaction.Commit();
						bool flag13 = 0 < list2.Count;
						if (flag13)
						{
							DataRow[] array = new DataRow[list2.Count - 1 + 1];
							list2.CopyTo(array);
							foreach (DataRow dataRow in array)
							{
								dataRow.AcceptChanges();
							}
						}
						bool flag14 = 0 < list.Count;
						if (flag14)
						{
							DataRow[] array2 = new DataRow[list.Count - 1 + 1];
							list.CopyTo(array2);
							foreach (DataRow dataRow2 in array2)
							{
								dataRow2.AcceptChanges();
							}
						}
					}
					catch (Exception ex)
					{
						dbTransaction.Rollback();
						bool backupDataSetBeforeUpdate2 = this.BackupDataSetBeforeUpdate;
						if (backupDataSetBeforeUpdate2)
						{
							Debug.Assert(dataSet2 != null);
							dataSet.Clear();
							dataSet.Merge(dataSet2);
						}
						else
						{
							bool flag15 = 0 < list2.Count;
							if (flag15)
							{
								DataRow[] array3 = new DataRow[list2.Count - 1 + 1];
								list2.CopyTo(array3);
								foreach (DataRow dataRow3 in array3)
								{
									dataRow3.AcceptChanges();
									dataRow3.SetAdded();
								}
							}
						}
						throw ex;
					}
					finally
					{
						bool flag16 = flag6;
						if (flag16)
						{
							connection.Close();
						}
						bool flag17 = this._bankingDetails2TableAdapter != null;
						if (flag17)
						{
							this._bankingDetails2TableAdapter.Connection = (SqlConnection)dictionary[this._bankingDetails2TableAdapter];
							this._bankingDetails2TableAdapter.Transaction = null;
						}
						bool flag18 = this._shiftDetailTableAdapter != null;
						if (flag18)
						{
							this._shiftDetailTableAdapter.Connection = (SqlConnection)dictionary[this._shiftDetailTableAdapter];
							this._shiftDetailTableAdapter.Transaction = null;
						}
						bool flag19 = 0 < list3.Count;
						if (flag19)
						{
							DataAdapter[] array4 = new DataAdapter[list3.Count - 1 + 1];
							list3.CopyTo(array4);
							foreach (DataAdapter dataAdapter in array4)
							{
								dataAdapter.AcceptChangesDuringUpdate = true;
							}
						}
					}
					num = num2;
				}
				return num;
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00195984 File Offset: 0x00193B84
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00195998 File Offset: 0x00193B98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			bool flag = this._connection != null;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = this.Connection == null || inputConnection == null;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
					flag2 = flag4;
				}
			}
			return flag2;
		}

		// Token: 0x040013F0 RID: 5104
		private TableAdapterManager.UpdateOrderOption _updateOrder;

		// Token: 0x040013F1 RID: 5105
		private BankingDetails2TableAdapter _bankingDetails2TableAdapter;

		// Token: 0x040013F2 RID: 5106
		private ShiftDetailTableAdapter _shiftDetailTableAdapter;

		// Token: 0x040013F3 RID: 5107
		private bool _backupDataSetBeforeUpdate;

		// Token: 0x040013F4 RID: 5108
		private IDbConnection _connection;

		// Token: 0x0200058F RID: 1423
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			// Token: 0x0400379D RID: 14237
			InsertUpdateDelete,
			// Token: 0x0400379E RID: 14238
			UpdateInsertDelete
		}

		// Token: 0x02000590 RID: 1424
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			// Token: 0x06009CA1 RID: 40097 RVA: 0x00447F20 File Offset: 0x00446120
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (childFirst)
				{
					this._childFirst = -1;
				}
				else
				{
					this._childFirst = 1;
				}
			}

			// Token: 0x06009CA2 RID: 40098 RVA: 0x00447F54 File Offset: 0x00446154
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, ref int distance)
			{
				Debug.Assert(row != null);
				DataRow dataRow = row;
				distance = 0;
				IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
				dictionary[row] = row;
				DataRow dataRow2 = row.GetParentRow(this._relation, DataRowVersion.Default);
				checked
				{
					while (dataRow2 != null && !dictionary.ContainsKey(dataRow2))
					{
						distance++;
						dataRow = dataRow2;
						dictionary[dataRow2] = dataRow2;
						dataRow2 = dataRow2.GetParentRow(this._relation, DataRowVersion.Default);
					}
					bool flag = distance == 0;
					if (flag)
					{
						dictionary.Clear();
						dictionary[row] = row;
						dataRow2 = row.GetParentRow(this._relation, DataRowVersion.Original);
						while (dataRow2 != null && !dictionary.ContainsKey(dataRow2))
						{
							distance++;
							dataRow = dataRow2;
							dictionary[dataRow2] = dataRow2;
							dataRow2 = dataRow2.GetParentRow(this._relation, DataRowVersion.Original);
						}
					}
					return dataRow;
				}
			}

			// Token: 0x06009CA3 RID: 40099 RVA: 0x00448040 File Offset: 0x00446240
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				bool flag = object.ReferenceEquals(row1, row2);
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					bool flag2 = row1 == null;
					if (flag2)
					{
						num = -1;
					}
					else
					{
						bool flag3 = row2 == null;
						if (flag3)
						{
							num = 1;
						}
						else
						{
							int num2 = 0;
							DataRow root = this.GetRoot(row1, ref num2);
							int num3 = 0;
							DataRow root2 = this.GetRoot(row2, ref num3);
							bool flag4 = object.ReferenceEquals(root, root2);
							if (flag4)
							{
								num = checked(this._childFirst * num2.CompareTo(num3));
							}
							else
							{
								Debug.Assert(root.Table != null && root2.Table != null);
								bool flag5 = root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2);
								if (flag5)
								{
									num = -1;
								}
								else
								{
									num = 1;
								}
							}
						}
					}
				}
				return num;
			}

			// Token: 0x0400379F RID: 14239
			private DataRelation _relation;

			// Token: 0x040037A0 RID: 14240
			private int _childFirst;
		}
	}
}

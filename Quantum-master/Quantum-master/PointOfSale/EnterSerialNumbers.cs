using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000055 RID: 85
	[DesignerGenerated]
	public partial class EnterSerialNumbers : Form
	{
		// Token: 0x060011DE RID: 4574 RVA: 0x000AB814 File Offset: 0x000A9A14
		public EnterSerialNumbers()
		{
			base.Load += this.EnterSerialNumbers_Load;
			this.numofproducts = 0;
			this.productdesc = "";
			this.productid = 0;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x000ABD6E File Offset: 0x000A9F6E
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x000ABD78 File Offset: 0x000A9F78
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000ABD81 File Offset: 0x000A9F81
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x000ABD8B File Offset: 0x000A9F8B
		internal virtual DataGridView dgvSerials
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000ABD94 File Offset: 0x000A9F94
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x000ABD9E File Offset: 0x000A9F9E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000ABDA7 File Offset: 0x000A9FA7
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x000ABDB1 File Offset: 0x000A9FB1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x000ABDBA File Offset: 0x000A9FBA
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x000ABDC4 File Offset: 0x000A9FC4
		internal virtual TextBox TXTDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x000ABDCD File Offset: 0x000A9FCD
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x000ABDD7 File Offset: 0x000A9FD7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x000ABDEC File Offset: 0x000A9FEC
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000ABE30 File Offset: 0x000AA030
		private void EnterSerialNumbers_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.Label2.Text = "ENTER " + MyProject.Forms.Form1.serialNumberName + " FOR NEW STOCK PURCHASE";
					DataTable dataTable = new DataTable();
					MyProject.Forms.Form1.datSerials = dataTable;
					this.Text = "Enter " + MyProject.Forms.Form1.serialNumberName;
					this.Label3.Text = "Number of " + MyProject.Forms.Form1.serialNumberName + " required is " + Conversions.ToString(this.numofproducts);
					this.TXTDESC.Text = this.productdesc;
					bool flag = (Operators.CompareString(this.productdesc, "", false) != 0) & (this.numofproducts != 0);
					if (flag)
					{
						this.dgvSerials.Columns.Add("ProductID", "Product ID");
						this.dgvSerials.Columns.Add("ProductDesc", "Product Description");
						this.dgvSerials.Columns.Add("SerialNumber", MyProject.Forms.Form1.serialNumberName);
						int num = this.numofproducts;
						for (int i = 1; i <= num; i++)
						{
							string[] array = new string[]
							{
								Conversions.ToString(this.productid),
								this.productdesc,
								""
							};
							this.dgvSerials.Rows.Add(array);
						}
						this.dgvSerials.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
						this.dgvSerials.Columns["ProductDesc"].ReadOnly = true;
						this.dgvSerials.Columns["ProductID"].Visible = false;
					}
					else
					{
						MessageBox.Show("Please ensure that the product and quantity is entered first.");
						base.Dispose();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading form. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000AC070 File Offset: 0x000AA270
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvSerials.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Operators.CompareString(dataGridViewRow.Cells["SerialNumber"].Value.ToString(), "", false) != 0;
							if (flag)
							{
								num++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					bool flag2 = num == this.numofproducts;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to save these serial numbers?", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							MyProject.Forms.Form1.datSerials = this.pf.ConvertDatagridviewToDataTable(this.dgvSerials, true);
							base.Dispose();
						}
					}
					else
					{
						MessageBox.Show("Please enter all the required serial numbers.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error submitting. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x04000869 RID: 2153
		public int numofproducts;

		// Token: 0x0400086A RID: 2154
		public string productdesc;

		// Token: 0x0400086B RID: 2155
		public int productid;

		// Token: 0x0400086C RID: 2156
		private PublicFunctions pf;
	}
}

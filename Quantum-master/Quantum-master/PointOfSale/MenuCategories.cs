using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200006F RID: 111
	[DesignerGenerated]
	public partial class MenuCategories : Form
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x000EC6EC File Offset: 0x000EA8EC
		public MenuCategories()
		{
			base.Load += this.MenuCategories_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.categoryname = "";
			this.selectedproductid_cat = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000EC874 File Offset: 0x000EAA74
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x000EC87E File Offset: 0x000EAA7E
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000EC888 File Offset: 0x000EAA88
		private void MenuCategories_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading products. Detail: " + ex.Message);
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x000EC8D8 File Offset: 0x000EAAD8
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			int num = 1;
			int btnHeight = MyProject.Forms.Form1.btnHeight;
			int btnWidth = MyProject.Forms.Form1.btnWidth;
			int num2 = 5;
			int num3 = 35;
			FontFamily fontFamily = new FontFamily("Arial");
			int btnFontSize = MyProject.Forms.Form1.btnFontSize;
			Font font = new Font(fontFamily, (float)btnFontSize, FontStyle.Regular, GraphicsUnit.Pixel);
			checked
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Button button = new Button();
						button.BackColor = Color.LightYellow;
						bool flag = num == 1;
						if (flag)
						{
							button.Text = Conversions.ToString(dataRow["CatDesc"]);
							button.Name = Conversions.ToString(dataRow["CatDesc"]);
							bool flag2 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["pic"]));
							if (flag2)
							{
								byte[] array = (byte[])dataRow["pic"];
								MemoryStream memoryStream = new MemoryStream(array);
								button.Image = Image.FromStream(memoryStream);
							}
							button.Location = new Point(num2, num3);
							num2 = num2 + btnWidth + MyProject.Forms.Form1.btnSpace;
							button.Height = btnHeight;
							button.Width = btnWidth;
							button.Font = font;
							this.Panel1.Controls.Add(button);
							button.Click += this.Button_Click;
							num++;
						}
						else
						{
							button.Text = Conversions.ToString(dataRow["CatDesc"]);
							button.Name = Conversions.ToString(dataRow["CatDesc"]);
							bool flag3 = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["pic"]));
							if (flag3)
							{
								byte[] array2 = (byte[])dataRow["pic"];
								MemoryStream memoryStream2 = new MemoryStream(array2);
								button.Image = Image.FromStream(memoryStream2);
							}
							button.Location = new Point(num2, num3);
							bool flag4 = num % MyProject.Forms.Form1.btnCountperLine == 0;
							if (flag4)
							{
								num3 = num3 + btnHeight + MyProject.Forms.Form1.btnSpace;
								num2 = 5;
							}
							else
							{
								num2 = num2 + btnWidth + MyProject.Forms.Form1.btnSpace;
							}
							button.Height = btnHeight;
							button.Width = btnWidth;
							button.Font = font;
							this.Panel1.Controls.Add(button);
							button.Click += this.Button_Click;
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
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000ECC4C File Offset: 0x000EAE4C
		private void Button_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				MenuProducts menuProducts = new MenuProducts();
				menuProducts.categoryname = button.Name;
				bool flag = menuProducts.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.selectedproductid_cat = menuProducts.selectedproductid;
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading category products. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000C67 RID: 3175
		private string _cnn;

		// Token: 0x04000C68 RID: 3176
		public string categoryname;

		// Token: 0x04000C69 RID: 3177
		public int selectedproductid_cat;
	}
}

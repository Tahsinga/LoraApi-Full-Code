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
	// Token: 0x02000070 RID: 112
	[DesignerGenerated]
	public partial class MenuProducts : Form
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x000ECCD0 File Offset: 0x000EAED0
		public MenuProducts()
		{
			base.Load += this.MenuProducts_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.selectedproductid = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000ECE40 File Offset: 0x000EB040
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x000ECE4A File Offset: 0x000EB04A
		internal virtual Panel PanelProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000ECE54 File Offset: 0x000EB054
		private void MenuProducts_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading products. Detail: " + ex.Message);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000ECEA4 File Offset: 0x000EB0A4
		private void LoadProducts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductsByCategoryName";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("category", this.categoryname);
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
							button.Text = Conversions.ToString(dataRow["ProductDesc"]);
							button.Name = Conversions.ToString(dataRow["productid"]);
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
							this.PanelProducts.Controls.Add(button);
							button.Click += this.ProductButton_Click;
							num++;
						}
						else
						{
							button.Text = Conversions.ToString(dataRow["ProductDesc"]);
							button.Name = Conversions.ToString(dataRow["productid"]);
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
							this.PanelProducts.Controls.Add(button);
							button.Click += this.ProductButton_Click;
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

		// Token: 0x060019B5 RID: 6581 RVA: 0x000ED230 File Offset: 0x000EB430
		private void ProductButton_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				try
				{
					foreach (object obj in this.PanelProducts.Controls)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						bool flag = objectValue is Button;
						if (flag)
						{
							Button button2 = (Button)objectValue;
							this.selectedproductid = Conversions.ToInteger(button.Name);
							base.DialogResult = DialogResult.OK;
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
			catch (Exception ex)
			{
				MessageBox.Show("Error loading product. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000C6C RID: 3180
		public string categoryname;

		// Token: 0x04000C6D RID: 3181
		private string _cnn;

		// Token: 0x04000C6E RID: 3182
		public int selectedproductid;
	}
}

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class BackUpDB : Form
	{
		// Token: 0x060002DB RID: 731 RVA: 0x00019D4C File Offset: 0x00017F4C
		public BackUpDB()
		{
			base.Load += this.BackUpDB_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0001A361 File Offset: 0x00018561
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0001A36B File Offset: 0x0001856B
		internal virtual TextBox txtFilename
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0001A374 File Offset: 0x00018574
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0001A37E File Offset: 0x0001857E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0001A387 File Offset: 0x00018587
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0001A391 File Offset: 0x00018591
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0001A39A File Offset: 0x0001859A
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0001A3A4 File Offset: 0x000185A4
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0001A3E7 File Offset: 0x000185E7
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0001A3F1 File Offset: 0x000185F1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0001A3FA File Offset: 0x000185FA
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0001A404 File Offset: 0x00018604
		internal virtual TextBox txtFolderPath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0001A40D File Offset: 0x0001860D
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0001A417 File Offset: 0x00018617
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0001A420 File Offset: 0x00018620
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0001A42C File Offset: 0x0001862C
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0001A46F File Offset: 0x0001866F
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0001A479 File Offset: 0x00018679
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0001A482 File Offset: 0x00018682
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0001A48C File Offset: 0x0001868C
		internal virtual TextBox txtDBName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001A495 File Offset: 0x00018695
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001A49F File Offset: 0x0001869F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001A4A8 File Offset: 0x000186A8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.FolderBrowserDialog1.Description = "Please select the back up destination";
				this.FolderBrowserDialog1.ShowNewFolderButton = true;
				this.FolderBrowserDialog1.ShowDialog();
				this.txtFolderPath.Text = this.FolderBrowserDialog1.SelectedPath.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error accessing folders. Detail: " + ex.Message);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001A538 File Offset: 0x00018738
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.txtFilename.Text, "", false) != 0) & (Operators.CompareString(this.txtFolderPath.Text, "", false) != 0);
				if (flag)
				{
					this.ProgressBar1.Visible = true;
					this.ProgressBar1.Maximum = 2;
					this.ProgressBar1.Step = 1;
					this.ProgressBar1.Value = 0;
					this.ProgressBar1.PerformStep();
					this.BackUpDB(this.txtFolderPath.Text, this.txtFilename.Text);
					this.ProgressBar1.PerformStep();
					MessageBox.Show("Database successfully backed up to disk.", "Infor", MessageBoxButtons.OK);
					this.ProgressBar1.Visible = false;
					base.Close();
				}
				else
				{
					MessageBox.Show("Please ensure that the back up folder destination and the back up filename have been entered before clicking BackUp.", "Error", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error backing up database. Retry. Detailed error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.ProgressBar1.Visible = false;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001A674 File Offset: 0x00018874
		private void BackUpDB(string folderloc, string filename)
		{
			string constring = MyProject.Forms.Form1.Constring;
			SqlConnection sqlConnection = new SqlConnection(constring);
			string text = string.Concat(new string[]
			{
				"BACKUP DATABASE ",
				this.txtDBName.Text,
				" TO DISK = '",
				folderloc,
				"\\",
				filename,
				".BAK '"
			});
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandTimeout = 6000;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = text;
			sqlCommand.Connection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Connection.Close();
			sqlCommand.Dispose();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001A72C File Offset: 0x0001892C
		private void BackUpDB_Load(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string constring = MyProject.Forms.Form1.Constring;
					int num = constring.IndexOf("=");
					string text = constring.Substring(num + 1);
					int num2 = text.IndexOf("=");
					text = text.Substring(num2 + 1);
					int num3 = text.IndexOf(";");
					string text2 = text.Substring(0, num3);
					this.txtDBName.Text = text2;
				}
				catch (Exception ex)
				{
				}
			}
		}
	}
}

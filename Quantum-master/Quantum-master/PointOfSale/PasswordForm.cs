using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale
{
	// Token: 0x0200017C RID: 380
	public class PasswordForm : Form
	{
		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x001E8B18 File Offset: 0x001E6D18
		public string EnteredPassword
		{
			get
			{
				return this.txtPassword.Text;
			}
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x001E8B38 File Offset: 0x001E6D38
		public PasswordForm()
		{
			this.Text = "Enter Password";
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Size = new Size(300, 150);
			this.lblPrompt = new Label();
			this.lblPrompt.Text = this.coname + ". Please enter the password for user Admin:";
			this.lblPrompt.Location = new Point(10, 10);
			this.lblPrompt.AutoSize = true;
			this.txtPassword = new TextBox();
			this.txtPassword.Location = new Point(10, 40);
			this.txtPassword.Width = 250;
			this.txtPassword.PasswordChar = '*';
			this.btnOK = new Button();
			this.btnOK.Text = "OK";
			this.btnOK.Location = new Point(60, 80);
			this.btnOK.Click += this.BtnOK_Click;
			this.btnCancel = new Button();
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Location = new Point(150, 80);
			this.btnCancel.Click += this.BtnCancel_Click;
			base.Controls.Add(this.lblPrompt);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.btnCancel);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001E8CDC File Offset: 0x001E6EDC
		private void BtnOK_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x001E8CEE File Offset: 0x001E6EEE
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x040017BC RID: 6076
		private Label lblPrompt;

		// Token: 0x040017BD RID: 6077
		private TextBox txtPassword;

		// Token: 0x040017BE RID: 6078
		private Button btnOK;

		// Token: 0x040017BF RID: 6079
		private Button btnCancel;

		// Token: 0x040017C0 RID: 6080
		public string coname;
	}
}

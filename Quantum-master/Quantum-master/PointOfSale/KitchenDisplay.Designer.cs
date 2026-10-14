namespace PointOfSale
{
	// Token: 0x02000069 RID: 105
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class KitchenDisplay : global::System.Windows.Forms.Form
	{
		// Token: 0x06001608 RID: 5640 RVA: 0x000CD4DC File Offset: 0x000CB6DC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000CD52C File Offset: 0x000CB72C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvDisplay = new global::System.Windows.Forms.DataGridView();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.DateTimePicker1 = new global::System.Windows.Forms.DateTimePicker();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.chkHideDesc2 = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.chkHideComments = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDisplay).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkHideComments);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.chkHideDesc2);
			this.GroupBox1.Controls.Add(this.Panel3);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Panel1);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1870, 73);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(3, 22);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(403, 48);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "VIEW CURRENT ORDERS";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvDisplay.AllowUserToAddRows = false;
			this.dgvDisplay.AllowUserToDeleteRows = false;
			this.dgvDisplay.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvDisplay.Location = new global::System.Drawing.Point(0, 73);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.RowTemplate.Height = 28;
			this.dgvDisplay.Size = new global::System.Drawing.Size(1870, 367);
			this.dgvDisplay.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Red;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(1658, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(209, 40);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "     Close     ";
			this.Button2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.Location = new global::System.Drawing.Point(1255, 22);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(403, 48);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "VIEW ALL";
			this.Button2.UseVisualStyleBackColor = true;
			this.DateTimePicker1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DateTimePicker1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DateTimePicker1.Location = new global::System.Drawing.Point(406, 22);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new global::System.Drawing.Size(504, 39);
			this.DateTimePicker1.TabIndex = 4;
			this.Panel1.BackColor = global::System.Drawing.Color.Red;
			this.Panel1.Location = new global::System.Drawing.Point(924, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(34, 20);
			this.Panel1.TabIndex = 5;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(1004, 45);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(111, 20);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Pending Order";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(964, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(187, 20);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Order Already Completed";
			this.Panel2.BackColor = global::System.Drawing.Color.Yellow;
			this.Panel2.Location = new global::System.Drawing.Point(924, 45);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(34, 20);
			this.Panel2.TabIndex = 6;
			this.Panel3.BackColor = global::System.Drawing.Color.Lime;
			this.Panel3.Location = new global::System.Drawing.Point(964, 45);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(34, 20);
			this.Panel3.TabIndex = 7;
			this.chkHideDesc2.AutoSize = true;
			this.chkHideDesc2.Checked = true;
			this.chkHideDesc2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkHideDesc2.Location = new global::System.Drawing.Point(1182, 16);
			this.chkHideDesc2.Name = "chkHideDesc2";
			this.chkHideDesc2.Size = new global::System.Drawing.Size(131, 24);
			this.chkHideDesc2.TabIndex = 9;
			this.chkHideDesc2.Text = "Hide Desc 2?";
			this.chkHideDesc2.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(1178, 45);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(46, 20);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Font:";
			this.TextBox1.Location = new global::System.Drawing.Point(1237, 43);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(64, 26);
			this.TextBox1.TabIndex = 12;
			this.TextBox1.Text = "30";
			this.chkHideComments.AutoSize = true;
			this.chkHideComments.Checked = true;
			this.chkHideComments.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkHideComments.Location = new global::System.Drawing.Point(1319, 16);
			this.chkHideComments.Name = "chkHideComments";
			this.chkHideComments.Size = new global::System.Drawing.Size(158, 24);
			this.chkHideComments.TabIndex = 13;
			this.chkHideComments.Text = "Hide Comments?";
			this.chkHideComments.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1870, 440);
			base.Controls.Add(this.dgvDisplay);
			base.Controls.Add(this.GroupBox1);
			base.Name = "KitchenDisplay";
			this.Text = "Kitchen Display";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDisplay).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000B03 RID: 2819
		private global::System.ComponentModel.IContainer components;
	}
}

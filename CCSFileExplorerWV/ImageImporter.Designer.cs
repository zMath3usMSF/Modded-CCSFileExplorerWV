namespace CCSFileExplorerWV
{
	// Token: 0x02000015 RID: 21
	public partial class ImageImporter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000084E1 File Offset: 0x000066E1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008500 File Offset: 0x00006700
		private void InitializeComponent()
		{
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pic1 = new global::System.Windows.Forms.PictureBox();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.status = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(552, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openToolStripMenuItem
			});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(61, 20);
			this.fileToolStripMenuItem.Text = "Arquivo";
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Abrir";
			this.openToolStripMenuItem.Click += new global::System.EventHandler(this.openToolStripMenuItem_Click);
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.button2);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.textBox2);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.textBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.pic1);
			this.splitContainer1.Size = new global::System.Drawing.Size(552, 366);
			this.splitContainer1.SplitterDistance = 198;
			this.splitContainer1.TabIndex = 1;
			this.button2.Location = new global::System.Drawing.Point(113, 175);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Importar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Location = new global::System.Drawing.Point(5, 175);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Quantizar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox2.Location = new global::System.Drawing.Point(5, 149);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(184, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "16";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(5, 132);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(155, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Contagem de Tarefas Paralelas";
			this.textBox1.Location = new global::System.Drawing.Point(4, 105);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "256";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(4, 88);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cores";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(6, 61);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(182, 21);
			this.comboBox2.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(3, 45);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(74, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Pontilhamento";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(7, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(182, 21);
			this.comboBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quantizador";
			this.pic1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pic1.Location = new global::System.Drawing.Point(0, 0);
			this.pic1.Name = "pic1";
			this.pic1.Size = new global::System.Drawing.Size(350, 366);
			this.pic1.TabIndex = 2;
			this.pic1.TabStop = false;
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.status
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 390);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(552, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.status.Name = "status";
			this.status.Size = new global::System.Drawing.Size(0, 17);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(552, 412);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.statusStrip1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "ImageImporter";
			this.Text = "Importador";
			base.Load += new global::System.EventHandler(this.ImageImporter_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pic1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000083 RID: 131
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.PictureBox pic1;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.ToolStripStatusLabel status;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Button button2;
	}
}

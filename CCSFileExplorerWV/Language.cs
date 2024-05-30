using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CCSFileExplorerWV
{
	// Token: 0x02000011 RID: 17
	public partial class Language : Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003D48 File Offset: 0x00001F48
		public Language()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003D56 File Offset: 0x00001F56
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedItem.ToString() == "Português")
			{
				Application.Run(new Form1());
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003D80 File Offset: 0x00001F80
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedItem.ToString() == "English")
			{
				this.Text = "Language";
				this.comboBox1.Items[this.comboBox1.SelectedIndex] = "English";
				this.button1.Text = "Start";
				return;
			}
			if (this.comboBox1.SelectedItem.ToString() == "Spanish")
			{
				this.Text = "Linguagem";
				this.comboBox1.Items[this.comboBox1.SelectedIndex] = "Espanol";
				this.button1.Text = "Iniciar";
				return;
			}
			if (this.comboBox1.SelectedItem.ToString() == "Portuguese")
			{
				this.Text = "Linguagem";
				this.comboBox1.Items[this.comboBox1.SelectedIndex] = "Português";
				this.button1.Text = "Iniciar";
			}
		}
	}
}

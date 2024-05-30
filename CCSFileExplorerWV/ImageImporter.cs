using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SimplePaletteQuantizer.Ditherers;
using SimplePaletteQuantizer.Ditherers.ErrorDiffusion;
using SimplePaletteQuantizer.Ditherers.Ordered;
using SimplePaletteQuantizer.Helpers;
using SimplePaletteQuantizer.Quantizers;
using SimplePaletteQuantizer.Quantizers.DistinctSelection;
using SimplePaletteQuantizer.Quantizers.NeuQuant;
using SimplePaletteQuantizer.Quantizers.OptimalPalette;
using SimplePaletteQuantizer.Quantizers.Popularity;
using SimplePaletteQuantizer.Quantizers.Uniform;

namespace CCSFileExplorerWV
{
	// Token: 0x02000015 RID: 21
	public partial class ImageImporter : Form
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00007A5D File Offset: 0x00005C5D
		public ImageImporter(Form1 f1)
		{
			this.InitializeComponent();
			this.language1(f1);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007A84 File Offset: 0x00005C84
		private void language1(Form1 f01)
		{
			if (f01.inglêsToolStripMenuItem.Checked)
			{
				this.fileToolStripMenuItem.Text = "Archive";
				this.openToolStripMenuItem.Text = "Open";
				this.button2.Text = "Import";
				this.button1.Text = "Quantitize";
				this.label4.Text = "Parallel Task Count";
				this.label3.Text = "Colors";
				this.label2.Text = "Dithering";
				this.label1.Text = "Quanttizer";
				return;
			}
			if (f01.portuguêsToolStripMenuItem.Checked)
			{
				this.fileToolStripMenuItem.Text = "Arquivo";
				this.openToolStripMenuItem.Text = "Abrir";
				this.button2.Text = "Importar";
				this.button1.Text = "Quantizar";
				this.label4.Text = "Contagem de Tarefas Paralelas";
				this.label3.Text = "Cores";
				this.label2.Text = "Pontilhamento";
				this.label1.Text = "Quantizador";
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007BB4 File Offset: 0x00005DB4
		private void ImageImporter_Load(object sender, EventArgs e)
		{
			foreach (ObjectEntry objectEntry in this.ccsfile.files[this.index].objects)
			{
				foreach (Block b in objectEntry.blocks)
				{
					if (b.BlockID == 3435922432U && this.currPalette == null)
					{
						if(countClut == 1)
						{
                            this.currPalette =  b;
                        }
						else
						{
							if(currTexture == null)
							{
                                Block selectedClutObj = this.ccsfile.files[this.index].objects[selectedClut].blocks[0];

                                this.currPalette =  selectedClutObj;
                            }
							else
							{
                                Block selectedClutObj = this.ccsfile.files[this.index].objects[selectedClut + 1].blocks[0];

                                this.currPalette =  selectedClutObj;
                            }
                        }
                    }
					if (b.BlockID == 3435922176U && this.currTexture == null)
					{
						this.currTexture = b;
					}
				}
			}
			if (this.currPalette == null || this.currTexture == null)
			{
				base.Close();
				return;
			}
			this.expectedCount = BitConverter.ToInt32(this.currPalette.Data, 12);
			this.textBox1.Text = this.expectedCount.ToString();
			this.pic1.Image = (this.currOutput = (this.currInput = CCSFile.CreateImage(this.currPalette.Data, this.currTexture.Data)));
			this.expectedSizeX = this.currInput.Width;
			this.expectedSizeY = this.currInput.Height;
			this.comboBox1.Items.Clear();
			this.comboBox1.Items.Add("Distinct Selection");
			this.comboBox1.Items.Add("Neural Color");
			this.comboBox1.Items.Add("Optimal Palette");
			this.comboBox1.Items.Add("Popularity");
			this.comboBox1.Items.Add("Uniform");
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.Items.Clear();
			this.comboBox2.Items.Add("None");
			this.comboBox2.Items.Add("Atkinson Dithering");
			this.comboBox2.Items.Add("Burkes Ditherer");
			this.comboBox2.Items.Add("Fan Ditherer");
			this.comboBox2.Items.Add("Filter Lite Sierra");
			this.comboBox2.Items.Add("Floyd Steinberg Ditherer");
			this.comboBox2.Items.Add("Jarvis Judice Ninke Ditherer");
			this.comboBox2.Items.Add("Shiau Ditherer");
			this.comboBox2.Items.Add("Sierra Ditherer");
			this.comboBox2.Items.Add("Stucki Ditherer");
			this.comboBox2.Items.Add("Two Row Sierra Ditherer");
			this.comboBox2.Items.Add("Bayer Ditherer 4");
			this.comboBox2.Items.Add("Bayer Ditherer 8");
			this.comboBox2.Items.Add("Clustered Dot Ditherer");
			this.comboBox2.Items.Add("Dot Half Tone Ditherer");
			this.comboBox2.SelectedIndex = 0;
			this.CountColors();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007F1C File Offset: 0x0000611C
		private void CountColors()
		{
			Bitmap bmp = new Bitmap(this.currOutput);
			this.colors = new HashSet<Color>();
			for (int y = 0; y < bmp.Size.Height; y++)
			{
				for (int x = 0; x < bmp.Size.Width; x++)
				{
					this.colors.Add(bmp.GetPixel(x, y));
				}
			}
			this.lastColorCount = this.colors.Count<Color>();
			this.status.Text = "Colors : " + this.lastColorCount.ToString();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007FB8 File Offset: 0x000061B8
		private void button1_Click(object sender, EventArgs e)
		{
			IColorQuantizer q = null;
			switch (this.comboBox1.SelectedIndex)
			{
			case 0:
				q = new DistinctSelectionQuantizer();
				break;
			case 1:
				q = new NeuralColorQuantizer();
				break;
			case 2:
				q = new OptimalPaletteQuantizer();
				break;
			case 3:
				q = new PopularityQuantizer();
				break;
			case 4:
				q = new UniformQuantizer();
				break;
			}
			IColorDitherer d = null;
			switch (this.comboBox2.SelectedIndex)
			{
			case 1:
				d = new AtkinsonDithering();
				break;
			case 2:
				d = new BurkesDitherer();
				break;
			case 3:
				d = new FanDitherer();
				break;
			case 4:
				d = new FilterLiteSierra();
				break;
			case 5:
				d = new FloydSteinbergDitherer();
				break;
			case 6:
				d = new JarvisJudiceNinkeDitherer();
				break;
			case 7:
				d = new ShiauDitherer();
				break;
			case 8:
				d = new SierraDitherer();
				break;
			case 9:
				d = new StuckiDitherer();
				break;
			case 10:
				d = new TwoRowSierraDitherer();
				break;
			case 11:
				d = new BayerDitherer4();
				break;
			case 12:
				d = new BayerDitherer8();
				break;
			case 13:
				d = new ClusteredDotDitherer();
				break;
			case 14:
				d = new DotHalfToneDitherer();
				break;
			}
			int c = Convert.ToInt32(this.textBox1.Text);
			int p = Convert.ToInt32(this.textBox2.Text);
			try
			{
				this.lastColorCount = -1;
				this.pic1.Image = (this.currOutput = ImageBuffer.QuantizeImage(this.currInput, q, d, c, p));
				this.CountColors();
			}
			catch (Exception ex)
			{
				this.status.Text = ex.Message;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008154 File Offset: 0x00006354
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "*.png|*.png|*.bmp|*.bmp|*.jpg|*.jpg";
			if (d.ShowDialog() == DialogResult.OK)
			{
				Image img = Image.FromFile(d.FileName);
				if (img.Width != this.expectedSizeX || img.Height != this.expectedSizeY)
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"The imported image must have the size ",
						this.expectedSizeX.ToString(),
						"x",
						this.expectedSizeY.ToString(),
						"!"
					}));
					return;
				}
				this.pic1.Image = (this.currOutput = (this.currInput = img));
				this.CountColors();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008210 File Offset: 0x00006410
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.lastColorCount == -1)
			{
				return;
			}
			if (this.lastColorCount > this.expectedCount)
			{
				MessageBox.Show("Image still has too much colors to create a " + this.expectedCount.ToString() + " color palette!");
				return;
			}
			Color[] list = this.colors.ToArray<Color>();
			for (int i = 0; i < this.expectedCount; i++)
			{
				if (i < list.Length)
				{
					this.currPalette.Data[i * 4 + 16] = list[i].R;
					this.currPalette.Data[i * 4 + 17] = list[i].G;
					this.currPalette.Data[i * 4 + 18] = list[i].B;
					byte Alpha = list[i].A != 0xFF ? (byte)(list[i].A / 2) : (byte)(0x80) ;
					this.currPalette.Data[i * 4 + 19] = Alpha;
				}
				else
				{
					this.currPalette.Data[i * 4 + 16] = 0;
					this.currPalette.Data[i * 4 + 17] = 0;
					this.currPalette.Data[i * 4 + 18] = 0;
					this.currPalette.Data[i * 4 + 19] = 0;
				}
			}
			Bitmap bmp = new Bitmap(this.currOutput);
			int pos = 0;
			if (this.expectedCount == 16)
			{
				for (int y = 0; y < this.expectedSizeY; y++)
				{
					for (int x = 0; x < this.expectedSizeX / 2; x++)
					{
						Color c = bmp.GetPixel(x * 2 + 1, this.expectedSizeY - y - 1);
						Color c2 = bmp.GetPixel(x * 2, this.expectedSizeY - y - 1);
						this.currTexture.Data[24 + pos++] = (byte)(((int)ImageImporter.FindColorIndex(c, list) << 4) + (int)ImageImporter.FindColorIndex(c2, list));
					}
				}
			}
			else if (this.expectedCount == 256)
			{
				for (int y2 = 0; y2 < this.expectedSizeY; y2++)
				{
					for (int x2 = 0; x2 < this.expectedSizeX; x2++)
					{
						Color c = bmp.GetPixel(x2, this.expectedSizeY - y2 - 1);
						this.currTexture.Data[24 + pos++] = ImageImporter.FindColorIndex(c, list);
					}
				}
			}
			this.exitok = true;
			base.Close();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000846C File Offset: 0x0000666C
		public static byte FindColorIndex(Color v, Color[] pal)
		{
			byte index = 0;
			byte i = 0;
			while ((int)i < pal.Length)
			{
				if (pal[(int)i].R == v.R && pal[(int)i].G == v.G && pal[(int)i].B == v.B && pal[(int)i].A == v.A)
				{
					return i;
				}
				i += 1;
			}
			return index;
		}

		// Token: 0x04000077 RID: 119
		public int index;

		// Token: 0x04000078 RID: 120
		public CCSFile ccsfile;

		// Token: 0x04000079 RID: 121
		public bool exitok;

		// Token: 0x0400007A RID: 122
		public Block currPalette;

		public int selectedClut;

		public int countClut;

        // Token: 0x0400007B RID: 123
        public Block currTexture;

		// Token: 0x0400007C RID: 124
		public Image currInput;

		// Token: 0x0400007D RID: 125
		public Image currOutput;

		// Token: 0x0400007E RID: 126
		public HashSet<Color> colors;

		// Token: 0x0400007F RID: 127
		public int lastColorCount = -1;

		// Token: 0x04000080 RID: 128
		public int expectedCount = 256;

		// Token: 0x04000081 RID: 129
		public int expectedSizeX;

		// Token: 0x04000082 RID: 130
		public int expectedSizeY;
	}
}

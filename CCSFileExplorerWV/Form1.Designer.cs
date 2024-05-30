using CCSFileExplorerRT.Properties;

namespace CCSFileExplorerWV
{
	// Token: 0x02000014 RID: 20
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x0000627B File Offset: 0x0000447B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000629C File Offset: 0x0000449C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb1 = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCCSPACKEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCCSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCCSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarECompactarEmCCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.unpackBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repackBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAsBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInImageImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractParentNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractAllTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hackGUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRotationOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.línguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hb1 = new Be.Windows.Forms.HexBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb1,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb1
            // 
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(300, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectedBlobToolStripMenuItem,
            this.extractParentNodeToolStripMenuItem,
            this.fileFormatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.línguaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCCSPACKEDToolStripMenuItem,
            this.openCCSFileToolStripMenuItem,
            this.saveCCSFileToolStripMenuItem,
            this.salvarECompactarEmCCSToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.toolStripMenuItem1,
            this.unpackBINToolStripMenuItem,
            this.repackBINToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recentToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirCCSPACKEDToolStripMenuItem
            // 
            this.abrirCCSPACKEDToolStripMenuItem.Name = "abrirCCSPACKEDToolStripMenuItem";
            this.abrirCCSPACKEDToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.abrirCCSPACKEDToolStripMenuItem.Text = "Abrir CCS (PACKED)";
            this.abrirCCSPACKEDToolStripMenuItem.Click += new System.EventHandler(this.abrirCCSPACKEDToolStripMenuItem_Click);
            // 
            // openCCSFileToolStripMenuItem
            // 
            this.openCCSFileToolStripMenuItem.Name = "openCCSFileToolStripMenuItem";
            this.openCCSFileToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.openCCSFileToolStripMenuItem.Text = "Abrir CCS/TMP (UNPACKED)";
            this.openCCSFileToolStripMenuItem.Click += new System.EventHandler(this.openCCSFileToolStripMenuItem_Click);
            // 
            // saveCCSFileToolStripMenuItem
            // 
            this.saveCCSFileToolStripMenuItem.Name = "saveCCSFileToolStripMenuItem";
            this.saveCCSFileToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.saveCCSFileToolStripMenuItem.Text = "Salvar";
            this.saveCCSFileToolStripMenuItem.Click += new System.EventHandler(this.saveCCSFileToolStripMenuItem_Click);
            // 
            // salvarECompactarEmCCSToolStripMenuItem
            // 
            this.salvarECompactarEmCCSToolStripMenuItem.Name = "salvarECompactarEmCCSToolStripMenuItem";
            this.salvarECompactarEmCCSToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.salvarECompactarEmCCSToolStripMenuItem.Text = "Salvar e Compactar em CCS";
            this.salvarECompactarEmCCSToolStripMenuItem.Click += new System.EventHandler(this.salvarECompactarEmCCSToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // unpackBINToolStripMenuItem
            // 
            this.unpackBINToolStripMenuItem.Name = "unpackBINToolStripMenuItem";
            this.unpackBINToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.unpackBINToolStripMenuItem.Text = "Descompactar BIN";
            this.unpackBINToolStripMenuItem.Click += new System.EventHandler(this.unpackBINToolStripMenuItem_Click);
            // 
            // repackBINToolStripMenuItem
            // 
            this.repackBINToolStripMenuItem.Name = "repackBINToolStripMenuItem";
            this.repackBINToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.repackBINToolStripMenuItem.Text = "Recompactar BIN";
            this.repackBINToolStripMenuItem.Click += new System.EventHandler(this.repackBINToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Enabled = false;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.recentToolStripMenuItem.Text = "Recente";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // selectedBlobToolStripMenuItem
            // 
            this.selectedBlobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportRawToolStripMenuItem,
            this.importRawToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exportAsBitmapToolStripMenuItem,
            this.openInImageImporterToolStripMenuItem,
            this.exportToObjToolStripMenuItem});
            this.selectedBlobToolStripMenuItem.Name = "selectedBlobToolStripMenuItem";
            this.selectedBlobToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.selectedBlobToolStripMenuItem.Text = "Ação";
            // 
            // exportRawToolStripMenuItem
            // 
            this.exportRawToolStripMenuItem.Name = "exportRawToolStripMenuItem";
            this.exportRawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportRawToolStripMenuItem.Text = "Exportar DADOS";
            this.exportRawToolStripMenuItem.Click += new System.EventHandler(this.exportRawToolStripMenuItem_Click);
            // 
            // importRawToolStripMenuItem
            // 
            this.importRawToolStripMenuItem.Name = "importRawToolStripMenuItem";
            this.importRawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importRawToolStripMenuItem.Text = "Importar DADOS";
            this.importRawToolStripMenuItem.Click += new System.EventHandler(this.importRawToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // exportAsBitmapToolStripMenuItem
            // 
            this.exportAsBitmapToolStripMenuItem.Name = "exportAsBitmapToolStripMenuItem";
            this.exportAsBitmapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsBitmapToolStripMenuItem.Text = "Exportar Textura";
            this.exportAsBitmapToolStripMenuItem.Click += new System.EventHandler(this.exportAsBitmapToolStripMenuItem_Click);
            // 
            // openInImageImporterToolStripMenuItem
            // 
            this.openInImageImporterToolStripMenuItem.Name = "openInImageImporterToolStripMenuItem";
            this.openInImageImporterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openInImageImporterToolStripMenuItem.Text = "Abrir no Importador";
            this.openInImageImporterToolStripMenuItem.Click += new System.EventHandler(this.openInImageImporterToolStripMenuItem_Click);
            // 
            // exportToObjToolStripMenuItem
            // 
            this.exportToObjToolStripMenuItem.Name = "exportToObjToolStripMenuItem";
            this.exportToObjToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToObjToolStripMenuItem.Text = "Exportar para obj...";
            this.exportToObjToolStripMenuItem.Click += new System.EventHandler(this.exportToObjToolStripMenuItem_Click);
            // 
            // extractParentNodeToolStripMenuItem
            // 
            this.extractParentNodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractAllModelsToolStripMenuItem,
            this.extractAllTexturesToolStripMenuItem});
            this.extractParentNodeToolStripMenuItem.Name = "extractParentNodeToolStripMenuItem";
            this.extractParentNodeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.extractParentNodeToolStripMenuItem.Text = "Extrair";
            // 
            // extractAllModelsToolStripMenuItem
            // 
            this.extractAllModelsToolStripMenuItem.Name = "extractAllModelsToolStripMenuItem";
            this.extractAllModelsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.extractAllModelsToolStripMenuItem.Text = "Extrair Modelos";
            this.extractAllModelsToolStripMenuItem.Click += new System.EventHandler(this.extractAllModelsToolStripMenuItem_Click);
            // 
            // extractAllTexturesToolStripMenuItem
            // 
            this.extractAllTexturesToolStripMenuItem.Name = "extractAllTexturesToolStripMenuItem";
            this.extractAllTexturesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.extractAllTexturesToolStripMenuItem.Text = "Extrair Texturas";
            this.extractAllTexturesToolStripMenuItem.Click += new System.EventHandler(this.extractAllTexturesToolStripMenuItem_Click);
            // 
            // fileFormatToolStripMenuItem
            // 
            this.fileFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hackGUToolStripMenuItem});
            this.fileFormatToolStripMenuItem.Name = "fileFormatToolStripMenuItem";
            this.fileFormatToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileFormatToolStripMenuItem.Text = "Formato";
            // 
            // hackGUToolStripMenuItem
            // 
            this.hackGUToolStripMenuItem.Checked = true;
            this.hackGUToolStripMenuItem.CheckOnClick = true;
            this.hackGUToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hackGUToolStripMenuItem.Name = "hackGUToolStripMenuItem";
            this.hackGUToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hackGUToolStripMenuItem.Text = "Naruto";
            this.hackGUToolStripMenuItem.Click += new System.EventHandler(this.hackGUToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRotationOnToolStripMenuItem,
            this.wireframeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.viewToolStripMenuItem.Text = "Ver";
            // 
            // autoRotationOnToolStripMenuItem
            // 
            this.autoRotationOnToolStripMenuItem.Checked = true;
            this.autoRotationOnToolStripMenuItem.CheckOnClick = true;
            this.autoRotationOnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRotationOnToolStripMenuItem.Name = "autoRotationOnToolStripMenuItem";
            this.autoRotationOnToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.autoRotationOnToolStripMenuItem.Text = "Auto Rotacionar";
            this.autoRotationOnToolStripMenuItem.Click += new System.EventHandler(this.autoRotationOnToolStripMenuItem_Click);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.CheckOnClick = true;
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wireframeToolStripMenuItem.Text = "Wireframe";
            this.wireframeToolStripMenuItem.Click += new System.EventHandler(this.wireframeToolStripMenuItem_Click);
            // 
            // línguaToolStripMenuItem
            // 
            this.línguaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inglêsToolStripMenuItem,
            this.portuguêsToolStripMenuItem});
            this.línguaToolStripMenuItem.Name = "línguaToolStripMenuItem";
            this.línguaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.línguaToolStripMenuItem.Text = "Língua";
            // 
            // inglêsToolStripMenuItem
            // 
            this.inglêsToolStripMenuItem.Name = "inglêsToolStripMenuItem";
            this.inglêsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inglêsToolStripMenuItem.Text = "Inglês";
            this.inglêsToolStripMenuItem.Click += new System.EventHandler(this.inglêsToolStripMenuItem_Click);
            // 
            // portuguêsToolStripMenuItem
            // 
            this.portuguêsToolStripMenuItem.Checked = true;
            this.portuguêsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            this.portuguêsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.portuguêsToolStripMenuItem.Text = "Português";
            this.portuguêsToolStripMenuItem.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtb1);
            this.splitContainer1.Size = new System.Drawing.Size(571, 460);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(571, 378);
            this.splitContainer2.SplitterDistance = 209;
            this.splitContainer2.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 378);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hb1
            // 
            this.hb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hb1.BoldFont = null;
            this.hb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hb1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb1.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hb1.LineInfoVisible = true;
            this.hb1.Location = new System.Drawing.Point(3, 3);
            this.hb1.Name = "hb1";
            this.hb1.ReadOnly = true;
            this.hb1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb1.Size = new System.Drawing.Size(344, 346);
            this.hb1.StringViewVisible = true;
            this.hb1.TabIndex = 0;
            this.hb1.UseFixedBytesPerLine = true;
            this.hb1.VScrollBarVisible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pic1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Textura";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(3, 24);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(344, 325);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pic2);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(350, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver Modelo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pic2
            // 
            this.pic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic2.Location = new System.Drawing.Point(3, 24);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(344, 325);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseMove);
            this.pic2.Resize += new System.EventHandler(this.pic2_Resize);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(344, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // rtb1
            // 
            this.rtb1.DetectUrls = false;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtb1.Location = new System.Drawing.Point(0, 0);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(571, 78);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            this.rtb1.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::CCSFileExplorerRT.Properties.Resources.Icon;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CCSFile Explorer  / Modificado por Raiden e zMath3usMSF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripProgressBar pb1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem openCCSFileToolStripMenuItem;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ToolStripMenuItem saveCCSFileToolStripMenuItem;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ToolStripMenuItem unpackBINToolStripMenuItem;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ToolStripMenuItem repackBINToolStripMenuItem;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000053 RID: 83
		private global::Be.Windows.Forms.HexBox hb1;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.RichTextBox rtb1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.FolderBrowserDialog fbd;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.PictureBox pic1;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStripMenuItem selectedBlobToolStripMenuItem;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripMenuItem exportRawToolStripMenuItem;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripMenuItem exportAsBitmapToolStripMenuItem;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem importRawToolStripMenuItem;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripMenuItem openInImageImporterToolStripMenuItem;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ToolStripMenuItem exportToObjToolStripMenuItem;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.PictureBox pic2;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ToolStripMenuItem autoRotationOnToolStripMenuItem;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ToolStripMenuItem wireframeToolStripMenuItem;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ToolStripStatusLabel status;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ToolStripMenuItem fileFormatToolStripMenuItem;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.ToolStripMenuItem hackGUToolStripMenuItem;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ToolStripMenuItem extractParentNodeToolStripMenuItem;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ToolStripMenuItem extractAllModelsToolStripMenuItem;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.ToolStripMenuItem extractAllTexturesToolStripMenuItem;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.TreeView treeView1;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ToolStripMenuItem abrirCCSPACKEDToolStripMenuItem;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripMenuItem salvarECompactarEmCCSToolStripMenuItem;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ToolStripMenuItem línguaToolStripMenuItem;

		// Token: 0x04000075 RID: 117
		public global::System.Windows.Forms.ToolStripMenuItem inglêsToolStripMenuItem;

		// Token: 0x04000076 RID: 118
		public global::System.Windows.Forms.ToolStripMenuItem portuguêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}

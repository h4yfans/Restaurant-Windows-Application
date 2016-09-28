namespace ProjeLokanta
{
    partial class frmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dasdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStpUrunler = new System.Windows.Forms.ToolStrip();
            this.tlStpBtnAnaUrunEkle = new System.Windows.Forms.ToolStripButton();
            this.tlStpBtnAnaUrunDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tlStpBtnAnaUrunSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnAltUrunEkle = new System.Windows.Forms.ToolStripButton();
            this.tlStpBtnAltUrunDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tlStpBtnAltUrunSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnUrunGeri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnUrunKapat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnaUrunKaydet = new System.Windows.Forms.Button();
            this.btnAnaUrunGuncelle = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnAnaUrunIptal = new System.Windows.Forms.Button();
            this.txtAnaUrunAdi = new System.Windows.Forms.TextBox();
            this.lblAnaUrunAdi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGridAnaUrun = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAraUrunKaydet = new System.Windows.Forms.Button();
            this.btnAraUrunGuncellle = new System.Windows.Forms.Button();
            this.lblAltUrunBirimi = new System.Windows.Forms.Label();
            this.btnAraUrunIptal = new System.Windows.Forms.Button();
            this.cmbAltUrunBirimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAltUrunFiyati = new System.Windows.Forms.Label();
            this.txtAltUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtAltUrunAdi = new System.Windows.Forms.TextBox();
            this.lblAltUrunAdi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridAraUrun = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.tlStpUrunler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAnaUrun)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAraUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dasdasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dasdasToolStripMenuItem
            // 
            this.dasdasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.dasdasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dasdasToolStripMenuItem.Image")));
            this.dasdasToolStripMenuItem.Name = "dasdasToolStripMenuItem";
            this.dasdasToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.dasdasToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // tlStpUrunler
            // 
            this.tlStpUrunler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlStpUrunler.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.tlStpUrunler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStpBtnAnaUrunEkle,
            this.tlStpBtnAnaUrunDuzenle,
            this.tlStpBtnAnaUrunSil,
            this.toolStripSeparator1,
            this.tlStpBtnAltUrunEkle,
            this.tlStpBtnAltUrunDuzenle,
            this.tlStpBtnAltUrunSil,
            this.toolStripSeparator2,
            this.tlStpBtnUrunGeri,
            this.toolStripSeparator3,
            this.tlStpBtnUrunKapat});
            this.tlStpUrunler.Location = new System.Drawing.Point(0, 36);
            this.tlStpUrunler.Name = "tlStpUrunler";
            this.tlStpUrunler.Size = new System.Drawing.Size(994, 86);
            this.tlStpUrunler.TabIndex = 2;
            this.tlStpUrunler.Text = "toolStrip1";
            this.tlStpUrunler.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlStpUrunler_ItemClicked);
            // 
            // tlStpBtnAnaUrunEkle
            // 
            this.tlStpBtnAnaUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAnaUrunEkle.Image")));
            this.tlStpBtnAnaUrunEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAnaUrunEkle.Name = "tlStpBtnAnaUrunEkle";
            this.tlStpBtnAnaUrunEkle.Size = new System.Drawing.Size(85, 83);
            this.tlStpBtnAnaUrunEkle.Text = "Ana Ürün Ekle";
            this.tlStpBtnAnaUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAnaUrunEkle.Click += new System.EventHandler(this.tlStpBtnAnaUrunEkle_Click);
            // 
            // tlStpBtnAnaUrunDuzenle
            // 
            this.tlStpBtnAnaUrunDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAnaUrunDuzenle.Image")));
            this.tlStpBtnAnaUrunDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAnaUrunDuzenle.Name = "tlStpBtnAnaUrunDuzenle";
            this.tlStpBtnAnaUrunDuzenle.Size = new System.Drawing.Size(106, 83);
            this.tlStpBtnAnaUrunDuzenle.Text = "Ana Ürün Düzenle";
            this.tlStpBtnAnaUrunDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAnaUrunDuzenle.Click += new System.EventHandler(this.tlStpBtnAnaUrunDuzenle_Click);
            // 
            // tlStpBtnAnaUrunSil
            // 
            this.tlStpBtnAnaUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAnaUrunSil.Image")));
            this.tlStpBtnAnaUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAnaUrunSil.Name = "tlStpBtnAnaUrunSil";
            this.tlStpBtnAnaUrunSil.Size = new System.Drawing.Size(76, 83);
            this.tlStpBtnAnaUrunSil.Text = "Ana Ürün Sil";
            this.tlStpBtnAnaUrunSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAnaUrunSil.Click += new System.EventHandler(this.tlStpBtnAnaUrunSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // tlStpBtnAltUrunEkle
            // 
            this.tlStpBtnAltUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAltUrunEkle.Image")));
            this.tlStpBtnAltUrunEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAltUrunEkle.Name = "tlStpBtnAltUrunEkle";
            this.tlStpBtnAltUrunEkle.Size = new System.Drawing.Size(79, 83);
            this.tlStpBtnAltUrunEkle.Text = "Alt Ürün Ekle";
            this.tlStpBtnAltUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAltUrunEkle.Click += new System.EventHandler(this.tlStpBtnAltUrunEkle_Click);
            // 
            // tlStpBtnAltUrunDuzenle
            // 
            this.tlStpBtnAltUrunDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAltUrunDuzenle.Image")));
            this.tlStpBtnAltUrunDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAltUrunDuzenle.Name = "tlStpBtnAltUrunDuzenle";
            this.tlStpBtnAltUrunDuzenle.Size = new System.Drawing.Size(100, 83);
            this.tlStpBtnAltUrunDuzenle.Text = "Alt Ürün Düzenle";
            this.tlStpBtnAltUrunDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAltUrunDuzenle.ToolTipText = "Düzenledikten Sonra Buraya Tıklayınız";
            this.tlStpBtnAltUrunDuzenle.Click += new System.EventHandler(this.tlStpBtnAltUrunDuzenle_Click);
            // 
            // tlStpBtnAltUrunSil
            // 
            this.tlStpBtnAltUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnAltUrunSil.Image")));
            this.tlStpBtnAltUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnAltUrunSil.Name = "tlStpBtnAltUrunSil";
            this.tlStpBtnAltUrunSil.Size = new System.Drawing.Size(70, 83);
            this.tlStpBtnAltUrunSil.Text = "Alt Ürün Sil";
            this.tlStpBtnAltUrunSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnAltUrunSil.Click += new System.EventHandler(this.tlStpBtnAltUrunSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // tlStpBtnUrunGeri
            // 
            this.tlStpBtnUrunGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnUrunGeri.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnUrunGeri.Image")));
            this.tlStpBtnUrunGeri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnUrunGeri.Name = "tlStpBtnUrunGeri";
            this.tlStpBtnUrunGeri.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnUrunGeri.Text = "Geri";
            this.tlStpBtnUrunGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnUrunGeri.Click += new System.EventHandler(this.tlStpBtnUrunGeri_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // tlStpBtnUrunKapat
            // 
            this.tlStpBtnUrunKapat.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnUrunKapat.Image")));
            this.tlStpBtnUrunKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnUrunKapat.Name = "tlStpBtnUrunKapat";
            this.tlStpBtnUrunKapat.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnUrunKapat.Text = "Kapat";
            this.tlStpBtnUrunKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnUrunKapat.Click += new System.EventHandler(this.tlStpBtnUrunKapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnaUrunKaydet);
            this.panel1.Controls.Add(this.btnAnaUrunGuncelle);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.btnAnaUrunIptal);
            this.panel1.Controls.Add(this.txtAnaUrunAdi);
            this.panel1.Controls.Add(this.lblAnaUrunAdi);
            this.panel1.Location = new System.Drawing.Point(13, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 110);
            this.panel1.TabIndex = 3;
            // 
            // btnAnaUrunKaydet
            // 
            this.btnAnaUrunKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaUrunKaydet.Image")));
            this.btnAnaUrunKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaUrunKaydet.Location = new System.Drawing.Point(27, 42);
            this.btnAnaUrunKaydet.Name = "btnAnaUrunKaydet";
            this.btnAnaUrunKaydet.Size = new System.Drawing.Size(94, 43);
            this.btnAnaUrunKaydet.TabIndex = 2;
            this.btnAnaUrunKaydet.Text = "Kaydet";
            this.btnAnaUrunKaydet.UseVisualStyleBackColor = true;
            this.btnAnaUrunKaydet.Click += new System.EventHandler(this.btnAnaUrunKaydet_Click);
            // 
            // btnAnaUrunGuncelle
            // 
            this.btnAnaUrunGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaUrunGuncelle.Image")));
            this.btnAnaUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaUrunGuncelle.Location = new System.Drawing.Point(27, 42);
            this.btnAnaUrunGuncelle.Name = "btnAnaUrunGuncelle";
            this.btnAnaUrunGuncelle.Size = new System.Drawing.Size(94, 43);
            this.btnAnaUrunGuncelle.TabIndex = 8;
            this.btnAnaUrunGuncelle.Text = "Güncelle";
            this.btnAnaUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnAnaUrunGuncelle.Click += new System.EventHandler(this.btnAnaUrunGuncelle_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A-Z Sıralama";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(149, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Z-A Sıralama";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnAnaUrunIptal
            // 
            this.btnAnaUrunIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaUrunIptal.Image")));
            this.btnAnaUrunIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaUrunIptal.Location = new System.Drawing.Point(149, 42);
            this.btnAnaUrunIptal.Name = "btnAnaUrunIptal";
            this.btnAnaUrunIptal.Size = new System.Drawing.Size(91, 43);
            this.btnAnaUrunIptal.TabIndex = 3;
            this.btnAnaUrunIptal.Text = "İptal";
            this.btnAnaUrunIptal.UseVisualStyleBackColor = true;
            this.btnAnaUrunIptal.Click += new System.EventHandler(this.btnAnaUrunIptal_Click);
            // 
            // txtAnaUrunAdi
            // 
            this.txtAnaUrunAdi.Location = new System.Drawing.Point(91, 10);
            this.txtAnaUrunAdi.Name = "txtAnaUrunAdi";
            this.txtAnaUrunAdi.Size = new System.Drawing.Size(151, 20);
            this.txtAnaUrunAdi.TabIndex = 1;
            this.txtAnaUrunAdi.TextChanged += new System.EventHandler(this.txtAnaUrunAdi_TextChanged);
            // 
            // lblAnaUrunAdi
            // 
            this.lblAnaUrunAdi.AutoSize = true;
            this.lblAnaUrunAdi.Location = new System.Drawing.Point(12, 17);
            this.lblAnaUrunAdi.Name = "lblAnaUrunAdi";
            this.lblAnaUrunAdi.Size = new System.Drawing.Size(73, 13);
            this.lblAnaUrunAdi.TabIndex = 0;
            this.lblAnaUrunAdi.Text = "Ana Ürün Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridAnaUrun);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 508);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Ürünler";
            // 
            // dtGridAnaUrun
            // 
            this.dtGridAnaUrun.AllowUserToAddRows = false;
            this.dtGridAnaUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dtGridAnaUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAnaUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridAnaUrun.Location = new System.Drawing.Point(6, 19);
            this.dtGridAnaUrun.Name = "dtGridAnaUrun";
            this.dtGridAnaUrun.Size = new System.Drawing.Size(253, 469);
            this.dtGridAnaUrun.TabIndex = 0;
            this.dtGridAnaUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAnaUrun_CellClick);
            this.dtGridAnaUrun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAnaUrun_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAraUrunKaydet);
            this.panel2.Controls.Add(this.btnAraUrunGuncellle);
            this.panel2.Controls.Add(this.lblAltUrunBirimi);
            this.panel2.Controls.Add(this.btnAraUrunIptal);
            this.panel2.Controls.Add(this.cmbAltUrunBirimi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblAltUrunFiyati);
            this.panel2.Controls.Add(this.txtAltUrunFiyati);
            this.panel2.Controls.Add(this.txtAltUrunAdi);
            this.panel2.Controls.Add(this.lblAltUrunAdi);
            this.panel2.Location = new System.Drawing.Point(284, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 110);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAraUrunKaydet
            // 
            this.btnAraUrunKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnAraUrunKaydet.Image")));
            this.btnAraUrunKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraUrunKaydet.Location = new System.Drawing.Point(324, 56);
            this.btnAraUrunKaydet.Name = "btnAraUrunKaydet";
            this.btnAraUrunKaydet.Size = new System.Drawing.Size(94, 43);
            this.btnAraUrunKaydet.TabIndex = 2;
            this.btnAraUrunKaydet.Text = "Kaydet";
            this.btnAraUrunKaydet.UseVisualStyleBackColor = true;
            this.btnAraUrunKaydet.Click += new System.EventHandler(this.btnAraUrunKaydet_Click);
            // 
            // btnAraUrunGuncellle
            // 
            this.btnAraUrunGuncellle.Image = ((System.Drawing.Image)(resources.GetObject("btnAraUrunGuncellle.Image")));
            this.btnAraUrunGuncellle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraUrunGuncellle.Location = new System.Drawing.Point(325, 56);
            this.btnAraUrunGuncellle.Name = "btnAraUrunGuncellle";
            this.btnAraUrunGuncellle.Size = new System.Drawing.Size(94, 43);
            this.btnAraUrunGuncellle.TabIndex = 7;
            this.btnAraUrunGuncellle.Text = "Güncelle";
            this.btnAraUrunGuncellle.UseVisualStyleBackColor = true;
            this.btnAraUrunGuncellle.Click += new System.EventHandler(this.btnAraUrunGuncellle_Click);
            // 
            // lblAltUrunBirimi
            // 
            this.lblAltUrunBirimi.AutoSize = true;
            this.lblAltUrunBirimi.Location = new System.Drawing.Point(385, 10);
            this.lblAltUrunBirimi.Name = "lblAltUrunBirimi";
            this.lblAltUrunBirimi.Size = new System.Drawing.Size(34, 13);
            this.lblAltUrunBirimi.TabIndex = 6;
            this.lblAltUrunBirimi.Text = "Birimi:";
            // 
            // btnAraUrunIptal
            // 
            this.btnAraUrunIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnAraUrunIptal.Image")));
            this.btnAraUrunIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraUrunIptal.Location = new System.Drawing.Point(450, 56);
            this.btnAraUrunIptal.Name = "btnAraUrunIptal";
            this.btnAraUrunIptal.Size = new System.Drawing.Size(94, 43);
            this.btnAraUrunIptal.TabIndex = 2;
            this.btnAraUrunIptal.Text = "İptal";
            this.btnAraUrunIptal.UseVisualStyleBackColor = true;
            this.btnAraUrunIptal.Click += new System.EventHandler(this.btnAraUrunIptal_Click);
            // 
            // cmbAltUrunBirimi
            // 
            this.cmbAltUrunBirimi.FormattingEnabled = true;
            this.cmbAltUrunBirimi.Items.AddRange(new object[] {
            "Porsiyon",
            "Adet"});
            this.cmbAltUrunBirimi.Location = new System.Drawing.Point(388, 29);
            this.cmbAltUrunBirimi.Name = "cmbAltUrunBirimi";
            this.cmbAltUrunBirimi.Size = new System.Drawing.Size(121, 21);
            this.cmbAltUrunBirimi.TabIndex = 5;
            this.cmbAltUrunBirimi.SelectedIndexChanged += new System.EventHandler(this.cmbAltUrunBirimi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TL";
            // 
            // lblAltUrunFiyati
            // 
            this.lblAltUrunFiyati.AutoSize = true;
            this.lblAltUrunFiyati.Location = new System.Drawing.Point(221, 10);
            this.lblAltUrunFiyati.Name = "lblAltUrunFiyati";
            this.lblAltUrunFiyati.Size = new System.Drawing.Size(34, 13);
            this.lblAltUrunFiyati.TabIndex = 3;
            this.lblAltUrunFiyati.Text = "Fiyatı:";
            // 
            // txtAltUrunFiyati
            // 
            this.txtAltUrunFiyati.Location = new System.Drawing.Point(224, 26);
            this.txtAltUrunFiyati.Name = "txtAltUrunFiyati";
            this.txtAltUrunFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtAltUrunFiyati.TabIndex = 2;
            this.txtAltUrunFiyati.TextChanged += new System.EventHandler(this.txtAltUrunFiyati_TextChanged);
            // 
            // txtAltUrunAdi
            // 
            this.txtAltUrunAdi.Location = new System.Drawing.Point(31, 26);
            this.txtAltUrunAdi.Name = "txtAltUrunAdi";
            this.txtAltUrunAdi.Size = new System.Drawing.Size(162, 20);
            this.txtAltUrunAdi.TabIndex = 1;
            this.txtAltUrunAdi.TextChanged += new System.EventHandler(this.txtAltUrunAdi_TextChanged);
            // 
            // lblAltUrunAdi
            // 
            this.lblAltUrunAdi.AutoSize = true;
            this.lblAltUrunAdi.Location = new System.Drawing.Point(28, 10);
            this.lblAltUrunAdi.Name = "lblAltUrunAdi";
            this.lblAltUrunAdi.Size = new System.Drawing.Size(66, 13);
            this.lblAltUrunAdi.TabIndex = 0;
            this.lblAltUrunAdi.Text = "Alt Ürün Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridAraUrun);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(284, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 508);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ara Ürünler";
            // 
            // dtGridAraUrun
            // 
            this.dtGridAraUrun.AllowUserToAddRows = false;
            this.dtGridAraUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dtGridAraUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAraUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridAraUrun.Location = new System.Drawing.Point(13, 19);
            this.dtGridAraUrun.Name = "dtGridAraUrun";
            this.dtGridAraUrun.Size = new System.Drawing.Size(668, 469);
            this.dtGridAraUrun.TabIndex = 0;
            this.dtGridAraUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAraUrun_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(994, 752);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlStpUrunler);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle - Çıkar - Değiştir";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlStpUrunler.ResumeLayout(false);
            this.tlStpUrunler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAnaUrun)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAraUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dasdasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlStpUrunler;
        private System.Windows.Forms.ToolStripButton tlStpBtnAnaUrunEkle;
        private System.Windows.Forms.ToolStripButton tlStpBtnAnaUrunDuzenle;
        private System.Windows.Forms.ToolStripButton tlStpBtnAnaUrunSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlStpBtnAltUrunEkle;
        private System.Windows.Forms.ToolStripButton tlStpBtnAltUrunDuzenle;
        private System.Windows.Forms.ToolStripButton tlStpBtnAltUrunSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlStpBtnUrunKapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnaUrunIptal;
        private System.Windows.Forms.Button btnAnaUrunKaydet;
        private System.Windows.Forms.TextBox txtAnaUrunAdi;
        private System.Windows.Forms.Label lblAnaUrunAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAltUrunFiyati;
        private System.Windows.Forms.TextBox txtAltUrunFiyati;
        private System.Windows.Forms.TextBox txtAltUrunAdi;
        private System.Windows.Forms.Label lblAltUrunAdi;
        private System.Windows.Forms.ComboBox cmbAltUrunBirimi;
        private System.Windows.Forms.Label lblAltUrunBirimi;
        private System.Windows.Forms.Button btnAraUrunIptal;
        private System.Windows.Forms.Button btnAraUrunKaydet;
        private System.Windows.Forms.DataGridView dtGridAnaUrun;
        private System.Windows.Forms.DataGridView dtGridAraUrun;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripButton tlStpBtnUrunGeri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnAnaUrunGuncelle;
        private System.Windows.Forms.Button btnAraUrunGuncellle;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}
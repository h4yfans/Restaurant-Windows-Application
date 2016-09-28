namespace ProjeLokanta
{
    partial class frmyetkiliekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmyetkiliekle));
            this.btnYetkiliIptal = new System.Windows.Forms.Button();
            this.btnYetkiliKaydet = new System.Windows.Forms.Button();
            this.txtYetkiliSifre = new System.Windows.Forms.TextBox();
            this.txtYetkiliSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYetkiliKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblYetkiliEkleKullaniciAdi = new System.Windows.Forms.Label();
            this.lblYetkiliEkleSifreTekrar = new System.Windows.Forms.Label();
            this.lblYetkiliEkleSifre = new System.Windows.Forms.Label();
            this.txtYetkiliAdres = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtGridYetkili = new System.Windows.Forms.DataGridView();
            this.lblYetkiliEkleAdres = new System.Windows.Forms.Label();
            this.radioZAsırala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYetkiliArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAZsırala = new System.Windows.Forms.RadioButton();
            this.txtYetkiliSoyad = new System.Windows.Forms.TextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.txtYetkiliEvno = new System.Windows.Forms.TextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yetkiliİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtYetkiliCepNo = new System.Windows.Forms.TextBox();
            this.txtYetkiliAd = new System.Windows.Forms.TextBox();
            this.lblYetkiliEkleCepNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYetkiliAyar = new System.Windows.Forms.Button();
            this.lblYetkiliEkleEvNo = new System.Windows.Forms.Label();
            this.lblYetkiliEkleSoyad = new System.Windows.Forms.Label();
            this.lblYetkiliEkleAd = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHepsiniGoster = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridYetkili)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYetkiliIptal
            // 
            this.btnYetkiliIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiliIptal.Image")));
            this.btnYetkiliIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiliIptal.Location = new System.Drawing.Point(421, 105);
            this.btnYetkiliIptal.Name = "btnYetkiliIptal";
            this.btnYetkiliIptal.Size = new System.Drawing.Size(96, 32);
            this.btnYetkiliIptal.TabIndex = 10;
            this.btnYetkiliIptal.Text = "İptal";
            this.btnYetkiliIptal.UseVisualStyleBackColor = true;
            this.btnYetkiliIptal.Click += new System.EventHandler(this.btnYetkiliIptal_Click);
            // 
            // btnYetkiliKaydet
            // 
            this.btnYetkiliKaydet.Enabled = false;
            this.btnYetkiliKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiliKaydet.Image")));
            this.btnYetkiliKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiliKaydet.Location = new System.Drawing.Point(319, 105);
            this.btnYetkiliKaydet.Name = "btnYetkiliKaydet";
            this.btnYetkiliKaydet.Size = new System.Drawing.Size(96, 32);
            this.btnYetkiliKaydet.TabIndex = 9;
            this.btnYetkiliKaydet.Text = "Kaydet";
            this.btnYetkiliKaydet.UseVisualStyleBackColor = true;
            this.btnYetkiliKaydet.Click += new System.EventHandler(this.btnYetkiliKaydet_Click);
            // 
            // txtYetkiliSifre
            // 
            this.txtYetkiliSifre.Enabled = false;
            this.txtYetkiliSifre.Location = new System.Drawing.Point(410, 44);
            this.txtYetkiliSifre.Name = "txtYetkiliSifre";
            this.txtYetkiliSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliSifre.TabIndex = 8;
            this.txtYetkiliSifre.UseSystemPasswordChar = true;
            this.txtYetkiliSifre.TextChanged += new System.EventHandler(this.txtYetkiliSifre_TextChanged);
            // 
            // txtYetkiliSifreTekrar
            // 
            this.txtYetkiliSifreTekrar.Enabled = false;
            this.txtYetkiliSifreTekrar.Location = new System.Drawing.Point(410, 73);
            this.txtYetkiliSifreTekrar.Name = "txtYetkiliSifreTekrar";
            this.txtYetkiliSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliSifreTekrar.TabIndex = 8;
            this.txtYetkiliSifreTekrar.UseSystemPasswordChar = true;
            this.txtYetkiliSifreTekrar.TextChanged += new System.EventHandler(this.txtYetkiliSifreTekrar_TextChanged);
            // 
            // txtYetkiliKullaniciAd
            // 
            this.txtYetkiliKullaniciAd.Enabled = false;
            this.txtYetkiliKullaniciAd.Location = new System.Drawing.Point(410, 16);
            this.txtYetkiliKullaniciAd.Name = "txtYetkiliKullaniciAd";
            this.txtYetkiliKullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliKullaniciAd.TabIndex = 8;
            this.txtYetkiliKullaniciAd.TextChanged += new System.EventHandler(this.txtYetkiliKullaniciAd_TextChanged);
            // 
            // lblYetkiliEkleKullaniciAdi
            // 
            this.lblYetkiliEkleKullaniciAdi.AutoSize = true;
            this.lblYetkiliEkleKullaniciAdi.Location = new System.Drawing.Point(316, 16);
            this.lblYetkiliEkleKullaniciAdi.Name = "lblYetkiliEkleKullaniciAdi";
            this.lblYetkiliEkleKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblYetkiliEkleKullaniciAdi.TabIndex = 7;
            this.lblYetkiliEkleKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblYetkiliEkleSifreTekrar
            // 
            this.lblYetkiliEkleSifreTekrar.AutoSize = true;
            this.lblYetkiliEkleSifreTekrar.Location = new System.Drawing.Point(316, 76);
            this.lblYetkiliEkleSifreTekrar.Name = "lblYetkiliEkleSifreTekrar";
            this.lblYetkiliEkleSifreTekrar.Size = new System.Drawing.Size(67, 13);
            this.lblYetkiliEkleSifreTekrar.TabIndex = 7;
            this.lblYetkiliEkleSifreTekrar.Text = "Şifre Tekrarı:";
            // 
            // lblYetkiliEkleSifre
            // 
            this.lblYetkiliEkleSifre.AutoSize = true;
            this.lblYetkiliEkleSifre.Location = new System.Drawing.Point(316, 47);
            this.lblYetkiliEkleSifre.Name = "lblYetkiliEkleSifre";
            this.lblYetkiliEkleSifre.Size = new System.Drawing.Size(31, 13);
            this.lblYetkiliEkleSifre.TabIndex = 7;
            this.lblYetkiliEkleSifre.Text = "Şifre:";
            // 
            // txtYetkiliAdres
            // 
            this.txtYetkiliAdres.Enabled = false;
            this.txtYetkiliAdres.Location = new System.Drawing.Point(96, 121);
            this.txtYetkiliAdres.Multiline = true;
            this.txtYetkiliAdres.Name = "txtYetkiliAdres";
            this.txtYetkiliAdres.Size = new System.Drawing.Size(170, 44);
            this.txtYetkiliAdres.TabIndex = 3;
            this.txtYetkiliAdres.TextChanged += new System.EventHandler(this.txtYetkiliAdres_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtGridYetkili);
            this.groupBox3.Location = new System.Drawing.Point(6, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(972, 395);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yetkililer";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtGridYetkili
            // 
            this.dtGridYetkili.AllowUserToAddRows = false;
            this.dtGridYetkili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridYetkili.Location = new System.Drawing.Point(7, 20);
            this.dtGridYetkili.Name = "dtGridYetkili";
            this.dtGridYetkili.Size = new System.Drawing.Size(619, 352);
            this.dtGridYetkili.TabIndex = 0;
            this.dtGridYetkili.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridYetkili_CellClick);
            this.dtGridYetkili.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridYetkili_CellContentClick);
            // 
            // lblYetkiliEkleAdres
            // 
            this.lblYetkiliEkleAdres.AutoSize = true;
            this.lblYetkiliEkleAdres.Location = new System.Drawing.Point(19, 124);
            this.lblYetkiliEkleAdres.Name = "lblYetkiliEkleAdres";
            this.lblYetkiliEkleAdres.Size = new System.Drawing.Size(37, 13);
            this.lblYetkiliEkleAdres.TabIndex = 2;
            this.lblYetkiliEkleAdres.Text = "Adres:";
            // 
            // radioZAsırala
            // 
            this.radioZAsırala.AutoSize = true;
            this.radioZAsırala.Location = new System.Drawing.Point(124, 13);
            this.radioZAsırala.Name = "radioZAsırala";
            this.radioZAsırala.Size = new System.Drawing.Size(71, 17);
            this.radioZAsırala.TabIndex = 1;
            this.radioZAsırala.TabStop = true;
            this.radioZAsırala.Text = "Z-A Sırala";
            this.radioZAsırala.UseVisualStyleBackColor = true;
            this.radioZAsırala.CheckedChanged += new System.EventHandler(this.radioZAsırala_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHepsiniGoster);
            this.groupBox2.Controls.Add(this.txtYetkiliArama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioZAsırala);
            this.groupBox2.Controls.Add(this.radioAZsırala);
            this.groupBox2.Location = new System.Drawing.Point(6, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listeleme Kriterleri";
            // 
            // txtYetkiliArama
            // 
            this.txtYetkiliArama.Location = new System.Drawing.Point(724, 12);
            this.txtYetkiliArama.Name = "txtYetkiliArama";
            this.txtYetkiliArama.Size = new System.Drawing.Size(137, 20);
            this.txtYetkiliArama.TabIndex = 3;
            this.txtYetkiliArama.TextChanged += new System.EventHandler(this.txtYetkiliArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama";
            // 
            // radioAZsırala
            // 
            this.radioAZsırala.AutoSize = true;
            this.radioAZsırala.Location = new System.Drawing.Point(22, 13);
            this.radioAZsırala.Name = "radioAZsırala";
            this.radioAZsırala.Size = new System.Drawing.Size(71, 17);
            this.radioAZsırala.TabIndex = 0;
            this.radioAZsırala.TabStop = true;
            this.radioAZsırala.Text = "A-Z Sırala";
            this.radioAZsırala.UseVisualStyleBackColor = true;
            this.radioAZsırala.CheckedChanged += new System.EventHandler(this.radioAZsırala_CheckedChanged);
            // 
            // txtYetkiliSoyad
            // 
            this.txtYetkiliSoyad.Enabled = false;
            this.txtYetkiliSoyad.Location = new System.Drawing.Point(96, 44);
            this.txtYetkiliSoyad.Name = "txtYetkiliSoyad";
            this.txtYetkiliSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtYetkiliSoyad.TabIndex = 1;
            this.txtYetkiliSoyad.TextChanged += new System.EventHandler(this.txtYetkiliSoyad_TextChanged);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 102);
            this.toolStripButton3.Text = "Sil";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // txtYetkiliEvno
            // 
            this.txtYetkiliEvno.Enabled = false;
            this.txtYetkiliEvno.Location = new System.Drawing.Point(96, 69);
            this.txtYetkiliEvno.Name = "txtYetkiliEvno";
            this.txtYetkiliEvno.Size = new System.Drawing.Size(170, 20);
            this.txtYetkiliEvno.TabIndex = 1;
            this.txtYetkiliEvno.TextChanged += new System.EventHandler(this.txtYetkiliEvno_TextChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 102);
            this.toolStripButton2.Text = "Düzenle";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 102);
            this.toolStripButton4.Text = "Kapat";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 102);
            this.toolStripButton1.Text = "Yeni Kayıt";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 105);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 105);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 105);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 105);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(68, 102);
            this.toolStripButton5.Text = "Geri";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 105);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yetkiliİşlemleriToolStripMenuItem
            // 
            this.yetkiliİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.yetkiliİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yetkiliİşlemleriToolStripMenuItem.Image")));
            this.yetkiliİşlemleriToolStripMenuItem.Name = "yetkiliİşlemleriToolStripMenuItem";
            this.yetkiliİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.yetkiliİşlemleriToolStripMenuItem.Text = "Yetkili İşlemleri";
            // 
            // txtYetkiliCepNo
            // 
            this.txtYetkiliCepNo.Enabled = false;
            this.txtYetkiliCepNo.Location = new System.Drawing.Point(96, 95);
            this.txtYetkiliCepNo.Name = "txtYetkiliCepNo";
            this.txtYetkiliCepNo.Size = new System.Drawing.Size(170, 20);
            this.txtYetkiliCepNo.TabIndex = 1;
            this.txtYetkiliCepNo.TextChanged += new System.EventHandler(this.txtYetkiliCepNo_TextChanged);
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.Enabled = false;
            this.txtYetkiliAd.Location = new System.Drawing.Point(96, 18);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(170, 20);
            this.txtYetkiliAd.TabIndex = 1;
            this.txtYetkiliAd.TextChanged += new System.EventHandler(this.txtYetkiliAd_TextChanged);
            // 
            // lblYetkiliEkleCepNo
            // 
            this.lblYetkiliEkleCepNo.AutoSize = true;
            this.lblYetkiliEkleCepNo.Location = new System.Drawing.Point(19, 95);
            this.lblYetkiliEkleCepNo.Name = "lblYetkiliEkleCepNo";
            this.lblYetkiliEkleCepNo.Size = new System.Drawing.Size(70, 13);
            this.lblYetkiliEkleCepNo.TabIndex = 0;
            this.lblYetkiliEkleCepNo.Text = "Cep telefonu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYetkiliAyar);
            this.groupBox1.Controls.Add(this.btnYetkiliIptal);
            this.groupBox1.Controls.Add(this.btnYetkiliKaydet);
            this.groupBox1.Controls.Add(this.txtYetkiliSifre);
            this.groupBox1.Controls.Add(this.txtYetkiliSifreTekrar);
            this.groupBox1.Controls.Add(this.txtYetkiliKullaniciAd);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleSifreTekrar);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleSifre);
            this.groupBox1.Controls.Add(this.txtYetkiliAdres);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleAdres);
            this.groupBox1.Controls.Add(this.txtYetkiliSoyad);
            this.groupBox1.Controls.Add(this.txtYetkiliEvno);
            this.groupBox1.Controls.Add(this.txtYetkiliCepNo);
            this.groupBox1.Controls.Add(this.txtYetkiliAd);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleCepNo);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleEvNo);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleSoyad);
            this.groupBox1.Controls.Add(this.lblYetkiliEkleAd);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Location = new System.Drawing.Point(6, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnYetkiliAyar
            // 
            this.btnYetkiliAyar.Location = new System.Drawing.Point(768, 23);
            this.btnYetkiliAyar.Name = "btnYetkiliAyar";
            this.btnYetkiliAyar.Size = new System.Drawing.Size(115, 34);
            this.btnYetkiliAyar.TabIndex = 11;
            this.btnYetkiliAyar.Text = "Yetkili Ayarları";
            this.btnYetkiliAyar.UseVisualStyleBackColor = true;
            this.btnYetkiliAyar.Click += new System.EventHandler(this.btnYetkiliAyar_Click);
            // 
            // lblYetkiliEkleEvNo
            // 
            this.lblYetkiliEkleEvNo.AutoSize = true;
            this.lblYetkiliEkleEvNo.Location = new System.Drawing.Point(19, 69);
            this.lblYetkiliEkleEvNo.Name = "lblYetkiliEkleEvNo";
            this.lblYetkiliEkleEvNo.Size = new System.Drawing.Size(68, 13);
            this.lblYetkiliEkleEvNo.TabIndex = 0;
            this.lblYetkiliEkleEvNo.Text = "Ev Telefonu:";
            // 
            // lblYetkiliEkleSoyad
            // 
            this.lblYetkiliEkleSoyad.AutoSize = true;
            this.lblYetkiliEkleSoyad.Location = new System.Drawing.Point(19, 44);
            this.lblYetkiliEkleSoyad.Name = "lblYetkiliEkleSoyad";
            this.lblYetkiliEkleSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblYetkiliEkleSoyad.TabIndex = 0;
            this.lblYetkiliEkleSoyad.Text = "Soyad:";
            // 
            // lblYetkiliEkleAd
            // 
            this.lblYetkiliEkleAd.AutoSize = true;
            this.lblYetkiliEkleAd.Location = new System.Drawing.Point(19, 20);
            this.lblYetkiliEkleAd.Name = "lblYetkiliEkleAd";
            this.lblYetkiliEkleAd.Size = new System.Drawing.Size(23, 13);
            this.lblYetkiliEkleAd.TabIndex = 0;
            this.lblYetkiliEkleAd.Text = "Ad:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(319, 105);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 32);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnHepsiniGoster
            // 
            this.btnHepsiniGoster.Location = new System.Drawing.Point(319, 10);
            this.btnHepsiniGoster.Name = "btnHepsiniGoster";
            this.btnHepsiniGoster.Size = new System.Drawing.Size(123, 23);
            this.btnHepsiniGoster.TabIndex = 4;
            this.btnHepsiniGoster.Text = "Hepsini Göster";
            this.btnHepsiniGoster.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster.Click += new System.EventHandler(this.btnHepsiniGoster_Click);
            // 
            // frmyetkiliekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 784);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmyetkiliekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Ekle / Değiştir / Sil";
            this.Load += new System.EventHandler(this.frmyetkiliekle_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridYetkili)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYetkiliIptal;
        private System.Windows.Forms.Button btnYetkiliKaydet;
        private System.Windows.Forms.TextBox txtYetkiliSifre;
        private System.Windows.Forms.TextBox txtYetkiliSifreTekrar;
        private System.Windows.Forms.TextBox txtYetkiliKullaniciAd;
        private System.Windows.Forms.Label lblYetkiliEkleKullaniciAdi;
        private System.Windows.Forms.Label lblYetkiliEkleSifreTekrar;
        private System.Windows.Forms.Label lblYetkiliEkleSifre;
        private System.Windows.Forms.TextBox txtYetkiliAdres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblYetkiliEkleAdres;
        private System.Windows.Forms.RadioButton radioZAsırala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioAZsırala;
        private System.Windows.Forms.TextBox txtYetkiliSoyad;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txtYetkiliEvno;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yetkiliİşlemleriToolStripMenuItem;
        private System.Windows.Forms.TextBox txtYetkiliCepNo;
        private System.Windows.Forms.TextBox txtYetkiliAd;
        private System.Windows.Forms.Label lblYetkiliEkleCepNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYetkiliEkleEvNo;
        private System.Windows.Forms.Label lblYetkiliEkleSoyad;
        private System.Windows.Forms.Label lblYetkiliEkleAd;
        private System.Windows.Forms.TextBox txtYetkiliArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYetkiliAyar;
        private System.Windows.Forms.DataGridView dtGridYetkili;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnHepsiniGoster;
    }
}
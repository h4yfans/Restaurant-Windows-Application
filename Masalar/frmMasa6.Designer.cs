namespace ProjeLokanta
{
    partial class frmMasa6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasa6));
            this.msMasa1 = new System.Windows.Forms.MenuStrip();
            this.tsMasa1Siparis = new System.Windows.Forms.ToolStripMenuItem();
            this.tpMasa1 = new System.Windows.Forms.TabControl();
            this.Ürünler = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAltUrunAdi = new System.Windows.Forms.GroupBox();
            this.dgAraUrun = new System.Windows.Forms.DataGridView();
            this.gbAnaGrupAdı = new System.Windows.Forms.GroupBox();
            this.dgAnaUrun = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblMasa2TTutar = new System.Windows.Forms.Label();
            this.gbSatisIslemleri = new System.Windows.Forms.GroupBox();
            this.btnMasa2SiparisIptal = new System.Windows.Forms.Button();
            this.btnMasa2SiparisAl = new System.Windows.Forms.Button();
            this.btnMasa2ServisKapa = new System.Windows.Forms.Button();
            this.dtMasa1Saat = new System.Windows.Forms.DateTimePicker();
            this.dtMasa1Tarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsMasaAyrac = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblMasaSiparisAZ = new System.Windows.Forms.Label();
            this.btnMasa2Azalt = new System.Windows.Forms.Button();
            this.btnMasa2Arttır = new System.Windows.Forms.Button();
            this.gbSiparisSepeti = new System.Windows.Forms.GroupBox();
            this.dgMasa6Siparis = new System.Windows.Forms.DataGridView();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnMasaikram = new System.Windows.Forms.Button();
            this.btnMasaCikar = new System.Windows.Forms.Button();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.lblTarihUstBar = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMasa1.SuspendLayout();
            this.tpMasa1.SuspendLayout();
            this.Ürünler.SuspendLayout();
            this.gbAltUrunAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAraUrun)).BeginInit();
            this.gbAnaGrupAdı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnaUrun)).BeginInit();
            this.gbSatisIslemleri.SuspendLayout();
            this.gbSiparisSepeti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasa6Siparis)).BeginInit();
            this.gbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMasa1
            // 
            this.msMasa1.AutoSize = false;
            this.msMasa1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.msMasa1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMasa1Siparis});
            this.msMasa1.Location = new System.Drawing.Point(0, 0);
            this.msMasa1.Name = "msMasa1";
            this.msMasa1.Size = new System.Drawing.Size(1166, 40);
            this.msMasa1.TabIndex = 3;
            this.msMasa1.Text = "menuStrip1";
            // 
            // tsMasa1Siparis
            // 
            this.tsMasa1Siparis.BackColor = System.Drawing.Color.SkyBlue;
            this.tsMasa1Siparis.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.tsMasa1Siparis.ForeColor = System.Drawing.Color.White;
            this.tsMasa1Siparis.Image = ((System.Drawing.Image)(resources.GetObject("tsMasa1Siparis.Image")));
            this.tsMasa1Siparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMasa1Siparis.Name = "tsMasa1Siparis";
            this.tsMasa1Siparis.Size = new System.Drawing.Size(218, 36);
            this.tsMasa1Siparis.Text = "Sipariş - MASA 6";
            // 
            // tpMasa1
            // 
            this.tpMasa1.Controls.Add(this.Ürünler);
            this.tpMasa1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.tpMasa1.ImageList = this.ımageList1;
            this.tpMasa1.ItemSize = new System.Drawing.Size(61, 30);
            this.tpMasa1.Location = new System.Drawing.Point(12, 43);
            this.tpMasa1.Name = "tpMasa1";
            this.tpMasa1.SelectedIndex = 0;
            this.tpMasa1.Size = new System.Drawing.Size(607, 501);
            this.tpMasa1.TabIndex = 4;
            // 
            // Ürünler
            // 
            this.Ürünler.BackColor = System.Drawing.Color.Transparent;
            this.Ürünler.Controls.Add(this.label1);
            this.Ürünler.Controls.Add(this.gbAltUrunAdi);
            this.Ürünler.Controls.Add(this.gbAnaGrupAdı);
            this.Ürünler.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.Ürünler.ImageIndex = 0;
            this.Ürünler.Location = new System.Drawing.Point(4, 34);
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.Padding = new System.Windows.Forms.Padding(3);
            this.Ürünler.Size = new System.Drawing.Size(599, 463);
            this.Ürünler.TabIndex = 0;
            this.Ürünler.Text = "Menü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(247, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = ">>";
            // 
            // gbAltUrunAdi
            // 
            this.gbAltUrunAdi.Controls.Add(this.dgAraUrun);
            this.gbAltUrunAdi.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbAltUrunAdi.Location = new System.Drawing.Point(274, 6);
            this.gbAltUrunAdi.Name = "gbAltUrunAdi";
            this.gbAltUrunAdi.Size = new System.Drawing.Size(315, 452);
            this.gbAltUrunAdi.TabIndex = 1;
            this.gbAltUrunAdi.TabStop = false;
            this.gbAltUrunAdi.Text = "Alt Ürün Adı";
            // 
            // dgAraUrun
            // 
            this.dgAraUrun.AllowUserToAddRows = false;
            this.dgAraUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dgAraUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAraUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAraUrun.Location = new System.Drawing.Point(6, 16);
            this.dgAraUrun.Name = "dgAraUrun";
            this.dgAraUrun.Size = new System.Drawing.Size(303, 430);
            this.dgAraUrun.TabIndex = 0;
            this.dgAraUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAraUrun_CellClick);
            this.dgAraUrun.DoubleClick += new System.EventHandler(this.dgAraUrun_DoubleClick);
            // 
            // gbAnaGrupAdı
            // 
            this.gbAnaGrupAdı.Controls.Add(this.dgAnaUrun);
            this.gbAnaGrupAdı.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbAnaGrupAdı.Location = new System.Drawing.Point(6, 6);
            this.gbAnaGrupAdı.Name = "gbAnaGrupAdı";
            this.gbAnaGrupAdı.Size = new System.Drawing.Size(239, 452);
            this.gbAnaGrupAdı.TabIndex = 0;
            this.gbAnaGrupAdı.TabStop = false;
            this.gbAnaGrupAdı.Text = "Ana Grup Adı";
            // 
            // dgAnaUrun
            // 
            this.dgAnaUrun.AllowUserToAddRows = false;
            this.dgAnaUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dgAnaUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnaUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgAnaUrun.Location = new System.Drawing.Point(6, 16);
            this.dgAnaUrun.Name = "dgAnaUrun";
            this.dgAnaUrun.Size = new System.Drawing.Size(227, 430);
            this.dgAnaUrun.TabIndex = 2;
            this.dgAnaUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnaUrun_CellClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "hamburger.ico");
            // 
            // lblMasa2TTutar
            // 
            this.lblMasa2TTutar.BackColor = System.Drawing.Color.Navy;
            this.lblMasa2TTutar.Font = new System.Drawing.Font("Trebuchet MS", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblMasa2TTutar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMasa2TTutar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMasa2TTutar.Location = new System.Drawing.Point(879, 43);
            this.lblMasa2TTutar.Name = "lblMasa2TTutar";
            this.lblMasa2TTutar.Size = new System.Drawing.Size(152, 38);
            this.lblMasa2TTutar.TabIndex = 22;
            this.lblMasa2TTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSatisIslemleri
            // 
            this.gbSatisIslemleri.Controls.Add(this.btnMasa2SiparisIptal);
            this.gbSatisIslemleri.Controls.Add(this.btnMasa2SiparisAl);
            this.gbSatisIslemleri.Controls.Add(this.btnMasa2ServisKapa);
            this.gbSatisIslemleri.Controls.Add(this.dtMasa1Saat);
            this.gbSatisIslemleri.Controls.Add(this.dtMasa1Tarih);
            this.gbSatisIslemleri.Controls.Add(this.lblTarih);
            this.gbSatisIslemleri.Controls.Add(this.shapeContainer1);
            this.gbSatisIslemleri.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbSatisIslemleri.Location = new System.Drawing.Point(631, 365);
            this.gbSatisIslemleri.Name = "gbSatisIslemleri";
            this.gbSatisIslemleri.Size = new System.Drawing.Size(517, 179);
            this.gbSatisIslemleri.TabIndex = 21;
            this.gbSatisIslemleri.TabStop = false;
            this.gbSatisIslemleri.Text = "Satış İşlemleri";
            // 
            // btnMasa2SiparisIptal
            // 
            this.btnMasa2SiparisIptal.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMasa2SiparisIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnMasa2SiparisIptal.Image")));
            this.btnMasa2SiparisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasa2SiparisIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasa2SiparisIptal.Location = new System.Drawing.Point(410, 90);
            this.btnMasa2SiparisIptal.Name = "btnMasa2SiparisIptal";
            this.btnMasa2SiparisIptal.Size = new System.Drawing.Size(89, 53);
            this.btnMasa2SiparisIptal.TabIndex = 10;
            this.btnMasa2SiparisIptal.Text = "İptal";
            this.btnMasa2SiparisIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasa2SiparisIptal.UseVisualStyleBackColor = true;
            this.btnMasa2SiparisIptal.Click += new System.EventHandler(this.btnMasa2SiparisIptal_Click);
            // 
            // btnMasa2SiparisAl
            // 
            this.btnMasa2SiparisAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMasa2SiparisAl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMasa2SiparisAl.Image = ((System.Drawing.Image)(resources.GetObject("btnMasa2SiparisAl.Image")));
            this.btnMasa2SiparisAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasa2SiparisAl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasa2SiparisAl.Location = new System.Drawing.Point(225, 90);
            this.btnMasa2SiparisAl.Name = "btnMasa2SiparisAl";
            this.btnMasa2SiparisAl.Size = new System.Drawing.Size(143, 53);
            this.btnMasa2SiparisAl.TabIndex = 9;
            this.btnMasa2SiparisAl.Text = "Sipariş Al";
            this.btnMasa2SiparisAl.UseVisualStyleBackColor = false;
            this.btnMasa2SiparisAl.Click += new System.EventHandler(this.btnMasa2SiparisAl_Click);
            // 
            // btnMasa2ServisKapa
            // 
            this.btnMasa2ServisKapa.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMasa2ServisKapa.Image = ((System.Drawing.Image)(resources.GetObject("btnMasa2ServisKapa.Image")));
            this.btnMasa2ServisKapa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMasa2ServisKapa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasa2ServisKapa.Location = new System.Drawing.Point(27, 90);
            this.btnMasa2ServisKapa.Name = "btnMasa2ServisKapa";
            this.btnMasa2ServisKapa.Size = new System.Drawing.Size(117, 53);
            this.btnMasa2ServisKapa.TabIndex = 8;
            this.btnMasa2ServisKapa.Text = "Servisi Kapat";
            this.btnMasa2ServisKapa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMasa2ServisKapa.UseVisualStyleBackColor = true;
            this.btnMasa2ServisKapa.Click += new System.EventHandler(this.btnMasa2ServisKapa_Click);
            // 
            // dtMasa1Saat
            // 
            this.dtMasa1Saat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtMasa1Saat.Location = new System.Drawing.Point(150, 32);
            this.dtMasa1Saat.Name = "dtMasa1Saat";
            this.dtMasa1Saat.Size = new System.Drawing.Size(72, 20);
            this.dtMasa1Saat.TabIndex = 7;
            // 
            // dtMasa1Tarih
            // 
            this.dtMasa1Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMasa1Tarih.Location = new System.Drawing.Point(67, 32);
            this.dtMasa1Tarih.Name = "dtMasa1Tarih";
            this.dtMasa1Tarih.Size = new System.Drawing.Size(77, 20);
            this.dtMasa1Tarih.TabIndex = 6;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTarih.Location = new System.Drawing.Point(25, 32);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(36, 16);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsMasaAyrac});
            this.shapeContainer1.Size = new System.Drawing.Size(511, 160);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lsMasaAyrac
            // 
            this.lsMasaAyrac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lsMasaAyrac.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lsMasaAyrac.BorderWidth = 2;
            this.lsMasaAyrac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsMasaAyrac.Name = "lsMasaAyrac";
            this.lsMasaAyrac.X1 = 162;
            this.lsMasaAyrac.X2 = 162;
            this.lsMasaAyrac.Y1 = 75;
            this.lsMasaAyrac.Y2 = 131;
            // 
            // lblMasaSiparisAZ
            // 
            this.lblMasaSiparisAZ.AutoSize = true;
            this.lblMasaSiparisAZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMasaSiparisAZ.Location = new System.Drawing.Point(895, 329);
            this.lblMasaSiparisAZ.Name = "lblMasaSiparisAZ";
            this.lblMasaSiparisAZ.Size = new System.Drawing.Size(91, 13);
            this.lblMasaSiparisAZ.TabIndex = 20;
            this.lblMasaSiparisAZ.Text = "Miktar Artır / Azalt";
            // 
            // btnMasa2Azalt
            // 
            this.btnMasa2Azalt.Image = ((System.Drawing.Image)(resources.GetObject("btnMasa2Azalt.Image")));
            this.btnMasa2Azalt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasa2Azalt.Location = new System.Drawing.Point(1004, 320);
            this.btnMasa2Azalt.Name = "btnMasa2Azalt";
            this.btnMasa2Azalt.Size = new System.Drawing.Size(35, 30);
            this.btnMasa2Azalt.TabIndex = 19;
            this.btnMasa2Azalt.UseVisualStyleBackColor = true;
            this.btnMasa2Azalt.Click += new System.EventHandler(this.btnMasa2Azalt_Click);
            // 
            // btnMasa2Arttır
            // 
            this.btnMasa2Arttır.Image = ((System.Drawing.Image)(resources.GetObject("btnMasa2Arttır.Image")));
            this.btnMasa2Arttır.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasa2Arttır.Location = new System.Drawing.Point(837, 320);
            this.btnMasa2Arttır.Name = "btnMasa2Arttır";
            this.btnMasa2Arttır.Size = new System.Drawing.Size(38, 30);
            this.btnMasa2Arttır.TabIndex = 18;
            this.btnMasa2Arttır.UseVisualStyleBackColor = true;
            this.btnMasa2Arttır.Click += new System.EventHandler(this.btnMasa2Arttır_Click);
            // 
            // gbSiparisSepeti
            // 
            this.gbSiparisSepeti.Controls.Add(this.dgMasa6Siparis);
            this.gbSiparisSepeti.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbSiparisSepeti.Location = new System.Drawing.Point(739, 77);
            this.gbSiparisSepeti.Name = "gbSiparisSepeti";
            this.gbSiparisSepeti.Size = new System.Drawing.Size(415, 223);
            this.gbSiparisSepeti.TabIndex = 17;
            this.gbSiparisSepeti.TabStop = false;
            this.gbSiparisSepeti.Text = "Sipariş Sepeti";
            // 
            // dgMasa6Siparis
            // 
            this.dgMasa6Siparis.AllowUserToAddRows = false;
            this.dgMasa6Siparis.BackgroundColor = System.Drawing.Color.Tan;
            this.dgMasa6Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasa6Siparis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMasa6Siparis.Location = new System.Drawing.Point(6, 19);
            this.dgMasa6Siparis.Name = "dgMasa6Siparis";
            this.dgMasa6Siparis.Size = new System.Drawing.Size(403, 198);
            this.dgMasa6Siparis.TabIndex = 0;
            this.dgMasa6Siparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMasa6Siparis_CellClick);
            this.dgMasa6Siparis.DoubleClick += new System.EventHandler(this.dgMasa6Siparis_DoubleClick);
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnMasaikram);
            this.gbIslemler.Controls.Add(this.btnMasaCikar);
            this.gbIslemler.Controls.Add(this.btnMasaEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbIslemler.Location = new System.Drawing.Point(625, 77);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(108, 273);
            this.gbIslemler.TabIndex = 16;
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Text = "İşlemler";
            // 
            // btnMasaikram
            // 
            this.btnMasaikram.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaikram.Image")));
            this.btnMasaikram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasaikram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasaikram.Location = new System.Drawing.Point(17, 176);
            this.btnMasaikram.Name = "btnMasaikram";
            this.btnMasaikram.Size = new System.Drawing.Size(71, 34);
            this.btnMasaikram.TabIndex = 3;
            this.btnMasaikram.Text = "İkram";
            this.btnMasaikram.UseVisualStyleBackColor = true;
            this.btnMasaikram.Click += new System.EventHandler(this.btnMasaikram_Click);
            // 
            // btnMasaCikar
            // 
            this.btnMasaCikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMasaCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaCikar.Image")));
            this.btnMasaCikar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasaCikar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasaCikar.Location = new System.Drawing.Point(17, 105);
            this.btnMasaCikar.Name = "btnMasaCikar";
            this.btnMasaCikar.Size = new System.Drawing.Size(71, 34);
            this.btnMasaCikar.TabIndex = 2;
            this.btnMasaCikar.Text = "Çıkar";
            this.btnMasaCikar.UseVisualStyleBackColor = false;
            this.btnMasaCikar.Click += new System.EventHandler(this.btnMasaCikar_Click);
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMasaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaEkle.Image")));
            this.btnMasaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasaEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMasaEkle.Location = new System.Drawing.Point(17, 37);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(71, 34);
            this.btnMasaEkle.TabIndex = 1;
            this.btnMasaEkle.Text = "Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = false;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasaEkle_Click);
            // 
            // lblTarihUstBar
            // 
            this.lblTarihUstBar.AutoSize = true;
            this.lblTarihUstBar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTarihUstBar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTarihUstBar.ForeColor = System.Drawing.Color.White;
            this.lblTarihUstBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTarihUstBar.Location = new System.Drawing.Point(986, 9);
            this.lblTarihUstBar.Name = "lblTarihUstBar";
            this.lblTarihUstBar.Size = new System.Drawing.Size(45, 20);
            this.lblTarihUstBar.TabIndex = 24;
            this.lblTarihUstBar.Text = "Tarih";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSaat.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSaat.Location = new System.Drawing.Point(889, 9);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(39, 20);
            this.lblSaat.TabIndex = 23;
            this.lblSaat.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMasa6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 558);
            this.Controls.Add(this.lblTarihUstBar);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblMasa2TTutar);
            this.Controls.Add(this.gbSatisIslemleri);
            this.Controls.Add(this.lblMasaSiparisAZ);
            this.Controls.Add(this.btnMasa2Azalt);
            this.Controls.Add(this.btnMasa2Arttır);
            this.Controls.Add(this.gbSiparisSepeti);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.tpMasa1);
            this.Controls.Add(this.msMasa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMasa6";
            this.Text = "Sipariş Masa 6";
            this.Load += new System.EventHandler(this.frmMasa6_Load);
            this.msMasa1.ResumeLayout(false);
            this.msMasa1.PerformLayout();
            this.tpMasa1.ResumeLayout(false);
            this.Ürünler.ResumeLayout(false);
            this.Ürünler.PerformLayout();
            this.gbAltUrunAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAraUrun)).EndInit();
            this.gbAnaGrupAdı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnaUrun)).EndInit();
            this.gbSatisIslemleri.ResumeLayout(false);
            this.gbSatisIslemleri.PerformLayout();
            this.gbSiparisSepeti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasa6Siparis)).EndInit();
            this.gbIslemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMasa1;
        private System.Windows.Forms.ToolStripMenuItem tsMasa1Siparis;
        private System.Windows.Forms.TabControl tpMasa1;
        private System.Windows.Forms.TabPage Ürünler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAltUrunAdi;
        private System.Windows.Forms.DataGridView dgAraUrun;
        private System.Windows.Forms.GroupBox gbAnaGrupAdı;
        private System.Windows.Forms.DataGridView dgAnaUrun;
        private System.Windows.Forms.Label lblMasa2TTutar;
        private System.Windows.Forms.GroupBox gbSatisIslemleri;
        private System.Windows.Forms.Button btnMasa2SiparisIptal;
        private System.Windows.Forms.Button btnMasa2SiparisAl;
        private System.Windows.Forms.Button btnMasa2ServisKapa;
        private System.Windows.Forms.DateTimePicker dtMasa1Saat;
        private System.Windows.Forms.DateTimePicker dtMasa1Tarih;
        private System.Windows.Forms.Label lblTarih;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsMasaAyrac;
        private System.Windows.Forms.Label lblMasaSiparisAZ;
        private System.Windows.Forms.Button btnMasa2Azalt;
        private System.Windows.Forms.Button btnMasa2Arttır;
        private System.Windows.Forms.GroupBox gbSiparisSepeti;
        private System.Windows.Forms.DataGridView dgMasa6Siparis;
        private System.Windows.Forms.GroupBox gbIslemler;
        private System.Windows.Forms.Button btnMasaikram;
        private System.Windows.Forms.Button btnMasaCikar;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Label lblTarihUstBar;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
    }
}
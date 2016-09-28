namespace ProjeLokanta.Masalar
{
    partial class frmMasa1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasa1));
            this.tpMasa1 = new System.Windows.Forms.TabControl();
            this.Ürünler = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAltUrunAdi = new System.Windows.Forms.GroupBox();
            this.dgAraUrun = new System.Windows.Forms.DataGridView();
            this.gbAnaGrupAdı = new System.Windows.Forms.GroupBox();
            this.dgAnaUrun = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.msMasa1 = new System.Windows.Forms.MenuStrip();
            this.tsMasa1Siparis = new System.Windows.Forms.ToolStripMenuItem();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnMasaikram = new System.Windows.Forms.Button();
            this.btnMasaCikar = new System.Windows.Forms.Button();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.gbSiparisSepeti = new System.Windows.Forms.GroupBox();
            this.dgMasa1Siparis = new System.Windows.Forms.DataGridView();
            this.btnMasa1Arttır = new System.Windows.Forms.Button();
            this.btnMasa1Azalt = new System.Windows.Forms.Button();
            this.lblMasaSiparisAZ = new System.Windows.Forms.Label();
            this.gbSatisIslemleri = new System.Windows.Forms.GroupBox();
            this.btnMasa1SiparisIptal = new System.Windows.Forms.Button();
            this.btnMasa1SiparisAl = new System.Windows.Forms.Button();
            this.btnMasa1ServisKapa = new System.Windows.Forms.Button();
            this.dtMasa1Saat = new System.Windows.Forms.DateTimePicker();
            this.dtMasa1Tarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsMasaAyrac = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarihUstBar = new System.Windows.Forms.Label();
            this.lblMasa1TTutar = new System.Windows.Forms.Label();
            this.tpMasa1.SuspendLayout();
            this.Ürünler.SuspendLayout();
            this.gbAltUrunAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAraUrun)).BeginInit();
            this.gbAnaGrupAdı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnaUrun)).BeginInit();
            this.msMasa1.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            this.gbSiparisSepeti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasa1Siparis)).BeginInit();
            this.gbSatisIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMasa1
            // 
            this.tpMasa1.Controls.Add(this.Ürünler);
            resources.ApplyResources(this.tpMasa1, "tpMasa1");
            this.tpMasa1.ImageList = this.ımageList1;
            this.tpMasa1.Name = "tpMasa1";
            this.tpMasa1.SelectedIndex = 0;
            // 
            // Ürünler
            // 
            this.Ürünler.BackColor = System.Drawing.Color.Transparent;
            this.Ürünler.Controls.Add(this.label1);
            this.Ürünler.Controls.Add(this.gbAltUrunAdi);
            this.Ürünler.Controls.Add(this.gbAnaGrupAdı);
            resources.ApplyResources(this.Ürünler, "Ürünler");
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.Click += new System.EventHandler(this.Ürünler_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbAltUrunAdi
            // 
            this.gbAltUrunAdi.Controls.Add(this.dgAraUrun);
            resources.ApplyResources(this.gbAltUrunAdi, "gbAltUrunAdi");
            this.gbAltUrunAdi.Name = "gbAltUrunAdi";
            this.gbAltUrunAdi.TabStop = false;
            this.gbAltUrunAdi.Enter += new System.EventHandler(this.gbAltUrunAdi_Enter);
            // 
            // dgAraUrun
            // 
            this.dgAraUrun.AllowUserToAddRows = false;
            this.dgAraUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dgAraUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAraUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgAraUrun, "dgAraUrun");
            this.dgAraUrun.Name = "dgAraUrun";
            this.dgAraUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAraUrun_CellClick);
            this.dgAraUrun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAraUrun_CellContentClick);
            this.dgAraUrun.DoubleClick += new System.EventHandler(this.dgAraUrun_DoubleClick);
            // 
            // gbAnaGrupAdı
            // 
            this.gbAnaGrupAdı.Controls.Add(this.dgAnaUrun);
            resources.ApplyResources(this.gbAnaGrupAdı, "gbAnaGrupAdı");
            this.gbAnaGrupAdı.Name = "gbAnaGrupAdı";
            this.gbAnaGrupAdı.TabStop = false;
            // 
            // dgAnaUrun
            // 
            this.dgAnaUrun.AllowUserToAddRows = false;
            this.dgAnaUrun.BackgroundColor = System.Drawing.Color.Tan;
            this.dgAnaUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnaUrun.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgAnaUrun, "dgAnaUrun");
            this.dgAnaUrun.Name = "dgAnaUrun";
            this.dgAnaUrun.DefaultCellStyleChanged += new System.EventHandler(this.dgAnaUrun_DefaultCellStyleChanged);
            this.dgAnaUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnaUrun_CellClick);
            this.dgAnaUrun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnaUrun_CellContentClick);
            this.dgAnaUrun.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgAnaUrun_CellFormatting);
            this.dgAnaUrun.MouseHover += new System.EventHandler(this.dgAnaUrun_MouseHover);
            this.dgAnaUrun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgAnaUrun_MouseMove);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "hamburger.ico");
            // 
            // msMasa1
            // 
            resources.ApplyResources(this.msMasa1, "msMasa1");
            this.msMasa1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.msMasa1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMasa1Siparis});
            this.msMasa1.Name = "msMasa1";
            this.msMasa1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMasa1_ItemClicked);
            // 
            // tsMasa1Siparis
            // 
            this.tsMasa1Siparis.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.tsMasa1Siparis, "tsMasa1Siparis");
            this.tsMasa1Siparis.ForeColor = System.Drawing.Color.White;
            this.tsMasa1Siparis.Name = "tsMasa1Siparis";
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnMasaikram);
            this.gbIslemler.Controls.Add(this.btnMasaCikar);
            this.gbIslemler.Controls.Add(this.btnMasaEkle);
            resources.ApplyResources(this.gbIslemler, "gbIslemler");
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Enter += new System.EventHandler(this.gbIslemler_Enter);
            // 
            // btnMasaikram
            // 
            resources.ApplyResources(this.btnMasaikram, "btnMasaikram");
            this.btnMasaikram.Name = "btnMasaikram";
            this.btnMasaikram.UseVisualStyleBackColor = true;
            this.btnMasaikram.Click += new System.EventHandler(this.btnMasa1ikram_Click);
            // 
            // btnMasaCikar
            // 
            this.btnMasaCikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnMasaCikar, "btnMasaCikar");
            this.btnMasaCikar.Name = "btnMasaCikar";
            this.btnMasaCikar.UseVisualStyleBackColor = false;
            this.btnMasaCikar.Click += new System.EventHandler(this.btnMasa1Cikar_Click);
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnMasaEkle, "btnMasaEkle");
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.UseVisualStyleBackColor = false;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasa1Ekle_Click);
            // 
            // gbSiparisSepeti
            // 
            this.gbSiparisSepeti.Controls.Add(this.dgMasa1Siparis);
            resources.ApplyResources(this.gbSiparisSepeti, "gbSiparisSepeti");
            this.gbSiparisSepeti.Name = "gbSiparisSepeti";
            this.gbSiparisSepeti.TabStop = false;
            // 
            // dgMasa1Siparis
            // 
            this.dgMasa1Siparis.AllowUserToAddRows = false;
            this.dgMasa1Siparis.BackgroundColor = System.Drawing.Color.Tan;
            this.dgMasa1Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasa1Siparis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgMasa1Siparis, "dgMasa1Siparis");
            this.dgMasa1Siparis.Name = "dgMasa1Siparis";
            this.dgMasa1Siparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMasa1Siparis_CellClick);
            this.dgMasa1Siparis.DoubleClick += new System.EventHandler(this.dgMasa1Siparis_DoubleClick);
            // 
            // btnMasa1Arttır
            // 
            resources.ApplyResources(this.btnMasa1Arttır, "btnMasa1Arttır");
            this.btnMasa1Arttır.Name = "btnMasa1Arttır";
            this.btnMasa1Arttır.UseVisualStyleBackColor = true;
            this.btnMasa1Arttır.Click += new System.EventHandler(this.btnMasa1Arttır_Click);
            // 
            // btnMasa1Azalt
            // 
            resources.ApplyResources(this.btnMasa1Azalt, "btnMasa1Azalt");
            this.btnMasa1Azalt.Name = "btnMasa1Azalt";
            this.btnMasa1Azalt.UseVisualStyleBackColor = true;
            this.btnMasa1Azalt.Click += new System.EventHandler(this.btnMasa1Azalt_Click);
            // 
            // lblMasaSiparisAZ
            // 
            resources.ApplyResources(this.lblMasaSiparisAZ, "lblMasaSiparisAZ");
            this.lblMasaSiparisAZ.Name = "lblMasaSiparisAZ";
            // 
            // gbSatisIslemleri
            // 
            this.gbSatisIslemleri.Controls.Add(this.btnMasa1SiparisIptal);
            this.gbSatisIslemleri.Controls.Add(this.btnMasa1SiparisAl);
            this.gbSatisIslemleri.Controls.Add(this.btnMasa1ServisKapa);
            this.gbSatisIslemleri.Controls.Add(this.dtMasa1Saat);
            this.gbSatisIslemleri.Controls.Add(this.dtMasa1Tarih);
            this.gbSatisIslemleri.Controls.Add(this.lblTarih);
            this.gbSatisIslemleri.Controls.Add(this.shapeContainer1);
            resources.ApplyResources(this.gbSatisIslemleri, "gbSatisIslemleri");
            this.gbSatisIslemleri.Name = "gbSatisIslemleri";
            this.gbSatisIslemleri.TabStop = false;
            // 
            // btnMasa1SiparisIptal
            // 
            resources.ApplyResources(this.btnMasa1SiparisIptal, "btnMasa1SiparisIptal");
            this.btnMasa1SiparisIptal.Name = "btnMasa1SiparisIptal";
            this.btnMasa1SiparisIptal.UseVisualStyleBackColor = true;
            this.btnMasa1SiparisIptal.Click += new System.EventHandler(this.btnMasa1SiparisIptal_Click);
            // 
            // btnMasa1SiparisAl
            // 
            this.btnMasa1SiparisAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnMasa1SiparisAl, "btnMasa1SiparisAl");
            this.btnMasa1SiparisAl.Name = "btnMasa1SiparisAl";
            this.btnMasa1SiparisAl.UseVisualStyleBackColor = false;
            this.btnMasa1SiparisAl.Click += new System.EventHandler(this.btnMasa1SiparisAl_Click);
            // 
            // btnMasa1ServisKapa
            // 
            resources.ApplyResources(this.btnMasa1ServisKapa, "btnMasa1ServisKapa");
            this.btnMasa1ServisKapa.Name = "btnMasa1ServisKapa";
            this.btnMasa1ServisKapa.UseVisualStyleBackColor = true;
            this.btnMasa1ServisKapa.Click += new System.EventHandler(this.btnMasa1ServisKapa_Click);
            // 
            // dtMasa1Saat
            // 
            this.dtMasa1Saat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dtMasa1Saat, "dtMasa1Saat");
            this.dtMasa1Saat.Name = "dtMasa1Saat";
            // 
            // dtMasa1Tarih
            // 
            this.dtMasa1Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtMasa1Tarih, "dtMasa1Tarih");
            this.dtMasa1Tarih.Name = "dtMasa1Tarih";
            this.dtMasa1Tarih.ValueChanged += new System.EventHandler(this.dtMasa1Tarih_ValueChanged);
            // 
            // lblTarih
            // 
            resources.ApplyResources(this.lblTarih, "lblTarih");
            this.lblTarih.Name = "lblTarih";
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsMasaAyrac});
            this.shapeContainer1.TabStop = false;
            // 
            // lsMasaAyrac
            // 
            resources.ApplyResources(this.lsMasaAyrac, "lsMasaAyrac");
            this.lsMasaAyrac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsMasaAyrac.Name = "lsMasaAyrac";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            resources.ApplyResources(this.lblSaat, "lblSaat");
            this.lblSaat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // lblTarihUstBar
            // 
            resources.ApplyResources(this.lblTarihUstBar, "lblTarihUstBar");
            this.lblTarihUstBar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTarihUstBar.ForeColor = System.Drawing.Color.White;
            this.lblTarihUstBar.Name = "lblTarihUstBar";
            this.lblTarihUstBar.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // lblMasa1TTutar
            // 
            this.lblMasa1TTutar.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.lblMasa1TTutar, "lblMasa1TTutar");
            this.lblMasa1TTutar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMasa1TTutar.Name = "lblMasa1TTutar";
            this.lblMasa1TTutar.Click += new System.EventHandler(this.lblMasa1TTutar_Click);
            // 
            // frmMasa1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblMasa1TTutar);
            this.Controls.Add(this.lblTarihUstBar);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.gbSatisIslemleri);
            this.Controls.Add(this.lblMasaSiparisAZ);
            this.Controls.Add(this.btnMasa1Azalt);
            this.Controls.Add(this.btnMasa1Arttır);
            this.Controls.Add(this.gbSiparisSepeti);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.tpMasa1);
            this.Controls.Add(this.msMasa1);
            this.HelpButton = true;
            this.MainMenuStrip = this.msMasa1;
            this.Name = "frmMasa1";
            this.Load += new System.EventHandler(this.frmMasa1_Load);
            this.tpMasa1.ResumeLayout(false);
            this.Ürünler.ResumeLayout(false);
            this.Ürünler.PerformLayout();
            this.gbAltUrunAdi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAraUrun)).EndInit();
            this.gbAnaGrupAdı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnaUrun)).EndInit();
            this.msMasa1.ResumeLayout(false);
            this.msMasa1.PerformLayout();
            this.gbIslemler.ResumeLayout(false);
            this.gbSiparisSepeti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasa1Siparis)).EndInit();
            this.gbSatisIslemleri.ResumeLayout(false);
            this.gbSatisIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpMasa1;
        private System.Windows.Forms.TabPage Ürünler;
        private System.Windows.Forms.MenuStrip msMasa1;
        private System.Windows.Forms.ToolStripMenuItem tsMasa1Siparis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox gbAltUrunAdi;
        private System.Windows.Forms.GroupBox gbAnaGrupAdı;
        private System.Windows.Forms.DataGridView dgAraUrun;
        private System.Windows.Forms.DataGridView dgAnaUrun;
        private System.Windows.Forms.GroupBox gbIslemler;
        private System.Windows.Forms.Button btnMasaikram;
        private System.Windows.Forms.Button btnMasaCikar;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.GroupBox gbSiparisSepeti;
        private System.Windows.Forms.DataGridView dgMasa1Siparis;
        private System.Windows.Forms.Button btnMasa1Arttır;
        private System.Windows.Forms.Button btnMasa1Azalt;
        private System.Windows.Forms.Label lblMasaSiparisAZ;
        private System.Windows.Forms.GroupBox gbSatisIslemleri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.DateTimePicker dtMasa1Tarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtMasa1Saat;
        private System.Windows.Forms.Button btnMasa1ServisKapa;
        private System.Windows.Forms.Button btnMasa1SiparisIptal;
        private System.Windows.Forms.Button btnMasa1SiparisAl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsMasaAyrac;
        private System.Windows.Forms.Label lblTarihUstBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMasa1TTutar;
    }
}
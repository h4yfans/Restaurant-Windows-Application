namespace ProjeLokanta
{
    partial class frmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnUrunler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnHesapEkle = new System.Windows.Forms.ToolStripSplitButton();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnMasa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnYardim = new System.Windows.Forms.ToolStripSplitButton();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnGeri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStpBtnKapat = new System.Windows.Forms.ToolStripButton();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtGridZRaporu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcelKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRaporTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridZRaporu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tlStpBtnUrunler,
            this.toolStripSeparator5,
            this.tlStpBtnHesapEkle,
            this.toolStripSeparator4,
            this.tlStpBtnMasa,
            this.toolStripSeparator3,
            this.tlStpBtnYardim,
            this.toolStripSeparator2,
            this.tlStpBtnGeri,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator7,
            this.tlStpBtnKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = " ";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator6.Click += new System.EventHandler(this.toolStripSeparator6_Click);
            // 
            // tlStpBtnUrunler
            // 
            this.tlStpBtnUrunler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnUrunler.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnUrunler.Image")));
            this.tlStpBtnUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnUrunler.Name = "tlStpBtnUrunler";
            this.tlStpBtnUrunler.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnUrunler.Text = "Ürünler";
            this.tlStpBtnUrunler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnUrunler.Click += new System.EventHandler(this.tlStpBtnUrunler_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator5.Click += new System.EventHandler(this.toolStripSeparator5_Click);
            // 
            // tlStpBtnHesapEkle
            // 
            this.tlStpBtnHesapEkle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.yetkiliEkleToolStripMenuItem});
            this.tlStpBtnHesapEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnHesapEkle.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnHesapEkle.Image")));
            this.tlStpBtnHesapEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnHesapEkle.Name = "tlStpBtnHesapEkle";
            this.tlStpBtnHesapEkle.Size = new System.Drawing.Size(83, 83);
            this.tlStpBtnHesapEkle.Text = "Hesap Ekle";
            this.tlStpBtnHesapEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnHesapEkle.ButtonClick += new System.EventHandler(this.tlStpBtnHesapEkle_ButtonClick);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelEkleToolStripMenuItem.Image")));
            this.personelEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // yetkiliEkleToolStripMenuItem
            // 
            this.yetkiliEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yetkiliEkleToolStripMenuItem.Image")));
            this.yetkiliEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yetkiliEkleToolStripMenuItem.Name = "yetkiliEkleToolStripMenuItem";
            this.yetkiliEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.yetkiliEkleToolStripMenuItem.Text = "Yetkili Ekle";
            this.yetkiliEkleToolStripMenuItem.Click += new System.EventHandler(this.yetkiliEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator4.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // tlStpBtnMasa
            // 
            this.tlStpBtnMasa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnMasa.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnMasa.Image")));
            this.tlStpBtnMasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnMasa.Name = "tlStpBtnMasa";
            this.tlStpBtnMasa.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnMasa.Text = "Masalar";
            this.tlStpBtnMasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnMasa.Click += new System.EventHandler(this.tlStpBtnMasa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // tlStpBtnYardim
            // 
            this.tlStpBtnYardim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destekToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.tlStpBtnYardim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnYardim.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnYardim.Image")));
            this.tlStpBtnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnYardim.Name = "tlStpBtnYardim";
            this.tlStpBtnYardim.Size = new System.Drawing.Size(80, 83);
            this.tlStpBtnYardim.Text = "Yardım";
            this.tlStpBtnYardim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnYardim.ButtonClick += new System.EventHandler(this.tlStpBtnYardim_ButtonClick_1);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("destekToolStripMenuItem.Image")));
            this.destekToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.destekToolStripMenuItem.Text = "Destek";
            this.destekToolStripMenuItem.Click += new System.EventHandler(this.destekToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkımızdaToolStripMenuItem.Image")));
            this.hakkımızdaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // tlStpBtnGeri
            // 
            this.tlStpBtnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnGeri.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnGeri.Image")));
            this.tlStpBtnGeri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnGeri.Name = "tlStpBtnGeri";
            this.tlStpBtnGeri.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnGeri.Text = "Geri";
            this.tlStpBtnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnGeri.Click += new System.EventHandler(this.tlStpBtnGeri_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton2.Text = "Loglar";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton1.Text = "Z Raporu";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 86);
            this.toolStripSeparator7.Click += new System.EventHandler(this.toolStripSeparator7_Click);
            // 
            // tlStpBtnKapat
            // 
            this.tlStpBtnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tlStpBtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tlStpBtnKapat.Image")));
            this.tlStpBtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpBtnKapat.Name = "tlStpBtnKapat";
            this.tlStpBtnKapat.Size = new System.Drawing.Size(68, 83);
            this.tlStpBtnKapat.Text = "Çıkış";
            this.tlStpBtnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlStpBtnKapat.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Cornsilk;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSaat.Location = new System.Drawing.Point(845, 55);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(43, 20);
            this.lblSaat.TabIndex = 1;
            this.lblSaat.Text = "Saat";
            this.lblSaat.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtGridZRaporu
            // 
            this.dtGridZRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridZRaporu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridZRaporu.Location = new System.Drawing.Point(3, 16);
            this.dtGridZRaporu.Name = "dtGridZRaporu";
            this.dtGridZRaporu.Size = new System.Drawing.Size(685, 423);
            this.dtGridZRaporu.TabIndex = 2;
            this.dtGridZRaporu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridZRaporu_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridZRaporu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 442);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z Raporu";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kaydedilmedi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcelKaydet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(711, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel\'e Kaydet";
            this.groupBox2.Visible = false;
            // 
            // btnExcelKaydet
            // 
            this.btnExcelKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelKaydet.Image")));
            this.btnExcelKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelKaydet.Location = new System.Drawing.Point(20, 31);
            this.btnExcelKaydet.Name = "btnExcelKaydet";
            this.btnExcelKaydet.Size = new System.Drawing.Size(171, 27);
            this.btnExcelKaydet.TabIndex = 5;
            this.btnExcelKaydet.Text = "Excel olarak kaydet";
            this.btnExcelKaydet.UseVisualStyleBackColor = true;
            this.btnExcelKaydet.Click += new System.EventHandler(this.btnExcelKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRaporTemizle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMesaj);
            this.groupBox3.Controls.Add(this.txtKime);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(711, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 313);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kaydet ve Gönder";
            this.groupBox3.Visible = false;
            // 
            // btnRaporTemizle
            // 
            this.btnRaporTemizle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRaporTemizle.Location = new System.Drawing.Point(6, 284);
            this.btnRaporTemizle.Name = "btnRaporTemizle";
            this.btnRaporTemizle.Size = new System.Drawing.Size(203, 23);
            this.btnRaporTemizle.TabIndex = 9;
            this.btnRaporTemizle.Text = "Veritabanından günlük kaydı sil";
            this.btnRaporTemizle.UseVisualStyleBackColor = true;
            this.btnRaporTemizle.Click += new System.EventHandler(this.btnRaporTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Eklemek İstediğiniz mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kime :";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(15, 129);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(159, 65);
            this.txtMesaj.TabIndex = 9;
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(15, 45);
            this.txtKime.Multiline = true;
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(176, 62);
            this.txtKime.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kaydet ve Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 89);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminPanel";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridZRaporu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStpBtnUrunler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlStpBtnMasa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlStpBtnKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton tlStpBtnHesapEkle;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tlStpBtnYardim;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tlStpBtnGeri;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.DataGridView dtGridZRaporu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcelKaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKime;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRaporTemizle;
        private System.Windows.Forms.ToolStripButton toolStripButton2;



    }
}
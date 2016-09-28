namespace ProjeLokanta
{
    partial class frmRezervasyonlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyonlar));
            this.txtRezSahip = new System.Windows.Forms.TextBox();
            this.txtRezIletisim = new System.Windows.Forms.TextBox();
            this.txtRezAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtRezervasyon = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRezMasalar = new System.Windows.Forms.ComboBox();
            this.btnRezGoster = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtRezSaat = new System.Windows.Forms.TextBox();
            this.RezPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtRezervasyon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRezSahip
            // 
            this.txtRezSahip.Location = new System.Drawing.Point(170, 37);
            this.txtRezSahip.Name = "txtRezSahip";
            this.txtRezSahip.Size = new System.Drawing.Size(180, 20);
            this.txtRezSahip.TabIndex = 1;
            this.txtRezSahip.TextChanged += new System.EventHandler(this.txtRezSahip_TextChanged);
            // 
            // txtRezIletisim
            // 
            this.txtRezIletisim.Location = new System.Drawing.Point(170, 116);
            this.txtRezIletisim.Name = "txtRezIletisim";
            this.txtRezIletisim.Size = new System.Drawing.Size(180, 20);
            this.txtRezIletisim.TabIndex = 1;
            // 
            // txtRezAciklama
            // 
            this.txtRezAciklama.Location = new System.Drawing.Point(170, 151);
            this.txtRezAciklama.Multiline = true;
            this.txtRezAciklama.Name = "txtRezAciklama";
            this.txtRezAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRezAciklama.Size = new System.Drawing.Size(180, 77);
            this.txtRezAciklama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervasyon Sahibi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masa Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "İletişim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Açıklama";
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(275, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(170, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtRezervasyon
            // 
            this.dtRezervasyon.AllowUserToAddRows = false;
            this.dtRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRezervasyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtRezervasyon.Location = new System.Drawing.Point(3, 19);
            this.dtRezervasyon.Name = "dtRezervasyon";
            this.dtRezervasyon.Size = new System.Drawing.Size(778, 248);
            this.dtRezervasyon.TabIndex = 10;
            this.dtRezervasyon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRezervasyon_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton1.Text = "MASALAR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(122, 22);
            this.toolStripButton2.Text = "     REZERVASYON AL";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.White;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 22);
            this.toolStripButton3.Text = "REZERVASYONLAR";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtRezervasyon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 270);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REZERVASYONLAR";
            // 
            // cmbRezMasalar
            // 
            this.cmbRezMasalar.FormattingEnabled = true;
            this.cmbRezMasalar.Items.AddRange(new object[] {
            "MASA 1",
            "MASA 2",
            "MASA 3",
            "MASA 4",
            "MASA 5",
            "MASA 6",
            "MASA 7",
            "MASA 8",
            "MASA 9",
            "MASA 10"});
            this.cmbRezMasalar.Location = new System.Drawing.Point(170, 73);
            this.cmbRezMasalar.Name = "cmbRezMasalar";
            this.cmbRezMasalar.Size = new System.Drawing.Size(180, 21);
            this.cmbRezMasalar.TabIndex = 13;
            this.cmbRezMasalar.SelectedIndexChanged += new System.EventHandler(this.cmbRezMasalar_SelectedIndexChanged);
            // 
            // btnRezGoster
            // 
            this.btnRezGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezGoster.Location = new System.Drawing.Point(205, 263);
            this.btnRezGoster.Name = "btnRezGoster";
            this.btnRezGoster.Size = new System.Drawing.Size(101, 23);
            this.btnRezGoster.TabIndex = 14;
            this.btnRezGoster.Text = "Hepsini Göster";
            this.btnRezGoster.UseVisualStyleBackColor = true;
            this.btnRezGoster.Click += new System.EventHandler(this.btnRezGoster_Click);
            // 
            // btnAra
            // 
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.Location = new System.Drawing.Point(371, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(142, 23);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Rezervasyon Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtRezSaat
            // 
            this.txtRezSaat.Location = new System.Drawing.Point(634, 84);
            this.txtRezSaat.Name = "txtRezSaat";
            this.txtRezSaat.Size = new System.Drawing.Size(100, 20);
            this.txtRezSaat.TabIndex = 17;
            // 
            // RezPicker
            // 
            this.RezPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RezPicker.Location = new System.Drawing.Point(524, 84);
            this.RezPicker.Name = "RezPicker";
            this.RezPicker.Size = new System.Drawing.Size(87, 20);
            this.RezPicker.TabIndex = 16;
            this.RezPicker.Value = new System.DateTime(2014, 5, 25, 21, 13, 47, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rezervasyon Tarihi";
            // 
            // frmRezervasyonlar
            // 
            this.AccessibleName = "lbl";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRezSaat);
            this.Controls.Add(this.RezPicker);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnRezGoster);
            this.Controls.Add(this.cmbRezMasalar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRezAciklama);
            this.Controls.Add(this.txtRezIletisim);
            this.Controls.Add(this.txtRezSahip);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncel Rezervasyonlar";
            this.Load += new System.EventHandler(this.frmRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRezervasyon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRezSahip;
        private System.Windows.Forms.TextBox txtRezIletisim;
        private System.Windows.Forms.TextBox txtRezAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRezMasalar;
        private System.Windows.Forms.Button btnRezGoster;
        public System.Windows.Forms.DataGridView dtRezervasyon;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtRezSaat;
        private System.Windows.Forms.DateTimePicker RezPicker;
        private System.Windows.Forms.Label label4;
    }
}
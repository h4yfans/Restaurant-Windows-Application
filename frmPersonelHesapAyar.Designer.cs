namespace ProjeLokanta
{
    partial class frmPersonelHesapAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelHesapAyar));
            this.btnHesapAyarDuzenle = new System.Windows.Forms.Button();
            this.btnHesapAyarSil = new System.Windows.Forms.Button();
            this.dtGridHesapAyar = new System.Windows.Forms.DataGridView();
            this.txtHesapAyarKulad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesapAyarKulSif = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridHesapAyar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapAyarDuzenle
            // 
            this.btnHesapAyarDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapAyarDuzenle.Image")));
            this.btnHesapAyarDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAyarDuzenle.Location = new System.Drawing.Point(23, 307);
            this.btnHesapAyarDuzenle.Name = "btnHesapAyarDuzenle";
            this.btnHesapAyarDuzenle.Size = new System.Drawing.Size(166, 39);
            this.btnHesapAyarDuzenle.TabIndex = 0;
            this.btnHesapAyarDuzenle.Text = "Düzenle";
            this.btnHesapAyarDuzenle.UseVisualStyleBackColor = true;
            this.btnHesapAyarDuzenle.Click += new System.EventHandler(this.btnHesapAyarDuzenle_Click);
            // 
            // btnHesapAyarSil
            // 
            this.btnHesapAyarSil.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapAyarSil.Image")));
            this.btnHesapAyarSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAyarSil.Location = new System.Drawing.Point(210, 307);
            this.btnHesapAyarSil.Name = "btnHesapAyarSil";
            this.btnHesapAyarSil.Size = new System.Drawing.Size(182, 39);
            this.btnHesapAyarSil.TabIndex = 1;
            this.btnHesapAyarSil.Text = "Sil";
            this.btnHesapAyarSil.UseVisualStyleBackColor = true;
            this.btnHesapAyarSil.Click += new System.EventHandler(this.btnHesapAyarSil_Click);
            // 
            // dtGridHesapAyar
            // 
            this.dtGridHesapAyar.AllowDrop = true;
            this.dtGridHesapAyar.AllowUserToAddRows = false;
            this.dtGridHesapAyar.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGridHesapAyar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridHesapAyar.Location = new System.Drawing.Point(23, 59);
            this.dtGridHesapAyar.Name = "dtGridHesapAyar";
            this.dtGridHesapAyar.Size = new System.Drawing.Size(369, 229);
            this.dtGridHesapAyar.TabIndex = 2;
            this.dtGridHesapAyar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridHesapAyar_CellClick);
            this.dtGridHesapAyar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridHesapAyar_CellContentClick);
            // 
            // txtHesapAyarKulad
            // 
            this.txtHesapAyarKulad.Location = new System.Drawing.Point(23, 33);
            this.txtHesapAyarKulad.Name = "txtHesapAyarKulad";
            this.txtHesapAyarKulad.Size = new System.Drawing.Size(100, 20);
            this.txtHesapAyarKulad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // txtHesapAyarKulSif
            // 
            this.txtHesapAyarKulSif.Location = new System.Drawing.Point(145, 33);
            this.txtHesapAyarKulSif.Name = "txtHesapAyarKulSif";
            this.txtHesapAyarKulSif.Size = new System.Drawing.Size(100, 20);
            this.txtHesapAyarKulSif.TabIndex = 6;
            this.txtHesapAyarKulSif.UseSystemPasswordChar = true;
            // 
            // frmPersonelHesapAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 387);
            this.Controls.Add(this.txtHesapAyarKulSif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesapAyarKulad);
            this.Controls.Add(this.dtGridHesapAyar);
            this.Controls.Add(this.btnHesapAyarSil);
            this.Controls.Add(this.btnHesapAyarDuzenle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonelHesapAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Düzenle / Sil";
            this.Load += new System.EventHandler(this.frmPersonelHesapAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridHesapAyar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapAyarDuzenle;
        private System.Windows.Forms.Button btnHesapAyarSil;
        private System.Windows.Forms.DataGridView dtGridHesapAyar;
        private System.Windows.Forms.TextBox txtHesapAyarKulad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHesapAyarKulSif;
    }
}
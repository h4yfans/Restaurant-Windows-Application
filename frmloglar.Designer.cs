namespace ProjeLokanta
{
    partial class frmloglar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloglar));
            this.dtLoglar = new System.Windows.Forms.DataGridView();
            this.txtKullaniciyaGore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHepsiniGoster = new System.Windows.Forms.Button();
            this.txtYetkiyeGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtLoglar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLoglar
            // 
            this.dtLoglar.AllowUserToAddRows = false;
            this.dtLoglar.BackgroundColor = System.Drawing.Color.Tan;
            this.dtLoglar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLoglar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtLoglar.Location = new System.Drawing.Point(0, 110);
            this.dtLoglar.Name = "dtLoglar";
            this.dtLoglar.Size = new System.Drawing.Size(661, 347);
            this.dtLoglar.TabIndex = 0;
            // 
            // txtKullaniciyaGore
            // 
            this.txtKullaniciyaGore.Location = new System.Drawing.Point(114, 24);
            this.txtKullaniciyaGore.Name = "txtKullaniciyaGore";
            this.txtKullaniciyaGore.Size = new System.Drawing.Size(159, 20);
            this.txtKullaniciyaGore.TabIndex = 1;
            this.txtKullaniciyaGore.TextChanged += new System.EventHandler(this.txtKullaniciyaGore_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHepsiniGoster);
            this.groupBox1.Controls.Add(this.txtYetkiyeGore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKullaniciyaGore);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loglar içinde arama";
            // 
            // btnHepsiniGoster
            // 
            this.btnHepsiniGoster.Location = new System.Drawing.Point(6, 72);
            this.btnHepsiniGoster.Name = "btnHepsiniGoster";
            this.btnHepsiniGoster.Size = new System.Drawing.Size(139, 23);
            this.btnHepsiniGoster.TabIndex = 5;
            this.btnHepsiniGoster.Text = "Hepsini göster";
            this.btnHepsiniGoster.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster.Click += new System.EventHandler(this.btnHepsiniGoster_Click);
            // 
            // txtYetkiyeGore
            // 
            this.txtYetkiyeGore.Location = new System.Drawing.Point(114, 46);
            this.txtYetkiyeGore.Name = "txtYetkiyeGore";
            this.txtYetkiyeGore.Size = new System.Drawing.Size(159, 20);
            this.txtYetkiyeGore.TabIndex = 4;
            this.txtYetkiyeGore.TextChanged += new System.EventHandler(this.txtYetkiyeGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yetkiye göre ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı ismine göre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeri);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kaydet ve Temizle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(125, 19);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 25);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Logları temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(6, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 25);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Logları kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(263, 19);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 25);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // frmloglar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtLoglar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmloglar";
            this.Text = "Loglar";
            this.Load += new System.EventHandler(this.frmloglar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLoglar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLoglar;
        private System.Windows.Forms.TextBox txtKullaniciyaGore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtYetkiyeGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHepsiniGoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
    }
}
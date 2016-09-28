namespace ProjeLokanta
{
    partial class FormKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullanici));
            this.label3 = new System.Windows.Forms.Label();
            this.btnKullaniciCikis = new System.Windows.Forms.Button();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblDurumPers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Personel Giriş";
            // 
            // btnKullaniciCikis
            // 
            this.btnKullaniciCikis.Location = new System.Drawing.Point(158, 196);
            this.btnKullaniciCikis.Name = "btnKullaniciCikis";
            this.btnKullaniciCikis.Size = new System.Drawing.Size(75, 23);
            this.btnKullaniciCikis.TabIndex = 12;
            this.btnKullaniciCikis.Text = "GERİ";
            this.btnKullaniciCikis.UseVisualStyleBackColor = true;
            this.btnKullaniciCikis.Click += new System.EventHandler(this.btnKullaniciCikis_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Location = new System.Drawing.Point(44, 196);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(75, 23);
            this.btnKullaniciGiris.TabIndex = 11;
            this.btnKullaniciGiris.Text = "GİRİŞ";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            this.btnKullaniciGiris.Enter += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(133, 127);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSifre.TabIndex = 10;
            // 
            // txtKullaniciKullaniciAdi
            // 
            this.txtKullaniciKullaniciAdi.Location = new System.Drawing.Point(133, 95);
            this.txtKullaniciKullaniciAdi.Name = "txtKullaniciKullaniciAdi";
            this.txtKullaniciKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciKullaniciAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel Adı :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(283, 290);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 175;
            this.lineShape1.Y1 = 59;
            this.lineShape1.Y2 = 59;
            // 
            // lblDurumPers
            // 
            this.lblDurumPers.AutoSize = true;
            this.lblDurumPers.BackColor = System.Drawing.Color.Transparent;
            this.lblDurumPers.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDurumPers.Location = new System.Drawing.Point(44, 250);
            this.lblDurumPers.Name = "lblDurumPers";
            this.lblDurumPers.Size = new System.Drawing.Size(35, 13);
            this.lblDurumPers.TabIndex = 15;
            this.lblDurumPers.Text = "label4";
            this.lblDurumPers.Visible = false;
            // 
            // FormKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 290);
            this.Controls.Add(this.lblDurumPers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKullaniciCikis);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKullaniciCikis;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblDurumPers;
    }
}
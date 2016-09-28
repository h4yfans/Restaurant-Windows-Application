namespace ProjeLokanta
{
    partial class formAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnAdminCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblDurumAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
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
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(133, 95);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdminKullaniciAdi.TabIndex = 2;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(133, 127);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(100, 20);
            this.txtAdminSifre.TabIndex = 3;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(44, 187);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(75, 23);
            this.btnAdminGiris.TabIndex = 4;
            this.btnAdminGiris.Text = "GİRİŞ";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            this.btnAdminGiris.Enter += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnAdminCikis
            // 
            this.btnAdminCikis.Location = new System.Drawing.Point(158, 187);
            this.btnAdminCikis.Name = "btnAdminCikis";
            this.btnAdminCikis.Size = new System.Drawing.Size(75, 23);
            this.btnAdminCikis.TabIndex = 5;
            this.btnAdminCikis.Text = "GERİ";
            this.btnAdminCikis.UseVisualStyleBackColor = true;
            this.btnAdminCikis.Click += new System.EventHandler(this.btnAdminCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yönetici Giriş";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(283, 290);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 175;
            this.lineShape1.Y1 = 59;
            this.lineShape1.Y2 = 59;
            // 
            // lblDurumAdmin
            // 
            this.lblDurumAdmin.AutoSize = true;
            this.lblDurumAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblDurumAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDurumAdmin.Location = new System.Drawing.Point(32, 246);
            this.lblDurumAdmin.Name = "lblDurumAdmin";
            this.lblDurumAdmin.Size = new System.Drawing.Size(35, 13);
            this.lblDurumAdmin.TabIndex = 8;
            this.lblDurumAdmin.Text = "label4";
            this.lblDurumAdmin.Visible = false;
            // 
            // formAdmin
            // 
            this.AcceptButton = this.btnAdminGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 290);
            this.Controls.Add(this.lblDurumAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdminCikis);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formAdmin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnAdminCikis;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblDurumAdmin;
    }
}
namespace ProjeLokanta
{
    partial class FormHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHesap));
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.Image")));
            this.btnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminGiris.Location = new System.Drawing.Point(40, 52);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(201, 64);
            this.btnAdminGiris.TabIndex = 2;
            this.btnAdminGiris.Text = "Yönetici Girişi İçin TIKLAYINIZ";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGiris.Image")));
            this.btnKullaniciGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(40, 155);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(201, 64);
            this.btnKullaniciGiris.TabIndex = 3;
            this.btnKullaniciGiris.Text = "Personel Girişi için TIKLAYINIZ";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 290);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.FormHesap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnKullaniciGiris;

    }
}
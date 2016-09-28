namespace ProjeLokanta
{
    partial class frmRezOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezOnay));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezOnay = new System.Windows.Forms.TextBox();
            this.btnRezOnay = new System.Windows.Forms.Button();
            this.btnRezIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon sahibinin ismini girin";
            // 
            // txtRezOnay
            // 
            this.txtRezOnay.Location = new System.Drawing.Point(174, 21);
            this.txtRezOnay.Name = "txtRezOnay";
            this.txtRezOnay.Size = new System.Drawing.Size(100, 20);
            this.txtRezOnay.TabIndex = 1;
            // 
            // btnRezOnay
            // 
            this.btnRezOnay.Location = new System.Drawing.Point(93, 63);
            this.btnRezOnay.Name = "btnRezOnay";
            this.btnRezOnay.Size = new System.Drawing.Size(75, 23);
            this.btnRezOnay.TabIndex = 2;
            this.btnRezOnay.Text = "Gönder";
            this.btnRezOnay.UseVisualStyleBackColor = true;
            this.btnRezOnay.Click += new System.EventHandler(this.btnRezOnay_Click);
            // 
            // btnRezIptal
            // 
            this.btnRezIptal.Location = new System.Drawing.Point(174, 63);
            this.btnRezIptal.Name = "btnRezIptal";
            this.btnRezIptal.Size = new System.Drawing.Size(75, 23);
            this.btnRezIptal.TabIndex = 3;
            this.btnRezIptal.Text = "İptal";
            this.btnRezIptal.UseVisualStyleBackColor = true;
            this.btnRezIptal.Click += new System.EventHandler(this.btnRezIptal_Click);
            // 
            // frmRezOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 98);
            this.Controls.Add(this.btnRezIptal);
            this.Controls.Add(this.btnRezOnay);
            this.Controls.Add(this.txtRezOnay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Teyit Penceresi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezOnay;
        private System.Windows.Forms.Button btnRezOnay;
        private System.Windows.Forms.Button btnRezIptal;
    }
}
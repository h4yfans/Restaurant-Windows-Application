namespace ProjeLokanta
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRezSahibi = new System.Windows.Forms.TextBox();
            this.txtRezIletisim = new System.Windows.Forms.TextBox();
            this.txtRezAciklama = new System.Windows.Forms.TextBox();
            this.btnRezAl = new System.Windows.Forms.Button();
            this.btnRezIptal = new System.Windows.Forms.Button();
            this.btnRezTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMasa = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.RezPicker = new System.Windows.Forms.DateTimePicker();
            this.txtRezSaat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Rezervasyon sahibi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "* İletişim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(89, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Açıklama :";
            // 
            // txtRezSahibi
            // 
            this.txtRezSahibi.Location = new System.Drawing.Point(167, 32);
            this.txtRezSahibi.Name = "txtRezSahibi";
            this.txtRezSahibi.Size = new System.Drawing.Size(100, 20);
            this.txtRezSahibi.TabIndex = 3;
            this.txtRezSahibi.TextChanged += new System.EventHandler(this.txtRezSahibi_TextChanged);
            // 
            // txtRezIletisim
            // 
            this.txtRezIletisim.Location = new System.Drawing.Point(167, 128);
            this.txtRezIletisim.Name = "txtRezIletisim";
            this.txtRezIletisim.Size = new System.Drawing.Size(100, 20);
            this.txtRezIletisim.TabIndex = 4;
            this.txtRezIletisim.TextChanged += new System.EventHandler(this.txtRezIletisim_TextChanged);
            // 
            // txtRezAciklama
            // 
            this.txtRezAciklama.Location = new System.Drawing.Point(167, 170);
            this.txtRezAciklama.Multiline = true;
            this.txtRezAciklama.Name = "txtRezAciklama";
            this.txtRezAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRezAciklama.Size = new System.Drawing.Size(167, 83);
            this.txtRezAciklama.TabIndex = 5;
            // 
            // btnRezAl
            // 
            this.btnRezAl.Location = new System.Drawing.Point(21, 294);
            this.btnRezAl.Name = "btnRezAl";
            this.btnRezAl.Size = new System.Drawing.Size(104, 23);
            this.btnRezAl.TabIndex = 6;
            this.btnRezAl.Text = "Rezervasyon Al";
            this.btnRezAl.UseVisualStyleBackColor = true;
            this.btnRezAl.Click += new System.EventHandler(this.btnRezAl_Click);
            // 
            // btnRezIptal
            // 
            this.btnRezIptal.Location = new System.Drawing.Point(270, 294);
            this.btnRezIptal.Name = "btnRezIptal";
            this.btnRezIptal.Size = new System.Drawing.Size(75, 23);
            this.btnRezIptal.TabIndex = 7;
            this.btnRezIptal.Text = "İptal";
            this.btnRezIptal.UseVisualStyleBackColor = true;
            this.btnRezIptal.Click += new System.EventHandler(this.btnRezIptal_Click);
            // 
            // btnRezTemizle
            // 
            this.btnRezTemizle.Location = new System.Drawing.Point(157, 294);
            this.btnRezTemizle.Name = "btnRezTemizle";
            this.btnRezTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnRezTemizle.TabIndex = 8;
            this.btnRezTemizle.Text = "Temizle";
            this.btnRezTemizle.UseVisualStyleBackColor = true;
            this.btnRezTemizle.Click += new System.EventHandler(this.btnRezTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "* Rezerve edilecek Masa :";
            // 
            // cmbMasa
            // 
            this.cmbMasa.FormattingEnabled = true;
            this.cmbMasa.Items.AddRange(new object[] {
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
            this.cmbMasa.Location = new System.Drawing.Point(167, 79);
            this.cmbMasa.Name = "cmbMasa";
            this.cmbMasa.Size = new System.Drawing.Size(121, 21);
            this.cmbMasa.TabIndex = 10;
            this.cmbMasa.SelectedIndexChanged += new System.EventHandler(this.cmbMasa_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(41, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "( * ) Doldurulması zorunlu alanlar";
            // 
            // RezPicker
            // 
            this.RezPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RezPicker.Location = new System.Drawing.Point(436, 32);
            this.RezPicker.Name = "RezPicker";
            this.RezPicker.Size = new System.Drawing.Size(87, 20);
            this.RezPicker.TabIndex = 12;
            this.RezPicker.Value = new System.DateTime(2014, 5, 27, 0, 0, 0, 0);
            this.RezPicker.ValueChanged += new System.EventHandler(this.RezPicker_ValueChanged);
            // 
            // txtRezSaat
            // 
            this.txtRezSaat.Location = new System.Drawing.Point(436, 58);
            this.txtRezSaat.Name = "txtRezSaat";
            this.txtRezSaat.Size = new System.Drawing.Size(67, 20);
            this.txtRezSaat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(296, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "* Rezervasyon Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(297, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "* Rezervasyon Saati :";
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 379);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRezSaat);
            this.Controls.Add(this.RezPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRezTemizle);
            this.Controls.Add(this.btnRezIptal);
            this.Controls.Add(this.btnRezAl);
            this.Controls.Add(this.txtRezAciklama);
            this.Controls.Add(this.txtRezIletisim);
            this.Controls.Add(this.txtRezSahibi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRezervasyon";
            this.Text = "Rezervasyon Kaydı";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRezSahibi;
        private System.Windows.Forms.TextBox txtRezIletisim;
        private System.Windows.Forms.TextBox txtRezAciklama;
        private System.Windows.Forms.Button btnRezAl;
        private System.Windows.Forms.Button btnRezIptal;
        private System.Windows.Forms.Button btnRezTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMasa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker RezPicker;
        private System.Windows.Forms.TextBox txtRezSaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
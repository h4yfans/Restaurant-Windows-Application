using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjeLokanta
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
        FormMasa frmmasa = new FormMasa();
        private void btnRezAl_Click(object sender, EventArgs e)
        {
            if( RezPicker.Value < DateTime.Now.Date )
              {
                  MessageBox.Show("Rezervasyon tarihi bugünden önce olamaz.");
             }
             else
            {
            
            
            if (txtRezSahibi.Text=="")
            {
                errorProvider1.SetError(txtRezSahibi, "Rezervasyon Sahibinin ismini girin");
            }
            else if (cmbMasa.SelectedIndex==-1)
            {
                errorProvider1.SetError(cmbMasa, "Rezervasyon edilecek masayı seçin");
            }
            else if (txtRezIletisim.Text=="")
            {
                errorProvider1.SetError(txtRezIletisim, "İletişim adresini girin");
            }
            else if (Ortak.rezervasyontarihdenetle!="degisti")
            {
                errorProvider1.SetError(RezPicker, "Rezervasyon bilgilerini belirleyin");
            }
            else if (txtRezSaat.Text=="")
            {
                errorProvider1.SetError(txtRezSaat, "Rezervasyon bilgilerini belirleyin");
            }
                
      
            else
            {
                string renkogren = "";
                string masanumarasi = cmbMasa.SelectedItem.ToString();
                
                SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + masanumarasi + "'", bag);
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                renkogren = cmd.ExecuteScalar().ToString();
                if (renkogren == "yesil")
                {
                    SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='sari' WHERE ButonAdi='" + masanumarasi + "'", bag);
                    komut.ExecuteNonQuery();
                    SqlCommand komut2 = new SqlCommand("INSERT INTO rezervasyon(Rezervasyon_Sahibi,Masa_Numarasi,Iletisim,Rezervasyon_Tarihi,Aciklama) VALUES('" + txtRezSahibi.Text + "','" + masanumarasi + "','" + txtRezIletisim.Text + "','" + RezPicker.Value.ToShortDateString()+" "+txtRezSaat.Text + "','" + txtRezAciklama.Text + "')", bag);
                    komut2.ExecuteNonQuery();
                    bag.Close();
                    errorProvider1.Clear();
                    MessageBox.Show("Rezervasyon alındı.");
                    if (Ortak.admingirisi == "admin")
                    {
                        frmmasa.btnMasaGeri.Visible = true;
                    }
                    this.Close();
                    frmmasa.butonrenkdenetle();
                    frmmasa.Show();
                    Ortak.rezervasyontarihdenetle = "";



                }
                else if (renkogren == "kirmizi")
                {
                    MessageBox.Show("Seçtiğiniz Masa dolu, Lütfen başka bir masa seçin");
                }
                else if (renkogren == "sari")
                {
                    MessageBox.Show("Seçtiğiniz masa zaten rezerve edilmiş, Lütfen başka masa seçin.");
                }
                
            }
        }
            
            
            
            
        }

        private void txtRezSahibi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cmbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtRezIletisim_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnRezTemizle_Click(object sender, EventArgs e)
        {
            txtRezAciklama.Text = "";
            txtRezIletisim.Text = "";
            txtRezSahibi.Text = "";
            cmbMasa.SelectedIndex = -1;
        }

        private void btnRezIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Threading.Thread.Sleep(1000);
            frmmasa.butonrenkdenetle();
            frmmasa.Show();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }
        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            
            
        }

        private void RezPicker_ValueChanged(object sender, EventArgs e)
        {
            Ortak.rezervasyontarihdenetle = "degisti";
                errorProvider1.Clear();
           
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjeLokanta
{
    public partial class frmRezervasyonlar : Form
    {
        public frmRezervasyonlar()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (RezPicker.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Rezervasyon tarihi bugünden önce olamaz.");
            }
            else
            {
                string renkogren = "";
                string kontroldegiskeni = "";
                SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + cmbRezMasalar.SelectedItem.ToString() + "'", bag);
                bag.Open();
                renkogren = cmd.ExecuteScalar().ToString();
                bag.Close();
                if (Ortak.masarenkdenetle == cmbRezMasalar.SelectedItem.ToString())
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("UPDATE rezervasyon SET Rezervasyon_Sahibi='" + txtRezSahip.Text + "',Masa_Numarasi='" + cmbRezMasalar.SelectedItem.ToString() + "',Iletisim='" + txtRezIletisim.Text + "',Rezervasyon_Tarihi='" + RezPicker.Value.ToShortDateString() + " " + txtRezSaat.Text + "',Aciklama='" + txtRezAciklama.Text + "' WHERE id='" + dtRezervasyon.CurrentRow.Cells[5].Value.ToString() + "'", bag);
                    SqlCommand komut2 = new SqlCommand("UPDATE butonrenk SET ButonRengi='sari' WHERE ButonAdi='" + cmbRezMasalar.SelectedItem.ToString() + "'", bag);
                    SqlCommand komut4 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + Ortak.rezmasadurumu + "'", bag);
                    komut4.ExecuteNonQuery();

                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Kayıt Güncellenmiştir");
                    listele();
                    txtRezAciklama.Text = "";
                    txtRezIletisim.Text = "";
                    cmbRezMasalar.SelectedIndex = -1;
                    txtRezSahip.Text = "";
                    txtRezSaat.Text = "";
                    FormMasa frmmasa = new FormMasa();
                    frmmasa.butonrenkdenetle();
                    kontroldegiskeni = "true";

                }
                if (renkogren == "yesil")
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("UPDATE rezervasyon SET Rezervasyon_Sahibi='" + txtRezSahip.Text + "',Masa_Numarasi='" + cmbRezMasalar.SelectedItem.ToString() + "',Iletisim='" + txtRezIletisim.Text + "',Rezervasyon_Tarihi='" + RezPicker.Value.ToShortDateString() + " " + txtRezSaat.Text + "',Aciklama='" + txtRezAciklama.Text + "' WHERE id='" + dtRezervasyon.CurrentRow.Cells[5].Value.ToString() + "'", bag);
                    SqlCommand komut2 = new SqlCommand("UPDATE butonrenk SET ButonRengi='sari' WHERE ButonAdi='" + cmbRezMasalar.SelectedItem.ToString() + "'", bag);
                    SqlCommand komut4 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + Ortak.rezmasadurumu + "'", bag);
                    komut4.ExecuteNonQuery();

                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Kayıt Güncellenmiştir");
                    listele();
                    txtRezAciklama.Text = "";
                    txtRezIletisim.Text = "";
                    cmbRezMasalar.SelectedIndex = -1;
                    txtRezSahip.Text = "";
                    txtRezSaat.Text = "";
                    FormMasa frmmasa = new FormMasa();
                    frmmasa.butonrenkdenetle();
                }
                else if (renkogren == "kirmizi")
                {
                    if (kontroldegiskeni != "true")
                    {
                        MessageBox.Show("Seçtiğiniz Masa dolu, Lütfen başka bir masa seçin");
                    }
                }
                else if (renkogren == "sari")
                {
                    if (kontroldegiskeni != "true")
                    {
                        MessageBox.Show("Seçtiğiniz masa zaten rezerve edilmiş, Lütfen başka masa seçin.");
                    }
                }
            }
        }

        private void frmRezervasyonlar_Load(object sender, EventArgs e)
        {
            listele();
            dtRezervasyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        void listele() {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM rezervasyon", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtRezervasyon.DataSource = tablo;
            bag.Close();
            dtRezervasyon.Columns[5].Visible = false;
            dtRezervasyon.Columns[0].Width = 125;
            dtRezervasyon.Columns[1].Width = 100;
            dtRezervasyon.Columns[2].Width = 100;
            dtRezervasyon.Columns[3].Width = 125;
            dtRezervasyon.Columns[4].Width = 284;
            dtRezervasyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int ColumnsIndex0 = 0;
            this.dtRezervasyon.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Orange;
            int ColumnsIndex1 = 1;
            this.dtRezervasyon.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.Gray;
            int ColumnsIndex2 = 2;
            this.dtRezervasyon.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            int ColumnsIndex3 = 3;
            this.dtRezervasyon.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.Beige;
            int ColumnsIndex4 = 4;
            this.dtRezervasyon.Columns[ColumnsIndex4].DefaultCellStyle.BackColor = Color.WhiteSmoke;
        
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRezervasyon frmrez = new frmRezervasyon();
            frmrez.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRezervasyonlar frmrez = new frmRezervasyonlar();
            frmrez.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMasa frmmasa = new FormMasa();
            frmmasa.Show();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }

        }

        private void txtRezSahip_TextChanged(object sender, EventArgs e)
        {
            /*DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM rezervasyon WHERE Rezervasyon_Sahibi LIKE'" + txtRezSahip.Text + "%'", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtRezervasyon.DataSource = tablo;
            bag.Close();*/
        }

        private void cmbRezMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            
            
        }

        private void btnRezGoster_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dtRezervasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRezSahip.Text = dtRezervasyon.CurrentRow.Cells[0].Value.ToString();
            cmbRezMasalar.SelectedItem = dtRezervasyon.CurrentRow.Cells[1].Value.ToString();
            txtRezIletisim.Text = dtRezervasyon.CurrentRow.Cells[2].Value.ToString();
            string tarih = dtRezervasyon.CurrentRow.Cells[3].Value.ToString();
            txtRezAciklama.Text = dtRezervasyon.CurrentRow.Cells[4].Value.ToString();
            Ortak.rezmasadurumu = dtRezervasyon.CurrentRow.Cells[1].Value.ToString();
            Ortak.masarenkdenetle = cmbRezMasalar.SelectedItem.ToString();
            string saat = tarih;
            tarih.Substring(0,9);
            RezPicker.Value = Convert.ToDateTime(tarih);
            txtRezSaat.Text = saat.Substring(10);
            
        }

      

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtRezervasyon.CurrentCell != null)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM rezervasyon WHERE id='" + dtRezervasyon.CurrentRow.Cells[5].Value.ToString() + "'", bag);
                SqlCommand komut2 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + dtRezervasyon.CurrentRow.Cells[1].Value.ToString() + "'", bag);
                bag.Open();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("REZERVASYON SİLİNDİ");
                listele();
                txtRezSahip.Text = "";
                txtRezSaat.Text = "";
                txtRezIletisim.Text = "";
                txtRezAciklama.Text = "";
                cmbRezMasalar.SelectedIndex = -1;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM rezervasyon WHERE Rezervasyon_Sahibi LIKE'" + txtRezSahip.Text + "%'", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtRezervasyon.DataSource = tablo;
            bag.Close();
            txtRezSahip.Clear();
        }
        
    }
}

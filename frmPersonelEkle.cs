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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");


        
        


        
        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            temizle();
            listele();
            dtGritPersonelEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int ColumnsIndex0 = 0;
            this.dtGritPersonelEkle.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Orange;

            int ColumnsIndex1 = 1;
            this.dtGritPersonelEkle.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.Orange;
            int ColumnsIndex3 = 3;
            this.dtGritPersonelEkle.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.MistyRose;
            int ColumnsIndex4 = 4;
            this.dtGritPersonelEkle.Columns[ColumnsIndex4].DefaultCellStyle.BackColor = Color.LightSlateGray;
            int ColumnsIndex5 = 5;
            this.dtGritPersonelEkle.Columns[ColumnsIndex5].DefaultCellStyle.BackColor = Color.Bisque;
            int ColumnsIndex2 = 2;
            this.dtGritPersonelEkle.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.AntiqueWhite;


          
        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();
            dtGritPersonelEkle.RowHeadersWidth = 14;
            dtGritPersonelEkle.Columns[5].Width = 134;
            dtGritPersonelEkle.Columns[6].Visible = false;
        }
        void truela()
        {
            txtPersonelAd.Enabled = true;
            txtPersonelAdres.Enabled = true;
            txtPersonelCepNo.Enabled = true;
            txtPersonelEvno.Enabled = true;
            txtPersonelSoyad.Enabled = true;
            cmbPersonelMeslek.Enabled = true;
        
        }
        private void tlStpBtnYeniKayit_Click(object sender, EventArgs e)
        {
            txtPersonelAd.Enabled = true;
            txtPersonelSoyad.Enabled = true;
            txtPersonelEvno.Enabled = true;
            txtPersonelCepNo.Enabled = true;
            cmbPersonelMeslek.Enabled = true;
            txtPersonelAdres.Enabled = true;
            txtPersonelKullaniciAd.Enabled = true;
            txtPersonelSifre.Enabled = true;
            txtPersonelSifreTekrar.Enabled = true;
            btnGuncelle.Visible = false;
            btnPersonelKaydet.Visible = true;
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtPersonelEvno.Clear();
            txtPersonelCepNo.Clear();
            cmbPersonelMeslek.SelectedIndex = -1;
            txtPersonelAdres.Clear();
            txtPersonelKullaniciAd.Clear();
            txtPersonelSifre.Clear();
            txtPersonelSifreTekrar.Clear();


            truela();
        }
        void temizle()
        {
            txtPersonelAd.Enabled = false;
            txtPersonelAdres.Enabled = false;
            txtPersonelCepNo.Enabled = false;
            txtPersonelEvno.Enabled = false;
            txtPersonelSoyad.Enabled = false;
            cmbPersonelMeslek.Enabled = false;
        }

        private void tlStpBtnDuzenle_Click(object sender, EventArgs e)
        {
            txtPersonelAd.Enabled = true;
            txtPersonelSoyad.Enabled = true;
            txtPersonelEvno.Enabled = true;
            txtPersonelCepNo.Enabled = true;
            cmbPersonelMeslek.Enabled = true;
            txtPersonelAdres.Enabled = true;
            txtPersonelKullaniciAd.Enabled = false;
            txtPersonelSifre.Enabled = false;
            txtPersonelSifreTekrar.Enabled = false;
            btnGuncelle.Visible = true;
            btnPersonelKaydet.Visible = false;
            txtPersonelKullaniciAd.Clear();
            txtPersonelSifre.Clear();
            txtPersonelSifreTekrar.Clear();
           
        }

        private void btnPersonelIptal_Click(object sender, EventArgs e)
        {
            txtPersonelAd.Text = "";
            txtPersonelAdres.Text = "";
            txtPersonelCepNo.Text = "";
            txtPersonelEvno.Text = "";
            txtPersonelSoyad.Text = "";
            cmbPersonelMeslek.Text = "";
            txtPersonelKullaniciAd.Text = "";
            txtPersonelSifre.Text = "";
            txtPersonelSifreTekrar.Text = "";
            txtPersonelAd.Enabled = false;
            txtPersonelAdres.Enabled = false;
            txtPersonelCepNo.Enabled = false;
            txtPersonelEvno.Enabled = false;
            txtPersonelSoyad.Enabled = false;
            cmbPersonelMeslek.Enabled = false;
            txtPersonelKullaniciAd.Enabled = false;
            txtPersonelSifre.Enabled = false;
            txtPersonelSifreTekrar.Enabled = false;
        }
        

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {


            try
            {

                DataSet ds = new DataSet();
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                    }
                if (txtPersonelAd.Text=="")
                {
                    errorProvider1.SetError(txtPersonelAd, "Personel ismini girin");
                }
                else if (txtPersonelSoyad.Text=="")
                {
                    errorProvider1.SetError(txtPersonelSoyad, "Personel soyadını girin");
                }
                else if (txtPersonelEvno.Text=="")
                {
                    errorProvider1.SetError(txtPersonelEvno, "Personelin Ev numarasını girin");
                }
                else if (txtPersonelCepNo.Text=="")
                {
                    errorProvider1.SetError(txtPersonelCepNo, "Personel Cep telefonunu yazın");
                }
                else if (cmbPersonelMeslek.SelectedIndex==-1)
                {
                    errorProvider1.SetError(cmbPersonelMeslek, "Personel mesleğini seçin");
                }
                else if (txtPersonelAdres.Text=="")
                {
                    errorProvider1.SetError(txtPersonelAdres, "Personelin adresini yazın");
                }
                else if (txtPersonelKullaniciAd.Text=="")
	            {
		             errorProvider1.SetError(txtPersonelKullaniciAd,"Personelin kullanacığı kullanıcı adını girin");
	            }
                else if (txtPersonelSifre.Text=="")
	{
		 errorProvider1.SetError(txtPersonelSifre,"Personelin şifresini belirleyin");
	}
                else if (txtPersonelSifreTekrar.Text=="")
	{
		 errorProvider1.SetError(txtPersonelSifreTekrar,"Personel şifresini teyit edin");
	}
                else if (txtPersonelSifre.Text!=txtPersonelSifreTekrar.Text)
	{
		            errorProvider1.SetError(txtPersonelSifre,"Şifreler uyuşmadı");
                    errorProvider2.SetError(txtPersonelSifreTekrar,"Şifreler uyuşmadı");
	}
                else
	{
        

            errorProvider1.Clear();
            errorProvider2.Clear();
            ds.Clear();
            SqlCommand komut = new SqlCommand("INSERT INTO PersonelKaydi2(ad,soyad,EvNo,CepNo,Meslek,Adres) VALUES('" + txtPersonelAd.Text + "','" + txtPersonelSoyad.Text + "','" + txtPersonelEvno.Text + "','" + txtPersonelCepNo.Text + "','" + cmbPersonelMeslek.SelectedItem.ToString() + "','" + txtPersonelAdres.Text + "')", bag);
            SqlCommand komut2 = new SqlCommand("INSERT INTO kullanici(personeladi,sifre) VALUES('" + txtPersonelKullaniciAd.Text + "','" + txtPersonelSifre.Text + "')", bag);
            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();
            MessageBox.Show("Kayıt Başarıyla Yapılmıştır");
        
        
        
        

        
        
        }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                bag.Close();
            }
        }

        private void tlStpBtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM PersonelKaydi2 WHERE id='" + dtGritPersonelEkle.CurrentRow.Cells[6].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı");
            listele();
        }

        private void dtGritPersonelEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            truela();
            dtGritPersonelEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGritPersonelEkle.CurrentCell.Style.SelectionBackColor = Color.Purple;
            txtPersonelAd.Text = dtGritPersonelEkle.CurrentRow.Cells[0].Value.ToString();
            txtPersonelSoyad.Text = dtGritPersonelEkle.CurrentRow.Cells[1].Value.ToString();
            txtPersonelEvno.Text = dtGritPersonelEkle.CurrentRow.Cells[2].Value.ToString();
            txtPersonelCepNo.Text = dtGritPersonelEkle.CurrentRow.Cells[3].Value.ToString();
            cmbPersonelMeslek.Text = dtGritPersonelEkle.CurrentRow.Cells[4].Value.ToString();
            txtPersonelAdres.Text = dtGritPersonelEkle.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtPersonelArama_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE ad LIKE'"+txtPersonelArama.Text+"%'", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();
        }

        private void btnPersonelHesapAyarlari_Click(object sender, EventArgs e)
        {
            frmPersonelHesapAyar frmhspayar = new frmPersonelHesapAyar();
            frmhspayar.Show();
        }

        private void tlStpBtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Program kapatılsın mı?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void radioAZsırala_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 ORDER BY ad", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();

        }

        private void radioZAsırala_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 ORDER BY ad desc", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();
        }

        private void cmbGrpBoxSıralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrpBoxSıralama.SelectedIndex==0)
            {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE Meslek='Garson'", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();
            
            }
            else if (cmbGrpBoxSıralama.SelectedIndex == 1)
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE Meslek='Kasiyer'", bag);
                bag.Open();
                adptr.Fill(tablo);
                dtGritPersonelEkle.DataSource = tablo;
                bag.Close();
            }
            else if (cmbGrpBoxSıralama.SelectedIndex==2)
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE Meslek='Şef'", bag);
                bag.Open();
                adptr.Fill(tablo);
                dtGritPersonelEkle.DataSource = tablo;
                bag.Close();
            }
            else if (cmbGrpBoxSıralama.SelectedIndex==3)
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE Meslek='Aşçı'", bag);
                bag.Open();
                adptr.Fill(tablo);
                dtGritPersonelEkle.DataSource = tablo;
                bag.Close();
            }
            else if (cmbGrpBoxSıralama.SelectedIndex==4)
            {
                DataTable tablo = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 WHERE Meslek='Bulaşıkçı'", bag);
                bag.Open();
                adptr.Fill(tablo);
                dtGritPersonelEkle.DataSource = tablo;
                bag.Close();
            }
        }

       

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPersonelMeslek_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void tlStpBtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminPanel frmadmin = new frmAdminPanel();
            frmadmin.Show();
        
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dtGritPersonelEkle.CurrentCell != null)
            {
                if (txtPersonelAd.Text=="")
                {
                    errorProvider1.SetError(txtPersonelAd, "Personel ismini girin");
                }
                else if (txtPersonelSoyad.Text=="")
                {
                    errorProvider1.SetError(txtPersonelSoyad, "Personel soyadını girin");
                }
                else if (txtPersonelEvno.Text=="")
                {
                    errorProvider1.SetError(txtPersonelEvno, "Personelin Ev numarasını girin");
                }
                else if (txtPersonelCepNo.Text=="")
                {
                    errorProvider1.SetError(txtPersonelCepNo, "Personel Cep telefonunu yazın");
                }
                else if (cmbPersonelMeslek.SelectedItem.ToString()=="")
                {
                    errorProvider1.SetError(cmbPersonelMeslek, "Personel mesleğini seçin");
                }
                else if (txtPersonelAdres.Text=="")
                {
                    errorProvider1.SetError(txtPersonelAdres, "Personelin adresini yazın");
                }
                
                else
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    SqlCommand komut = new SqlCommand("UPDATE PersonelKaydi2 SET ad='" + txtPersonelAd.Text + "',soyad='" + txtPersonelSoyad.Text + "',EvNo='" + txtPersonelEvno.Text + "',CepNo='" + txtPersonelCepNo.Text + "',Meslek='" + cmbPersonelMeslek.SelectedItem.ToString() + "',Adres='" + txtPersonelAdres.Text + "' WHERE id='" + dtGritPersonelEkle.CurrentRow.Cells[6].Value.ToString() + "'", bag);
                    bag.Open();
                    komut.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Kayıt Güncellenmiştir");
                    listele();
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için Personel seçiniz.");
            }
            
        }

        private void txtPersonelAd_TextChanged(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text!="")
            {
                errorProvider1.Clear();
            }
        }

        private void txtPersonelSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtPersonelSoyad.Text!="")
            {
                errorProvider1.Clear();
            }
        }

        private void txtPersonelEvno_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPersonelCepNo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPersonelAdres_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPersonelKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPersonelSifre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPersonelSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void BtnHepsiniGoster_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM PersonelKaydi2 ", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGritPersonelEkle.DataSource = tablo;
            bag.Close();
        }

        

        

       

       

       

       

      
    }
}

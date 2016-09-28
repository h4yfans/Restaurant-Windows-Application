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
    public partial class frmyetkiliekle : Form
    {
        public frmyetkiliekle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");

       
        void truela()
        {
            txtYetkiliAd.Enabled = true;
            txtYetkiliAdres.Enabled = true;
            txtYetkiliCepNo.Enabled = true;
            txtYetkiliEvno.Enabled = true;
            txtYetkiliSoyad.Enabled = true;
            txtYetkiliKullaniciAd.Enabled = true;
            txtYetkiliSifre.Enabled = true;
            txtYetkiliSifreTekrar.Enabled = true;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            truela();
            btnYetkiliKaydet.Enabled = true;
            btnGuncelle.Visible = false;
            btnYetkiliKaydet.Visible = true;
            txtYetkiliAd.Clear();
            txtYetkiliSoyad.Clear();
            txtYetkiliEvno.Clear();
            txtYetkiliCepNo.Clear();
            txtYetkiliAdres.Clear();
            txtYetkiliKullaniciAd.Clear();
            txtYetkiliSifre.Clear();
            txtYetkiliSifreTekrar.Clear();
            
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            truela();
            btnYetkiliKaydet.Visible = false;
            btnGuncelle.Visible = true;
            txtYetkiliKullaniciAd.Enabled = false;
            txtYetkiliSifre.Enabled = false;
            txtYetkiliSifreTekrar.Enabled = false;
            txtYetkiliKullaniciAd.Clear();
            txtYetkiliSifre.Clear();
            txtYetkiliSifreTekrar.Clear();
            
            
        }

        private void btnYetkiliIptal_Click(object sender, EventArgs e)
        {
            txtYetkiliAd.Text = "";
            txtYetkiliAdres.Text = "";
            txtYetkiliCepNo.Text = "";
            txtYetkiliEvno.Text = "";
            txtYetkiliSoyad.Text = "";
            txtYetkiliKullaniciAd.Text = "";
            txtYetkiliSifre.Text = "";
            txtYetkiliSifreTekrar.Text = "";
            txtYetkiliAd.Enabled = false;
            txtYetkiliAdres.Enabled = false;
            txtYetkiliCepNo.Enabled = false;
            txtYetkiliEvno.Enabled = false;
            txtYetkiliSoyad.Enabled = false;
            txtYetkiliKullaniciAd.Enabled = false;
            txtYetkiliSifre.Enabled = false;
            txtYetkiliSifreTekrar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnYetkiliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYetkiliAd.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliAd, "Yetkili ismini girin");
                }
                else if (txtYetkiliSoyad.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliSoyad, "Yetkili soyadını girin");
                }
                else if (txtYetkiliEvno.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliEvno, "Yetkiliin Ev numarasını girin");
                }
                else if (txtYetkiliCepNo.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliCepNo, "Yetkili Cep telefonunu yazın");
                }
                
                else if (txtYetkiliAdres.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliAdres, "Yetkiliin adresini yazın");
                }
                else if (txtYetkiliKullaniciAd.Text=="")
	            {
		             errorProvider1.SetError(txtYetkiliKullaniciAd,"Yetkiliin kullanacığı kullanıcı adını girin");
	            }
                else if (txtYetkiliSifre.Text=="")
	{
		 errorProvider1.SetError(txtYetkiliSifre,"Yetkiliin şifresini belirleyin");
	}
                else if (txtYetkiliSifreTekrar.Text=="")
	{
		 errorProvider1.SetError(txtYetkiliSifreTekrar,"Yetkili şifresini teyit edin");
	}
                else if (txtYetkiliSifre.Text != txtYetkiliSifreTekrar.Text)
                {
                    errorProvider1.SetError(txtYetkiliSifre, "Şifreler uyuşmadı");
                    errorProvider2.SetError(txtYetkiliSifreTekrar, "Şifreler uyuşmadı");
                }
                else
                {
                    
                    DataSet ds = new DataSet();
                    if (bag.State == ConnectionState.Closed)
                    {
                        bag.Open();
                        }
                        ds.Clear();
                        SqlCommand komut = new SqlCommand("INSERT INTO YetkiliKaydi(ad,soyad,ev_no,cep_no,Adres) VALUES('" + txtYetkiliAd.Text + "','" + txtYetkiliSoyad.Text + "','" + txtYetkiliEvno.Text + "','" + txtYetkiliCepNo.Text + "','" + txtYetkiliAdres.Text + "')", bag);

                        SqlCommand komut2 = new SqlCommand("INSERT INTO yetkili(yetkiliadi,sifre) VALUES('" + txtYetkiliKullaniciAd.Text + "','" + txtYetkiliSifre.Text + "')", bag);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmyetkiliekle_Load(object sender, EventArgs e)
        {
            temizle();
            listele();
           dtGridYetkili.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      
        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM YetkiliKaydi", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridYetkili.DataSource = tablo;
            bag.Close();
            int ColumnsIndex1 = 1;
            this.dtGridYetkili.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.Orange;
            int ColumnsIndex3 = 3;
            this.dtGridYetkili.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.MistyRose;
            int ColumnsIndex4 = 4;
            this.dtGridYetkili.Columns[ColumnsIndex4].DefaultCellStyle.BackColor = Color.LightSlateGray;
            int ColumnsIndex0 = 0;
            this.dtGridYetkili.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Bisque;
            int ColumnsIndex2 = 2;
            this.dtGridYetkili.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            dtGridYetkili.Columns[4].Width = 175;
            dtGridYetkili.Columns[5].Visible = false;
        }
        void temizle()
        {
            txtYetkiliAd.Enabled = false;
            txtYetkiliAdres.Enabled = false;
            txtYetkiliCepNo.Enabled = false;
            txtYetkiliEvno.Enabled = false;
            txtYetkiliSoyad.Enabled = false;
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM YetkiliKaydi WHERE id='" + dtGridYetkili.CurrentRow.Cells[5].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı");
            listele();
        }

        private void txtYetkiliArama_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM YetkiliKaydi WHERE ad LIKE'" + txtYetkiliArama.Text + "%'", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridYetkili.DataSource = tablo;
            bag.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridYetkili_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            truela();
            txtYetkiliAd.Text = dtGridYetkili.CurrentRow.Cells[0].Value.ToString();
            txtYetkiliSoyad.Text = dtGridYetkili.CurrentRow.Cells[1].Value.ToString();
            txtYetkiliEvno.Text = dtGridYetkili.CurrentRow.Cells[2].Value.ToString();
            txtYetkiliCepNo.Text = dtGridYetkili.CurrentRow.Cells[3].Value.ToString();
            txtYetkiliAdres.Text = dtGridYetkili.CurrentRow.Cells[4].Value.ToString();
        }

        private void radioAZsırala_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM YetkiliKaydi ORDER BY ad", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridYetkili.DataSource = tablo;
            bag.Close();
        }

        private void btnYetkiliAyar_Click(object sender, EventArgs e)
        {
            frmYetkiliHesapAyar frmyetkili = new frmYetkiliHesapAyar();
            frmyetkili.Show();
        }

        private void radioZAsırala_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM YetkiliKaydi ORDER BY ad desc", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridYetkili.DataSource = tablo;
            bag.Close();
        }

       

        private void dtGridYetkili_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminPanel frmadmin = new frmAdminPanel();
            frmadmin.Show();
        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYetkiliAd.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliAd, "Yetkili ismini girin");
                }
                else if (txtYetkiliSoyad.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliSoyad, "Yetkili soyadını girin");
                }
                else if (txtYetkiliEvno.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliEvno, "Yetkiliin Ev numarasını girin");
                }
                else if (txtYetkiliCepNo.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliCepNo, "Yetkili Cep telefonunu yazın");
                }
                
                else if (txtYetkiliAdres.Text=="")
                {
                    errorProvider1.SetError(txtYetkiliAdres, "Yetkiliin adresini yazın");
                }
                
            else
            {
                SqlCommand komut = new SqlCommand("UPDATE YetkiliKaydi SET ad='" + txtYetkiliAd.Text + "',soyad='" + txtYetkiliSoyad.Text + "',ev_no='" + txtYetkiliEvno.Text + "',cep_no='" + txtYetkiliCepNo.Text + "',adres='" + txtYetkiliAdres.Text + "' WHERE id='" + dtGridYetkili.CurrentRow.Cells[5].Value.ToString() + "'", bag);
                
                bag.Open();
                komut.ExecuteNonQuery();
                
                bag.Close();
                MessageBox.Show("Kayıt Güncellenmiştir");
                listele();
            }
        }

        private void txtYetkiliAd_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliSoyad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliEvno_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliCepNo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliAdres_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliSifre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtYetkiliSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            errorProvider1.Clear();
        }

        private void btnHepsiniGoster_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM YetkiliKaydi ", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridYetkili.DataSource = tablo;
            bag.Close();
        }

        
    }
}

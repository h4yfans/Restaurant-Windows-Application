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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        void providerTemizle() {
            errorProvider1.Clear();
        
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            listele1();

            dtGridAnaUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridAraUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtAnaUrunAdi.Enabled = false;
            txtAltUrunAdi.Enabled = false;
            txtAltUrunFiyati.Enabled = false;
            cmbAltUrunBirimi.Enabled = false;
            btnAnaUrunGuncelle.Visible = false;
            btnAnaUrunKaydet.Enabled = false;
            btnAraUrunKaydet.Enabled = false;
            btnAraUrunGuncellle.Enabled = false;
            btnAraUrunIptal.Enabled = false;
            btnAnaUrunIptal.Enabled = false;
        }


        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        decimal duzenle;
        int anagrup_id;
        void listele1()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridAnaUrun.DataSource = tablo;
            bag.Close();
            dtGridAnaUrun.Columns[0].Visible = false;
            dtGridAnaUrun.Columns[1].Width = 237;
            dtGridAnaUrun.RowHeadersWidth = 14;
            int ColumnsIndex = 1; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dtGridAnaUrun.Columns[ColumnsIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
        }
        void listele2()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM altgrup2 where anagrup_id = " + anagrup_id, bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridAraUrun.DataSource = tablo;
            bag.Close();
            dtGridAraUrun.Columns[0].Visible = false;
            dtGridAraUrun.Columns[2].Visible = false;
            dtGridAraUrun.Columns[5].Visible = false;
            dtGridAraUrun.Columns[1].Width = 222;
            dtGridAraUrun.Columns[3].Width = 222;
            dtGridAraUrun.Columns[4].Width = 207;
            dtGridAraUrun.RowHeadersWidth = 14;

            this.dtGridAraUrun.Columns["Urunler"].DefaultCellStyle
           .Alignment = DataGridViewContentAlignment.NotSet;

            int ColumnsIndex1 = 1; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dtGridAraUrun.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.DeepSkyBlue;

            int ColumnsIndex2 = 3;
            this.dtGridAraUrun.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.DarkOrange;

            int ColumnsIndex3 = 4;
            this.dtGridAraUrun.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.SlateGray;
           


        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridAnaUrun.DataSource = tablo;
            bag.Close();
        }





        private void btnAraUrunIptal_Click(object sender, EventArgs e)
        {
            btnAraUrunGuncellle.Enabled = false;
            txtAltUrunAdi.Enabled = false;
            txtAltUrunFiyati.Enabled = false;
            cmbAltUrunBirimi.Enabled = false;
            btnAraUrunIptal.Enabled = false;
            btnAraUrunKaydet.Enabled = false;

        }
        void truela()
        {
            txtAltUrunAdi.Enabled = true;
            txtAltUrunFiyati.Enabled = true;
            cmbAltUrunBirimi.Enabled = true;
            btnAraUrunIptal.Enabled = true;
            btnAraUrunKaydet.Enabled = true;
        }

        private void tlStpBtnAltUrunEkle_Click(object sender, EventArgs e)
        {
            truela();
            btnAraUrunGuncellle.Visible = false;
            btnAraUrunKaydet.Visible = true;
            txtAltUrunAdi.Text = "";
            txtAltUrunFiyati.Text = "";
            cmbAltUrunBirimi.SelectedIndex = -1;
            

        }

        private void tlStpBtnAltUrunDuzenle_Click(object sender, EventArgs e)
        {
            
            btnAraUrunGuncellle.Visible = true;
            btnAraUrunKaydet.Visible = false;
            txtAltUrunAdi.Enabled = true;
            txtAltUrunFiyati.Enabled = true;
            cmbAltUrunBirimi.Enabled = true;
            btnAraUrunGuncellle.Enabled = true;
            btnAraUrunIptal.Enabled = true;
            
           
        }

        private void btnAnaUrunIptal_Click(object sender, EventArgs e)
        {
            btnAnaUrunGuncelle.Enabled = false;
            btnAnaUrunIptal.Enabled = false;
            btnAnaUrunKaydet.Enabled = false;
            txtAnaUrunAdi.Enabled = false;

        }

        private void tlStpBtnAnaUrunDuzenle_Click(object sender, EventArgs e)
        {
            btnAnaUrunIptal.Enabled = true;
            btnAnaUrunKaydet.Enabled = true;
            txtAnaUrunAdi.Enabled = true;
            btnAnaUrunKaydet.Visible = false;
            btnAnaUrunGuncelle.Visible = true;
            listele();
            



        }

        private void tlStpBtnAnaUrunSil_Click(object sender, EventArgs e)
        {
            if (dtGridAnaUrun.CurrentCell != null)
            {
                  SqlCommand komut = new SqlCommand("DELETE FROM anagrup2 WHERE Cesitler='" + dtGridAnaUrun.CurrentRow.Cells[1].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();
            txtAnaUrunAdi.Clear();
            MessageBox.Show("Silme İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Silmek için bir Ana Ürün seçiniz!");
            }

        }

        private void tlStpBtnAltUrunSil_Click(object sender, EventArgs e)
        {
            if (dtGridAraUrun.CurrentCell != null)
            {
                  SqlCommand komut = new SqlCommand("DELETE FROM altgrup2 WHERE altgrup_id='" + dtGridAraUrun.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı");
            listele2();
            txtAltUrunAdi.Text = "";
            txtAltUrunFiyati.Text = "";
            cmbAltUrunBirimi.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Silmek için bir Ara Ürün seçiniz!");
            }
        }

        private void tlStpBtnAnaUrunEkle_Click(object sender, EventArgs e)
        {
            txtAnaUrunAdi.Text = "";
            btnAnaUrunGuncelle.Visible = false;
            btnAnaUrunKaydet.Visible = true;
            btnAnaUrunIptal.Enabled = true;
            btnAnaUrunKaydet.Enabled = true;
            txtAnaUrunAdi.Enabled = true;
        }


        private void dtGridAnaUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGridAnaUrun.CurrentCell.Style.SelectionBackColor = Color.Purple; // Yazar burada click olayına backcolor verdi.
            txtAnaUrunAdi.Text = dtGridAnaUrun.CurrentRow.Cells[1].Value.ToString();
            anagrup_id = int.Parse(dtGridAnaUrun.CurrentRow.Cells[0].Value.ToString());
            listele2();

        }



        private void btnAnaUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtAnaUrunAdi.Text=="")
            {
                errorProvider1.SetError(txtAnaUrunAdi, "Ana Ürün adı belirleyiniz.");
            }
            else
	{
                SqlCommand komut = new SqlCommand("INSERT INTO anagrup2(Cesitler) VALUES('" + txtAnaUrunAdi.Text + "')", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();
            txtAnaUrunAdi.Text = "";
            MessageBox.Show("Kayıt Başarıyla Yapılmıştır");
            
	}
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2 ORDER BY Cesitler", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridAnaUrun.DataSource = tablo;
            bag.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2 ORDER BY Cesitler desc", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridAnaUrun.DataSource = tablo;
            bag.Close();
        }

        private void btnAraUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtAltUrunAdi.Text=="")
            {
                errorProvider1.SetError(txtAltUrunAdi, "Ürün ismi girin.");
            }
            else if (txtAltUrunFiyati.Text=="")
            {
                 errorProvider1.SetError(txtAltUrunFiyati, "Fiyat belirleyiniz.");
            }
            else if (cmbAltUrunBirimi.SelectedIndex==-1)
            {
                 errorProvider1.SetError(cmbAltUrunBirimi, "Birim belirleyiniz.");
            }
            else
            {
                int miktar = 1;

                bag.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO altgrup2(Urunler,anagrup_id,Fiyat,Birim,Miktar) VALUES('" + txtAltUrunAdi.Text + "','" + anagrup_id.ToString() + "','" + txtAltUrunFiyati.Text + "','" + cmbAltUrunBirimi.SelectedItem.ToString() + "','"+miktar+"')", bag);
                komut.ExecuteNonQuery();
                bag.Close();
                listele2();
                MessageBox.Show("Kayıt Başarıyla Yapılmıştır");
                txtAltUrunAdi.Text = "";
                txtAltUrunFiyati.Text = "";
                cmbAltUrunBirimi.SelectedIndex = -1;
            }
            
        }

        private void cmbAltUrunBirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            providerTemizle();
        }

        private void dtGridAraUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAltUrunAdi.Text = dtGridAraUrun.CurrentRow.Cells[1].Value.ToString();
            txtAltUrunFiyati.Text = dtGridAraUrun.CurrentRow.Cells[3].Value.ToString();
            cmbAltUrunBirimi.Text = dtGridAraUrun.CurrentRow.Cells[4].Value.ToString();
        }

        private void tlStpBtnUrunKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Program kapatılsın mı?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void tlStpBtnUrunGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminPanel frmadmin = new frmAdminPanel();
            frmadmin.Show();
        }

        private void tlStpUrunler_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtGridAnaUrun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtAltUrunFiyati_TextChanged(object sender, EventArgs e)
        {
            providerTemizle();
        }

        private void btnAnaUrunGuncelle_Click(object sender, EventArgs e)
        {
            btnAnaUrunIptal.Enabled = true;
            btnAnaUrunKaydet.Enabled = true;
            txtAnaUrunAdi.Enabled = true;
             if (txtAnaUrunAdi.Text=="")
            {
                errorProvider1.SetError(txtAnaUrunAdi, "Ana Ürün adı belirleyiniz.");
            }
             else
             {
                 SqlCommand komut = new SqlCommand("UPDATE anagrup2 SET Cesitler='" + txtAnaUrunAdi.Text + "'WHERE anagrup_id='" + dtGridAnaUrun.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                 bag.Open();
                 komut.ExecuteNonQuery();
                 bag.Close();
                 listele();
                 txtAnaUrunAdi.Text = "";
                 MessageBox.Show("Kayıt Güncellenmiştir");
             }
            
        }

        private void btnAraUrunGuncellle_Click(object sender, EventArgs e)
        {
            if (txtAltUrunAdi.Text == "")
            {
                errorProvider1.SetError(txtAltUrunAdi, "Ürün ismi girin.");
            }
            else if (txtAltUrunFiyati.Text == "")
            {
                errorProvider1.SetError(txtAltUrunFiyati, "Fiyat belirleyiniz.");
            }
            else if (cmbAltUrunBirimi.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbAltUrunBirimi, "Birim belirleyiniz.");
            }

            else
            {
                if (dtGridAraUrun.CurrentCell != null)
                {
                    truela();
                    int miktar = 1;
                    duzenle = decimal.Parse(txtAltUrunFiyati.Text);
                    anagrup_id = int.Parse(dtGridAraUrun.CurrentRow.Cells[2].Value.ToString());
                    SqlCommand komut = new SqlCommand("UPDATE altgrup2 SET Urunler='" + txtAltUrunAdi.Text + "',anagrup_id='" + anagrup_id + "',Fiyat=replace( '" + duzenle + "', ',' , '.'),Birim='" + cmbAltUrunBirimi.SelectedItem.ToString() + "',Miktar='" + miktar + "' WHERE altgrup_id='" + dtGridAraUrun.CurrentRow.Cells[0].Value.ToString() + "'", bag);

                    bag.Open();
                    komut.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("Kayıt Güncellenmiştir");
                    listele2();
                    txtAltUrunAdi.Text = "";
                    txtAltUrunFiyati.Text = "";
                    cmbAltUrunBirimi.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Güncellemek için Ara Ürün seçiniz!", "!!");
                }
            }
            
        }

        private void txtAnaUrunAdi_TextChanged(object sender, EventArgs e)
        {
            providerTemizle();
        }

        private void txtAltUrunAdi_TextChanged(object sender, EventArgs e)
        {
            providerTemizle();
        }
    }
}


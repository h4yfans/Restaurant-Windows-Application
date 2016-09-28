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
    public partial class frmMasa8 : Form
    {
        public frmMasa8()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");

        private void frmMasa8_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dtMasa1Tarih.Enabled = false;
            dtMasa1Saat.Enabled = false;
            masasiparis();
            listele1();
            toplamtutar();
            dgAnaUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAraUrun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMasa8Siparis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMasa8Siparis.Columns[4].Visible = false;
            //dgMasa8Siparis.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
        }

        void toplamtutar()
        {

            SqlCommand komut = new SqlCommand("select sum(tutar)as Tutar from masa8siparis", bag);
            bag.Open();
            lblMasa2TTutar.Text = komut.ExecuteScalar().ToString() + " TL ";
            bag.Close();
            Ortak.toplamtutar8 = lblMasa2TTutar.Text;

        }

        decimal masaeklenoktali;
        decimal arttir = 1;
        double aragrup_id;
        double anagrup_id;
        decimal tutar1;
        decimal tutar2;
        void listele1()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2", bag);
            bag.Open();
            adptr.Fill(tablo);
            dgAnaUrun.DataSource = tablo;
            bag.Close();
            dgAnaUrun.Columns[0].Visible = false;
            dgAnaUrun.Columns[1].Width = 253;
            dgAnaUrun.RowHeadersWidth = 14;

            int ColumnsIndex = 1; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dgAnaUrun.Columns[ColumnsIndex].DefaultCellStyle.BackColor = Color.YellowGreen;



        }
        void listele2()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM altgrup2 where anagrup_id = " + anagrup_id, bag);
            bag.Open();
            adptr.Fill(tablo);
            dgAraUrun.DataSource = tablo;
            bag.Close();
            dgAraUrun.Columns[0].Visible = false;
            dgAraUrun.Columns[2].Visible = false;
            dgAraUrun.Columns[5].Visible = false;
            dgMasa8Siparis.Columns[4].Visible = false;
            dgAraUrun.Columns[1].Width = 126;
            dgAraUrun.Columns[3].Width = 100;
            dgAraUrun.Columns[4].Width = 60;
            dgAraUrun.RowHeadersWidth = 14;
            dgMasa8Siparis.Columns[4].Visible = false;
            this.dgAraUrun.Columns["Fiyat"].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleRight;

            int ColumnsIndex1 = 1; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dgAraUrun.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.DeepSkyBlue;

            int ColumnsIndex2 = 3;
            this.dgAraUrun.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.DarkOrange;

            int ColumnsIndex3 = 4;
            this.dgAraUrun.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.SlateGray;






        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM anagrup2", bag);
            bag.Open();
            adptr.Fill(tablo);
            dgAnaUrun.DataSource = tablo;
            bag.Close();
        }



        void masasiparis()
        {

            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from masa8siparis", bag);
            bag.Open();
            adptr.Fill(tablo);
            dgMasa8Siparis.DataSource = tablo;
            bag.Close();
            dgMasa8Siparis.Columns[0].Width = 45;
            dgMasa8Siparis.Columns[1].Width = 58;
            dgMasa8Siparis.Columns[2].Width = 207;
            dgMasa8Siparis.Columns[3].Width = 75;
            dgAraUrun.RowHeadersWidth = 14;

            this.dgMasa8Siparis.Columns["Tutar"].DefaultCellStyle
           .Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgMasa8Siparis.Columns["Miktar"].DefaultCellStyle
          .Alignment = DataGridViewContentAlignment.MiddleCenter;

            int ColumnsIndex0 = 0; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dgMasa8Siparis.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Coral;


            int ColumnsIndex1 = 1; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dgMasa8Siparis.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.DodgerBlue;


            int ColumnsIndex2 = 2; // Yazar burada Kolon 1'in arka plan rengini değiştirmiş.
            this.dgMasa8Siparis.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.Wheat;

            int ColumnsIndex3 = 3;
            this.dgMasa8Siparis.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.SlateGray;

            dgMasa8Siparis.RowHeadersWidth = 14;
            dgMasa8Siparis.Columns[5].Visible = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = System.DateTime.Now.ToLongTimeString();
            lblTarihUstBar.Text = DateTime.Now.ToShortDateString();
        }

        private void dgAnaUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            anagrup_id = double.Parse(dgAnaUrun.CurrentRow.Cells[0].Value.ToString());
            listele2();
            dgAnaUrun.Columns[1].Width = 222;
            dgAnaUrun.CurrentCell.Style.SelectionBackColor = Color.Purple; // Yazar burada click olayına backcolor verdi.
        }

        private void dgAraUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgAraUrun.CurrentCell.Style.SelectionBackColor = Color.Black; // Yazar burada click olayına backcolor verdi.
        }

        private void dgAraUrun_DoubleClick(object sender, EventArgs e)
        {
            masaeklenoktali = decimal.Parse(dgAraUrun.CurrentRow.Cells[3].Value.ToString());

            SqlCommand komut = new SqlCommand("INSERT INTO masa8siparis(Miktar,Birim,Urun,Tutar,Tutar2) VALUES('" + dgAraUrun.CurrentRow.Cells[5].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[4].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[1].Value.ToString() + "', replace( '" + masaeklenoktali + "', ',' , '.') , replace( '" + masaeklenoktali + "', ',' , '.'))", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            masasiparis();
            toplamtutar();
        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            if (dgAraUrun.CurrentCell != null)
            {
                masaeklenoktali = decimal.Parse(dgAraUrun.CurrentRow.Cells[3].Value.ToString());

                SqlCommand komut = new SqlCommand("INSERT INTO masa8siparis(Miktar,Birim,Urun,Tutar,Tutar2) VALUES('" + dgAraUrun.CurrentRow.Cells[5].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[4].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[1].Value.ToString() + "', replace( '" + masaeklenoktali + "', ',' , '.') , replace( '" + masaeklenoktali + "', ',' , '.'))", bag);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                masasiparis();
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Ürün Seç");
            }
        }

        private void btnMasaCikar_Click(object sender, EventArgs e)
        {
            if (dgMasa8Siparis.CurrentCell != null)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM masa8siparis WHERE id='" + dgMasa8Siparis.CurrentRow.Cells[5].Value.ToString() + "'", bag);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                masasiparis();
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Ürün Seçmediniz");
            }
        }

        private void btnMasaikram_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO masa8siparis(Miktar,Birim,Urun,Tutar) VALUES('" + dgAraUrun.CurrentRow.Cells[5].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[4].Value.ToString() + "','" + dgAraUrun.CurrentRow.Cells[1].Value.ToString() + " (İKRAM)','" + 0 * aragrup_id + "')", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            masasiparis();
        }

        private void btnMasa2Arttır_Click(object sender, EventArgs e)
        {
            if (dgMasa8Siparis.CurrentCell != null)
            {
                aragrup_id = double.Parse(dgMasa8Siparis.CurrentRow.Cells[0].Value.ToString());
                tutar1 = decimal.Parse(dgMasa8Siparis.CurrentRow.Cells[3].Value.ToString());
                tutar2 = decimal.Parse(dgMasa8Siparis.CurrentRow.Cells[4].Value.ToString());
                decimal x;
                x = arttir + Convert.ToDecimal(aragrup_id);
                tutar1 = tutar2 * x;
                SqlCommand komut = new SqlCommand("UPDATE masa8siparis SET Miktar='" + x.ToString() + "',Birim='" + dgMasa8Siparis.CurrentRow.Cells[1].Value.ToString() + "',Urun='" + dgMasa8Siparis.CurrentRow.Cells[2].Value.ToString() + "',Tutar=replace( '" + tutar1 + "', ',' , '.') WHERE Urun='" + dgMasa8Siparis.CurrentRow.Cells[2].Value.ToString() + "'", bag);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                masasiparis();
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Ürün Miktarını Artırmak için Lütfen Ürün Seçiniz");
            }
        }

        private void btnMasa2Azalt_Click(object sender, EventArgs e)
        {
            decimal tutar1;
            decimal tutar2;
            decimal arttir = -1;

            if (dgMasa8Siparis.CurrentCell != null)
            {
                aragrup_id = double.Parse(dgMasa8Siparis.CurrentRow.Cells[0].Value.ToString());
                tutar1 = decimal.Parse(dgMasa8Siparis.CurrentRow.Cells[3].Value.ToString());
                tutar2 = decimal.Parse(dgMasa8Siparis.CurrentRow.Cells[4].Value.ToString());
                decimal x;
                x = arttir + Convert.ToDecimal(aragrup_id);
                tutar2 = tutar1 - tutar2;
                SqlCommand komut = new SqlCommand("UPDATE masa8siparis SET Miktar='" + x.ToString() + "',Birim='" + dgMasa8Siparis.CurrentRow.Cells[1].Value.ToString() + "',Urun='" + dgMasa8Siparis.CurrentRow.Cells[2].Value.ToString() + "',Tutar=replace( '" + tutar2 + "', ',' , '.') WHERE Urun='" + dgMasa8Siparis.CurrentRow.Cells[2].Value.ToString() + "'", bag);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                masasiparis();
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Ürün Miktarını Azaltmak için Lütfen Ürün Seçiniz!");
            }
        }

        private void btnMasa2ServisKapa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar8, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa8siparis");
                DataSet ds = new DataSet();
                bag.Open();
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + frmmasa.btnMASA8.Text + "'", bag);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa8siparis ", bag);
                komut2.ExecuteNonQuery();
                Ortak.toplamtutar8 = "00,00";
                bag.Close();
                frmmasa.Show();
                frmmasa.butonrenkdenetle();
                this.Hide();
                if (Ortak.admingirisi == "admin")
                {
                    frmmasa.btnMasaGeri.Visible = true;
                }
            }
        }

        private void btnMasa2SiparisAl_Click(object sender, EventArgs e)
        {
            FormMasa frmmasa = new FormMasa();
            DataSet ds = new DataSet();
            bag.Open();
            ds.Clear();
            SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='kirmizi' WHERE ButonAdi='" + frmmasa.btnMASA8.Text + "'", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            frmmasa.Show();
            frmmasa.butonrenkdenetle();
            this.Hide();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }
        }

        private void btnMasa2SiparisIptal_Click(object sender, EventArgs e)
        {
            FormMasa frmmasa = new FormMasa();
            frmmasa.Show();
            this.Hide();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }
        }

        private void dgMasa8Siparis_DoubleClick(object sender, EventArgs e)
        {
            if (dgMasa8Siparis.CurrentCell != null)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM masa8siparis WHERE Urun='" + dgMasa8Siparis.CurrentRow.Cells[2].Value.ToString() + "'", bag);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                masasiparis();
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Ürün Seçmediniz");
            }
        }
    }
}

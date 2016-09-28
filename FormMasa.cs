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
    public partial class FormMasa : Form
    {
        public FormMasa()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMASA1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA1.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren=="yesil" || renkogren=="kirmizi")
            {
                Masalar.frmMasa1 frmmasa1 = new Masalar.frmMasa1();
                frmmasa1.Show();
                this.Hide();
            }
            else if (renkogren=="sari")
            {
                Ortak.Masanumarasi = "MASA 1";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();
                
            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA2.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa2 frmmasa2 = new frmMasa2();
                frmmasa2.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 2";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA3.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa3 frmmasa3 = new frmMasa3();
                frmmasa3.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 3";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA4.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa4 frmmasa4 = new frmMasa4();
                frmmasa4.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 4";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA5.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa5 frmmasa5 = new frmMasa5();
                frmmasa5.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 5";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA6.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa6 frmmasa6 = new frmMasa6();
                frmmasa6.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 6";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA7.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa7 frmmasa7 = new frmMasa7();
                frmmasa7.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 7";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA8_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA8.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa8 frmmasa8 = new frmMasa8();
                frmmasa8.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 8";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnMASA9_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA9.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa9 frmmasa9 = new frmMasa9();
                frmmasa9.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 9";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void FormMasa_Load(object sender, EventArgs e)
        {
            butonrenkdenetle();
            label1.Text = "Hesap düzeyi: " + Ortak.kullanicidurumu;
            label2.Text = "Hoşgeldin, " + Ortak.kullaniciismi;
        }
        public void butonrenkdenetle()
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = "";
            string[] butonrenk1 = new string[15];
            for (int i = 1; i <= 10; i++)
            {
                butonrenk1[i] = "MASA " + i;
            }
            for (int i = 1; i <= 10; i++)
            {



                SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + butonrenk1[i] + "'", bag);
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                renkogren = cmd.ExecuteScalar().ToString();
                if (renkogren == "kirmizi")
                {
                    switch (butonrenk1[i])
                    {
                        case "MASA 1": btnMASA1.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 2": btnMASA2.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 3": btnMASA3.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 4": btnMASA4.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 5": btnMASA5.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 6": btnMASA6.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 7": btnMASA7.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 8": btnMASA8.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 9": btnMASA9.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        case "MASA 10": btnMASA10.BackColor = Color.FromArgb(196, 35, 35);
                            break;
                        default:
                            break;
                    }
                }
                else if (renkogren == "yesil")
                {
                    switch (butonrenk1[i])
                    {
                        case "MASA 1": btnMASA1.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 2": btnMASA2.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 3": btnMASA3.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 4": btnMASA4.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 5": btnMASA5.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 6": btnMASA6.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 7": btnMASA7.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 8": btnMASA8.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 9": btnMASA9.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        case "MASA 10": btnMASA10.BackColor = Color.FromArgb(148, 196, 112);
                            break;
                        default:
                            break;
                    }
                }
                else if (renkogren == "sari")
                {
                    switch (butonrenk1[i])
                    {
                        case "MASA 1": btnMASA1.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 2": btnMASA2.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 3": btnMASA3.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 4": btnMASA4.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 5": btnMASA5.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 6": btnMASA6.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 7": btnMASA7.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 8": btnMASA8.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 9": btnMASA9.BackColor = Color.Goldenrod;
                            break;
                        case "MASA 10": btnMASA10.BackColor = Color.Goldenrod;
                            break;
                        default:
                            break;
                    }
                    if (bag.State == ConnectionState.Open)
                    {
                        bag.Close();
                    }
                }
            }
        }
        private void btnMASA10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ButonRengi from butonrenk where ButonAdi='" + btnMASA10.Text + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            string renkogren = cmd.ExecuteScalar().ToString();
            if (renkogren == "yesil" || renkogren == "kirmizi")
            {
                frmMasa10 frmmasa10 = new frmMasa10();
                frmmasa10.Show();
                this.Hide();
            }
            else if (renkogren == "sari")
            {
                Ortak.Masanumarasi = "MASA 10";
                frmRezOnay frmrez = new frmRezOnay();
                frmrez.Show();
                this.Close();

            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }
        public void butonrenklerisifirla() {
            string[] butonlar = new string[11];
            for (int i = 1; i <=10 ; i++)
            {
                butonlar[i] = "MASA " + i;
            
            DataSet ds = new DataSet();
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            ds.Clear();
            SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +butonlar[i]+ "'", bag);
            komut.ExecuteNonQuery();
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            butonrenkdenetle();
            }
        
        }

        private void servisiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar1, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa1siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA1.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa1siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA1.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                Ortak.toplamtutar1 = "00,00";

                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar2, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa2siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA2.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa2siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA2.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar2 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar3, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa3siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA3.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa3siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA3.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar3 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar4, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa4siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA4.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa4siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA4.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar4 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar5, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa5siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA5.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa5siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA5.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar5 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar6, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa6siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA6.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa6siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA6.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar6 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar7, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa7siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA7.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa7siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA7.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar7 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }



        private void servisiKapatToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar9, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa9siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA9.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa9siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA9.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar9 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar10, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa10siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA10.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa10siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA10.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar10 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void servisiKapatToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Servis kapatılsın mı ? Hesap: " + Ortak.toplamtutar8, "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                FormMasa frmmasa = new FormMasa();
                frmmasa.gunluktutar("masa8siparis");
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                ds.Clear();
                SqlCommand komut = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" + btnMASA8.Text + "'", bag);
                SqlCommand komut2 = new SqlCommand("DELETE FROM masa8siparis ", bag);
                SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + btnMASA8.Text + "'", bag);
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                Ortak.toplamtutar8 = "00,00";
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                butonrenkdenetle();
            }
        }

        private void tümServisleriKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butonrenklerisifirla();
            FormMasa frmmasa = new FormMasa();
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon", bag);
            komut3.ExecuteNonQuery();

            for (int i = 1; i <= 10; i++)
            {
                frmmasa.gunluktutar("masa"+i+"siparis");
            }
            for (int i = 1; i <= 10; i++)
            {
                 DataSet ds = new DataSet();
                 
            ds.Clear();         
            SqlCommand komut = new SqlCommand("DELETE FROM masa"+i+"siparis ", bag);
            komut.ExecuteNonQuery();
            }
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            
        }

        public void gunluktutar(string masanumarasi) {
            string masanumarasi2 = "";
            string tarih = DateTime.Now.ToShortDateString();
            string tarih2 = DateTime.Now.ToShortTimeString();
            bag.Open();
            
            SqlCommand komut = new SqlCommand("INSERT INTO gunlukrapor(Urun_Adi,Tutar) SELECT Urun,Tutar FROM "+masanumarasi, bag);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("select sum(Tutar)as Toplam_Tutar from gunlukrapor", bag);
            komut2.ExecuteNonQuery();
            string toplamtutar = komut2.ExecuteScalar().ToString();
            if (masanumarasi.Length==13)
	{
		 masanumarasi2 = masanumarasi.Substring(4,2);
	}
            else
	{
        masanumarasi2 = masanumarasi.Substring(4, 1);
	}

            SqlCommand komut3 = new SqlCommand("INSERT INTO gunlukrapor(Urun_Adi,Toplam_Tutar,Tarih) values('" + masanumarasi2 + ". masanın servisi kapandı','" + toplamtutar + "','" + tarih + " " + tarih2 + "')", bag);
           
            
            
           
            
            komut3.ExecuteNonQuery();
            bag.Close();
        
        
        
        }

        private void btnMasaGeri_Click(object sender, EventArgs e)
        {
            frmAdminPanel frmadmin = new frmAdminPanel();
            frmadmin.Show();
            this.Close();
        }
        
        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rezervasyonAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                frmRezervasyon frmrez = new frmRezervasyon();
                frmrez.Show();
                this.Close();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Ortak.admingirisi == "admin")
            {
                btnMasaGeri.Visible = true;
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Giriş ekranına dönmek istiyor musunuz ?","Uyarı!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {FormHesap frmhesap = new FormHesap();
            frmhesap.Show();
            this.Hide();   
            } 
        }

        

        


       


    }
}

       
        


   
       

      
      

   

        

        

        
      
 
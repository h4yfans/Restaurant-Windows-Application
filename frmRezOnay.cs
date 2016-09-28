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
    public partial class frmRezOnay : Form
    {
        public frmRezOnay()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
        private void btnRezOnay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Rezervasyon_Sahibi from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
           string masasahibi = cmd.ExecuteScalar().ToString();
          
           
            if (txtRezOnay.Text ==masasahibi)
            {
                FormMasa frmmasa = new FormMasa();
                frmmasa.Close();
                switch (Ortak.Masanumarasi)
                {
                    case "MASA 1":
                            MessageBox.Show("Giriş başarılı.");
                            frmmasa.Close();
                            Masalar.frmMasa1 frmmasa1 = new Masalar.frmMasa1();
                            frmmasa1.Show();
                            this.Hide();
                            SqlCommand komut = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                            komut.ExecuteNonQuery();
                        SqlCommand komut11 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut11.ExecuteNonQuery();
                        
                        break;
                    case "MASA 2": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa2 frmmasa2 = new frmMasa2();
                        frmmasa2.Show();
                        this.Hide();
                        SqlCommand komut2 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut2.ExecuteNonQuery();
                        SqlCommand komut22 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut22.ExecuteNonQuery();
                        break;
                    case "MASA 3": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa3 frmmasa3 = new frmMasa3();
                        frmmasa3.Show();
                        this.Hide();
                        SqlCommand komut3 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut3.ExecuteNonQuery();
                        SqlCommand komut33 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut33.ExecuteNonQuery();
                        break;
                    case "MASA 4": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa4 frmmasa4 = new frmMasa4();
                        frmmasa4.Show();
                        this.Hide();
                        SqlCommand komut4 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut4.ExecuteNonQuery();
                        SqlCommand komut44 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut44.ExecuteNonQuery();
                        break;
                    case "MASA 5": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa5 frmmasa5 = new frmMasa5();
                        frmmasa5.Show();
                        this.Hide();
                        
                        SqlCommand komut5 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut5.ExecuteNonQuery();
                        SqlCommand komut55 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut55.ExecuteNonQuery();
                        break;
                    case "MASA 6": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa6 frmmasa6 = new frmMasa6();
                        frmmasa6.Show();
                        this.Hide();
                        
                        SqlCommand komut6 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut6.ExecuteNonQuery();
                        SqlCommand komut66 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut66.ExecuteNonQuery();
                        break;
                    case "MASA 7": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa7 frmmasa7 = new frmMasa7();
                        frmmasa7.Show();
                        this.Hide();
                        
                        SqlCommand komut7 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut7.ExecuteNonQuery();
                        SqlCommand komut77 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut77.ExecuteNonQuery();
                        break;
                    case "MASA 8": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa8 frmmasa8 = new frmMasa8();
                        frmmasa8.Show();
                        this.Hide();
                       
                        SqlCommand komut8 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut8.ExecuteNonQuery();
                        SqlCommand komut88 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut88.ExecuteNonQuery();
                        break;
                    case "MASA 9": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa9 frmmasa9 = new frmMasa9();
                        frmmasa9.Show();
                        this.Hide();
                       
                        SqlCommand komut9 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut9.ExecuteNonQuery();
                        SqlCommand komut99 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut99.ExecuteNonQuery();
                        break;
                    case "MASA 10": MessageBox.Show("Giriş başarılı.");
                        frmmasa.Close();
                        frmMasa10 frmmasa10= new frmMasa10();
                        frmmasa10.Show();
                        this.Hide();
                        
                        SqlCommand komut10 = new SqlCommand("DELETE from rezervasyon where Masa_Numarasi='" + Ortak.Masanumarasi + "'", bag);
                        komut10.ExecuteNonQuery();
                        SqlCommand komut12 = new SqlCommand("UPDATE butonrenk SET ButonRengi='yesil' WHERE ButonAdi='" +Ortak.Masanumarasi+ "'", bag);
                        komut12.ExecuteNonQuery();
                        break;
                    default:
                        break;
                }
                
                
                
            }
            else
            {
                MessageBox.Show("İsim yanlış. Lütfen büyük küçük harf uyumuna dikkat edin.");
            }
            if (bag.State == ConnectionState.Open)
            {
                bag.Close();
            }
        }

        private void btnRezIptal_Click(object sender, EventArgs e)
        {
            FormMasa frmmasa = new FormMasa();
            this.Close();
            System.Threading.Thread.Sleep(1000);
            frmmasa.butonrenkdenetle();
            frmmasa.Show();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }
        }
       
    }
}

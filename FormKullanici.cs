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
namespace ProjeLokanta
{
    public partial class FormKullanici : Form
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        private void btnKullaniciCikis_Click(object sender, EventArgs e)
        {
            FormHesap frmhesap = new FormHesap();
            frmhesap.Show();
            this.Hide();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan = new SqlConnection();
                baglan.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
                baglan.Open();
                SqlParameter prm1 = new SqlParameter("@141", txtKullaniciKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("@142", txtKullaniciSifre.Text);
                string sql = "";
                sql = "SELECT * FROM kullanici WHERE personeladi =@141 AND sifre=@142";
                SqlCommand cmd = new SqlCommand(sql, baglan);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblDurumPers.Visible = true;
                    lblDurumPers.Text = "Giriş Başarılı";
                    FormMasa frmmasa = new FormMasa();
                    Ortak.admingirisi = "kullanici";
                    SqlCommand logekle = new SqlCommand("INSERT INTO loglar(Kullanici_Adi,Giris_Yetkisi,Giris_Tarihi) VALUES('" + txtKullaniciKullaniciAdi.Text + "','Personel','" + DateTime.Now + "')", baglan);
                    Ortak.kullaniciismi = txtKullaniciKullaniciAdi.Text;
                    Ortak.kullanicidurumu = "Personel";
                    Ortak.destek = "false";
                    Ortak.hakkimizda = "false";
                    logekle.ExecuteNonQuery();
                    frmmasa.Show();
                    this.Hide();
                }
                else
                {
                    lblDurumPers.Visible = true;
                    lblDurumPers.Text = "Yanlış Kullanıcı Adı ve ŞİFRE Girdiniz!!!";

                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                lblDurumPers.Visible = true;
                lblDurumPers.Text = ex.Message;

            }
           
        }
    }
}

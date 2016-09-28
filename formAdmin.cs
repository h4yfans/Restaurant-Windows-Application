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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdminCikis_Click(object sender, EventArgs e)
        {
            FormHesap frmhsp = new FormHesap();
            frmhsp.Show();
            this.Hide();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan = new SqlConnection();
                baglan.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
                baglan.Open();
                SqlParameter prm1 = new SqlParameter("@141", txtAdminKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("@142", txtAdminSifre.Text);
                string sql = "";
                sql = "SELECT * FROM yetkili WHERE yetkiliadi =@141 AND sifre=@142";
                SqlCommand cmd = new SqlCommand(sql,baglan);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblDurumAdmin.Visible = true;
                    lblDurumAdmin.Text = "Giriş Başarılı";
                    frmAdminPanel frmadminpanel = new frmAdminPanel();
                    Ortak.admingirisi = "admin";
                    frmadminpanel.Show();
                    this.Hide();
                    SqlCommand logekle = new SqlCommand("INSERT INTO loglar(Kullanici_Adi,Giris_Yetkisi,Giris_Tarihi) VALUES('"+txtAdminKullaniciAdi.Text +"','Yönetici','"+DateTime.Now+"')",baglan);
                    Ortak.kullaniciismi = txtAdminKullaniciAdi.Text;
                    Ortak.kullanicidurumu = "Yönetici";
                    Ortak.hakkimizda = "true";
                    Ortak.destek = "true";
                    logekle.ExecuteNonQuery();
                }
                else
                {
                    lblDurumAdmin.Visible = true;
                    lblDurumAdmin.Text = "Yanlış Kullanıcı Adı ve ŞİFRE Girdiniz!!!";
                     
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                lblDurumAdmin.Visible = true;
                lblDurumAdmin.Text = ex.Message;
                
            }
        }

        private void formAdmin_KeyDown(object sender, KeyEventArgs e)
        {

        }

      
    }
}

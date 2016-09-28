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
    public partial class frmYetkiliHesapAyar : Form
    {
        public frmYetkiliHesapAyar()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");
        private void btnHesapAyarSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM yetkili WHERE id='" + dtGridHesapAyar.CurrentRow.Cells[2].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme İşlemi Tamamlandı");
            listele();
        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM yetkili", bag);
            bag.Open();
            adptr.Fill(tablo);
            dtGridHesapAyar.DataSource = tablo;
            bag.Close();
            dtGridHesapAyar.Columns[0].Width = 150;
            dtGridHesapAyar.Columns[1].Width = 200;
            dtGridHesapAyar.RowHeadersWidth = 14;
            dtGridHesapAyar.Columns[2].Visible = false;
        }
        private void frmYetkiliHesapAyar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnHesapAyarDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE yetkili SET yetkiliadi='" + txtHesapAyarKulad.Text + "',sifre='" + txtHesapAyarKulSif.Text + "'WHERE yetkiliadi='" + dtGridHesapAyar.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Güncellenmiştir");
            listele();
        }

        private void dtGridHesapAyar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHesapAyarKulad.Text = dtGridHesapAyar.CurrentRow.Cells[0].Value.ToString();
            txtHesapAyarKulSif.Text = dtGridHesapAyar.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtHesapAyarKulSif_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridHesapAyar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

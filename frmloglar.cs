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
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace ProjeLokanta
{
    public partial class frmloglar : Form
    {
        public frmloglar()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmloglar_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele() {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM loglar", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            adptr.Fill(tablo);
            dtLoglar.DataSource = tablo;
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            dtLoglar.Columns[0].Width = 205;
            dtLoglar.Columns[2].Width = 205;
            dtLoglar.Columns[1].Width = 207;
            dtLoglar.RowHeadersWidth = 14;
            int ColumnsIndex0 = 0;
            this.dtLoglar.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Orange;
            int ColumnsIndex1 = 1;
            this.dtLoglar.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.Gray;
            int ColumnsIndex2 = 2;
            this.dtLoglar.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            dtLoglar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\BKM RESTORAN\Loglar\"+DateTime.Now.ToShortDateString()+".txt");
            try
            {
                string sLine = "";

                string baslik = "Kullanıcı Adı,Yetki,Giris Tarihi";
                file.WriteLine(baslik);
                for (int r = 0; r <= dtLoglar.Rows.Count - 1; r++)
                {
                   
                    for (int c = 0; c <= dtLoglar.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dtLoglar.Rows[r].Cells[c].Value;
                        if (c != dtLoglar.Columns.Count - 1)
                        {
                            
                            sLine = sLine + ",";
                        }
                    }
                    
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                MessageBox.Show("Loglar Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Visible = true;
                label4.Visible = true;
                label3.Text = "Kaydedildi";
                label4.Text = @"Kaydedilen Yer : C:\BKM RESTORAN\Loglar\";
            }
            catch (System.Exception err)
            {
               MessageBox.Show(err.Message, "Hata ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Loglar Temizlensin mi ? Evet'e basarsanız veritabanından silinecek","SİLİNME UYARISI",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                SqlCommand sil = new SqlCommand("DELETE FROM loglar", bag);
                sil.ExecuteNonQuery();
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                listele();
            }
            
        }

        private void txtKullaniciyaGore_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM loglar WHERE Kullanici_Adi LIKE'" + txtKullaniciyaGore.Text + "%'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            adptr.Fill(tablo);
            dtLoglar.DataSource = tablo;
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            
        }

        private void txtYetkiyeGore_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM loglar WHERE Giris_Yetkisi LIKE'" + txtYetkiyeGore.Text + "%'", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            adptr.Fill(tablo);
            dtLoglar.DataSource = tablo;
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            
        }

        private void btnHepsiniGoster_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAdminPanel frmadmin = new frmAdminPanel();
            frmadmin.Show();
            this.Hide();
        }

        
    }
}

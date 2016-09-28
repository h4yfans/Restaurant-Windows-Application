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

namespace ProjeLokanta
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=kullanicigirisi; Integrated Security=True;");

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            dtGridZRaporu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void tlStpBtnYardim_ButtonClick(object sender, EventArgs e)
        {
    
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Programdan Çıkış Yapılsın mı?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text=System.DateTime.Now.ToLongTimeString();
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlStpBtnUrunler_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
           
            frmUrunler frmurun = new frmUrunler();
            frmurun.Show();
            this.Hide();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            this.Hide();
            frmPersonelEkle frmpersonelekle = new frmPersonelEkle();
            frmpersonelekle.Show();
        }

        private void yetkiliEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            frmyetkiliekle frmyetkiliekle = new frmyetkiliekle();
            frmyetkiliekle.Show();
            this.Hide();

        }

        private void tlStpBtnMasa_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            FormMasa frmmasa = new FormMasa();
            if (Ortak.admingirisi == "admin")
            {
                frmmasa.btnMasaGeri.Visible = true;
            }
            frmmasa.Show();
            this.Hide();
        }

        private void tlStpBtnGeri_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            this.Close();
            FormHesap frmhspp = new FormHesap();
            frmhspp.Show();
        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox2.Visible = true;
            frmAdminPanel.ActiveForm.Height = 563;
            listele();
        }
        void listele()
        {
            
            DataTable tablo = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM gunlukrapor", bag);
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
            adptr.Fill(tablo);
            dtGridZRaporu.DataSource = tablo;
            if (bag.State != ConnectionState.Open)
            {
                bag.Close();
            }
            dtGridZRaporu.Columns[0].Width = 300;
            dtGridZRaporu.Columns[1].Width = 100;
            dtGridZRaporu.Columns[2].Width = 100;
            dtGridZRaporu.Columns[3].Width = 170;
            dtGridZRaporu.RowHeadersWidth = 14;
            int ColumnsIndex0 = 0;
            this.dtGridZRaporu.Columns[ColumnsIndex0].DefaultCellStyle.BackColor = Color.Orange;
            int ColumnsIndex1 = 1;
            this.dtGridZRaporu.Columns[ColumnsIndex1].DefaultCellStyle.BackColor = Color.Gray;
            int ColumnsIndex2 = 2;
            this.dtGridZRaporu.Columns[ColumnsIndex2].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            int ColumnsIndex3 = 3;
            this.dtGridZRaporu.Columns[ColumnsIndex3].DefaultCellStyle.BackColor = Color.Beige;
            dtGridZRaporu.Columns["Tutar"].DefaultCellStyle.ForeColor = Color.White;

         
        }

        private void dtGridZRaporu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void tlStpBtnHesapEkle_ButtonClick(object sender, EventArgs e)
        {
            frmAdminPanel.ActiveForm.Height = 117;
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void tlStpBtnYardim_ButtonClick_1(object sender, EventArgs e)
        {
            frmAdminPanel.ActiveForm.Height = 117;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDestek frmdestek = new frmDestek();
            frmdestek.Show();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkimizdacs frmhakkimizda = new frmHakkimizdacs();
            frmhakkimizda.Show();
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


         

        public string dosyaYolu = "";

        private void btnExcelKaydet_Click(object sender, EventArgs e)
        {
            
           excelkaydet(); 
        
        }
        public void excelkaydet() { 
        
        string dosyaTarihi = DateTime.Now.ToShortDateString();
            saveFileDialog1.InitialDirectory = "C:\\BKM RESTORAN\\Z Raporları";
            saveFileDialog1.Title = "Raporun Kaydedileceği Yeri Seçin";
            saveFileDialog1.FileName = dosyaTarihi;
            saveFileDialog1.Filter = "Excel Files(2007)|*.xlsx";
            if (saveFileDialog1.ShowDialog()!=DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExceleGonder = new Microsoft.Office.Interop.Excel.Application();
                ExceleGonder.Application.Workbooks.Add(Type.Missing);
                ExceleGonder.Columns.ColumnWidth = 25;
                for (int i = 1; i < dtGridZRaporu.Columns.Count + 1; i++)
                {
                    ExceleGonder.Cells[1, i] = dtGridZRaporu.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < dtGridZRaporu.Rows.Count-1; i++)
                {
                    for (int j = 0; j < dtGridZRaporu.Columns.Count; j++)
                    {
                        ExceleGonder.Cells[i + 2, j + 1] = dtGridZRaporu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExceleGonder.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExceleGonder.ActiveWorkbook.Saved = true;
                dosyaYolu = saveFileDialog1.InitialDirectory.ToString();
                ExceleGonder.Quit();
                label1.Text = dosyaYolu;
                label1.Visible = true;
        }
   }
        private void button1_Click(object sender, EventArgs e)
        {
           
           string dosyaTarihi = DateTime.Now.ToShortDateString();
           if (label1.Text=="Kaydedilmedi")
           {
               MessageBox.Show("İlk önce dosyayı kaydedin.");
               excelkaydet();
           }
           string dosya = label1.Text;
         
            MailGonder("Lokantanın " +dosyaTarihi+" tarihli raporu", txtMesaj.Text, dosya );
            label4.Text = "Mail başarıyla gönderildi.";
            label4.Visible = true;
        }
        
        public void MailGonder(string konu, string mesaj, string dosya)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                MailMessage msg = new MailMessage();
                string[] mailler = txtKime.Lines;
                for (int i = 0; i < mailler.Length; i++)
                {
                    msg.CC.Add(mailler[i]);
                }

                string dosyaTarihi = DateTime.Now.ToShortDateString();
                string gidenDosya = dosya + "\\" + dosyaTarihi + ".xlsx";
                Attachment eklenecekdosya = new Attachment(gidenDosya);
                msg.Attachments.Add(eklenecekdosya);

                msg.From = new MailAddress("bkmRestoran@gmail.com", dosyaTarihi + " Tarihinin Z Raporu");
                msg.Subject = konu;
                msg.IsBodyHtml = true;
                msg.Body = mesaj;
                msg.BodyEncoding = System.Text.Encoding.GetEncoding(1254);

                NetworkCredential guvenlikKarti = new NetworkCredential("bkmRestoran@gmail.com", "bkm123456");
                client.Credentials = guvenlikKarti;
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu. Hata mesajı : "+ex.Message);
                
            }
            
        }

        private void btnRaporTemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eğer Evet'e tıklarsanız günlük rapor geri dönüştürülemez bir biçimde silinecektir.", "Silinme Uyarısı", MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }
                SqlCommand komut = new SqlCommand("DELETE FROM gunlukrapor", bag);
                komut.ExecuteNonQuery();
                if (bag.State != ConnectionState.Open)
                {
                    bag.Close();
                }
                listele();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
                listele();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmloglar frmlog = new frmloglar();
            frmlog.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeLokanta
{
    public partial class FormHesap : Form
    {
        public FormHesap()
        {
            InitializeComponent();
        }

        private void FormHesap_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdmin frmadmin = new formAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKullanici frmkullanici = new FormKullanici();
            frmkullanici.Show();
            this.Hide();
        }
    }
}

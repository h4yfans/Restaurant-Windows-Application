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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AcilisBar.Value < 100)
            {
                AcilisBar.Value += 5;
            }
            else
            {
                FormHesap frmhsp = new FormHesap();
                frmhsp.Show();
                timer1.Stop();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}

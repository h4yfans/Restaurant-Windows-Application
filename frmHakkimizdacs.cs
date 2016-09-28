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
    public partial class frmHakkimizdacs : Form
    {
        public frmHakkimizdacs()
        {
            InitializeComponent();
        }

        private void frmHakkimizdacs_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void frmHakkimizdacs_Load(object sender, EventArgs e)
        {

        }

        private void frmHakkimizdacs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                    this.Close();
         }
        }

        

        
    }
}

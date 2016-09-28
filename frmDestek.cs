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
    public partial class frmDestek : Form
    {
        public frmDestek()
        {
            InitializeComponent();
        }

        public void destekkapat() {
            this.Close();
           
        
        }

        

        private void frmDestek_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void frmDestek_Load(object sender, EventArgs e)
        {

        }

        private void frmDestek_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmDestek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               
                    destekkapat();
                    
                   
                
                
            }
        }

        private void frmDestek_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        
    }
}

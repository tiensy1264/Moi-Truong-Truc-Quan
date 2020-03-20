using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesign_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void picOff_Click(object sender, EventArgs e)
        {
            picOff.Visible = false;
            picOn.Visible = true;
            
                txtOn.Text = txtName.Text + ". Turn Off the Light, please! ";
            
           
        }

        private void picOn_Click(object sender, EventArgs e)
        {

            picOn.Visible = false;
            picOff.Visible = true;
           
            
                txtOn.Text = txtName.Text +"." +" Turn On the Light, please! ";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

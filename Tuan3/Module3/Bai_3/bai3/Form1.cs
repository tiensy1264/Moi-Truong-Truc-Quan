using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            txtChuVi.Text = "0";
            txtR.Text = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            double bk = Convert.ToDouble(txtR.Text);
            if (bk > 0)
            {
                btnChuVi.Enabled = true;
            }
            else
            {
                btnChuVi.Enabled = false;
            }
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            double bk = Convert.ToDouble(txtR.Text);
            txtChuVi.Text = (2 * Math.PI * bk).ToString();
        }
    }
}

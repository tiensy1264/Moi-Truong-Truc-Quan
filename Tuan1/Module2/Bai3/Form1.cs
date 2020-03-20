using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
             txtHoTen.Text = txtBHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtTen.Text;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtBHoLot.Text +" "+ txtTen.Text;
        }
    }
}

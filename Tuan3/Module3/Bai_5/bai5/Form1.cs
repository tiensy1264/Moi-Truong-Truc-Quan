using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tongSL=0;
        double TongTien =0;
        float TB;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSL.Clear();
            txtDG.Clear();
            txtTT.Clear();
            txtSL.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sl = Convert.ToInt32(txtSL.Text);
            double dg = Convert.ToInt32(txtDG.Text);
            tongSL += sl;
            double Thanhtien = sl * dg;
            TongTien += Thanhtien;
            txtTT.Text = Thanhtien.ToString();
            txtTSL.Text = tongSL.ToString();
            txtTongTien.Text = TongTien.ToString();
        }
    }
}

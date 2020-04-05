using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        int tongKH;
        int tongKHSV;
        double tongDoanhThu=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtSL.Clear();
            txtThanhtien.Clear();
            ckbSV.Checked = false;
            txtTenKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dg = 20000;
        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(txtSL.Text);
            double thanhtien = sl * dg;
            txtThanhtien.Text = thanhtien.ToString();
            tongDoanhThu += thanhtien;
            if (ckbSV.Checked)
            {
                tongKHSV ++;
            }
            tongKH++;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongKH.Text = tongKH.ToString();
            txtTongSV.Text = tongKHSV.ToString();
            txtTongDT.Text = tongDoanhThu.ToString();
        }
    }
}

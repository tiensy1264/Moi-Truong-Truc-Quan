using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinhBoi.Text = txtNhapTen.Text;
            //txtNhapTen.SelectionStart = 0;
            //txtNhapTen.Text = txtLapTrinhBoi.SelectedText;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbColor_Enter(object sender, EventArgs e)
        {
           
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Red;
            txtLapTrinhBoi.ForeColor = Color.Red;
        }

        private void rdbGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Green;
            txtLapTrinhBoi.ForeColor = Color.Green;
        }

        private void rdbBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Blue;
            txtLapTrinhBoi.ForeColor = Color.Blue;
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.ForeColor = Color.Black;
            txtLapTrinhBoi.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinhBoi.Font = new Font(txtLapTrinhBoi.Font.Name, txtLapTrinhBoi.Font.Size, txtLapTrinhBoi.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinhBoi.Font = new Font(txtLapTrinhBoi.Font.Name, txtLapTrinhBoi.Font.Size, txtLapTrinhBoi.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinhBoi.Font = new Font(txtLapTrinhBoi.Font.Name, txtLapTrinhBoi.Font.Size, txtLapTrinhBoi.Font.Style ^ FontStyle.Underline);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtLapTrinhBoi_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

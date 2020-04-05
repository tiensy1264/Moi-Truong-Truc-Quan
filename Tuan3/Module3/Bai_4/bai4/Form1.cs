using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radBac1_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "ax+b";
            txtC.Visible = false;
            lblc.Visible = false;
            lblx2.Text = "x :";
            lblx1.Visible = false;
            txtx1.Visible = false;
            lblKQ.Text="";
            txtA.Clear();
            txtB.Clear();
            txtx1.Clear();
            txtx2.Clear();
            txtA.Focus();
        }

        private void radBac2_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "ax2+bx+c";
            txtC.Visible = true;
            lblc.Visible = true;
            lblx2.Text = "x2 :";
            lblx1.Visible = true;
            txtx1.Visible = true;
            lblKQ.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtA.Focus();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtA.Focus();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            
            if (radBac2.Checked)
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                double denta;
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            lblKQ.Text = "phương trình có vô số nghiệm";
                            lblTitle.Text = txtA.Text + "x2 +" + txtB.Text + "x +" + txtC.Text;
                            

                        }
                        else
                        {
                            txtx1.Text = "#########";
                            txtx2.Text = "#########";
                            lblKQ.Text = "phương trình vô nghiệm";
                            lblTitle.Text =txtB.Text + "x +" + txtC.Text;
                            
                        }
                    }
                    else
                    {
                        lblKQ.Text = "Nghiệm của phuong trình là :";
                        txtx2.Text = ((float)-c / b).ToString();
                    }
                }
                else
                {
                    denta = b * b - 4 * a * c;
                    if (denta > 0)
                    {
                        lblTitle.Text = txtA.Text + "x2 +" + txtB.Text + "x +" + txtC.Text;
                        lblKQ.Text = "phương trình có 2 nghiệm phân biệt";
                        txtx1.Text = ((float)(-b - Math.Sqrt(denta)) / (2 * a)).ToString();
                        txtx2.Text = ((float)(-b + Math.Sqrt(denta)) / (2 * a)).ToString();
                    }
                    else if (denta == 0)
                    {
                        lblTitle.Text = txtA.Text + "x2 +" + txtB.Text + "x +" + txtC.Text;
                        lblx1.Visible = false;
                        txtx1.Visible = false;
                        lblKQ.Text = "phương trình có nghiệm kép";
                        lblx2.Text = "x :";
                        txtx2.Text = ((float)(-b) / (2 * a)).ToString();

                    }
                    else
                    {
                        lblTitle.Text = txtA.Text + "x2 +" + txtB.Text + "x +" + txtC.Text;
                        lblKQ.Text = "phương trình vô nghiệm ";
                    }
                }
            }else if (radBac1.Checked)
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {

                        lblKQ.Text = "phương trình có vô số nghiệm";

                    }
                    else
                    {
                        lblKQ.Text = "phương trình vô nghiệm";
                        txtx2.Text = "#########";
                        lblTitle.Text = txtA.Text + "x +" + txtB.Text;
                        
                    }
                }
                else
                {
                    lblKQ.Text = "Nghiệm của phuong trình là :";
                    lblTitle.Text = txtA.Text + "x +" + txtB.Text;
                    txtx2.Text = ((float)-b / a).ToString();
                }
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA.Focus();
        }
    }
}

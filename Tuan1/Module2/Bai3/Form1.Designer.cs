namespace Bai3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.txtBHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(106, 178);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(75, 23);
            this.btnHoLot.TabIndex = 0;
            this.btnHoLot.Text = "Ho Lot";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(325, 177);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 1;
            this.btnTen.Text = "Ten";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(517, 177);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoVaTen.TabIndex = 2;
            this.btnHoVaTen.Text = "Ho Va Ten";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(291, 229);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(151, 41);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Location = new System.Drawing.Point(106, 54);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(39, 13);
            this.lblHoLot.TabIndex = 4;
            this.lblHoLot.Text = "Ho Lot";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(106, 94);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(29, 13);
            this.lblten.TabIndex = 5;
            this.lblten.Text = "Ten ";
            // 
            // txtBHoLot
            // 
            this.txtBHoLot.Location = new System.Drawing.Point(179, 47);
            this.txtBHoLot.Name = "txtBHoLot";
            this.txtBHoLot.Size = new System.Drawing.Size(413, 20);
            this.txtBHoLot.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(413, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(179, 13);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(413, 20);
            this.txtHoTen.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtBHoLot);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Name = "Form1";
            this.Text = "Bai Tap Ho Ten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox txtBHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}


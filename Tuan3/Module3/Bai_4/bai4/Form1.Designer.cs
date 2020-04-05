namespace bai4
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
            this.grPT = new System.Windows.Forms.GroupBox();
            this.radBac1 = new System.Windows.Forms.RadioButton();
            this.radBac2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbla = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grkq = new System.Windows.Forms.GroupBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.lblx2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grPT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grkq.SuspendLayout();
            this.SuspendLayout();
            // 
            // grPT
            // 
            this.grPT.Controls.Add(this.radBac2);
            this.grPT.Controls.Add(this.radBac1);
            this.grPT.Location = new System.Drawing.Point(12, 12);
            this.grPT.Name = "grPT";
            this.grPT.Size = new System.Drawing.Size(87, 62);
            this.grPT.TabIndex = 0;
            this.grPT.TabStop = false;
            this.grPT.Text = "Phuong Trình";
            // 
            // radBac1
            // 
            this.radBac1.AutoSize = true;
            this.radBac1.Checked = true;
            this.radBac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBac1.Location = new System.Drawing.Point(7, 20);
            this.radBac1.Name = "radBac1";
            this.radBac1.Size = new System.Drawing.Size(58, 17);
            this.radBac1.TabIndex = 0;
            this.radBac1.TabStop = true;
            this.radBac1.Text = "Bậc 1";
            this.radBac1.UseVisualStyleBackColor = true;
            this.radBac1.CheckedChanged += new System.EventHandler(this.radBac1_CheckedChanged);
            // 
            // radBac2
            // 
            this.radBac2.AutoSize = true;
            this.radBac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBac2.Location = new System.Drawing.Point(7, 43);
            this.radBac2.Name = "radBac2";
            this.radBac2.Size = new System.Drawing.Size(58, 17);
            this.radBac2.TabIndex = 1;
            this.radBac2.Text = "Bậc 2";
            this.radBac2.UseVisualStyleBackColor = true;
            this.radBac2.CheckedChanged += new System.EventHandler(this.radBac2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.lblc);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.lblb);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.lbla);
            this.groupBox1.Location = new System.Drawing.Point(141, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chỉ số";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(19, 18);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(22, 13);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "a :";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(60, 15);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(60, 42);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(19, 45);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(22, 13);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "b :";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(60, 68);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 5;
            this.txtC.Text = "0";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtC.Visible = false;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(19, 71);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(22, 13);
            this.lblc.TabIndex = 4;
            this.lblc.Text = "c :";
            this.lblc.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ax+b";
            // 
            // grkq
            // 
            this.grkq.Controls.Add(this.lblKQ);
            this.grkq.Controls.Add(this.txtx2);
            this.grkq.Controls.Add(this.lblx2);
            this.grkq.Controls.Add(this.txtx1);
            this.grkq.Controls.Add(this.lblx1);
            this.grkq.Location = new System.Drawing.Point(12, 123);
            this.grkq.Name = "grkq";
            this.grkq.Size = new System.Drawing.Size(302, 77);
            this.grkq.TabIndex = 3;
            this.grkq.TabStop = false;
            this.grkq.Text = "Kết quả :";
            // 
            // txtx1
            // 
            this.txtx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx1.Location = new System.Drawing.Point(49, 45);
            this.txtx1.Name = "txtx1";
            this.txtx1.ReadOnly = true;
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 7;
            this.txtx1.TabStop = false;
            this.txtx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtx1.Visible = false;
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx1.Location = new System.Drawing.Point(15, 48);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(28, 13);
            this.lblx1.TabIndex = 6;
            this.lblx1.Text = "x1 :";
            this.lblx1.Visible = false;
            // 
            // txtx2
            // 
            this.txtx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx2.Location = new System.Drawing.Point(189, 45);
            this.txtx2.Name = "txtx2";
            this.txtx2.ReadOnly = true;
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 9;
            this.txtx2.TabStop = false;
            this.txtx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx2.Location = new System.Drawing.Point(155, 48);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(21, 13);
            this.lblx2.TabIndex = 8;
            this.lblx2.Text = "x :";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(51, 20);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 13);
            this.lblKQ.TabIndex = 10;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(19, 206);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 4;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(120, 206);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp tục";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(226, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(326, 252);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.grkq);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grPT);
            this.Name = "Form1";
            this.Text = "Giải Phương Trình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grPT.ResumeLayout(false);
            this.grPT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grkq.ResumeLayout(false);
            this.grkq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grPT;
        private System.Windows.Forms.RadioButton radBac2;
        private System.Windows.Forms.RadioButton radBac1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grkq;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnClose;
    }
}


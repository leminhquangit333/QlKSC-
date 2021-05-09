namespace Phan_Mem_Quan_Ly_Khach_San
{
    partial class ThueTheoGio
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nbPhutDat = new System.Windows.Forms.NumericUpDown();
            this.nbGioDat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.NgayTra = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.NgayDat = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nbPhutTra = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nbGioTra = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhutDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGioDat)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhutTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGioTra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(105, 407);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 39);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 39);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nbPhutDat);
            this.panel6.Controls.Add(this.nbGioDat);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(27, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 46);
            this.panel6.TabIndex = 4;
            // 
            // nbPhutDat
            // 
            this.nbPhutDat.Location = new System.Drawing.Point(325, 15);
            this.nbPhutDat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbPhutDat.Name = "nbPhutDat";
            this.nbPhutDat.Size = new System.Drawing.Size(47, 22);
            this.nbPhutDat.TabIndex = 0;
            // 
            // nbGioDat
            // 
            this.nbGioDat.Location = new System.Drawing.Point(174, 15);
            this.nbGioDat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nbGioDat.Name = "nbGioDat";
            this.nbGioDat.Size = new System.Drawing.Size(47, 22);
            this.nbGioDat.TabIndex = 0;
            this.nbGioDat.ValueChanged += new System.EventHandler(this.nbGioDat_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giờ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vào Lúc:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtCMND);
            this.panel5.Location = new System.Drawing.Point(27, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 46);
            this.panel5.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "CMND/Passport:";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(174, 13);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(254, 23);
            this.txtCMND.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.NgayTra);
            this.panel4.Location = new System.Drawing.Point(27, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 46);
            this.panel4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Ra:";
            // 
            // NgayTra
            // 
            this.NgayTra.Enabled = false;
            this.NgayTra.Location = new System.Drawing.Point(174, 10);
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Size = new System.Drawing.Size(200, 22);
            this.NgayTra.TabIndex = 0;
            this.NgayTra.ValueChanged += new System.EventHandler(this.NgayTra_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NgayDat);
            this.panel2.Location = new System.Drawing.Point(27, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 46);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày vào:";
            // 
            // NgayDat
            // 
            this.NgayDat.Enabled = false;
            this.NgayDat.Location = new System.Drawing.Point(174, 10);
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Size = new System.Drawing.Size(200, 22);
            this.NgayDat.TabIndex = 0;
            this.NgayDat.ValueChanged += new System.EventHandler(this.NgayDat_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTenKH);
            this.panel3.Location = new System.Drawing.Point(27, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 46);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(174, 15);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(257, 23);
            this.txtTenKH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 46);
            this.panel1.TabIndex = 9;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(190, 11);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(45, 25);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nbPhutTra);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.nbGioTra);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(27, 272);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(469, 46);
            this.panel7.TabIndex = 4;
            // 
            // nbPhutTra
            // 
            this.nbPhutTra.Enabled = false;
            this.nbPhutTra.Location = new System.Drawing.Point(325, 9);
            this.nbPhutTra.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbPhutTra.Name = "nbPhutTra";
            this.nbPhutTra.Size = new System.Drawing.Size(47, 22);
            this.nbPhutTra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giờ";
            // 
            // nbGioTra
            // 
            this.nbGioTra.Enabled = false;
            this.nbGioTra.Location = new System.Drawing.Point(174, 10);
            this.nbGioTra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nbGioTra.Name = "nbGioTra";
            this.nbGioTra.Size = new System.Drawing.Size(47, 22);
            this.nbGioTra.TabIndex = 0;
            this.nbGioTra.ValueChanged += new System.EventHandler(this.nbGioTra_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phút";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ra Lúc:";
            // 
            // ThueTheoGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 548);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ThueTheoGio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThueTheoGio";
            this.Load += new System.EventHandler(this.ThueTheoGio_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhutDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGioDat)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhutTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGioTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker NgayTra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker NgayDat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nbPhutDat;
        private System.Windows.Forms.NumericUpDown nbGioDat;
        private System.Windows.Forms.NumericUpDown nbPhutTra;
        private System.Windows.Forms.NumericUpDown nbGioTra;
    }
}
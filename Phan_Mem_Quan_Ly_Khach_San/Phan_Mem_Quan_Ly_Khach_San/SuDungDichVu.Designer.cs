namespace Phan_Mem_Quan_Ly_Khach_San
{
    partial class SuDungDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCancelSer = new System.Windows.Forms.Button();
            this.cboTenDV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(156, 90);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(216, 22);
            this.txtSL.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(111, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 31);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCancelSer
            // 
            this.btnCancelSer.Location = new System.Drawing.Point(291, 172);
            this.btnCancelSer.Name = "btnCancelSer";
            this.btnCancelSer.Size = new System.Drawing.Size(81, 31);
            this.btnCancelSer.TabIndex = 3;
            this.btnCancelSer.Text = "Cancel";
            this.btnCancelSer.UseVisualStyleBackColor = true;
            this.btnCancelSer.Click += new System.EventHandler(this.btnCancelSer_Click);
            // 
            // cboTenDV
            // 
            this.cboTenDV.FormattingEnabled = true;
            this.cboTenDV.Location = new System.Drawing.Point(157, 30);
            this.cboTenDV.Name = "cboTenDV";
            this.cboTenDV.Size = new System.Drawing.Size(215, 24);
            this.cboTenDV.TabIndex = 4;
            // 
            // SuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 226);
            this.Controls.Add(this.cboTenDV);
            this.Controls.Add(this.btnCancelSer);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SuDungDichVu";
            this.Text = "Thêm Dịch Vụ Cho Phòng";
            this.Load += new System.EventHandler(this.SuDungDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCancelSer;
        private System.Windows.Forms.ComboBox cboTenDV;
    }
}
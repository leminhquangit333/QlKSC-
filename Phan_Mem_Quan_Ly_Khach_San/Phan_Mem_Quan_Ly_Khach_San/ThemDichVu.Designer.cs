namespace Phan_Mem_Quan_Ly_Khach_San
{
    partial class ThemDichVu
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
            this.txtNameSer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoteSer = new System.Windows.Forms.RichTextBox();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnCancelSer = new System.Windows.Forms.Button();
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
            // txtNameSer
            // 
            this.txtNameSer.Location = new System.Drawing.Point(156, 29);
            this.txtNameSer.Name = "txtNameSer";
            this.txtNameSer.Size = new System.Drawing.Size(216, 22);
            this.txtNameSer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(156, 71);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi Chú:";
            // 
            // txtNoteSer
            // 
            this.txtNoteSer.Location = new System.Drawing.Point(157, 117);
            this.txtNoteSer.Name = "txtNoteSer";
            this.txtNoteSer.Size = new System.Drawing.Size(216, 161);
            this.txtNoteSer.TabIndex = 2;
            this.txtNoteSer.Text = "";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(197, 295);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(96, 31);
            this.btnThemSua.TabIndex = 3;
            this.btnThemSua.Text = "Thêm";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnCancelSer
            // 
            this.btnCancelSer.Location = new System.Drawing.Point(305, 295);
            this.btnCancelSer.Name = "btnCancelSer";
            this.btnCancelSer.Size = new System.Drawing.Size(81, 31);
            this.btnCancelSer.TabIndex = 3;
            this.btnCancelSer.Text = "Cancel";
            this.btnCancelSer.UseVisualStyleBackColor = true;
            this.btnCancelSer.Click += new System.EventHandler(this.btnCancelSer_Click);
            // 
            // ThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.btnCancelSer);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.txtNoteSer);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameSer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ThemDichVu";
            this.Text = "Thêm Dịch Vụ Mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNoteSer;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnCancelSer;
    }
}
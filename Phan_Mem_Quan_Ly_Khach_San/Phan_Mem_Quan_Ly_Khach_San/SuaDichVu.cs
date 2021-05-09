using Controrler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_Khach_San
{
    public partial class SuaDichVu : Form
    {
        private string tenDV;
        private string gia;
        private string thongTin;

        public SuaDichVu()
        {
            InitializeComponent();
        }
        AccountController controller = new AccountController();
        int ID = -1;
        public SuaDichVu(string tenDV, string gia, string thongTin)
        {
            InitializeComponent();
            this.tenDV = tenDV;
            this.gia = gia;
            this.thongTin = thongTin;
            // lấy ID để update
            ID = controller.GetIDDV(tenDV, gia, thongTin);

            

        }

        private void SuaDichVu_Load(object sender, EventArgs e)
        {
            txtNameSer.Text = this.tenDV;
            txtPrice.Text = this.gia;
            txtNoteSer.Text = this.thongTin;
        }

        private void btnCancelSer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!(txtPrice.Text.Equals("") || txtNoteSer.Text.Equals("") || txtNameSer.Text.Equals("")))
            {
                if (isNumber(txtPrice.Text))
                {
                    if (controller.UpdateDV(ID, txtNameSer.Text, txtPrice.Text, txtNoteSer.Text))
                    {
                        MessageBox.Show("Update Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Update Thất bại do lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Giá là số");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
            }
           
 
        }
        public bool isNumber(string str)
        {
            foreach (Char c in str)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}

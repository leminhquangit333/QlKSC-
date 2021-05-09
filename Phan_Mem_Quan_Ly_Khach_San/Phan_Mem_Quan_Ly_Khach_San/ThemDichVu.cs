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
    public partial class ThemDichVu : Form
    {
        public ThemDichVu()
        {
            InitializeComponent();
        }
        AccountController controller = new AccountController();

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtNameSer.Text.Equals("") || txtPrice.Text.Equals("") || txtNoteSer.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (isNumber(txtPrice.Text))
                {
                    if (controller.ThemDichVu(txtNameSer.Text, txtPrice.Text, txtNoteSer.Text))
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Giá là số!!");
                }
            }
          

        }

        private void btnCancelSer_Click(object sender, EventArgs e)
        {
            this.Close();
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

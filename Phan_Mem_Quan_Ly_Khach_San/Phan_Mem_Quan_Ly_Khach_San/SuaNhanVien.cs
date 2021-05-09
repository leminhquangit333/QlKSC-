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
    public partial class SuaNhanVien : Form
    {
        private string nvTaiKhoan;
        private string nvTenNV;
        private string nvMaNV;
        private string nvCMND;
        private string nvNhomQuyen;

        public SuaNhanVien()
        {
            InitializeComponent();
        }
        AccountController controller = new AccountController();
        public SuaNhanVien(string nvTaiKhoan, string nvTenNV, string nvMaNV, string nvCMND, string nvNhomQuyen)
        {
            InitializeComponent();
            this.nvTaiKhoan = nvTaiKhoan;
            this.nvTenNV = nvTenNV;
            this.nvMaNV = nvMaNV;
            this.nvCMND = nvCMND;
            this.nvNhomQuyen = nvNhomQuyen;
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            string pass = controller.GetPass(nvMaNV);
            txtUserName.Text = nvTaiKhoan;
            txtFullName.Text = nvTenNV;
            txtCMND.Text = nvCMND;
            txtPass.Text = pass;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!(txtFullName.Equals("") || txtPass.Text.Equals("") || txtCMND.Text.Equals(""))){
                if (isNumber(txtCMND.Text))
                {
                    if (controller.UpdateNV(txtUserName.Text, txtPass.Text, txtFullName.Text, Convert.ToInt32(txtCMND.Text)))
                    {
                        MessageBox.Show("Update Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("CMND là số");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
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

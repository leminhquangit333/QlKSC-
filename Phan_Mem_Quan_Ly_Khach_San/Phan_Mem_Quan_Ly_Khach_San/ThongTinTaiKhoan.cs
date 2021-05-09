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
    public partial class ThongTinTaiKhoan : Form
    {
        private string userName;

        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        public ThongTinTaiKhoan(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        AccountController controller = new AccountController();
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            // lấy thông tin của account 
            string[,] info = controller.GetInfo(userName);
            txtUserName.Text = userName;
            txtFullName.Text = info[0,0].ToString();
            txtCMND.Text = info[0, 1].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hoTen = txtFullName.Text;
            int cMND = Convert.ToInt32(txtCMND.Text);
            string matKhau = txtPW.Text;
            if (txtPW.Text.Equals(""))
            {
                //cap nhat ten va CMND thôi
                if (controller.UpdateNV(userName, hoTen, cMND))
                {
                    MessageBox.Show("Update Thành Công!!!");
                }
                else
                {
                    MessageBox.Show("Lỗi Update!!!");
                }
            }
            else
            {
                //kiểm tra pw vaf retypePw coi giống nhau không
                if (txtPW.Text.Equals(txtRePW.Text))
                {
                    //cap nhat ca mat khau nua
                    if (controller.UpdateNV(userName,matKhau, hoTen, cMND))
                    {
                        MessageBox.Show("Update Thành Công!!!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Update!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không giống nhau");
                    txtPW.Focus();
                }
            }
        }
    }
}

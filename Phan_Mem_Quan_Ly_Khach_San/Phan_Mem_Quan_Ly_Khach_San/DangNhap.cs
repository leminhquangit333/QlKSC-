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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            panel4.Location = new Point(0,0);
        }
        AccountController controller = new AccountController();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string userName = "";
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình không", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                this.Show();
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (controller.CheckAccount(txtUserName.Text, txtPW.Text)==0){
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu!");
            }
            else
            {
                if(controller.CheckAccount(txtUserName.Text, txtPW.Text) == 1)
                {
                    MessageBox.Show("Thành công admin!");
                    userName = txtUserName.Text;
                    txtPW.Text = "";
                    GiaoDienChinh gdc = new GiaoDienChinh(1,this);
                    this.Hide();
                    gdc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thành công Nhân Viên!");
                    userName = txtUserName.Text;
                    txtPW.Text = "";
                    GiaoDienChinh gdc = new GiaoDienChinh(2,this);
                    this.Hide();
                    gdc.ShowDialog();
                }
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
        //thay ddooir kichs thuoc
        private void DangNhap_Resize(object sender, EventArgs e)
        {
            panel4.Location=new Point(Width/2-panel4.Width/2 , this.Height/2-panel4.Height/2 );
        }
    }
}

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
    public partial class ThemNhanVien : Form
    {
        int sTT;
        int loai=-1;
        string maNV;
        public ThemNhanVien()
        {
            InitializeComponent();
        }
        //truyền mã nhân viên tiếp theo vào
        public ThemNhanVien(int sTT)
        {
            InitializeComponent();
            //Ma nv tiếp theo sẽ tăng 1
            this.sTT = sTT +1;
        }
        AccountController controller = new AccountController();
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cboLoai.Text.Equals("Nhân Viên"))
            {

                maNV = "NV" + sTT;
                loai = 2;
            }
            else
            {
                maNV = "BV" + sTT;
                loai = 3;
            }
            if (controller.ThemNV(txtUserName.Text, txtPass.Text, txtFullName.Text, Convert.ToInt32(txtCMND.Text), maNV, loai))
            {
                MessageBox.Show("Thêm Thành Công!");
                txtUserName.Text = "";
                txtPass.Text = "";
                txtFullName.Text = "";
                txtCMND.Text = "";
                sTT++;
                loai = -1;

            }
            else
            {
                MessageBox.Show("Không Thêm Được Do Lỗi");
            }
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            cboLoai.SelectedIndex = 1;
        }
    }
}

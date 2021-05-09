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
    public partial class DatPhong : Form
    {
        private string here;

        public DatPhong()
        {
            InitializeComponent();
        }

        public DatPhong(string here)
        {
            InitializeComponent();
            this.here = here;
        }
        AccountController controller = new AccountController();
        private void DatPhong_Load(object sender, EventArgs e)
        {
            string kieuThue = "Ngay";
            this.Text = here;
            lblGia.Text = controller.GetPrice(here, kieuThue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void NgayDat_ValueChanged(object sender, EventArgs e)
        {

            //Ngày đặt phải lớn hơn ngày hiện tại
            if (NgayDat.Value.Date < System.DateTime.Today.Date)
            {
                MessageBox.Show("Phải đặt trước ngày hiện tại!!");
            }
            else
            {
                // kiem tra ngay dat gan nhat neu ngày trả của ngày đặt gần nhất mà bé hơn ngày mình chọn thì tức là phòng đó chưa được đặt
                if (controller.KiemTraNgayDat(NgayDat.Value.Date, here))
                {
                    NgayTra.Enabled = true;
                }
                else
                {
                    NgayTra.Enabled = false;
                    MessageBox.Show("Ngày này Phòng đã được đặt nhân viên vui lòng xem thông tin tại tab khách hàng để dễ dàng tư vấn");
                }
            }

        }

        private void NgayTra_ValueChanged(object sender, EventArgs e)
        {
            // ngày trả phải lớn hơn ngày đặt
            if (NgayDat.Value.Date < NgayTra.Value.Date)
            {
                // kiểm tra với ngày trả gần nhất nếu ngày đặt của nó lớn hơn ngày trả hiện tại thì phòng trống và cho đặt
                if (controller.KiemTraNgayTra(NgayTra.Value.Date,here))
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                    MessageBox.Show("Ngày này Phòng đã được đặt nhân viên vui lòng xem thông tin tại tab khách hàng để dễ dàng tư vấn");
                }
            }
            else
            {
                btnOk.Enabled = false;
                MessageBox.Show("Ngày Trả Phải lớn hơn ngày đặt");
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!(txtCMND.Text.Equals("")|| txtSDT.Text.Equals("")|| txtDatCoc.Text.Equals("") || txtTenKH.Equals("")))
            {
                if (isNumber(txtCMND.Text))
                {
                    if (isNumber(txtSDT.Text))
                    {
                        if (isNumber(txtDatCoc.Text))
                        {
                            int IDKH = controller.GetIDKH(Convert.ToInt32(txtCMND.Text));
                            string IDNV = controller.GetIDNV(DangNhap.userName);
                            if (IDKH == -1)
                            {
                                if (controller.AddKH(txtTenKH.Text, Convert.ToInt32(txtSDT.Text), Convert.ToInt32(txtCMND.Text)))
                                {
                                    IDKH = controller.GetIDKH(Convert.ToInt32(txtCMND.Text));
                                }
                                else
                                {
                                    MessageBox.Show("Có Lỗi Vui Lòng Liên Hệ Với Quản Trị Hệ Thống!!!");
                                }

                            }
                            else
                            {
                                if (controller.DatPhong(IDKH, IDNV, NgayDat.Value.Date, NgayTra.Value.Date, Convert.ToInt64(txtDatCoc.Text), Convert.ToInt32(here), 1))
                                {
                                    MessageBox.Show("Đặt Phòng Thành Công");
                                }
                                else
                                {
                                    MessageBox.Show("Có Lỗi Vui Lòng Liên Hệ Với Quản Trị Hệ Thống!!!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đặt cọc là số");
                        }
                    }
                    else
                    {
                        MessageBox.Show("SĐT là số");
                    }
                }
                else
                {
                    MessageBox.Show("CMND là số");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
           
        }
        //Hàm kiểm tra là số
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

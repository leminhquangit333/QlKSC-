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
    public partial class ThueTheoGio : Form
    {
        private string here;

        public ThueTheoGio()
        {
            InitializeComponent();
        }

        public ThueTheoGio(string here)
        {
            InitializeComponent();
            this.here = here;
        }
        AccountController controller = new AccountController();
        private void ThueTheoGio_Load(object sender, EventArgs e)
        {
            //load giá nữa
            string kieuThue = "Gio";
            lblGia.Text = controller.GetPrice(here, kieuThue);
            this.Text = here;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //biến này để lưu lại ngày giờ đặt
        DateTime ngayGioDat;
        private void NgayDat_ValueChanged(object sender, EventArgs e)
        {
            string gioDat =" "+ nbGioDat.Value + ":" + nbPhutDat.Value + ":00";
            if (NgayDat.Value.Date < System.DateTime.Today.Date)
            {
                MessageBox.Show("Phải đặt trước ngày hiện tại!!");
            }
            else
            {
                string[] ngay = NgayDat.Value.Date.ToString().Split(' ');
                gioDat = ngay[0] + gioDat;
                ngayGioDat =Convert.ToDateTime(gioDat);
                // kiem tra ngay dat gan nhat neu ngày trả của ngày đặt gần nhất mà bé hơn ngày mình chọn thì tức là phòng đó chưa được đặt
                if (controller.KiemTraNgayDat(ngayGioDat, here))
                {
                    nbGioTra.Enabled = true;
                    nbPhutTra.Enabled = true;
                }
                else
                {
                    NgayTra.Enabled = false;
                    MessageBox.Show("Phòng đã được đặt vào giờ này nhân viên vui lòng xem thông tin tại tab khách hàng để dễ dàng tư vấn");
                }
            }
        }
        //biến này dùng để lưu lại ngày giờ trả
        DateTime ngayGioTra;
        private void NgayTra_ValueChanged(object sender, EventArgs e)
        {
            string gioTra = " "+ nbGioTra.Value + ":" + nbPhutTra.Value + ":00";
            if (NgayDat.Value.Date < NgayTra.Value.Date)
            {
                string[] ngay = NgayTra.Value.Date.ToString().Split(' ');
                gioTra = ngay[0]+gioTra;
                ngayGioTra = Convert.ToDateTime(gioTra);
                // kiểm tra với ngày trả gần nhất nếu ngày đặt của nó lớn hơn ngày trả hiện tại thì phòng trống và cho đặt
                if (controller.KiemTraNgayTra(ngayGioTra, here))
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                    MessageBox.Show("Phòng đã được đặt vào lúc này nhân viên vui lòng xem thông tin tại tab khách hàng để dễ dàng tư vấn");
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
            int IDKH = controller.GetIDKH(Convert.ToInt32(txtCMND.Text));
            string IDNV = controller.GetIDNV(DangNhap.userName);
            if (IDKH == -1)
            {
                if (controller.AddKH(txtTenKH.Text,0, Convert.ToInt32(txtCMND.Text)))
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
                if (controller.DatPhong(IDKH, IDNV, ngayGioDat, ngayGioTra, 0, Convert.ToInt32(here),2))
                {
                    MessageBox.Show("Đặt Phòng Thành Công");
                }
            }
        }

        private void nbGioDat_ValueChanged(object sender, EventArgs e)
        {
            NgayDat.Enabled = true;
        }

        private void nbGioTra_ValueChanged(object sender, EventArgs e)
        {
            NgayTra.Enabled = true;
        }
    }
}

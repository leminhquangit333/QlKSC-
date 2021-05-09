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
    public partial class ThanhToanPhong : Form
    {
        private string here;

        public ThanhToanPhong()
        {
            InitializeComponent();
        }

        public ThanhToanPhong(string here)
        {
            InitializeComponent();
            this.here = here;
        }
        AccountController controller = new AccountController();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //in hoa don

            //cap nhat database
            if (controller.ThemHoaDon(Convert.ToInt32(here), controller.GetIDNV(DangNhap.userName), DateTime.Today.Date, Convert.ToDecimal(lblTongTien.Text)))
            {
                MessageBox.Show("Thanh Toán Thành Công");
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            else
            {
                MessageBox.Show("Lỗi Hệ Thống!!!");
            }
      
        }

        private void ThanhToanPhong_Load(object sender, EventArgs e)
        {
            string[,] thanhToan = controller.ThanhToan(Convert.ToInt32(here));
            lblTienDichVu.Text = thanhToan[0, 0];
            lblTenKhachHang.Text = thanhToan[0, 1];
            lblNgayVao.Text = thanhToan[0, 2];
            lblNgayTra.Text = thanhToan[0, 3];
            lblDatCoc.Text = thanhToan[0, 4];
            lblGiaPhong.Text = thanhToan[0, 5];
            lblTienPhong.Text = thanhToan[0, 6];
            lblTongTien.Text = (Convert.ToInt64(lblTienPhong.Text) + Convert.ToInt64(lblTienDichVu.Text) - Convert.ToInt64(lblDatCoc.Text)).ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\t\t\tHóa Đơn\n\tTên Khách Hàng: " + lblTenKhachHang.Text + "\n\tNgày Vào:" + lblNgayVao.Text + "\n\tNgày Trả:" + lblNgayTra.Text + "\n\tGiá Phòng:" + lblGiaPhong.Text  + "\n\tTiền Phòng:" + lblTienPhong.Text + "\n\tĐặt Cọc:" + lblDatCoc.Text + "\n\tTiền Dịch Vụ:" + lblTienDichVu.Text + "\n\t\tTổng thanh toán:" + lblTongTien.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 180));
        }
    }
}

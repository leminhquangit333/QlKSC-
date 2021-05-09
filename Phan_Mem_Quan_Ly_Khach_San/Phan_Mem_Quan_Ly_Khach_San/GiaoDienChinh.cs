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
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }
        DangNhap dangNhap;
        public GiaoDienChinh(int v,DangNhap dangNhap)
        {
            this.dangNhap = dangNhap;
            InitializeComponent();
            // v là loại tài khoản
            //Nếu là loại 2 thì k hiện tab thống kê, đơn giá dịch vụ, Nhân viên
            if (v == 2)
            {
                tabControlMnu.TabPages.Remove(tabDonGia);
                tabControlMnu.TabPages.Remove(tabThongKe);
                tabControlMnu.TabPages.Remove(tabNhanVien);
            }
        }
        //biến này dùng để lấy tọa độ tại pnl Phòng nào mục đích hiện menu cho đúng chỗ
        Point pt;
        // biến này để lưu bạn đang click phải vào phòng nào 
        string here = "";
        //COntroller 
        AccountController controller = new AccountController();

        private void pnl101_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pt = pnl101.Location;
                here = "101";
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }
        private void pnl102_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "102";
                pt = pnl102.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl103_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "103";
                pt = pnl103.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl104_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "104";
                pt = pnl104.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl105_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "105";
                pt = pnl105.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }


        private void pnl201_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "201";
                pt = pnl201.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl202_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "202";
                pt = pnl202.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl203_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "203";
                pt = pnl203.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl204_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "204";
                pt = pnl204.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl205_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "205";
                pt = pnl205.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }


        private void pnl301_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "301";
                pt = pnl301.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl302_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "302";
                pt = pnl302.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl303_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "303";
                pt = pnl303.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl304_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "304";
                pt = pnl304.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl305_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "305";
                pt = pnl305.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }


        private void pnl401_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "401";
                pt = pnl401.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl402_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "402";
                pt = pnl402.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl403_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "403";
                pt = pnl403.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl404_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "404";
                pt = pnl404.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl405_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "405";
                pt = pnl405.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }


        private void pnl501_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "501";
                pt = pnl501.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl502_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "502";
                pt = pnl502.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl503_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "503";
                pt = pnl503.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl504_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "504";
                pt = pnl504.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl505_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "505";
                pt = pnl505.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }


        private void pnl601_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "601";
                pt = pnl601.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl602_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "602";
                pt = pnl602.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl603_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "603";
                pt = pnl603.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl604_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "604";
                pt = pnl604.Location;
                mnuRightClick.Show(this, new Point(pt.X + 400, pt.Y + 95));
            }
        }

        private void pnl605_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                here = "605";
                pt = pnl605.Location;
                mnuRightClick.Show(this, new Point(pt.X+400, pt.Y+95));
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            dangNhap.Show();
            this.Close();
        }
// SỰ kiện tab control
        private void tabControlMnu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMnu.SelectedTab == tabSoDo)
            {
                LoadRooms(NgayXem.Value);
            }
            if (tabControlMnu.SelectedTab == tabDonGia)
            {
                string[,] dichVu = controller.LoadDichVu();
                BindDichVu(dichVu);
            }
            if (tabControlMnu.SelectedTab == tabThongKe)
            {
                string[,] thongKe = controller.LoadThongKe();
                BindThongKe(thongKe);
            }
            if (tabControlMnu.SelectedTab == tabKhachHang)
            {
                string[,] khachHang = controller.LoadKhachHang();
                BindKhachHang(khachHang);
            }
            if (tabControlMnu.SelectedTab == tabNhanVien)
            {
                string[,] nhanVien = controller.LoadNhanVien(DangNhap.userName);
                BindNhanVien(nhanVien);
            }
        }

        private void BindThongKe(string[,] thongKe)
        {
            dgvThongKe.Rows.Clear();
            for (int i = 0; i < thongKe.GetLength(0); i++)
            {
                dgvThongKe.Rows.Add();
                dgvThongKe.Rows[i].Cells[0].Value = i + 1;
                dgvThongKe.Rows[i].Cells[1].Value = thongKe[i, 0];
                dgvThongKe.Rows[i].Cells[2].Value = thongKe[i, 1];
                dgvThongKe.Rows[i].Cells[3].Value = thongKe[i, 2];
                dgvThongKe.Rows[i].Cells[4].Value = thongKe[i, 3];
                dgvThongKe.Rows[i].Cells[5].Value = thongKe[i, 4];

            }
        }

        private void BindDichVu(string[,] dichVu)
        {
            dgvDichVu.Rows.Clear();
            for (int i = 0; i < dichVu.GetLength(0); i++)
            {
                dgvDichVu.Rows.Add();
                dgvDichVu.Rows[i].Cells[0].Value = i + 1;
                dgvDichVu.Rows[i].Cells[1].Value = dichVu[i, 0];
                dgvDichVu.Rows[i].Cells[2].Value = dichVu[i, 1];
                dgvDichVu.Rows[i].Cells[3].Value = dichVu[i, 2];

            }
        }

        private void LoadRooms(DateTime value)
        {
            LoadRoom(value, pnl101);
            LoadRoom(value, pnl102);
            LoadRoom(value, pnl103);
            LoadRoom(value, pnl104);
            LoadRoom(value, pnl105);
            LoadRoom(value, pnl201);
            LoadRoom(value, pnl202);
            LoadRoom(value, pnl203);
            LoadRoom(value, pnl204);
            LoadRoom(value, pnl205);
            LoadRoom(value, pnl301);
            LoadRoom(value, pnl302);
            LoadRoom(value, pnl303);
            LoadRoom(value, pnl304);
            LoadRoom(value, pnl305);
            LoadRoom(value, pnl401);
            LoadRoom(value, pnl402);
            LoadRoom(value, pnl403);
            LoadRoom(value, pnl404);
            LoadRoom(value, pnl405);
            LoadRoom(value, pnl501);
            LoadRoom(value, pnl502);
            LoadRoom(value, pnl503);
            LoadRoom(value, pnl504);
            LoadRoom(value, pnl505);
            LoadRoom(value, pnl601);
            LoadRoom(value, pnl602);
            LoadRoom(value, pnl603);
            LoadRoom(value, pnl604);
            LoadRoom(value, pnl605);
        }

        private void LoadRoom(DateTime value, Panel pnl)
        {
            if (controller.LoadRoom(value,pnl.Name) == 0)
            { 
                //0 là trống
                pnl.BackColor= Color.Green;
            }
            else
            {
                if(controller.LoadRoom(value,pnl.Name) == 1)
                {
                    //1 là có người đặt
                    pnl.BackColor=Color.Orange;
                }
                else 
                {
                    //2 là đang có người ở
                    pnl.BackColor = Color.Red;
                }
            }
        }

        private void BindKhachHang(string[,] khachHang)
        {
            dgvBook.Rows.Clear();
            for (int i = 0; i < khachHang.GetLength(0); i++)
            {
                dgvBook.Rows.Add();
                dgvBook.Rows[i].Cells[0].Value = i + 1;
                dgvBook.Rows[i].Cells[1].Value = khachHang[i, 0];
                dgvBook.Rows[i].Cells[2].Value = khachHang[i, 1];
                dgvBook.Rows[i].Cells[3].Value = khachHang[i, 2];
                dgvBook.Rows[i].Cells[4].Value = khachHang[i, 3];
                dgvBook.Rows[i].Cells[5].Value = khachHang[i, 4];
                dgvBook.Rows[i].Cells[6].Value = khachHang[i, 5];

            }
        }

        private void BindNhanVien(string[,] nhanVien)
        {
            dgvEmployee.Rows.Clear();
            for(int i = 0; i < nhanVien.GetLength(0); i++)
            {
                dgvEmployee.Rows.Add();
                dgvEmployee.Rows[i].Cells[0].Value = i + 1;
                dgvEmployee.Rows[i].Cells[1].Value = nhanVien[i,0];
                dgvEmployee.Rows[i].Cells[2].Value = nhanVien[i, 1];
                dgvEmployee.Rows[i].Cells[3].Value = nhanVien[i, 2];
                dgvEmployee.Rows[i].Cells[4].Value = nhanVien[i, 3];
                if(nhanVien[i, 4].Equals("2"))
                {
                    nhanVien[i, 4] = "Nhân Viên";
                }
                else
                {
                    if (nhanVien[i, 4].Equals("3"))
                    {
                        nhanVien[i, 4] = "Bảo Vệ";
                    }
                    else
                    {
                        nhanVien[i, 4] = "Admin";
                    }
                    
                }
                dgvEmployee.Rows[i].Cells[5].Value = nhanVien[i, 4];

            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            //xem có bao nhhieeu nhân vien để tạo mã nhân viên tiếp theo
            new ThemNhanVien(dgvEmployee.RowCount).Show();
        }

        private void NgayXem_ValueChanged(object sender, EventArgs e)
        {
            //này là tại vì nếu ngày hiện tại thì mình load cả giờ để so sánh
            //nếu không phải ngày hiện tại thì mình coi cả ngày
            if (NgayXem.Value.Date == DateTime.Today)
            {
                LoadRooms(NgayXem.Value);
            }
            else
            {
                LoadRooms(NgayXem.Value.Date);
            }
        }
        //thông tin tài khoản
        private void tsmiInfo_Click(object sender, EventArgs e)
        {
            new ThongTinTaiKhoan(DangNhap.userName).Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ThanhToanPhong(here).Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DatPhong(here).Show();
        }

        private void btnAddSer_Click(object sender, EventArgs e)
        {
            new ThemDichVu().Show();
        }

        string tenDV = "";
        string giaDV = "";
        string thongTinDV = "";
        private void btnFixSer_Click(object sender, EventArgs e)
        {
            if (!tenDV.Equals(""))
            {
                // kiểm tra nếu đã chọn ô thì sửa
                new SuaDichVu(tenDV, giaDV, thongTinDV).Show();
                // cập nhật lại các biến chọn
                tenDV = "";
                giaDV = "";
                thongTinDV = "";
            }
            else
            {
                MessageBox.Show("Chưa chọn ô để sửa");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // biến lưu dong đang click
            try
            {
                // lưu các nội dung hiển thị
                int dong = e.RowIndex;
                tenDV = dgvDichVu.Rows[dong].Cells[1].Value.ToString();
                giaDV = dgvDichVu.Rows[dong].Cells[2].Value.ToString();
                thongTinDV = dgvDichVu.Rows[dong].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // dich vu
            txtTimDichVu.Text = "";
            string[,] dichVu = controller.LoadDichVu();
            BindDichVu(dichVu);
        }

        private void btnRefreshTK_Click(object sender, EventArgs e)
        {
            txtTimHoaDon.Text = "";
            string[,] ThongKe = controller.LoadThongKe();
            BindThongKe(ThongKe);
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            txtTimTenNV.Text = "";
            string[,] nhanVien = controller.LoadNhanVien(DangNhap.userName);
            BindNhanVien(nhanVien);
        }

        private void btnRefreshKH_Click(object sender, EventArgs e)
        {
            string[,] khachHang = controller.LoadKhachHang();
            BindKhachHang(khachHang);
        }

        private void btnDelSer_Click(object sender, EventArgs e)
        {
            if (!tenDV.Equals(""))
            {
                if(controller.XoaDV(tenDV, giaDV, thongTinDV))
                {
                    MessageBox.Show("Xóa Thành Công!");
                }
                else
                {
                    MessageBox.Show("Không xóa được do lỗi!");
                }
                // cập nhật lại các biến chọn
                tenDV = "";
                giaDV = "";
                thongTinDV = "";
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Ô để xóa");
            }
            
        }
        string nvTaiKhoan;
        string nvTenNV;
        string nvMaNV;
        string nvCMND;
        string nvNhomQuyen;
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (nvTaiKhoan.Equals(""))
            {
                MessageBox.Show("Chưa chọn ô để sửa");
            }
            else
            {
                new SuaNhanVien(nvTaiKhoan, nvTenNV, nvMaNV, nvCMND, nvNhomQuyen).Show();
                nvTaiKhoan = "";
                nvTenNV = "";
                nvMaNV = "";
                nvCMND = "";
                nvNhomQuyen = "";
            }
            
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int chon = e.RowIndex;
                if (chon < dgvEmployee.Rows.Count - 1)
                {
                    nvTaiKhoan = dgvEmployee.Rows[chon].Cells[1].Value.ToString();
                    nvTenNV = dgvEmployee.Rows[chon].Cells[2].Value.ToString();
                    nvMaNV = dgvEmployee.Rows[chon].Cells[3].Value.ToString();
                    nvCMND = dgvEmployee.Rows[chon].Cells[4].Value.ToString();
                    nvNhomQuyen = dgvEmployee.Rows[chon].Cells[5].Value.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if ( nvTaiKhoan== null||nvTaiKhoan.Equals("") )
                {
                    MessageBox.Show("Chưa chọn ô để xóa");
                }
                else
                {
                    if (controller.XoaNV(nvTaiKhoan))
                    {
                        MessageBox.Show("Xóa Thành Công!!");
                        nvTaiKhoan = "";
                        nvTenNV = "";
                        nvMaNV = "";
                        nvCMND = "";
                        nvNhomQuyen = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại!!");
                    }

                }
            }
            catch(Exception ex)
            {

            }
        }

        private void txtTimDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 là enter hoặc có thể dùng sự kiện Key down e.KeyCode == Keys.Enter
            {
                string[,] dichVu = controller.TimDichVu(txtTimDichVu.Text);
                if (dichVu != null)
                {
                    BindDichVu(dichVu);
                }
                else
                {
                    dgvDichVu.Rows.Clear();
                    MessageBox.Show("Không tìm thấy dịch vụ");
                }
                
                
            }
        }

        private void txtTimHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[,] thongKe = controller.TimHoaDon(txtTimHoaDon.Text);
                if (thongKe != null)
                {
                    BindThongKe(thongKe);
                }
                else
                {
                    dgvThongKe.Rows.Clear();
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void txtTimTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string[,] nhanVien = controller.TimNhanVien(txtTimTenNV.Text);
                if (nhanVien != null)
                {
                    BindNhanVien(nhanVien);
                }
                else
                {
                    dgvEmployee.Rows.Clear();
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void thuêTheoGiờToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ThueTheoGio(here).Show();
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuDungDichVu(here).Show();
        }

        private void btnRefreshSD_Click(object sender, EventArgs e)
        {
            NgayXem.Value = System.DateTime.Now;
        }
        int iDPDP;
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int chon = e.RowIndex;
                if (chon < dgvBook.Rows.Count - 1)
                {
                    iDPDP =Convert.ToInt32(dgvBook.Rows[chon].Cells[1].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {
            if (controller.XoaPDP(iDPDP))
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void GiaoDienChinh_Resize(object sender, EventArgs e)
        {
            tabControlMnu.Width = this.Width;
            tabControlMnu.Height = this.Height;
        }

        private void GiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            dangNhap.Show();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            DataTable soPhong = controller.LoadCboPhong();
            cboPhong.DataSource = soPhong;
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "SoPhong";
            cboPhong.Text = "";
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboPhong.Text.Equals(""))
            {
                try
                {
                    if (controller.LoadThongKe(Convert.ToInt32(cboPhong.Text)) != null)
                    {
                        string[,] thongKe = controller.LoadThongKe(Convert.ToInt32(cboPhong.Text));
                        BindThongKe(thongKe);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ Liệu");
                    }
                }
                catch
                {

                }

            }

        }
    }
}

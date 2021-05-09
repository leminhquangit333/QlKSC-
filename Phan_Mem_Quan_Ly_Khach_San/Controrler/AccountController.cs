using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controrler
{
    public class AccountController 
    {
        AccountModel model = new AccountModel();
        public int CheckAccount(string tenDangNhap, string matKhau)
        {
            // kq là loai tk có 3 trạng thái
            //0 sai
            //1 Admin
            //2 Nhân Viên
            int kq = model.CheckAccount(tenDangNhap, matKhau);
            return kq;
        }

        public bool ThemDichVu(string tenDV, string gia, string thongTin)
        {
            return model.ThemDichVu(tenDV, gia, thongTin);
        }

        public string[,] LoadNhanVien(string userName)
        {
            return model.LoadNhanVien(userName);
        }

        public string GetPrice(string here, string kieuThue)
        {
            return model.GetPrice(here, kieuThue);
        }

        public bool ThemHoaDon(int soPhong, string maNV, DateTime date, decimal tongTien)
        {
            return model.ThemHoaDon(soPhong, maNV, date, tongTien);
        }

        public int GetIDDV(string tenDV, string gia, string thongTin)
        {
            return model.GetIDDV(tenDV,gia,thongTin);
        }

        public string[,] ThanhToan(int here)
        {
            return model.ThanhToan(here);
        }

        public string GetIDNV(string userName)
        {
            return model.GetIDNV(userName);
        }

        public DataTable LoadCboDichVu()
        {
            return model.LoadCboDichVu();
        }

        public bool SuDungDichVu(int here, int maDV,int sL)
        {
            return model.SuDungDichVu(here,maDV,sL);
        }

        public int GetIDKH(int cMND)
        {
            return model.GetIDKH(cMND);
        }

        public bool AddKH(string tenKH, int SDT, int cMND)
        {
            return model.AddKH(tenKH, SDT, cMND);
        }

        public string[,] GetInfo(string userName)
        {
            return model.GetInfo(userName);
        }

        public bool KiemTraNgayDat(DateTime date, string here)
        {
            return model.KiemTraNgayDat(date,here);
        }

        public bool DatPhong(int iDKH, string iDNV, DateTime ngayDat, DateTime ngayTra, long tienCoc, int soPhong, int v)
        {
            //v ở đây 1 là thuê theo ngày 2 là thuê theo giờ
            return model.DatPhong(iDKH, iDNV, ngayDat, ngayTra, tienCoc, soPhong,v);
        }

        public bool KiemTraNgayTra(DateTime date, string here)
        {
            return model.KiemTraNgayTra (date,here);
        }
        public string[,] LoadKhachHang()
        {
            return model.LoadKhachHang();
        }

        public string GetPass(string nvMaNV)
        {
            return model.GetPass(nvMaNV);
        }

        public bool ThemNV(string tenDangNhap, string matKhau, string hoTen, int cMND, string maNV, int loai)
        {
            return model.ThemNV(tenDangNhap, matKhau, hoTen, cMND, maNV, loai);
        }


        public int LoadRoom(DateTime value, string name)
        {
            return model.LoadRoom(value, name);
        }

        public string[,] LoadDichVu()
        {
            return model.LoadDichVu();
        }

        public bool UpdateDV(int iD, string tenDV, string gia, string thongTin)
        {
            return model.UpdateDV(iD, tenDV, gia, thongTin);
        }

        public bool UpdateNV(string tenDangNhap, string matKhau, string hoTen, int cMND)//update có mật khẩu
        {
            return model.UpdateNV(tenDangNhap, matKhau, hoTen, cMND);
        }
        public bool UpdateNV(string userName, string hoTen, int cMND)//update không có mật khẩu
        {
            return model.UpdateNV(userName, hoTen, cMND);
        }
        public string[,] LoadThongKe()
        {
            return model.LoadThongKe();
        }
        public string[,] LoadThongKe(int v)
        {
            return model.LoadThongKe(v);
        }
        public bool XoaDV(string tenDV, string giaDV, string thongTinDV)
        {
            return model.XoaDV(tenDV, giaDV, thongTinDV);
        }

        public bool XoaNV(string nvTaiKhoan)
        {
            return model.XoaNV(nvTaiKhoan);
        }

        public string[,] TimDichVu(string tenDV)
        {
            return model.TimDichVu(tenDV);
        }

        public string[,] TimHoaDon(string tenKH)
        {
            return model.TimHoaDon(tenKH);
        }

        public string[,] TimNhanVien(string tenNV)
        {
            return model.TimNhanVien(tenNV);
        }

        public bool XoaPDP(int iDPDP)
        {
            return model.XoaPDP(iDPDP);
        }

        public DataTable LoadCboPhong()
        {
            return model.LoadCboPhong();
        }


    }
}

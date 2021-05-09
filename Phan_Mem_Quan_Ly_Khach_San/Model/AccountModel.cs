using DTO;//Vao references -> add project de dung DTO.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class AccountModel : DatabaseService//Ke thua du lieu cua <<DatabaseService>>.
    {
        AccountDTO account = new AccountDTO();

        //ham checkLogin se kiemtra email va pass co trong CSDL
        public int CheckAccount(string userName, string pwd)
        {
            // kq là loai tk có 3 trạng thái
            //0 sai
            //1 Admin
            //2 Nhân Viên
            try
            {
                CloseConnection();
                string sql = " Select * From NhanVien where TenDangNhap=@tenDangNhap and MatKHau =@matKhau";
                SqlParameter parUserName = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parUserName.Value = userName;
                SqlParameter parPwd = new SqlParameter("@matKhau", System.Data.SqlDbType.NVarChar);
                parPwd.Value = pwd;



                SqlDataReader reader = ReadDataPars(sql, new[] { parUserName, parPwd });

                if(reader.Read())
                {
                        return reader.GetInt32(5);
                }
                

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return 0;
        }

        public bool ThemHoaDon(int soPhong, string maNV, DateTime date, decimal tongTien)
        {
            try
            {
                CloseConnection();
                // lấy ra mã phiếu đặt phòng để tính tổng tiền dịch vụ
                string sql = " Select top 1 MaPhieu From PhieuDatPhong where NgayDat <= @ngayDat and SoPhong =@soPhong order by NgayTra desc";

                SqlParameter parNgayDat = new SqlParameter("@ngayDat", System.Data.SqlDbType.DateTime);
                parNgayDat.Value = System.DateTime.Now;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = soPhong;
                SqlDataReader reader = ReadDataPars(sql, new[] { parNgayDat, parSoPhong });
                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    sql = "insert into HoaDon values(@maPhieu,@maNV,@ngayLap,@thanhTien)";
                    SqlParameter parMaPhieu = new SqlParameter("@maPhieu", System.Data.SqlDbType.Int);
                    parMaPhieu.Value = ID;
                    SqlParameter parMaNV = new SqlParameter("@maNV", System.Data.SqlDbType.NVarChar);
                    parMaNV.Value = maNV;
                    SqlParameter parNgayLap = new SqlParameter("@ngayLap", System.Data.SqlDbType.DateTime);
                    parNgayLap.Value = date;
                    SqlParameter parTien = new SqlParameter("@thanhTien", System.Data.SqlDbType.BigInt);
                    parTien.Value = tongTien;
                    CloseConnection();
                    if(WriteData(sql, new[] { parMaPhieu, parMaNV, parNgayLap, parTien }))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public string[,] ThanhToan(int here)
        {
            try
            {
                string[,] kq = new string[1, 7];
                CloseConnection();
                // lấy ra mã phiếu đặt phòng để tính tổng tiền dịch vụ
                string sql = " Select top 1 MaPhieu From PhieuDatPhong where NgayDat <= @ngayDat and SoPhong =@soPhong order by NgayTra desc";

                SqlParameter parNgayDat = new SqlParameter("@ngayDat", System.Data.SqlDbType.DateTime);
                parNgayDat.Value = System.DateTime.Now;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = Convert.ToInt32(here);
                SqlDataReader reader = ReadDataPars(sql, new[] { parNgayDat, parSoPhong });
                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    sql = "select Sum(CTDV.SoLuong*DichVu.Gia) as Tong from DichVu,CTDV where DichVu.MaDV=CTDV.MaDV and CTDV.MaPhieuDatPhong=@maPhieu having sum(CTDV.SoLuong*DichVu.Gia)is not null";
                    SqlParameter parMaPDP = new SqlParameter("@maPhieu", System.Data.SqlDbType.Int);
                    parMaPDP.Value = ID;
                    CloseConnection();
                    reader = ReadDataPars(sql, new[] { parMaPDP });
                    //lấy ra tiền dịch vụ kq 0,0
                    if (reader.Read())
                    {
                        kq[0, 0] = reader.GetInt64(0).ToString();
                    }
                    else
                    {
                        kq[0, 0] = "0";
                    }
                    sql = "select KhachHang.TenKhachHang,PhieuDatPhong.HinhThuc,NgayDat,NgayTra,TienCoc,case PhieuDatPhong.HinhThuc when 1 then GiaTheoNgay when 2 then GiaTheoGio end as Gia from PhieuDatPhong, Phong, KhachHang where PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang and PhieuDatPhong.SoPhong = Phong.SoPhong and PhieuDatPhong.MaPhieu = @maPhieu ";
                    parMaPDP = new SqlParameter("@maPhieu", System.Data.SqlDbType.Int);
                    parMaPDP.Value = ID;
                    CloseConnection();
                    reader = ReadDataPars(sql, new[] { parMaPDP });
                    if (reader.Read())
                    {
                        //Ten khach hang
                        kq[0, 1] = reader.GetString(0);
                        //Hinh thức
                        //tổng tiền phòng
                        if (reader.GetInt32(1) == 1)
                        {
                            TimeSpan time = reader.GetDateTime(3).Date - reader.GetDateTime(2).Date;
                            //time.day là khoảng cách 2 ngày
                            //kq6 là tổng tiền phòng
                            kq[0, 6] = (time.Days * reader.GetInt64(5)).ToString();
                        }
                        else
                        {
                            TimeSpan time = reader.GetDateTime(3) - reader.GetDateTime(2);
                            kq[0, 6] = (time.Hours * reader.GetInt64(5)).ToString();
                        }
                        
                        //ngày dat
                        kq[0, 2] = reader.GetDateTime(2).ToString();
                        //ngày trả
                        kq[0, 3] = reader.GetDateTime(3).ToString();
                        //tiền cọc
                        kq[0, 4] = reader.GetInt64(4).ToString();
                        //giá
                        kq[0, 5] = reader.GetInt64(5).ToString();
                    }
                    return kq;

                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }



        public DataTable LoadCboPhong()
        {
            try
            {
                CloseConnection();
                OpenConnection();
                DataTable kq = new DataTable();
                SqlDataAdapter dt = new SqlDataAdapter(" Select SoPhong From Phong", connection);
                dt.Fill(kq);
                CloseConnection();
                return kq;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool SuDungDichVu(int here, int maDV, int sL)
        {
            try
            {
                CloseConnection();
                string sql = " Select top 1 MaPhieu From PhieuDatPhong where NgayDat <= @ngayDat and SoPhong =@soPhong order by NgayTra desc";

                SqlParameter parNgayDat = new SqlParameter("@ngayDat", System.Data.SqlDbType.DateTime);
                parNgayDat.Value = System.DateTime.Today.Date;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = Convert.ToInt32(here);
                SqlDataReader reader = ReadDataPars(sql, new[] { parNgayDat, parSoPhong });
                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    sql = " Insert into CTDV values(@maDV,@maPDP,@sL) ";
                    SqlParameter parMaDV = new SqlParameter("@maDV", System.Data.SqlDbType.Int);
                    parMaDV.Value = maDV;
                    SqlParameter parMaPDP = new SqlParameter("@maPDP", System.Data.SqlDbType.Int);
                    parMaPDP.Value = ID;
                    SqlParameter parSoLuong = new SqlParameter("@sL", System.Data.SqlDbType.Int);
                    parSoLuong.Value = sL;
                    CloseConnection();
                    if (WriteData(sql, new[] { parMaDV, parMaPDP, parSoLuong}))
                    {
                        return true;
                    }



                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return false;
        }

        public DataTable LoadCboDichVu()
        {
            //Lưu danh sách dịch vụ
            try
            {
                CloseConnection();
                OpenConnection();
                DataTable kq = new DataTable();
                SqlDataAdapter dt = new SqlDataAdapter(" Select * From DichVu", connection);
                dt.Fill(kq);
                CloseConnection();
                return kq;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public string GetIDNV(string userName)
        {
            try
            {
                CloseConnection();
                string sql = " select MaNV from NhanVien Where TenDangNhap=@userName";
                SqlParameter parUserName = new SqlParameter("@userName", System.Data.SqlDbType.NVarChar);
                parUserName.Value = userName;
                SqlDataReader reader = ReadDataPars(sql, new[] { parUserName });
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool XoaPDP(int iDPDP)
        {
            try
            {
                CloseConnection();
                string sql = " Delete from PhieuDatPhong Where MaPhieu=@maPhieu";
                SqlParameter parMaPhieu = new SqlParameter("@maPhieu", System.Data.SqlDbType.Int);
                parMaPhieu.Value = iDPDP;
                if (WriteData(sql, new[] { parMaPhieu }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool DatPhong(int iDKH, string iDNV, DateTime ngayDat, DateTime ngayTra, long tienCoc, int soPhong, int v)
        {
            try
            {
                string sql = " Insert into PhieuDatPhong values(@maKH,@maNV,@ngayDat,@ngayTra,@tienCoc,@soPhong,@hinhThuc) ";
                SqlParameter parMaKH = new SqlParameter("@maKH", System.Data.SqlDbType.Int);
                parMaKH.Value = iDKH;
                SqlParameter parMaNV = new SqlParameter("@maNV", System.Data.SqlDbType.Int);
                parMaNV.Value = iDNV;
                SqlParameter parNgayDat = new SqlParameter("@ngayDat", System.Data.SqlDbType.DateTime);
                parNgayDat.Value = ngayDat;
                SqlParameter parNgayTra = new SqlParameter("@ngayTra", System.Data.SqlDbType.DateTime);
                parNgayTra.Value = ngayTra;
                SqlParameter parTienCoc = new SqlParameter("@tienCoc", System.Data.SqlDbType.BigInt);
                parTienCoc.Value = tienCoc;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = soPhong;
                SqlParameter parHinhThuc = new SqlParameter("@hinhThuc", System.Data.SqlDbType.Int);
                parHinhThuc.Value = v;
                CloseConnection();
                if (WriteData(sql, new[] { parMaKH, parMaNV, parNgayDat, parNgayTra, parTienCoc , parSoPhong, parHinhThuc }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool AddKH(string tenKH, int sDT, int cMND)
        {
            try
            {
                string sql = " Insert into KhachHang values(@tenKH,@sDT,@cMND) ";
                SqlParameter parTenKH = new SqlParameter("@tenKH", System.Data.SqlDbType.NVarChar);
                parTenKH.Value = tenKH;
                SqlParameter parSDT = new SqlParameter("@sDT", System.Data.SqlDbType.Int);
                parSDT.Value = sDT;
                SqlParameter parCMND = new SqlParameter("@cMND", System.Data.SqlDbType.Int);
                parCMND.Value = cMND;
                CloseConnection();
                if (WriteData(sql, new[] { parTenKH, parSDT, parCMND}))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public int GetIDKH(int cMND)
        {
            try
            {
                CloseConnection();
                string sql = " Select MaKhachHang From KhachHang where CMND = @cMND";
                SqlParameter parCMND = new SqlParameter("@cMND", System.Data.SqlDbType.Int);
                parCMND.Value = cMND;
                SqlDataReader reader = ReadDataPars(sql, new[] { parCMND });
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return -1;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return -1;
        }

        public bool KiemTraNgayTra(DateTime date, string here)
        {
            try
            {
                CloseConnection();
                string sql = " Select top 1 NgayDat From PhieuDatPhong where NgayTra >= @ngayTra and SoPhong = @soPhong order by NgayDat asc";

                SqlParameter parNgayTra = new SqlParameter("@ngayTra", System.Data.SqlDbType.DateTime);
                parNgayTra.Value = date;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = Convert.ToInt32(here);
                SqlDataReader reader = ReadDataPars(sql, new[] { parNgayTra, parSoPhong });
                if (reader.Read())
                {
                    if (reader.GetDateTime(0) > date)
                    {
                        return true;
                    }
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool KiemTraNgayDat(DateTime date, string here)
        {
            try
            {
                CloseConnection();
                string sql =" Select top 1 NgayTra From PhieuDatPhong where NgayDat <= @ngayDat and SoPhong =@soPhong order by NgayTra desc";

                SqlParameter parNgayDat = new SqlParameter("@ngayDat", System.Data.SqlDbType.DateTime);
                parNgayDat.Value = date;
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value =Convert.ToInt32(here);
                SqlDataReader reader = ReadDataPars(sql, new[] { parNgayDat, parSoPhong });
                if (reader.Read())
                {
                    if (reader.GetDateTime(0)< date)
                    {
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return false;
        }

        public string GetPrice(string here, string kieuThue)
        {
            try
            {
                CloseConnection();
                string sql = "";
                if (kieuThue.Equals("Ngay"))
                {
                    sql = " Select GiaTheoNgay From Phong where SoPhong = @soPhong";
                }
                else
                {
                    sql = " Select GiaTheoGio From Phong where SoPhong = @soPhong";
                }
                
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.NVarChar);
                parSoPhong.Value = here;
                SqlDataReader reader = ReadDataPars(sql, new[] { parSoPhong });
                if (reader.Read())
                {
                    return reader.GetInt64(0).ToString();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public string[,] GetInfo(string userName)
        {
            try
            {
                CloseConnection();
                string[,] kq;
                //tạo function tìm DV trên SQL server
                string sql = " Select * From NhanVien where TenDangNhap = @tenDangNhap";
                SqlParameter parTenDangNhap = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parTenDangNhap.Value = userName;
                SqlDataReader reader = ReadDataPars(sql, new[] { parTenDangNhap });
                if (reader.Read())
                {
                    kq = new string[1, 2];
                        kq[0, 0] = reader.GetString(2);
                        kq[0, 1] = reader.GetInt32(3).ToString();
                    return kq;
                }
                   
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }



        // Lấy mật khẩu đổ về form sửa
        public string GetPass(string nvMaNV)
        {
            try
            {
                CloseConnection();
                //lấy ngày nhận gần nhất sau đó so sánh ngày trả với ngày cần xem
                string sql = " Select MatKhau from NhanVien Where Manv=@MaNV ";
                SqlParameter parMaNV = new SqlParameter("@MaNV", System.Data.SqlDbType.NVarChar);
                parMaNV.Value = nvMaNV;
                SqlDataReader reader = ReadDataPars(sql, new[] { parMaNV});
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                return "";
            }
            catch (Exception ex)
            {
                ex.ToString();
                return "";
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public string[,] TimDichVu(string tenDV)
        {
            try
            {
                CloseConnection();
                string[,] kq;
                //tạo function tìm DV trên SQL server
                string sql = " Select count(*) From FnTimDichVu(@tenDV)";
                SqlParameter parTenDV = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                parTenDV.Value = tenDV;
                SqlDataReader reader = ReadDataPars(sql, new[] { parTenDV });
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 3];
                    CloseConnection();
                    sql = " Select TenDV,Gia,ThongTinDV From FnTimDichVu(@tenDV)";
                    parTenDV = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                    parTenDV.Value = tenDV;
                    reader = ReadDataPars(sql, new[] { parTenDV });
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetString(0);
                        kq[i, 1] = reader.GetInt64(1).ToString();
                        kq[i, 2] = reader.GetString(2);
                        i++;
                    }
                    return kq;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public string[,] TimNhanVien(string tenNV)
        {
            string[,] kq;
            try
            {
                CloseConnection();
                string sql = " Select count(*) From fnTimNhanVien(@tenNV)";
                SqlParameter parName = new SqlParameter("@tenNV", System.Data.SqlDbType.NVarChar);
                parName.Value = tenNV;
                SqlDataReader reader = ReadDataPars(sql, new[] { parName });
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 5];
                    CloseConnection();
                    sql = "  Select * From fnTimNhanVien(@tenNV)";
                    parName = new SqlParameter("@tenNV", System.Data.SqlDbType.NVarChar);
                    parName.Value = tenNV;
                    reader = ReadDataPars(sql, new[] { parName });
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetString(0);
                        kq[i, 1] = reader.GetString(2);
                        kq[i, 2] = reader.GetString(4);
                        kq[i, 3] = reader.GetInt32(3).ToString();
                        kq[i, 4] = reader.GetInt32(5).ToString();
                        i++;
                    }
                    return kq;
                }



            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public string[,] TimHoaDon(string tenKH)
        {
            try
            {
                CloseConnection();
                string[,] kq;
                string sql = " Select count(*) From fnTimHoaDon(@tenKH)";
                SqlParameter parTenKH = new SqlParameter("@tenKH", System.Data.SqlDbType.NVarChar);
                parTenKH.Value = tenKH;
                SqlDataReader reader = ReadDataPars(sql, new[] { parTenKH });
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 5];
                    CloseConnection();
                    sql = " Select * From fnTimHoaDon(@tenKH)";
                    parTenKH = new SqlParameter("@tenKH", System.Data.SqlDbType.NVarChar);
                    parTenKH.Value = tenKH;
                    reader = ReadDataPars(sql, new[] { parTenKH });
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetInt32(0).ToString();
                        kq[i, 1] = reader.GetInt32(1).ToString();
                        kq[i, 2] = reader.GetString(2);
                        kq[i, 3] = reader.GetDateTime(3).ToString();
                        kq[i, 4] = reader.GetInt64(4).ToString();
                        i++;
                    }
                    return kq;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public bool XoaNV(string nvTaiKhoan)
        {
            try
            {
                CloseConnection();
                string sql = " Delete from NhanVien Where TenDangNhap=@tenDangNhap";
                SqlParameter parTenDangNhap = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parTenDangNhap.Value = nvTaiKhoan;
                if (WriteData(sql, new[] { parTenDangNhap }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool UpdateNV(string tenDangNhap, string matKhau, string hoTen, int cMND)
        {
            try
            {
                CloseConnection();
                string sql = "  UPDATE NhanVien Set MatKhau = @matKhau,HoVaTen=@hoTen,SoCMND = @cMND where TenDangNhap = @tenDangNhap ";
                SqlParameter parMatKhau = new SqlParameter("@matKhau", System.Data.SqlDbType.NVarChar);
                parMatKhau.Value = matKhau;
                SqlParameter parHoTen = new SqlParameter("@hoTen", System.Data.SqlDbType.NVarChar);
                parHoTen.Value = hoTen;
                SqlParameter parCMND = new SqlParameter("@cMND", System.Data.SqlDbType.Int);
                parCMND.Value = cMND;
                SqlParameter parTenDangNhap = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parTenDangNhap.Value = tenDangNhap;
                if (WriteData(sql, new[] { parMatKhau, parHoTen, parCMND, parTenDangNhap }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }
        public bool UpdateNV(string userName, string hoTen, int cMND)
        {
            try
            {
                CloseConnection();
                string sql = "  UPDATE NhanVien Set HoVaTen=@hoTen,SoCMND = @cMND where TenDangNhap = @tenDangNhap ";
                SqlParameter parHoTen = new SqlParameter("@hoTen", System.Data.SqlDbType.NVarChar);
                parHoTen.Value = hoTen;
                SqlParameter parCMND = new SqlParameter("@cMND", System.Data.SqlDbType.Int);
                parCMND.Value = cMND;
                SqlParameter parTenDangNhap = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parTenDangNhap.Value = userName;
                if (WriteData(sql, new[] {  parHoTen, parCMND, parTenDangNhap }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }
        public bool ThemNV(string tenDangNhap, string matKhau, string hoTen, int cMND, string maNV, int loai)
        {
            try
            {
                CloseConnection();
                string sql = " Insert into NhanVien values(@tenDN,@matKhau,@hoTen,@cMND,@maNV,@loai) ";
                SqlParameter parTenDN = new SqlParameter("@tenDN", System.Data.SqlDbType.NVarChar);
                parTenDN.Value = tenDangNhap;
                SqlParameter parMatKhau = new SqlParameter("@matKhau", System.Data.SqlDbType.NVarChar);
                parMatKhau.Value = matKhau;
                SqlParameter parHoTen = new SqlParameter("@hoTen", System.Data.SqlDbType.NVarChar);
                parHoTen.Value = hoTen;
                SqlParameter parCMND = new SqlParameter("@cMND", System.Data.SqlDbType.Int);
                parCMND.Value = cMND;
                SqlParameter parMaNV = new SqlParameter("@maNV", System.Data.SqlDbType.NVarChar);
                parMaNV.Value = maNV;
                SqlParameter parLoai = new SqlParameter("@loai", System.Data.SqlDbType.Int);
                parLoai.Value = loai;
                if (WriteData(sql, new[] { parTenDN, parMatKhau , parHoTen , parCMND , parMaNV , parLoai }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool UpdateDV(int iD, string tenDV, string gia, string thongTin)
        {
            try
            {
                CloseConnection();
                string sql = "  UPDATE DichVu Set TenDV = @tenDV,Gia=@gia,ThongTinDV = @thongTin where MaDV = @ID ";
                SqlParameter parTen = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                parTen.Value = tenDV;
                SqlParameter parGia = new SqlParameter("@gia", System.Data.SqlDbType.BigInt);
                parGia.Value = Convert.ToInt64(gia);
                SqlParameter parThongTin = new SqlParameter("@thongTin", System.Data.SqlDbType.NVarChar);
                parThongTin.Value = thongTin;
                SqlParameter parID = new SqlParameter("@ID", System.Data.SqlDbType.Int);
                parID.Value = iD;
                if (WriteData(sql, new[] {parID, parTen, parGia, parThongTin }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool XoaDV(string tenDV, string giaDV, string thongTinDV)
        {
            try
            {
                CloseConnection();
                string sql = " Delete from DichVu Where TenDV=@tenDV and Gia=@gia and ThongTinDV=@thongTin ";
                SqlParameter parTen = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                parTen.Value = tenDV;
                SqlParameter parGia = new SqlParameter("@gia", System.Data.SqlDbType.BigInt);
                parGia.Value = Convert.ToInt64(giaDV);
                SqlParameter parThongTin = new SqlParameter("@thongTin", System.Data.SqlDbType.NVarChar);
                parThongTin.Value = thongTinDV;
                if (WriteData(sql, new[] { parTen, parGia, parThongTin }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public int GetIDDV(string tenDV, string gia, string thongTin)
        {
            try
            {
                CloseConnection();
                string sql = " Select MaDV from DichVu Where TenDV=@tenDV and Gia=@gia and ThongTinDV=@thongTin";
                SqlParameter parTen = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                parTen.Value = tenDV;
                SqlParameter parGia = new SqlParameter("@gia", System.Data.SqlDbType.BigInt);
                parGia.Value = Convert.ToInt64(gia);
                SqlParameter parThongTin = new SqlParameter("@thongTin", System.Data.SqlDbType.NVarChar);
                parThongTin.Value = thongTin;
                SqlDataReader reader = ReadDataPars(sql, new[] { parTen, parGia, parThongTin });
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
                return -1;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return -1;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public bool ThemDichVu(string tenDV, string gia, string thongTin)
        {
            try
            {
                CloseConnection();
                string sql = " Insert into DichVu values(@tenDV,@gia,@thongTin) ";
                SqlParameter parTen = new SqlParameter("@tenDV", System.Data.SqlDbType.NVarChar);
                parTen.Value = tenDV;
                SqlParameter parGia = new SqlParameter("@gia", System.Data.SqlDbType.BigInt);
                parGia.Value = Convert.ToInt64(gia);
                SqlParameter parThongTin = new SqlParameter("@thongTin", System.Data.SqlDbType.NVarChar);
                parThongTin.Value = thongTin;
                if(WriteData(sql, new[] { parTen, parGia, parThongTin }))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
        }

        public string[,] LoadThongKe(int v)
        {
            try
            {
                CloseConnection();
                string[,] kq;
                string sql = " Select count(*) From KhachHang,PhieuDatPhong,HoaDon where HoaDon.MaPhieuDatPhong=PhieuDatPhong.MaPhieu and PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang and PhieuDatPhong.SoPhong = @soPhong ";
                SqlParameter parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                parSoPhong.Value = v;
                SqlDataReader reader = ReadDataPars(sql, new[] { parSoPhong });
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 5];
                    CloseConnection();
                    sql = " Select HoaDon.MaHD,PhieuDatPhong.SoPhong,KhachHang.TenKhachHang,HoaDon.NgayLap,HoaDon.ThanhTien From KhachHang,PhieuDatPhong,HoaDon where HoaDon.MaPhieuDatPhong=PhieuDatPhong.MaPhieu and PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang and PhieuDatPhong.SoPhong = @soPhong group by HoaDon.MaHD,PhieuDatPhong.SoPhong,KhachHang.TenKhachHang,HoaDon.NgayLap,HoaDon.ThanhTien order by HoaDon.NgayLap desc";
                    parSoPhong = new SqlParameter("@soPhong", System.Data.SqlDbType.Int);
                    parSoPhong.Value = v;
                    reader = ReadDataPars(sql,new[] { parSoPhong });
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetInt32(0).ToString();
                        kq[i, 1] = reader.GetInt32(1).ToString();
                        kq[i, 2] = reader.GetString(2);
                        kq[i, 3] = reader.GetDateTime(3).ToString();
                        kq[i, 4] = reader.GetInt64(4).ToString();
                        i++;
                    }
                    return kq;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }
        public string[,] LoadThongKe()
        {
            try
            {
                CloseConnection();
                string[,] kq;
                string sql = " Select count(*) From KhachHang,PhieuDatPhong,HoaDon where HoaDon.MaPhieuDatPhong=PhieuDatPhong.MaPhieu and PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang ";
                SqlDataReader reader = ReadData(sql);
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 5];
                    CloseConnection();
                    sql = " Select HoaDon.MaHD,PhieuDatPhong.SoPhong,KhachHang.TenKhachHang,HoaDon.NgayLap,HoaDon.ThanhTien From KhachHang,PhieuDatPhong,HoaDon where HoaDon.MaPhieuDatPhong=PhieuDatPhong.MaPhieu and PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang group by HoaDon.MaHD,PhieuDatPhong.SoPhong,KhachHang.TenKhachHang,HoaDon.NgayLap,HoaDon.ThanhTien order by HoaDon.NgayLap desc";
                    reader = ReadData(sql);
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetInt32(0).ToString();
                        kq[i, 1] = reader.GetInt32(1).ToString();
                        kq[i, 2] = reader.GetString(2);
                        kq[i, 3] = reader.GetDateTime(3).ToString();
                        kq[i, 4] = reader.GetInt64(4).ToString();
                        i++;
                    }
                    return kq;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public string[,] LoadDichVu()
        {
            //Lưu danh sách dịch vụ
            try
            {
                CloseConnection();
                string[,] kq;
            string sql = " Select count(*) From DichVu";
            SqlDataReader reader = ReadData(sql);
            int rows;
            int i = 0;
            if (reader.Read())
            {
                rows = reader.GetInt32(0);
                    if (rows == 0)
                    {
                        return null;
                    }
                    kq = new string[rows, 3];
                CloseConnection();
                sql = " Select TenDV,Gia,ThongTinDV From DichVu";
                reader = ReadData(sql);
                while (reader.Read())
                {
                    kq[i, 0] = reader.GetString(0);
                    kq[i, 1] = reader.GetInt64(1).ToString();
                    kq[i, 2] = reader.GetString(2);
                    i++;
                }
                return kq;
            }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;


        }

        public int LoadRoom(DateTime value, string name)
        {
            // lấy cái tên phòng sau ký tự l (pnl)
            string[] room = name.Split('l');
            try
            {
                CloseConnection();
                //lấy ngày nhận gần nhất sau đó so sánh ngày trả với ngày cần xem
                string sql = " SELECT Top 1 NgayTra from PhieuDatPhong where NgayDat<=@date and SoPhong=@room order by NgayTra desc ";
                SqlParameter parDate = new SqlParameter("@date", System.Data.SqlDbType.DateTime);
                parDate.Value = value;
                SqlParameter parRoom = new SqlParameter("@room", System.Data.SqlDbType.Int);
                parRoom.Value = Convert.ToInt32(room[1]);
                SqlDataReader reader = ReadDataPars(sql, new[] { parDate, parRoom });
                if (reader.Read())
                { //so sanh ngay xem voi hien tai

                    if (value> reader.GetDateTime(0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (value> DateTime.Now) { return 1; }
                        else
                        {
                            return 2;
                        }
                        
                    }
                }



            }
            catch (Exception ex)
            {
                ex.ToString();
                return -1;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return -1;
        }

        public string[,] LoadKhachHang()
        {
            string[,] kq;
            try
            {
                CloseConnection();
                string sql = " Select count(*) From fnKhachHang()";
                SqlDataReader reader = ReadData(sql);
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    kq = new string[rows, 6];
                    CloseConnection();
                    sql = " Select * From fnKhachHang()";
                    reader = ReadData(sql);
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetInt32(0).ToString();
                        kq[i, 1] = reader.GetString(1);
                        kq[i, 2] = reader.GetDateTime(2).ToString();
                        kq[i, 3] = reader.GetInt32(3).ToString();
                        kq[i, 4] = reader.GetDateTime(4).ToString();
                        kq[i, 5] = reader.GetInt64(5).ToString();
                        i++;
                    }
                    return kq;
                }



            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public string[,] LoadNhanVien(string userName)
        {
            string[,] kq ;
            try
            {
                CloseConnection();
                string sql = " Select count(*) From NhanVien where TenDangNhap!=@tenDangNhap";
                SqlParameter parUserName = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                parUserName.Value = userName;
                SqlDataReader reader = ReadDataPars(sql, new[] { parUserName});
                int rows;
                int i = 0;
                if (reader.Read())
                {
                    rows = reader.GetInt32(0);
                    kq = new string[rows, 5];
                    CloseConnection();
                    sql = " Select * From NhanVien where TenDangNhap!=@tenDangNhap";
                    parUserName = new SqlParameter("@tenDangNhap", System.Data.SqlDbType.NVarChar);
                    parUserName.Value = userName;
                    reader = ReadDataPars(sql, new[] { parUserName });
                    while (reader.Read())
                    {
                        kq[i, 0] = reader.GetString(0);
                        kq[i, 1] = reader.GetString(2);
                        kq[i, 2] = reader.GetString(4);
                        kq[i, 3] = reader.GetInt32(3).ToString();
                        kq[i, 4] = reader.GetInt32(5).ToString();
                        i++;
                    }
                    return kq;
                }



            }
            catch (Exception ex)
            {
                ex.ToString();
                return null;
            }
            //khi try.. catch ok roi thi finally.
            finally
            {
                CloseConnection();
            }
            return null;
        }
    }
}

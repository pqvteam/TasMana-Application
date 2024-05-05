using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CuDanRepositoty
    {
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();

        public CuDan? Get(string ID)
        {
            return db.CuDans.FirstOrDefault(x => x.MaCuDan == ID);
        }
        public List<CuDan> GetAll()
        {
            return db.CuDans.ToList();
        }
        public string getCuDanHoldHouse(string maCanHo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sqlCommand = $"select CuDan.*,ChuHo.ngayChuyenChuMoi,ChuHo.thongTinChuHoMoi from CuDan,CanHo,ChuHo where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = ChuHo.maCuDan and CanHo.maCH = '{maCanHo}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["hoVaTen"]}, ,{((DateTime)reader["namSinh"]).ToString("dd/MM/yyyy")}, ,{reader["quocTich"]}, ,{reader["SDT"]}, ,{reader["email"]}, ,{reader["soTheTamTru"]}, ,{((DateTime)reader["ngayBanGiao"]).ToString("dd/MM/yyyy")}, ,{((DateTime)reader["ngayChuyenVao"]).ToString("dd/MM/yyyy")}, ,{((DateTime)reader["ngayChuyenDi"]).ToString("dd/MM/yyyy")}, ,{reader["thanhVienLuuTruCung"]}, ,{reader["soLieuDNBanDau"]}, ,{reader["phiQLHangThang"]}, ,{reader["phiDichVu"]}, ,{reader["duLieuDoXe"]}, ,{reader["SDTNguoiThan"]}, ,{reader["ngayChuyenChuMoi"]}, ,{reader["thongTinChuHoMoi"]}, ,{reader["congNo"]}, ,{reader["thuCung"]}";
                }
                return "This department does not exist";
            }
            catch (Exception ex)
            {
                return $"Connection Failed!";
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> getCuDanHoldHouseID()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                string sqlCommand = $"select CanHo.maCH from CuDan,CanHo,ChuHo where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = ChuHo.maCuDan";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rs = $"{reader["maCH"]}";
                    list.Add(rs);
                }
                return list;
            }
            catch (Exception ex)
            {
                list.Add (ex.Message);
                return list;
            }
            finally
            {
                conn.Close();
            }
        }

        public string getCuDanAuthorized(string maCanHo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sqlCommand = $"select CuDan.*,NguoiDuocUyQuyenCuaChuHo.tenNguoiUyQuyen from CuDan,CanHo,NguoiDuocUyQuyenCuaChuHo where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = NguoiDuocUyQuyenCuaChuHo.maCuDan and CanHo.maCH = '{maCanHo}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["hoVaTen"]}, ,{((DateTime)reader["namSinh"]).ToString("dd/MM/yyyy")}, ,{reader["quocTich"]}, ,{reader["SDT"]}, ,{reader["email"]}, ,{reader["soTheTamTru"]}, ,{((DateTime)reader["ngayChuyenVao"]).ToString("dd/MM/yyyy")}, ,{((DateTime)reader["ngayChuyenDi"]).ToString("dd/MM/yyyy")}, ,{reader["thanhVienLuuTruCung"]}, ,{reader["phiQLHangThang"]}, ,{reader["phiDichVu"]}, ,{reader["duLieuDoXe"]}, ,{reader["SDTNguoiThan"]}, ,{reader["congNo"]}, ,{reader["thuCung"]}";
                }
                return "This department does not exist";
            }
            catch (Exception ex)
            {
                return $"Connection Failed!";
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> getCuDanAuthorizedID()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                string sqlCommand = $"select CanHo.maCH from CuDan,CanHo,NguoiDuocUyQuyenCuaChuHo where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = NguoiDuocUyQuyenCuaChuHo.maCuDan";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rs = $"{reader["maCH"]}";
                    list.Add(rs);
                }
                return list;
            }
            catch (Exception ex)
            {
                list.Add(ex.Message);
                return list;
            }
            finally
            {
                conn.Close();
            }
        }

        public string getCuDanTenant(string maCanHo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sqlCommand = $"select CuDan.*,NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay.tenNguoiGioiThieu from CuDan,CanHo,NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay.maCuDan and CanHo.maCH = '{maCanHo}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["hoVaTen"]}, ,{((DateTime)reader["namSinh"]).ToString("dd/MM/yyyy")}, ,{reader["quocTich"]}, ,{reader["SDT"]}, ,{reader["email"]}, ,{reader["soTheTamTru"]}, ,{((DateTime)reader["ngayChuyenVao"]).ToString("dd/MM/yyyy")}, ,{((DateTime)reader["ngayChuyenDi"]).ToString("dd/MM/yyyy")}, ,{reader["thanhVienLuuTruCung"]}, ,{reader["phiQLHangThang"]}, ,{reader["phiDichVu"]}, ,{reader["duLieuDoXe"]}, ,{reader["SDTNguoiThan"]}, ,{reader["congNo"]}, ,{reader["thuCung"]}";
                }
                return "This department does not exist";
            }
            catch (Exception ex)
            {
                return $"Connection Failed!";
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> getCuDanTenantID()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                string sqlCommand = $"select CanHo.maCH from CuDan,CanHo,NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = NhanVienCuaChuHoHoacKhachThueHoacKhachVangLaiLuuTruNganNgay.maCuDan";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rs = $"{reader["maCH"]}";
                    list.Add(rs);
                }
                return list;
            }
            catch (Exception ex)
            {
                list.Add(ex.Message);
                return list;
            }
            finally
            {
                conn.Close();
            }
        }

        public string getCuDanCommercial(string maCanHo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sqlCommand = $"select CuDan.* from CuDan,CanHo,KhachThueKhuThuongMai where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = KhachThueKhuThuongMai.maCuDan and CanHo.maCH = '{maCanHo}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["hoVaTen"]}, ,{((DateTime)reader["namSinh"]).ToString("dd/MM/yyyy")}, ,{reader["quocTich"]}, ,{reader["SDT"]}, ,{reader["email"]}, ,{reader["soTheTamTru"]}, ,{((DateTime)reader["ngayChuyenVao"]).ToString("dd/MM/yyyy")}, ,{((DateTime)reader["ngayChuyenVao"]).ToString("dd/MM/yyyy")}, ,{reader["thanhVienLuuTruCung"]}, ,{reader["phiQLHangThang"]}, ,{reader["phiDichVu"]}, ,{reader["duLieuDoXe"]}, ,{reader["SDTNguoiThan"]}, ,{reader["congNo"]}, ,{reader["thuCung"]}";
                }
                return "This department does not exist";
            }
            catch (Exception ex)
            {
                return $"Connection Failed!";
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> getCuDanCommercialID()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<string> list = new List<string>();
            try
            {
                conn.Open();
                string sqlCommand = $"select CanHo.maCH from CuDan,CanHo,KhachThueKhuThuongMai where CuDan.maCuDan = CanHo.maCuDan and CuDan.maCuDan = KhachThueKhuThuongMai.maCuDan";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string rs = $"{reader["maCH"]}";
                    list.Add(rs);
                }
                return list;
            }
            catch (Exception ex)
            {
                list.Add(ex.Message);
                return list;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

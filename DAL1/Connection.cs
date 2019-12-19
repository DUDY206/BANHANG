using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace DAL1
{
    public class Connection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1QGNFE;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
        public DataTable GetDataInfo(string query)
        {

            //Query trả về một bảng 
            DataTable dt = new DataTable();

            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public List<string> GetListDataInt(string query)
        {
            //trả về danh sách int
            List<string> ans = new List<string>();
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ans.Add(rd.GetInt32(0).ToString());
                }
                return ans;
            }
            catch
            {
                throw;
            }
        }
        public string getOneID(string query)
        {
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    return rd.GetSqlDecimal(0).ToString();
                }
            }
            catch
            {
                return "";
            }
            return "";
        }
        public List<string> geListID(string query)
        {
            Connection conn = new Connection();
            List<string> ans = new List<string>();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ans.Add(rd.GetSqlDecimal(0).ToString());
                }
                return ans;
            }
            catch
            {
                return ans;
            }
        }
        public string getOneStringInfo(string query)
        {
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    return rd.GetString(0).ToString();
                }
            }
            catch
            {
                return "";
            }
            return "";
        }
        public List<string> GetListDataString(string query)
        {
            //trả về danh sách int
            List<string> ans = new List<string>();
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ans.Add(rd.GetString(0).ToString());
                }
                return ans;
            }
            catch
            {
                throw;
            }
        }
        public void ExecuteQuery(string query)
        {
            //thực thi đoan query không có dữ liệu trả về
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
            }
            catch 
            {
                throw;
            }
        }
        public string ExecuteQuery_trangthai(string query)
        {
            try
            {
                Connection objDAL = new Connection();
                objDAL.ExecuteQuery(query);
                return "THANH CONG";
            }
            catch(Exception e)
            {
                return e.Message;
                throw;
            }
        }
        /// <summary>
        /// SQL SERVER EXECUTE QUERY
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachHang()
        {
            try
            {
                Connection objDAL = new Connection();
                return objDAL.GetDataInfo("SELECT ID,TEN FROM HANG");
            }
            catch
            {
                throw;
            }
        }

        public string NhapPhieuNhap()
        {
            try
            {
                Connection objDAL = new Connection();
                objDAL.GetDataInfo("INSERT INTO PHIEUXUAT VALUES(1,100,85,85,1)");
                return "OK";
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }
        public DataTable LayDanhSachNgayNhapHang()
        {
            try
            {
                Connection objDAL = new Connection();
                return objDAL.GetDataInfo("SELECT DISTINCT TOP 10 NGAYNHAP FROM PHIEUNHAP ORDER BY NGAYNHAP DESC");
            }
            catch
            {
                throw;
            }
        }
        public DataTable LayDanhSachNhapHangTheoNgay(string date)
        {
            try
            {
                Connection objDAL = new Connection();
                return objDAL.GetDataInfo("SELECT HANG.TEN, PHIEUNHAP.SOLUONG,HANG.ID AS HANG_ID,PHIEUNHAP.ID FROM HANG INNER JOIN PHIEUNHAP ON HANG.ID = PHIEUNHAP.HANG_ID WHERE NGAYNHAP = '" + date + "'");
            }
            catch
            {
                throw;
            }
        }

        public DataTable LaySoLuongHangTrongKho()
        {
            try
            {
                Connection objDAL = new Connection();
                return objDAL.GetDataInfo("SELECT TEN, SOLUONG FROM HANG");
            }
            catch
            {
                throw;
            }
        }

        public DataTable LayDanhSachNguoiBan()
        {
            return GetDataInfo("select * from NGUOIBAN");
        }

        public DataTable LayDanhSachNguoiMua(string sdt)
        {
            return GetDataInfo("select * from NGUOIMUA WHERE SDT = '"+sdt+"'");
        }

        public string LayDanhSachHangDaBan(string query)
        {
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn.con);
            try
            {
                string ans = "";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ans += rd.GetString(0).ToString() + ":";
                    ans += rd.GetInt32(1).ToString() + "\n";
                }
                return ans;
            }
            catch(Exception e)
            {
                return e.Message;
                throw;
            }
        }

        public string LaySoLuongHangPhieuXuat(string mabanhang,string hang_id)
        {
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT PHIEUXUAT.SOLUONG FROM PHIEUXUAT INNER JOIN HANG ON HANG.ID = PHIEUXUAT.HANG_ID WHERE PHIEUXUAT.MABANHANG = "+ mabanhang + " AND HANG_ID = "+ hang_id + "", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    return rd.GetInt32(0).ToString();
                }
            }
            catch
            {
                return "";
            }
            return "";
        }
        public string LayGiaHangPhieuXuat(string mabanhang, string hang_id)
        {
            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT GIABAN FROM PHIEUXUAT INNER JOIN HANG ON HANG.ID = PHIEUXUAT.HANG_ID WHERE PHIEUXUAT.MABANHANG = " + mabanhang + " AND HANG_ID = " + hang_id + "", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    return rd.GetInt32(0).ToString();
                }
            }
            catch
            {
                return "";
            }
            return "";
        }

        public DataTable LayChiTietDonBanHang(string thang) {
            DataTable dt = new DataTable();

            Connection conn = new Connection();
            if (conn.con.State == ConnectionState.Closed)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT BANHANG.TRANGTHAI,BANHANG.ID,NGUOIBAN.TEN AS NGUOIBAN,NGUOIMUA.TEN AS KHACH,NGAYBAN,FORMAT(SUM(PHIEUXUAT.GIABAN*PHIEUXUAT.SOLUONG),'#,0') AS TONGTIEN,FORMAT(SUM(BANHANG.GIAMGIA),'#,0') AS GIAMGIA FROM BANHANG INNER JOIN NGUOIMUA ON BANHANG.NGUOIMUA_ID = NGUOIMUA.ID INNER JOIN NGUOIBAN ON BANHANG.NGUOIBAN_ID = NGUOIBAN.ID INNER JOIN PHIEUXUAT ON PHIEUXUAT.MABANHANG = BANHANG.ID LEFT JOIN THUTIEN ON BANHANG.ID = THUTIEN.ID WHERE MONTH(BANHANG.NGAYBAN) = " + thang + " GROUP BY BANHANG.TRANGTHAI,BANHANG.ID,NGUOIBAN.TEN,NGUOIMUA.TEN,NGAYBAN,BANHANG.GIAMGIA ORDER BY NGAYBAN", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dt.Columns.Add("CHITIET",typeof(string));
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string chitiet = LayDanhSachHangDaBan("select hang.ten,phieuxuat.soluong from phieuxuat inner join hang on phieuxuat.hang_id = hang.id where phieuxuat.mabanhang = " + dt.Rows[i]["ID"].ToString() + "");
                    dt.Rows[i]["CHITIET"] = chitiet;
                }
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}

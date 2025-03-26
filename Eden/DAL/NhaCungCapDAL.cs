using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class NhaCungCapDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetAllNhaCungCap()
        {
            string query = "SELECT id, MaNhaCungCap as [Mã nhà cung cấp], TenNhaCungCap as [Tên nhà cung cấp], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email FROM NHACUNGCAP";
            return dbHelper.ExecuteQuery(query);
        }

        public bool InsertNhaCungCap(string tenNCC, string diaChi, string soDienThoai, string email)
        {
            string query = "INSERT INTO NHACUNGCAP (TenNhaCungCap, DiaChi, SoDienThoai, Email) VALUES (@TenNCC, @DiaChi, @SDT, @Email)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@TenNCC", tenNCC),
            new SqlParameter("@DiaChi", diaChi),
            new SqlParameter("@SDT", soDienThoai),
            new SqlParameter("@Email", email)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateNhaCungCap(int id, string tenNCC, string diaChi, string soDienThoai, string email)
        {
            string query = "UPDATE NHACUNGCAP SET TenNhaCungCap = @TenNCC, DiaChi = @DiaChi, SoDienThoai = @SDT, Email = @Email WHERE id = @id";
            SqlParameter[] parameters =
            {
            new SqlParameter("@id", id),
            new SqlParameter("@TenNCC", tenNCC),
            new SqlParameter("@DiaChi", diaChi),
            new SqlParameter("@SDT", soDienThoai),
            new SqlParameter("@Email", email)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteNhaCungCap(int id)
        {
            string query = "DELETE FROM NHACUNGCAP WHERE id = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
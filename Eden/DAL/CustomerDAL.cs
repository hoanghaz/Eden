using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class CustomerDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Lấy tất cả khách hàng
        public DataTable GetAllCustomer()
        {
            string query = "SELECT id, MaKHACHHANG as [Mã khách hàng], TenKHACHHANG as [Tên khách hàng], SoDienThoai as [Số điện thoại], DiaChi as [Địa chỉ], Email FROM KHACHHANG";
            return dbHelper.ExecuteQuery(query);
        }

        // Thêm khách hàng mới
        public int AddCustomer(string maKH, string tenKH, string soDienThoai, string diaChi, string email)
        {
            string query = @"
                INSERT INTO KHACHHANG (MaKHANCHANG, TenKHACHHANG, SoDienThoai, DiaChi, Email)
                VALUES (@maKH, @tenKH, @soDienThoai, @diaChi, @email)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@maKH", maKH),
                new SqlParameter("@tenKH", tenKH),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@email", email)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật thông tin khách hàng
        public int UpdateCustomer(int id, string tenKH, string soDienThoai, string diaChi, string email)
        {
            string query = @"
                UPDATE KHANCHANG
                SET TenKHACHHANG = @tenKH, SoDienThoai = @soDienThoai, DiaChi = @diaChi, Email = @email
                WHERE id = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@tenKH", tenKH),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@email", email)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa khách hàng
        public int DeleteCustomer(int id)
        {
            string query = "DELETE FROM KHACHHANG WHERE id = @id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
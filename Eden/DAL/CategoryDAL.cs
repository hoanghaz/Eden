using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class CategoryDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Lấy tất cả danh mục
        public DataTable GetAllCategories()
        {
            string query = "SELECT id, TenLoaiSanPham FROM LOAISANPHAM";
            return dbHelper.ExecuteQuery(query);
        }

        // Thêm danh mục mới
        public int AddCategory(string categoryName)
        {
            string query = "INSERT INTO LOAISANPHAM (TenLoaiSanPham) VALUES (@categoryName)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@categoryName", categoryName)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật danh mục
        public int UpdateCategory(int id, string categoryName)
        {
            string query = "UPDATE LOAISANPHAM SET TenLoaiSanPham = @categoryName WHERE id = @id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@categoryName", categoryName)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa danh mục
        public int DeleteCategory(int id)
        {
            string query = "DELETE FROM LOAISANPHAM WHERE id = @id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
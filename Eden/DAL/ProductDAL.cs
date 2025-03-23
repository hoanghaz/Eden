using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class ProductDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Lấy tất cả sản phẩm
        public DataTable GetAllProducts()
        {
            string query = @"
                SELECT
                    SP.id,
                    SP.TenSanPham AS [Tên],
                    SP.Gia AS [Giá],
                    SP.SoLuong AS [Kho],
                    SP.MoTa AS [Mô tả],
                    SP.NgayNhap AS [Ngày nhập],
                    SP.HanSuDung AS [Hạn],
                    SP.MauSac AS [Màu],
                    LSP.TenLoaiSanPham AS [Loại],
                    NCC.TenNhaCungCap AS [Nhà cung cấp]
                FROM SANPHAM SP
                INNER JOIN LOAISANPHAM LSP ON SP.idLoaiSanPham = LSP.id
                INNER JOIN NHACUNGCAP NCC ON SP.idNhaCungCap = NCC.id";
            return dbHelper.ExecuteQuery(query);
        }

        // Thêm sản phẩm mới
        public int AddProduct(string productName, decimal price, int stock, string description, DateTime importDate, DateTime? expiryDate, string color, string image, int categoryId, int supplierId)
        {
            string query = @"
                INSERT INTO SANPHAM
                    (TenSanPham, Gia, SoLuong, MoTa, NgayNhap, HanSuDung, MauSac, AnhChiTiet, idLoaiSanPham, idNhaCungCap)
                VALUES
                    (@productName, @price, @stock, @description, @importDate, @expiryDate, @color, @image, @categoryId, @supplierId)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@productName", productName),
                new SqlParameter("@price", price),
                new SqlParameter("@stock", stock),
                new SqlParameter("@description", description),
                new SqlParameter("@importDate", importDate),
                new SqlParameter("@expiryDate", expiryDate ?? (object)DBNull.Value), // Xử lý giá trị NULL
                new SqlParameter("@color", color),
                new SqlParameter("@image", image),
                new SqlParameter("@categoryId", categoryId),
                new SqlParameter("@supplierId", supplierId)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật sản phẩm
        public int UpdateProduct(int id, string productName, decimal price, int stock, string description, DateTime importDate, DateTime? expiryDate, string color, string image, int categoryId, int supplierId)
        {
            string query = @"
                UPDATE SANPHAM
                SET
                    TenSanPham = @productName,
                    Gia = @price,
                    SoLuong = @stock,
                    MoTa = @description,
                    NgayNhap = @importDate,
                    HanSuDung = @expiryDate,
                    MauSac = @color,
                    AnhChiTiet = @image,
                    idLoaiSanPham = @categoryId,
                    idNhaCungCap = @supplierId
                WHERE id = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@productName", productName),
                new SqlParameter("@price", price),
                new SqlParameter("@stock", stock),
                new SqlParameter("@description", description),
                new SqlParameter("@importDate", importDate),
                new SqlParameter("@expiryDate", expiryDate ?? (object)DBNull.Value), // Xử lý giá trị NULL
                new SqlParameter("@color", color),
                new SqlParameter("@image", image),
                new SqlParameter("@categoryId", categoryId),
                new SqlParameter("@supplierId", supplierId)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa sản phẩm
        public int DeleteProduct(int id)
        {
            string query = "DELETE FROM SANPHAM WHERE id = @id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
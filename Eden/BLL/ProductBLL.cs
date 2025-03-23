using System;
using System.Data;

namespace Eden
{
    public class ProductBLL
    {
        private ProductDAL productDAL = new ProductDAL();

        // Lấy tất cả sản phẩm
        public DataTable GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        // Thêm sản phẩm mới
        public bool AddProduct(string productName, decimal price, int stock, string description, DateTime importDate, DateTime? expiryDate, string color, string image, int categoryId, int supplierId)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(productName) || price <= 0 || stock < 0 || string.IsNullOrWhiteSpace(description) || categoryId <= 0 || supplierId <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            // Gọi phương thức từ DAL để thêm sản phẩm
            return productDAL.AddProduct(productName, price, stock, description, importDate, expiryDate, color, image, categoryId, supplierId) > 0;
        }

        // Cập nhật sản phẩm
        public bool UpdateProduct(int id, string productName, decimal price, int stock, string description, DateTime importDate, DateTime? expiryDate, string color, string image, int categoryId, int supplierId)
        {
            // Kiểm tra dữ liệu đầu vào
            if (id <= 0 || string.IsNullOrWhiteSpace(productName) || price <= 0 || stock < 0 || string.IsNullOrWhiteSpace(description) || categoryId <= 0 || supplierId <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            // Gọi phương thức từ DAL để cập nhật sản phẩm
            return productDAL.UpdateProduct(id, productName, price, stock, description, importDate, expiryDate, color, image, categoryId, supplierId) > 0;
        }

        // Xóa sản phẩm
        public bool DeleteProduct(int id)
        {
            // Kiểm tra ID hợp lệ
            if (id <= 0)
            {
                throw new Exception("ID không hợp lệ!");
            }

            // Gọi phương thức từ DAL để xóa sản phẩm
            return productDAL.DeleteProduct(id) > 0;
        }
    }
}
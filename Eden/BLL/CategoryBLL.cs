using System;
using System.Data;

namespace Eden
{
    public class CategoryBLL
    {
        private readonly CategoryDAL categoryDAL = new CategoryDAL();

        // Lấy tất cả danh mục
        public DataTable GetAllCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        // Thêm danh mục
        public bool AddCategory(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new Exception("Tên danh mục không hợp lệ!");
            }

            return categoryDAL.AddCategory(categoryName) > 0;
        }

        // Cập nhật danh mục
        public bool UpdateCategory(int id, string categoryName)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return categoryDAL.UpdateCategory(id, categoryName) > 0;
        }

        // Xóa danh mục
        public bool DeleteCategory(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID không hợp lệ!");
            }

            return categoryDAL.DeleteCategory(id) > 0;
        }
    }
}
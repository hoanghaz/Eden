using System;
using System.Data;

namespace Eden
{
    public class CustomerBLL
    {
        private readonly CustomerDAL CustomerDAL = new CustomerDAL();

        // Lấy tất cả khách hàng
        public DataTable GetAllCustomers()
        {
            return CustomerDAL.GetAllCustomer();
        }

        // Thêm khách hàng mới
        public bool AddCustomer(string maKH, string tenKH, string soDienThoai, string diaChi, string email)
        {
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                throw new Exception("Thông tin khách hàng không hợp lệ!");
            }

            return CustomerDAL.AddCustomer(maKH, tenKH, soDienThoai, diaChi, email) > 0;
        }

        // Cập nhật thông tin khách hàng
        public bool UpdateCustomer(int id, string tenKH, string soDienThoai, string diaChi, string email)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return CustomerDAL.UpdateCustomer(id, tenKH, soDienThoai, diaChi, email) > 0;
        }

        // Xóa khách hàng
        public bool DeleteCustomer(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID không hợp lệ!");
            }

            return CustomerDAL.DeleteCustomer(id) > 0;
        }
    }
}
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Eden
{
    public class NhaCungCapBLL
    {
        private readonly NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();

        public DataTable GetAllNhaCungCap()
        {
            return nhaCungCapDAL.GetAllNhaCungCap();
        }

        public bool InsertNhaCungCap(string tenNCC, string diaChi, string soDienThoai, string email)
        {
            if (string.IsNullOrWhiteSpace(tenNCC) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                throw new ArgumentException("Tên nhà cung cấp và số điện thoại không được để trống.");
            }
            if (!Regex.IsMatch(soDienThoai, @"^\d{10,11}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ.");
            }
            return nhaCungCapDAL.InsertNhaCungCap(tenNCC, diaChi, soDienThoai, email);
        }

        public bool UpdateNhaCungCap(int id, string tenNCC, string diaChi, string soDienThoai, string email)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(tenNCC) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                throw new ArgumentException("Thông tin nhà cung cấp không hợp lệ.");
            }
            if (!Regex.IsMatch(soDienThoai, @"^\d{10,11}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ.");
            }
            return nhaCungCapDAL.UpdateNhaCungCap(id, tenNCC, diaChi, soDienThoai, email);
        }

        public bool DeleteNhaCungCap(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID nhà cung cấp không hợp lệ.");
            }
            return nhaCungCapDAL.DeleteNhaCungCap(id);
        }
    }
}
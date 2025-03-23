using System;
using System.Data;

namespace Eden
{
    public class BillBLL
    {
        private readonly BillDAL billDAL = new BillDAL();

        // Lấy tất cả hóa đơn
        public DataTable GetAllBills()
        {
            return billDAL.GetAllBills();
        }

        // Thêm hóa đơn mới
        public bool AddBill(string maHD, DateTime ngayLap, decimal tongTien, int idKhachHang, int idNguoiDung)
        {
            if (string.IsNullOrWhiteSpace(maHD) || tongTien < 0 || idKhachHang <= 0 || idNguoiDung <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return billDAL.AddBill(maHD, ngayLap, tongTien, idKhachHang, idNguoiDung) > 0;
        }

        // Cập nhật hóa đơn
        public bool UpdateBill(int id, DateTime ngayLap, decimal tongTien, int idKhachHang, int idNguoiDung)
        {
            if (id <= 0 || tongTien < 0 || idKhachHang <= 0 || idNguoiDung <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return billDAL.UpdateBill(id, ngayLap, tongTien, idKhachHang, idNguoiDung) > 0;
        }

        // Xóa hóa đơn
        public bool DeleteBill(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID không hợp lệ!");
            }

            return billDAL.DeleteBill(id) > 0;
        }
    }
}
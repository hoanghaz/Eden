using System;
using System.Data;

namespace Eden
{
    public class ChiTietHoaDonBLL
    {
        private readonly ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public DataTable GetAllChiTietHoaDon()
        {
            return chiTietHoaDonDAL.GetAllChiTietHoaDon();
        }

        public bool InsertChiTietHoaDon(int idHoaDon, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            if (idHoaDon <= 0 || idSanPham <= 0 || soLuong <= 0 || donGia < 0 || thanhTien < 0)
            {
                throw new ArgumentException("Thông tin chi tiết hóa đơn không hợp lệ.");
            }
            return chiTietHoaDonDAL.InsertChiTietHoaDon(idHoaDon, idSanPham, soLuong, donGia, thanhTien);
        }

        public bool UpdateChiTietHoaDon(int idHoaDon, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            if (idHoaDon <= 0 || idSanPham <= 0 || soLuong <= 0 || donGia < 0 || thanhTien < 0)
            {
                throw new ArgumentException("Thông tin cập nhật chi tiết hóa đơn không hợp lệ.");
            }
            return chiTietHoaDonDAL.UpdateChiTietHoaDon(idHoaDon, idSanPham, soLuong, donGia, thanhTien);
        }

        public bool DeleteChiTietHoaDon(int idHoaDon, int idSanPham)
        {
            if (idHoaDon <= 0 || idSanPham <= 0)
            {
                throw new ArgumentException("ID hóa đơn hoặc sản phẩm không hợp lệ.");
            }
            return chiTietHoaDonDAL.DeleteChiTietHoaDon(idHoaDon, idSanPham);
        }
    }
}
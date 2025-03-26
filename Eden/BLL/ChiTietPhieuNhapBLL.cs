using System;
using System.Data;

namespace Eden
{
    public class ChiTietPhieuNhapBLL
    {
        private readonly ChiTietPhieuNhapDAL chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();

        public DataTable GetAllChiTietPhieuNhap()
        {
            return chiTietPhieuNhapDAL.GetAllChiTietPhieuNhap();
        }

        public bool InsertChiTietPhieuNhap(int idPhieuNhap, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            if (idPhieuNhap <= 0 || idSanPham <= 0 || soLuong <= 0 || donGia < 0 || thanhTien < 0)
            {
                throw new ArgumentException("Thông tin chi tiết phiếu nhập không hợp lệ.");
            }
            return chiTietPhieuNhapDAL.InsertChiTietPhieuNhap(idPhieuNhap, idSanPham, soLuong, donGia, thanhTien);
        }

        public bool UpdateChiTietPhieuNhap(int idPhieuNhap, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            if (idPhieuNhap <= 0 || idSanPham <= 0 || soLuong <= 0 || donGia < 0 || thanhTien < 0)
            {
                throw new ArgumentException("Thông tin cập nhật chi tiết phiếu nhập không hợp lệ.");
            }
            return chiTietPhieuNhapDAL.UpdateChiTietPhieuNhap(idPhieuNhap, idSanPham, soLuong, donGia, thanhTien);
        }

        public bool DeleteChiTietPhieuNhap(int idPhieuNhap, int idSanPham)
        {
            if (idPhieuNhap <= 0 || idSanPham <= 0)
            {
                throw new ArgumentException("ID phiếu nhập hoặc sản phẩm không hợp lệ.");
            }
            return chiTietPhieuNhapDAL.DeleteChiTietPhieuNhap(idPhieuNhap, idSanPham);
        }
    }
}
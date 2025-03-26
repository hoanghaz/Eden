using System;
using System.Data;

namespace Eden
{
    public class PhieuNhapBLL
    {
        private readonly PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();

        public DataTable GetAllPhieuNhap()
        {
            return phieuNhapDAL.GetAllPhieuNhap();
        }

        public bool InsertPhieuNhap(DateTime ngayNhap, int idNhaCungCap, int idNguoiDung, decimal tongTien)
        {
            if (idNhaCungCap <= 0 || idNguoiDung <= 0 || tongTien < 0)
            {
                throw new ArgumentException("Thông tin phiếu nhập không hợp lệ.");
            }
            return phieuNhapDAL.InsertPhieuNhap(ngayNhap, idNhaCungCap, idNguoiDung, tongTien);
        }

        public bool UpdatePhieuNhap(int id, DateTime ngayNhap, int idNhaCungCap, int idNguoiDung, decimal tongTien)
        {
            if (id <= 0 || idNhaCungCap <= 0 || idNguoiDung <= 0 || tongTien < 0)
            {
                throw new ArgumentException("Thông tin phiếu nhập không hợp lệ.");
            }
            return phieuNhapDAL.UpdatePhieuNhap(id, ngayNhap, idNhaCungCap, idNguoiDung, tongTien);
        }

        public bool DeletePhieuNhap(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID phiếu nhập không hợp lệ.");
            }
            return phieuNhapDAL.DeletePhieuNhap(id);
        }
    }
}
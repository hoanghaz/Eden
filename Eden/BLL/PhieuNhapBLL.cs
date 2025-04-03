using System;
using System.Collections.Generic;

namespace Eden
{
    public class PHIEUNHAPBLL : IDisposable
    {
        private PHIEUNHAPDAL dal = new PHIEUNHAPDAL();

        public PHIEUNHAPBLL()
        {
            dal = new PHIEUNHAPDAL();
        }

        // Lấy tất cả phiếu nhập
        public List<PHIEUNHAP> GetAll()
        {
            return dal.GetAll();
        }

        // Lấy phiếu nhập theo mã phiếu nhập
        public PHIEUNHAP GetByMaPhieuNhap(string maPhieuNhap)
        {
            return dal.GetByMaPhieuNhap(maPhieuNhap);
        }

        // Thêm phiếu nhập
        public void Add(PHIEUNHAP p)
        {
            dal.Add(p);
        }

        // Cập nhật phiếu nhập
        public void Update(PHIEUNHAP p)
        {
            dal.Update(p);
        }

        // Xóa phiếu nhập
        public void Delete(PHIEUNHAP p)
        {
            dal.Delete(p);
        }

        // Lấy chi tiết phiếu nhập theo id phiếu nhập
        public List<CHITIETPHIEUNHAP> GetChiTietByPhieuNhap(int idPhieuNhap)
        {
            return dal.GetChiTietByPhieuNhap(idPhieuNhap);
        }

        // Thêm chi tiết phiếu nhập
        public void AddChiTiet(CHITIETPHIEUNHAP c)
        {
            dal.AddChiTiet(c);
        }

        // Cập nhật chi tiết phiếu nhập
        public void UpdateChiTiet(CHITIETPHIEUNHAP c)
        {
            dal.UpdateChiTiet(c);
        }

        // Xóa chi tiết phiếu nhập
        public void DeleteChiTiet(CHITIETPHIEUNHAP c)
        {
            dal.DeleteChiTiet(c);
        }

        // Dispose
        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

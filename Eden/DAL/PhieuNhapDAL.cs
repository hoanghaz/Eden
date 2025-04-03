using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Eden
{
    public class PHIEUNHAPDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        // Lấy tất cả phiếu nhập cùng thông tin nhà cung cấp và người dùng
        public List<PHIEUNHAP> GetAll()
        {
            return db.PHIEUNHAPs
                     .Include(p => p.NHACUNGCAP)
                     .Include(p => p.NGUOIDUNG)
                     .ToList();
        }

        // Lấy phiếu nhập theo mã phiếu nhập (MaPhieuNhap)
        public PHIEUNHAP GetByMaPhieuNhap(string maPhieuNhap)
        {
            return db.PHIEUNHAPs
                     .Include(p => p.NHACUNGCAP)
                     .Include(p => p.NGUOIDUNG)
                     .FirstOrDefault(p => p.MaPhieuNhap == maPhieuNhap);
        }

        // Thêm phiếu nhập
        public void Add(PHIEUNHAP entity)
        {
            db.PHIEUNHAPs.Add(entity);
            db.SaveChanges();
        }

        // Cập nhật phiếu nhập
        public void Update(PHIEUNHAP entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        // Xóa phiếu nhập
        public void Delete(PHIEUNHAP entity)
        {
            db.PHIEUNHAPs.Remove(entity);
            db.SaveChanges();
        }

        // Lấy chi tiết phiếu nhập theo id phiếu nhập
        public List<CHITIETPHIEUNHAP> GetChiTietByPhieuNhap(int idPhieuNhap)
        {
            return db.CHITIETPHIEUNHAPs
                     .Where(c => c.idPhieuNhap == idPhieuNhap)
                     .ToList();
        }

        // Thêm chi tiết phiếu nhập
        public void AddChiTiet(CHITIETPHIEUNHAP entity)
        {
            db.CHITIETPHIEUNHAPs.Add(entity);
            db.SaveChanges();
        }

        // Cập nhật chi tiết phiếu nhập
        public void UpdateChiTiet(CHITIETPHIEUNHAP entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        // Xóa chi tiết phiếu nhập
        public void DeleteChiTiet(CHITIETPHIEUNHAP entity)
        {
            db.CHITIETPHIEUNHAPs.Remove(entity);
            db.SaveChanges();
        }

        // Dispose
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

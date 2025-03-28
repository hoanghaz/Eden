using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Eden
    {
        public class CHITIETPHIEUNHAPDAL : IDisposable
        {
            private QLBanHoaEntities db;

            // Constructor khởi tạo DbContext
            public CHITIETPHIEUNHAPDAL()
            {
                db = new QLBanHoaEntities();
            }

            // Lấy danh sách tất cả chi tiết phiếu nhập
            public List<CHITIETPHIEUNHAP> GetAll()
            {
                return db.CHITIETPHIEUNHAPs.ToList();
            }

            // Thêm chi tiết phiếu nhập mới
            public void Add(CHITIETPHIEUNHAP entity)
            {
                db.CHITIETPHIEUNHAPs.Add(entity);
                db.SaveChanges();
            }

            // Cập nhật chi tiết phiếu nhập
            public void Update(CHITIETPHIEUNHAP entity)
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            // Xóa chi tiết phiếu nhập
            public void Delete(CHITIETPHIEUNHAP entity)
            {
                db.CHITIETPHIEUNHAPs.Remove(entity);
                db.SaveChanges();
            }

            // Giải phóng tài nguyên khi không còn sử dụng
            public void Dispose()
            {
                db.Dispose();
            }
        }
    }
}

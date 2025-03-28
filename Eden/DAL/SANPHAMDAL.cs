using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class SANPHAMDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }

        public List<SANPHAM> GetAll()
        {
            return db.SANPHAMs.ToList();
        }

        public void Add(SANPHAM sp)
        {
            db.SANPHAMs.Add(sp);
            db.SaveChanges();
        }

        public void Update(SANPHAM sp)
        {
            db.Entry(sp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(SANPHAM sp)
        {
            db.SANPHAMs.Remove(sp);
            db.SaveChanges();
        }
    }
}

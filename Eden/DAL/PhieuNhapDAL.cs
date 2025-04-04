using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class PHIEUNHAPDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<PHIEUNHAP> GetAll() => db.PHIEUNHAPs.ToList();
        public void Add(PHIEUNHAP entity) { db.PHIEUNHAPs.Add(entity); db.SaveChanges(); }
        public void Update(PHIEUNHAP entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(PHIEUNHAP entity) { db.PHIEUNHAPs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}
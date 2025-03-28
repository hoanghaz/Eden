using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class HOADONDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<HOADON> GetAll() => db.HOADONs.ToList();
        public void Add(HOADON entity) { db.HOADONs.Add(entity); db.SaveChanges(); }
        public void Update(HOADON entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(HOADON entity) { db.HOADONs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}
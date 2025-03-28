using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class CHITIETHOADONDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<CHITIETHOADON> GetAll() => db.CHITIETHOADONs.ToList();
        public void Add(CHITIETHOADON entity) { db.CHITIETHOADONs.Add(entity); db.SaveChanges(); }
        public void Update(CHITIETHOADON entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(CHITIETHOADON entity) { db.CHITIETHOADONs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}
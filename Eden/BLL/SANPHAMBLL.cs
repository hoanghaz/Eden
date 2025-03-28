using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class SANPHAMBLL : IDisposable
    {
        private SANPHAMDAL dal = new SANPHAMDAL();

        public SANPHAMBLL()
        {
            dal = new SANPHAMDAL();
        }

        public List<SANPHAM> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(SANPHAM sp)
        {
            dal.Add(sp);
        }

        public void Update(SANPHAM sp)
        {
            dal.Update(sp);
        }

        public void Delete(SANPHAM sp)
        {
            dal.Delete(sp);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

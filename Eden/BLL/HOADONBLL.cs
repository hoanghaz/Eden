using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class HOADONBLL : IDisposable
    {
        private HOADONDAL dal = new HOADONDAL();

        public HOADONBLL()
        {
            dal = new HOADONDAL();
        }

        public List<HOADON> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(HOADON hd)
        {
            dal.Add(hd);
        }

        public void Update(HOADON hd)
        {
            dal.Update(hd);
        }

        public void Delete(HOADON hd)
        {
            dal.Delete(hd);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

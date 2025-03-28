using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class KHACHHANGBLL : IDisposable
    {
        private KHACHHANGDAL dal = new KHACHHANGDAL();

        public KHACHHANGBLL()
        {
            dal = new KHACHHANGDAL();
        }

        public List<KHACHHANG> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(KHACHHANG kh)
        {
            dal.Add(kh);
        }

        public void Update(KHACHHANG kh)
        {
            dal.Update(kh);
        }

        public void Delete(KHACHHANG kh)
        {
            dal.Delete(kh);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

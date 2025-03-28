using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class NGUOIDUNGBLL : IDisposable
    {
        private NGUOIDUNGDAL dal = new NGUOIDUNGDAL();

        public NGUOIDUNGBLL()
        {
            dal = new NGUOIDUNGDAL();
        }

        public List<NGUOIDUNG> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(NGUOIDUNG nd)
        {
            dal.Add(nd);
        }

        public void Update(NGUOIDUNG nd)
        {
            dal.Update(nd);
        }

        public void Delete(NGUOIDUNG nd)
        {
            dal.Delete(nd);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

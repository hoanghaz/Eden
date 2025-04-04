using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eden.Eden;

namespace Eden
{
    internal class NHAPKHOBLL : IDisposable
    {
        private NHAPKHOBLL dal = new NHAPKHOBLL();
        public NHAPKHOBLL()
        {
            dal = new NHAPKHOBLL();
        }

        public List<PHIEUNHAP> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(PHIEUNHAP pn)
        {
            dal.Add(pn);
        }

        public void Update(PHIEUNHAP pn)
        {
            dal.Update(pn);
        }

        public void Delete(PHIEUNHAP pn)
        {
            dal.Delete(pn);
        }
        public void Dispose()
        {
            dal.Dispose();
        }
    }
}

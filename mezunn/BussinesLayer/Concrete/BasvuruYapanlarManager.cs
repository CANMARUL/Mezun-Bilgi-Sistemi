using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
  public  class BasvuruYapanlarManager
    {

        GenericRepository<BasvuruYapanlar> bm = new GenericRepository<BasvuruYapanlar>();
        public List<BasvuruYapanlar> GetAllBasvuruYapanlar()
        {
            return bm.List();



        }
        public void GetAddBasvuruYapanlar(BasvuruYapanlar p)
        {
            bm.Insert(p);

        }
    }
}

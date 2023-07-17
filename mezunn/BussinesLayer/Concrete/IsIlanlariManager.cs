using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class IsIlanlariManager
    {

        GenericRepository<IsIlanlari> im = new GenericRepository<IsIlanlari>();

        public List<IsIlanlari> GetAllIsIlanlari()
        {
            return im.List();

        }
        public void GetAddIsIlanlari(IsIlanlari p)
        {
            im.Insert(p);

        }
        public IsIlanlari getById(int id)
        {
            return im.Get(x => x.IsIlnID == id);
        }
        




    }
}

using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
   public class GraduateManager
    {

       GenericRepository<Graduate> gm = new GenericRepository<Graduate>();

        public List<Graduate> GetAllGraduate()
        {
            return gm.List();



        }
        public void GetAddGraduate(Graduate p)
        {
            gm.Insert(p);

        }

    }
}

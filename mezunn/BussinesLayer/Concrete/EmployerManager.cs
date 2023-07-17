using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
   public class EmployerManager
    {

        GenericRepository<Employer> em = new GenericRepository<Employer>();

        public List<Employer> GetAllEmployer()
        {
            return em.List();
        }

        
        
        
    }
}

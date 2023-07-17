using BussinesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
  public  class RegisterManager
    {
        GenericRepository<Register> rm = new GenericRepository<Register>();
        Context contex = new Context();

        public List<Register> GetAllRegister( )
        {
            return rm.List();

        }
        public void GetAddRegister(Register p)
        {
            rm.Insert(p);

        }
        public Register getById(int id)
        {
            return rm.Get(x => x.registerId == id);
        }
        public void DeleteRegister(Register register)
        {
            rm.Delete(register);
        }

        public void RegisterUpdate(Register register)
        {
            rm.Update(register);
            
        }
        public bool IsUserExists(string email)
        {
            // Veritabanında email kontrolü yapılır
            // Eğer kullanıcı varsa true, yoksa false döndürülür
            // Örneğin:
            using (var context = new Context())
            {
                return context.Registers.Any(r=>r.registerEmail==email);
            }
        }
    }
}

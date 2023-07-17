using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context context = new Context();

        DbSet<T> _object;

       public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T p)
        {
           // var deleteEntity = context.Entry(p);
            //deleteEntity.State = EntityState.Deleted;
            _object.Remove(p);
            context.SaveChanges();

                
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);

        }

        public void Insert(T p)
        {
            try
            {
                context.Set<T>().Add(p);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Hataları loglama veya hata mesajlarını işleme gibi işlemleri yapabilirsiniz.
                // Örneğin:
                foreach (var errorMessage in errorMessages)
                {
                    // Hata mesajını kaydet veya hata yönetimi işlemlerini gerçekleştir.
                }

                throw; // Hatanın yeniden fırlatılması
            }
        }


        public List<T> List()
        {
            return _object.ToList();
        }
        

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updateEntity = context.Entry(p);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
        
    }
}

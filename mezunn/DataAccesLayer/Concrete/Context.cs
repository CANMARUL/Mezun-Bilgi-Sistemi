using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<IsIlanlari> IsIlanlaris { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<BasvuruYapanlar> BasvuruYapanlars { get; set; }
       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class IsIlanlari
    {
        [Key]
        public int IsIlnID { get; set; }

        [StringLength(30)]
        public string CompanyName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(30)]
        public string pozision { get; set; } 
        public string registerId { get; set; }
        public virtual Register Register { get; set; }



    }
}

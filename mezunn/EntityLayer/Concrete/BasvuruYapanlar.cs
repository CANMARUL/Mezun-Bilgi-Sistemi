using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class BasvuruYapanlar
    {
        [Key]
        public int Basvuruid { get; set; }
        [StringLength(30)]
        public string BasvuranName { get; set; }
       
        [StringLength(40)]
        public string BasvuranLastName { get; set; }
        [StringLength(50)]
        public string BasvuranEmail { get; set; }

        [StringLength(50)]
        public string BasvuranDepartment { get; set; }
    }
}

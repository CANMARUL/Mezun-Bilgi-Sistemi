using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Graduate
    {
        [Key]
        public string graduateId { get; set; }
        [StringLength(20)]
        public string graduateName { get; set; }
        [StringLength(20)]
        public string graduateSurname { get; set; }
        [StringLength(100)]
        public string graduateInformation{ get; set; }
        [StringLength(40)]
        public string graduateDepartment { get; set; }




    } 
}

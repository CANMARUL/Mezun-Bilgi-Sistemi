using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Employer
    {
        [Key]
        public int employerCompanyId { get; set; }
        [StringLength(20)]
        public string employerName { get; set; }
        [StringLength(20)]
        public string employerLastName { get; set; }
        
        public int graduateId { get; set; }
        public virtual Graduate graduate { get; set; }
    }
}

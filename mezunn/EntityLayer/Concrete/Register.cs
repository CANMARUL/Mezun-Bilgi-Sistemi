using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Register
    {
        [Key]
        public int registerId { get; set; }
        [StringLength(20)]
        public string registerName { get; set; }
        [StringLength(30)]
        public string resigterLastName{ get; set; }
        [StringLength(30)]
        public string registerDepartment { get; set; }

        [StringLength(50)]
        public string registerEmail { get; set; }
        [StringLength(20)]
        public string registerPassword { get; set; }
        [StringLength(1)]
        public string registerRoll { get; set; }

        public ICollection<IsIlanlari> IsIlanlaris { get; set; }
       
       
    }
}

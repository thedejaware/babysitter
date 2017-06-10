using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities.Entity
{
   public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }


        public Resume Resume { get; set; }

        public int ResumeId { get; set; }

        public short Nationality { get; set; }

        public short Gender { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

    }
}

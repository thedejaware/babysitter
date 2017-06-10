using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities.Entity
{
    public class ContactInformation
    {
        [Key]
        public int Id { get; set; }

        public Resume Resume { get; set; }

        public int ResumeId { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }     

        public string DetailAddress { get; set; }

    }
}

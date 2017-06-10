using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities.Entity
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }

        
    }
}

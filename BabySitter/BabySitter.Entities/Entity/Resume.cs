using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities.Entity
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the resume name.")]
        public string ResumeName { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public short Status { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}

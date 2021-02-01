using EFAiskinimas.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Models
{
   public class StudentExtended : Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Profession { get; set; }
        public List<string> Hobbies { get; set; }

    }
}

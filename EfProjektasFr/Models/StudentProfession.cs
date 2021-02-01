using EFAiskinimas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Models
{
    public class StudentProfession
    {
        public int ProfessionId { get; set; }
        public int StudentId { get; set; }

        public Profession Profession { get; set; }
        public Student Student { get; set; }


    }
}

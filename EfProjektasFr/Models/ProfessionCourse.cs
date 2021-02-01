using EFAiskinimas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Models
{
    public class ProfessionCourse
    {
        public int ProfessionId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
        public Profession Profession { get; set; }
    }
}

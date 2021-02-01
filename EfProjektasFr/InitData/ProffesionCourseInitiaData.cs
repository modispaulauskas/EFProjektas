using EfProjektasFr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EfProjektasFr.InitData
{
    public static class ProffesionCourseInitiaData
    {
        public readonly static ProfessionCourse[] DataSeed =
        {
            new ProfessionCourse { CourseId = 1, ProfessionId = 1 }, // buhalteris
            new ProfessionCourse { CourseId = 2, ProfessionId = 7 },
            new ProfessionCourse { CourseId = 3, ProfessionId = 7 },
            new ProfessionCourse { CourseId = 4, ProfessionId = 10 }, //mokytojas
            new ProfessionCourse { CourseId = 4, ProfessionId = 16 }, //mokslininkas
            new ProfessionCourse { CourseId = 5, ProfessionId = 18 },
            new ProfessionCourse { CourseId = 5, ProfessionId = 20 },
            new ProfessionCourse { CourseId = 6, ProfessionId = 6 },
            new ProfessionCourse { CourseId = 6, ProfessionId = 15 },
            new ProfessionCourse { CourseId = 6, ProfessionId = 20 },
            new ProfessionCourse { CourseId = 7, ProfessionId = 5 },
            new ProfessionCourse { CourseId = 8, ProfessionId = 5 },
            new ProfessionCourse { CourseId = 9, ProfessionId = 5 },
            new ProfessionCourse { CourseId = 9, ProfessionId = 16 },
            new ProfessionCourse { CourseId = 11, ProfessionId = 6 },
            new ProfessionCourse { CourseId = 12, ProfessionId = 4 },
            new ProfessionCourse { CourseId = 12, ProfessionId = 17 },
            new ProfessionCourse { CourseId = 13, ProfessionId = 17 },
        };
    }
}

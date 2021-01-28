using EFAiskinimas.Common.InitialData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Services
{
    class EfProjektasInitializer : CreateDatabaseIfNotExists<EfProjektasContext>
    {
        protected override void Seed(EfProjektasContext context)
        {
            context.Students.AddRange(StudentInitialData.DataSeed);
            context.Professions.AddRange(ProfessionInitialData.DataSeed);
            context.Persons.AddRange(PersonInitialData.DataSeed);
            context.Hobbies.AddRange(HobbyInitialData.DataSeed);
            context.Dormitories.AddRange(DormitoryInitialData.DataSeed);
            context.Courses.AddRange(CourseInitialData.DataSeed);

        }
    }
}

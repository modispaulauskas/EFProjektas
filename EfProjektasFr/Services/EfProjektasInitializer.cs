using EFAiskinimas.Common;
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
            context.Dormitories.AddRange(DormitoryInitialData.DataSeed);
            context.Courses.AddRange(CourseInitialData.DataSeed);

            foreach (var item in HobbyInitialData.DataSeed)
            {
                
                string[] temp = item.Split(',');
                Hobby HData = new Hobby
                {
                    HobbyId = int.Parse(item[0].ToString()),
                    Text = item[1].ToString(),
                    TextLt = item[2].ToString()
                };
                context.Hobbies.Add(HData);
            }
            
        }
    }
}

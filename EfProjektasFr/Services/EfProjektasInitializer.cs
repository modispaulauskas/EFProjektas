using EFAiskinimas.Common;
using EFAiskinimas.Common.InitialData;
using EfProjektasFr.InitData;
using EfProjektasFr.Models;
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
            context.ProfessionsCourses.AddRange(ProffesionCourseInitiaData.DataSeed);

            foreach (var item in HobbyInitialData.DataSeed)
            {
                string[] temp = item.Split(',');
                Hobby HData = new Hobby
                {
                    HobbyId = int.Parse(temp[0]),
                    Text = temp[1],
                    TextLt = temp[2]
                };
                context.Hobbies.Add(HData);
            }

            Random rnd = new Random();
            foreach (var item in StudentInitialData.DataSeed)
            {
                var studentExtended = new StudentExtended
                {
                    StudentId = item.StudentId,
                    Profession = ProfessionInitialData.DataSeed[rnd.Next(1, ProfessionInitialData.DataSeed.Length - 1)].Text,
                    Hobbies = ""
                };
                context.StudentExtended.Add(studentExtended);
            }

        }
    }
}

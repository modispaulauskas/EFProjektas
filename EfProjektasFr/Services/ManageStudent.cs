using EFAiskinimas.Common;
using EFAiskinimas.Common.InitialData;
using EfProjektasFr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Services
{
    public class ManageStudent
    {
        public void GenerateHobbies()
        {
            const int minHobbies = 1;
            const int maxHobbies = 3;

            var random = new Random();

            var numberOfHobies = random.Next(minHobbies, maxHobbies + 1);
            List<string> randomHobies =
                HobbyInitialData.DataSeed
                   .Take(numberOfHobies)
                   .Select(h => h.)
        }
    }
}

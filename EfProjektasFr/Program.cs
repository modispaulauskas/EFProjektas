using EfProjektasFr.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr
{
    class Program
    {
        static void Main(string[] args)
        {
            using( var context = new EfProjektasContext())
            {
                Console.WriteLine(context.Students.First());
            }
        }
    }
}

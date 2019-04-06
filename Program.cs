using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_29_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee();
            manager.Name = "Williams";
            manager.Salary = 255555;
            manager.Vacancy = Vacancies.Manager;
            manager.DateWork = DateTime.Now;

            manager.Print();
        }
    }
}

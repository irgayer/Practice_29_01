using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_29_01
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public DateTime DateWork { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Vacancy       : {Vacancy.ToString()}");
            Console.WriteLine($"Salary        : {Salary}");
            Console.WriteLine($"Working since : {DateWork}");
        }
    }
}

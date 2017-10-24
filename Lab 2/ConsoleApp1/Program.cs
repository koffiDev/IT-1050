using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("[Enter Information for the First Couple]");
            System.Console.WriteLine("");

            Person p1 = new Person();
            p1.AskUserForNameAndAge();
            

            System.Console.WriteLine("");
            System.Console.WriteLine("[Enter Information for the Second Couple]");
            System.Console.WriteLine("");

            Person p2 = new Person();
            p2.AskUserForNameAndAge();

            System.Console.WriteLine("");
            System.Console.WriteLine("[Printing Results]");
            System.Console.WriteLine("");

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
           
            System.Console.WriteLine("Average Age = " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}
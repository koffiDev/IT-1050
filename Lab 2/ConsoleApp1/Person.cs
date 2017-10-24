using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;

        public Person Spouse;

        public static double SumOfAllAges;


        public string GetFullName()
        {
            return this.FirstName + ", " + this.LastName;
        }


        public void AskUserForNameAndAge()
        {
            System.Console.Write("Your First Name              : ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("Your Last Name               : ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("Your Age                     : ");
            this.Age = int.Parse(System.Console.ReadLine());

            this.Spouse = new Person();
            System.Console.Write("Your Spouse's First Name     : ");
            this.Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("Your Spouse Age              : ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());

            this.Spouse.LastName = this.LastName;

            Person.SumOfAllAges += this.Age + this.Spouse.Age;
        }

        public void PrintNameAndAge()
        {
            System.Console.Write(this.GetFullName());
            System.Console.WriteLine(this.Age);
            //System.Console.WriteLine(this.Spouse.GetFullName());
            //System.Console.WriteLine((this.Spouse.Age));
        }
  
        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / 4;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_IT_1050
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("First Name: ");
            string firstName = System.Console.ReadLine();

            System.Console.Write("Middle Initial: ");
            char middleInitial = char.Parse(System.Console.ReadLine());

            System.Console.Write("Last Name: ");
            string lastName = System.Console.ReadLine();

           

            //firstName = "Koffi";
            //middleInitial = "M";
            //lastName = "Azouma";
        
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("Height in feet: ");
            int heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Inches beyond base height in feet: ");
            double heightInches = double.Parse(System.Console.ReadLine());

            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write("Age: ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you citizen? if Yes answer true, if No answer false : ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote ;
            if (isCitizen == true && age >= 18)
            {
                canVote = true;
            }
            else
            {
                canVote = false;
            }


            System.Console.Write("Your full name is: ");
            System.Console.WriteLine(fullName);
            System.Console.Write("Your are: ");
            System.Console.Write(totalHeightCM);
            System.Console.WriteLine(" cm tall");
            System.Console.Write("Your eligibilty to vote: ");
            System.Console.WriteLine(canVote);
            System.Threading.Thread.Sleep(15000);

        }
    }
}

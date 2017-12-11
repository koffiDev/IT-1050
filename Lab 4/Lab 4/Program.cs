using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int childTickets;
            int adultTickets;
            int seniorTickets;
            double totalTicketCost = 0;
            double totalConcessionCost = 0;

            System.Console.WriteLine("Welcome to the Cinema!");
            System.Console.WriteLine("How many Child Tickets?");
            childTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many Adult Tickets?");
            adultTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many Senior Tickets?");
            seniorTickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Will this be a Matinee or Evening show?");
            System.Console.WriteLine("Select 1 for Matinee or 2 for Evening: ");

            string movieTime = System.Console.ReadLine();

            if (movieTime == "1")
            {
                double childPrice = 3.99;
                double adultPrice = 5.99;
                double seniorPrice = 4.50;
                totalTicketCost += childTickets * childPrice;
                totalTicketCost += adultTickets * adultPrice;
                totalTicketCost += seniorTickets * seniorPrice;

            }

            else if (movieTime == "2")
            {
                double childPrice = 6.99;
                double adultPrice = 10.99;
                double seniorPrice = 8.50;
                totalTicketCost += childTickets * childPrice;
                totalTicketCost += adultTickets * adultPrice;
                totalTicketCost += seniorTickets * seniorPrice;
            }

            else
            {
                System.Console.WriteLine("I'm sorry that is not a valid show time");
            }

            int totalTicketCount = childTickets + adultTickets + seniorTickets;

            double smallSodaCost = 3.50;
            double largeSodaCost = 5.99;
            double hotDogCost = 3.99;
            double popcornCost = 4.50;
            double candyCost = 1.99;

            int smallSodaCount = 0;
            int largeSodaCount = 0;
            int hotDogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;

            System.Console.WriteLine("How many small sodas would you like?");
            smallSodaCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many large sodas would you like?");
            largeSodaCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many hot dogs would you like?");
            hotDogCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many popcorns would you like?");
            popcornCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many candys would you like?");
            candyCount = int.Parse(System.Console.ReadLine());

            totalConcessionCost += smallSodaCount * smallSodaCost;
            totalConcessionCost += largeSodaCount * largeSodaCost;
            totalConcessionCost += hotDogCount * hotDogCost;
            totalConcessionCost += popcornCount * popcornCost;
            totalConcessionCost += candyCount * candyCost;

            double firstDiscount = 0;
            double secondDiscount = 0;
            double thirdDiscount = 0;

            if (popcornCount >= 1 && largeSodaCount >= 1 && totalTicketCount >= 1)
            {
                if (popcornCount <= largeSodaCount && popcornCount <= totalTicketCount)
                {
                    firstDiscount = 2 * popcornCount;
                }
                else if (largeSodaCount <= popcornCount && largeSodaCount <= totalTicketCount)
                {
                    firstDiscount = 2 * largeSodaCount;
                }
                else
                {
                    firstDiscount = 2 * totalTicketCount;
                }
            }


            if (totalTicketCount >= 3)
            {
                if (movieTime == "2")
                {
                    if (popcornCount >= 1)
                    {
                        secondDiscount = 4.50;
                    }
                }
            }

            if (candyCount >= 4)
            {
                thirdDiscount = (candyCount / 4) * 1.99;
            }

            double discountAmount = firstDiscount + secondDiscount + thirdDiscount;
            double totalCost = (totalTicketCost + totalConcessionCost) - discountAmount;
            System.Console.WriteLine("Your total cost is: $" + totalCost);
            System.Console.WriteLine();
            System.Console.WriteLine("Press Any Key to Continue....");
            System.Console.ReadKey();
        }




        private static void WelcomeMessage()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Welcome to the Movie Cost Estimator ");
            System.Console.WriteLine("We are going to ask you a series of questions that will help us estimate the cost of your Movie ");
            System.Console.WriteLine();
            System.Console.WriteLine("When are you going to the movie? ");
            System.Console.WriteLine("Please choose from the following options ");
            System.Console.WriteLine("Matinee or Evening ");
        }
    }
}

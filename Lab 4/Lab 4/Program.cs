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
            
            WelcomeMessage();
            string When = System.Console.ReadLine();
            double NumberOfPerson;
            double SmallSoda;
            double LargeSoda;
            double Hotdogs;
            double Popcorns;
            double Candies;
            double ConcessionStand;
            double ticketCost;
            double totalCost;
            

            if (When == "Matinee")
            {
                System.Console.WriteLine();
                System.Console.Write("How many child ticket are you buying? ");
                double Child = double.Parse(System.Console.ReadLine());
                double totalChildcost = Child * 3.99;

                System.Console.Write("How many adult ticket are you buying? ");
                double Adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = Adult * 5.99;

                System.Console.Write("How many senior ticket are you buying? ");
                double Senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = Senior * 4.50;
                //double TotalCost;
                

                ticketCost = totalAdultcost + totalChildcost + totalSeniorcost;

                //totalCost = TotalCost;

                NumberOfPerson = Child + Adult + Senior;
                System.Console.WriteLine("You are buying a total of " + NumberOfPerson + " tickets which will cost $" + ticketCost );
               
            }
            else if (When == "Evening")
            {
                System.Console.WriteLine();
                System.Console.Write("How many child ticket are you buying? ");
                double Child = double.Parse(System.Console.ReadLine());
                double totalChildcost = Child * 6.99;

                System.Console.Write("How many adult ticket are you buying? ");
                double Adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = Adult * 10.99;

                System.Console.Write("How many senior ticket are you buying? ");
                double Senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = Senior * 8.50;
                double TicketCost;

                ticketCost = totalAdultcost + totalChildcost + totalSeniorcost;

                TicketCost = ticketCost;
                //totalCost = TotalCost;
                NumberOfPerson = Child + Adult + Senior;
                System.Console.WriteLine("You are buying a total of " + NumberOfPerson + " tickets which will cost $" + ticketCost);
            }
            else
            {
                System.Console.WriteLine("I didn't get that");
            }


            System.Console.WriteLine("Are you getting any snack from the Concession Stand? Yes or No: ");
            string Snacks = System.Console.ReadLine();

            if (Snacks == "Yes")
            {

                System.Console.Write("How many Small Sodas? ");
                SmallSoda = double.Parse(System.Console.ReadLine());
                SmallSoda = (SmallSoda * 3.50);

                System.Console.Write("How many Large Sodas? ");
                LargeSoda = double.Parse(System.Console.ReadLine());
                LargeSoda = (LargeSoda * 5.99);

                System.Console.Write("How many Hot Dogs? ");
                Hotdogs = double.Parse(System.Console.ReadLine());
                Hotdogs = (Hotdogs * 3.99);

                System.Console.Write("How many Popcorns? ");
                Popcorns = double.Parse(System.Console.ReadLine());
                Popcorns = (Popcorns * 4.50);

                System.Console.Write("How many Candies? ");
                Candies = double.Parse(System.Console.ReadLine());
                Candies = (Candies * 1.99);

                ConcessionStand = SmallSoda + LargeSoda + Hotdogs + Popcorns + Candies;

                totalCost = ticketCost + ConcessionStand;

                if ((Popcorns > 0) && (LargeSoda > 0))
                {
                    System.Console.WriteLine("Because you've bought a large popcorn and a large soda you recieve a $2 discount.");
                    System.Console.WriteLine("Your total is now: " + (ConcessionStand - 2));
                }
                if (Candies >= 5.97)
                {
                    System.Console.WriteLine("You have bought 3 candies and now you get one free!");
                }
                System.Console.WriteLine("Your balance is $" + totalCost);
            }
            else
            {
                
                System.Console.WriteLine("No Snack then!");
                System.Console.WriteLine("The total cost of your Movie remains the same");
            }



            System.Console.WriteLine("Enjoy your Movie!");

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

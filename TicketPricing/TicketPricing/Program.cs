using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPricing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("SILVER BIRD THEATER TICKET PRICING");
            Console.WriteLine("____________________________________________________________________________________________________");
            Console.WriteLine("");


            double TicketPrice = 10.00;
            String CustomerName;
            int CustomerAge;


            Console.WriteLine("Welcome to Silver Bird. We would like to know your name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Hi {CustomerName}, we would like to know your age for your ticket price");
            Console.WriteLine("How old are you?");
            CustomerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");


            if (CustomerAge >= 65 || CustomerAge <= 12)
            {
                double Discount = 7.00;
                TicketPrice -= Discount;
                Console.WriteLine($"You have a special discount of GHC {Discount} ");
                Console.WriteLine("Your Ticket Price is GHC : " + TicketPrice);
            }
            else
            {
                Console.WriteLine("Your Ticket Price is GHC : " + TicketPrice);
            }

            Console.ReadKey();
        }
    }
}

using System;


namespace TriangleIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("DETERMINE THE TYPE OF TRIAGLE");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("");

            double Len1;
            double Len2;
            double Len3;
            String TriangleType;
            

            Console.WriteLine("Enter bottom lenght of the triangle in cm");
            Len1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter right side lenght of the triangle in cm");
            Len2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter left side lenght of the triangle in cm");
            Len3 = Convert.ToDouble(Console.ReadLine());

           
            if (Len1 == Len2 && Len1 == Len3 && Len3 == Len2)
            {
                Console.WriteLine("Triangle is  Equilateral");
            }
            else if (Len1 != Len2 && Len1 != Len3 && Len3 != Len2)
            {
                Console.WriteLine("Triangle is  Scalene");

            }
            else
            {

                Console.WriteLine("Triangle is   Isosceles");
            }


            Console.ReadKey();

        } 
    }
}

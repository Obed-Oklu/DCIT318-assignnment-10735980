using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Grade Calculator");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("");

            String AskUserInput = "Please input your Grade Score";
            int UserInput;
            String Grade ;

              Console.WriteLine(AskUserInput);
              UserInput = Convert.ToInt32 (Console.ReadLine());

              Console.WriteLine();
              Console.WriteLine($"Your Score is : {UserInput}");

            if (UserInput >= 0 & UserInput < 60)
            {
                Grade = "F";
                Console.WriteLine("Your Grade is : "  + Grade);
                
            }
            else if(UserInput > 59 & UserInput < 70)
            {
                Grade = "D";
                Console.WriteLine("Your Grade is : " + Grade);
            }
            else if(UserInput > 69 & UserInput < 80)
            {
                Grade = "C";
                Console.WriteLine("Your Grade is : " + Grade);
            }
            else if(UserInput > 79 & UserInput < 90)
            {
                Grade = "B";
                Console.WriteLine("Your Grade is : " + Grade);
            }

            else if (UserInput > 89 & UserInput <= 100)
            {
                Grade = "A";
                Console.WriteLine("Your Grade is : " + Grade);
            }

            else
                Console.WriteLine("That's Incorrect! Re enter a grade score between 0 - 100");


            Console.ReadKey();
        }
    }
}

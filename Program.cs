using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Assessment1a
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            while (proceed == true)
            {
                string output = EnterGrade();
                Console.WriteLine(output);
                proceed = Proceed();
            }
        }

        public static string EnterGrade()
        {
            string input = "";
            int validcheck = 1;
                Console.WriteLine("Please enter your grades here ");
            while (validcheck == 1)
            {
                Console.Write("Grade #1: ");
                input = Console.ReadLine();
                if (input.All(char.IsNumber))
                {
                    validcheck = 0;
                }
                else
                {
                    validcheck = 1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            double grade1 = double.Parse(input);
            validcheck = 1;
            while (validcheck == 1)
            {
                Console.Write("Grade #2: ");
                input = Console.ReadLine();
                if (input.All(char.IsNumber))
                {
                    validcheck = 0;
                }
                else
                {
                    validcheck = 1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            double grade2 = double.Parse(input);
            validcheck = 1;
            while (validcheck == 1)
            {
                Console.Write("Grade #3: ");
                input = Console.ReadLine();
                if (input.All(char.IsNumber))
                {
                    validcheck = 0;
                }
                else
                {
                    validcheck = 1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            validcheck = 1;
            double grade3 = double.Parse(input);


            double quotient = AverageGrades(grade1, grade2, grade3);

                string result = OddOrEvenAndPassing(quotient);

               string output =  ($"Your quotient is {quotient} and {result}");

                return output;
                
        }

        public static bool IsPassing(double grade)
        {
            if(grade > 65)
            {
                return true;
            }
            if (grade <= 65)
            {
                return false;
            }
            return false;
        }

        public static double AverageGrades(double grade1, double grade2, double grade3)
        {
            double sum = (grade1 + grade2 + grade3);
            double quotient = (sum / 3);
            return quotient;
        }

        public static string OddOrEvenAndPassing(double grade)
        {
            if (IsPassing(grade) && grade % 2 != 0)
            {
                return "passing and odd";
            }
            if (!IsPassing(grade) && grade % 2 != 0)
            {
                return "failing and odd";
            }
            if (IsPassing(grade) && grade % 2 == 0)
            {
                return "passing and even";
            }
            if (!IsPassing(grade) && grade % 2 == 0)
            {
                return "failing and even";
            }
            else
            {
                return "error";
            }
        }

        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine().ToLower();
            if (proceed.StartsWith("y"))
            {
                return true;
            }
            if (proceed.StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }
        }

    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;
namespace Calc
{
    class Program
    {
        static void sum()
        {
            int[] sumnumbers = new int[2];
            Console.WriteLine("Enter First Number: ");
            sumnumbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            sumnumbers[1] = Convert.ToInt32(Console.ReadLine());

            int sum = sumnumbers[0] + sumnumbers[1];
            Console.WriteLine($"The sum of {sumnumbers[0]} and {sumnumbers[1]} is {sum}");
        }

        static void greatestNumber()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Input first value: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second value: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input third value: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The maximum number is {numbers.Max()}");
        }

        static void factorial()
        {
            long fac = 1;
            Console.WriteLine("Enter a Positive Integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Factorial of a negatice number does not exist!!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fac *= i;
                }

                Console.WriteLine($"The factorial of {n} is {fac}");
            }
        }

        static void simpleInterest()
            {
                Console.WriteLine("Enter Value for Principal: ");
                int principal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Value for Rate: ");
                int rate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Value for Time: ");
                int time = Convert.ToInt32(Console.ReadLine());

                int simpInterest = (principal * rate * time) / 100;
                Console.WriteLine($"The simple interest is {simpInterest}");
            }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Input 1 for sum, 2 for greatest number, 3 for factorial, 4 for simple interest: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    sum();
                    Main(args);
                    break;

                case 2:
                    greatestNumber();
                    Main(args);
                    break;

                case 3:
                    factorial();
                    Main(args);
                    break;

                case 4:
                    simpleInterest();
                    Main(args);
                    break;

                default:
                    Console.WriteLine("You did not select any of the options!!");
                    break;
            }
        }
    }
}

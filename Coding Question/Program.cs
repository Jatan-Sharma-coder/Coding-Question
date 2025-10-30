using Coding_Question;
using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace StartingPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Factoiral of Number 
            Factorial factorial = new Factorial();
            Console.WriteLine("Enter any number to calulate Factorials");
            int input = Convert.ToInt32(Console.ReadLine());

            //Simple
            int fact = factorial.CalculateFactRecursive(input);
            Console.WriteLine($"Factorial of {input} is {fact}");

            //Recursive
            fact = factorial.CalculateFactSimple(input);
            Console.WriteLine($"Factorial of {input} is {fact}");
        }
    }
}
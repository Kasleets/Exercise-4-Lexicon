using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_structure.Methods;

namespace Data_structure
{
    //Github test push for submit this version of file. V2.0
    // Class for the extra exercise 5 and 6
    public class ExtraExercise
    {
        public static void HandleRecursiveOdd()
        {
            Console.Write("Enter a number for Recursive Odd: ");
            int nOdd = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nOdd}th odd number is: {RecursiveOdd(nOdd)}");
        }

        public static void HandleRecursiveEven()
        {
            Console.Write("Enter a number for Recursive Even: ");
            int nEven = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nEven}th even number is: {RecursiveEven(nEven)}");
        }

        public static void HandleFibonacci()
        {
            Console.Write("Enter a number for Fibonacci: ");
            int nFib = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nFib}th Fibonacci number is: {Fibonacci(nFib)}");
        }

        public static void HandleIterativeOdd()
        {
            Console.Write("Enter a number for Iterative Odd: ");
            int nOdd = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nOdd}th odd number is: {IterativeOdd(nOdd)}");
        }

        public static void HandleIterativeEven()
        {
            Console.Write("Enter a number for Iterative Even: ");
            int nEven = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nEven}th even number is: {IterativeEven(nEven)}");
        }

        public static void HandleIterativeFibonacci()
        {
            Console.Write("Enter a number for Iterative Fibonacci: ");
            int nFib = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The {nFib}th Fibonacci number is: {IterativeFibonacci(nFib)}");
        }
    }
}

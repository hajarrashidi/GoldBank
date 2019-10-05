using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secodnNubmer;
            
            Console.Write("Input the First Number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Intput the Second Number: ");
            secodnNubmer = int.Parse(Console.ReadLine());
            int[] result = SwapNumbers(firstNumber, secodnNubmer);
            Console.WriteLine("First Number: " + result[0]);
            Console.WriteLine("Second Number: " + result[1]);
            
        }

        static int[] SwapNumbers(int firstNumber, int secondNumber)
        {
            int tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
            return new[] {firstNumber, secondNumber}; 
        }
        

    }
  
}

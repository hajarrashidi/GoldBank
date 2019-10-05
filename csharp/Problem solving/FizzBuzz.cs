using System;

class FizzBuzz
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FizzBuzz (1-100)");
        Console.WriteLine("----------------");

        for (int i = 1; i <= 100; i++)
        {
            var fizz = i % 3 == 0;
            var buzz = i % 5 == 0;

            if (fizz && buzz)
                Console.WriteLine("FizzBuzz");
            else if (fizz)
                Console.WriteLine("Fizz");
            else if (buzz)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }

        Console.ReadLine();



    }
}
using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please provide a number. ");
            int usersNumber = int.Parse( Console.ReadLine() );

            int someMathResult = Sum(usersNumber);
            Console.WriteLine(someMathResult);
            Console.ReadLine();
        }

        // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
        // Use the equation (n * (n + 1)) / 2.
        public static int Sum(int number)
        {
            int result = (number * (number + 1)) / 2;
            return result;
        }
    }
}

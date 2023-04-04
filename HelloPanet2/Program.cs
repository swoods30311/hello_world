// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            byte numOne = 3;
            byte numTwo = 8;

            Console.WriteLine(numTwo % numOne == 0);
            Console.WriteLine(numTwo / numOne);
            Console.WriteLine(numTwo != numOne);

            if (numTwo > numOne && numTwo % numOne ==0)
            {
                Console.WriteLine("This number set is the --it");
            }
            else
            {
                Console.WriteLine("F the world");
            }

            if (numTwo > numOne ||numTwo % numOne == 0)
            {
                Console.WriteLine("This number set is the --it");
            }
            else
            {
                Console.WriteLine("F the world");
            }

        }
    }
}

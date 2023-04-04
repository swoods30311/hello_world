// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Turning a byte to an integer happens implicitly b/c there is no data lost
            byte b = 1; //                           00000001
            int i = b; // 00000000 00000000 00000000 00000001

            double num = 89;
            //Explicit casting 
            int data = (int)num;//As oppose to int data = num
            Console.WriteLine(data);

            long number = 18;
            short numerical = (short)number;// look @ it like (short)number represents the transition from previous data type to current on

            Console.WriteLine(number);






        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Big Slime";

            static string greetings(string name)
            {
                // code to be executed
                return "What it do " + name + "?";

            }

            Console.WriteLine(greetings(name));

            
        }

        }
    }


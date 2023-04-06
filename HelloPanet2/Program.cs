// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Big Slime";

            static void greetings(string name)
            {
                // code to be executed
                Console.WriteLine("What it do? " + name);
            }

            greetings(name);
        }

        }
    }


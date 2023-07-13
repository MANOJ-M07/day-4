using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the number ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0) 
            {
                Console.WriteLine("The number is positive");
            }
            else 
            {
                Console.WriteLine("The number is negative");
            }
            string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("the number is " +  evenOrOdd);*/


            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + evenOrOdd + ".");
            Console.ReadKey();  
        }
    }
}

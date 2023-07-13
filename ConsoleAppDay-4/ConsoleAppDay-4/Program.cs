using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(condition) ?true case: false case
            //    int num1, num2;
            //    console.writeline("enter the first number");
            //    num1 = int.parse(console.readline());
            //    console.writeline("enter the second number ");
            //    num2 = int.parse(console.readline());
            //    var result = num1 > num2 ? "first number is greater " : "second number is greater";
            //    console.writeline(result);
            //    console.readkey();


            /* int num1 , num2;
             Console.WriteLine("");
             num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("");
             num2 = int.Parse(Console.ReadLine());
             if (num1 != num2)
             {
                 var result = num1 > num2 ? "first number is greater " : "second number is greater ";
                 Console.WriteLine(result);
             }*/

            int pre;
            int final;
            Console.WriteLine("Enter marks in the preexam:");
            pre = int.Parse(Console.ReadLine());

            if (pre > 60)
            {
                Console.WriteLine("Enter marks in the final exam:");
                final = int.Parse(Console.ReadLine());

                if (final > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
                Console.ReadKey();
            }
        }

    }

}


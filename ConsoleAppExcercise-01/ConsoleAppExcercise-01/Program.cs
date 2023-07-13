using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExcercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] rollnumbers = new int[4];
            int[,] marks = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter student {i + 1}\'s roll number");
                rollnumbers[i] = int.Parse(Console.ReadLine());

                *//*Console.WriteLine($"enter marks of student\'s {i + 1}");*//*
                for (int j = 1; j < 5; j++)
                {
                   Console.WriteLine($" enter the marks of student\'s {i+1}sem{j}");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < 4; i++)
            {
                int total = 0 ;
                for (int j = 0; j < 4; j++)
                {
                    total += marks[i, j] ;

                }
                marks[i, 4] = total ;
            }
            Console.WriteLine("roll no \t semone \t semtwo \t semthere \t semfour \t total");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{rollnumbers[i]}\t");
                for (int j = 1; j < 5; j++)
                {
                    Console.Write($"{marks[i,j]}\t");
                }
                Console.WriteLine("\t");
            }
            Console.ReadKey();*/

            int[,] marks = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Student {i + 1}\'s Roll number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine($"Enter marks of the Student\'s{i + 1} in Sem {j}");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List as follows");
            Console.WriteLine("RollNo SemOne SemTwo SemThree SemFour Total");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(marks[i, j] + " \t");
                }
                int total = 0;
                for (int k = 1; k < 5; k++)
                {
                    total = total + marks[i, k];
                }
                Console.Write(total);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] marks = new int[5];
            Console.WriteLine("Enter the marks");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("enter marks in subject" + (i+1));
                marks[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("marks lists");
            for(int i = 0;i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i+1} \t Marks : {marks[i]}");
            }
            Console.ReadKey();*/

            /*int[] marks = { 25,55,88,99};
            Console.WriteLine("marks lists");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks : {marks[i]}");
            }
            Console.ReadKey();*/

            Console.WriteLine("Enter Number of Students");
            int nos = int.Parse(Console.ReadLine());
            string[] students = new string[nos];
            for (int i = 0; i < nos; i++)
            {
                Console.WriteLine($"Enter student {i+1}\'s name");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("List of Student");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();  
        }
    }
}

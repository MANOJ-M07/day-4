using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[,] myRectArray = new string[4, 3];
            for (int i = 0; i <myRectArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRectArray.GetLength(1); j++) 
                {
                    myRectArray[i, j] = "[" + i + "," + j+"]";
                }
            }
            Console.WriteLine("Stored Values are:"); 
            for (int i = 0;i < myRectArray.GetLength(0);i++)
            {
                for(int j = 0;j < myRectArray.GetLength(1);j++)
                {
                    Console.Write(myRectArray[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();  */

            int[,] marks = new int[4, 3];
            for (int i = 0; i <4 ; i++)
            {
                Console.WriteLine($"Enter student {i + 1}\'s roll number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 1; j <3 ; j++)
                {
                    Console.WriteLine($"enter marks of student\'s {i + 1} in sem{j}");
                    marks[i,j]= int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("marks list as follows");
            Console.WriteLine("roll no \t semone \t semtwo");
            for (int i = 0; i< 4; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(marks[i,j] + "\t");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();  

        }
    }
}

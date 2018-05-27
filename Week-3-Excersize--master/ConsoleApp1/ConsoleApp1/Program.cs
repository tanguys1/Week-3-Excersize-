using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mod Testing
            int monthNumber;

            Console.WriteLine("Welcome to the Decision Calendar program! " + Environment.NewLine);

            Console.Write("Enter Month Number (1-12): ");
            monthNumber = Convert.ToInt32(Console.ReadLine());

            while (monthNumber < 1 || monthNumber > 12)
            {
                Console.Write("Enter Month Number (1-12): ");
                monthNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (monthNumber == 1)
            {
                Console.WriteLine("This is the 1st month...January");
            }
            else if (monthNumber == 2)
            {
                Console.WriteLine("This is the 2nd month...February");
            }
            else if (monthNumber == 3)
            {
                Console.WriteLine("This is the 3rd month...March");
            }
            else if (monthNumber == 4)
            {
                Console.WriteLine("This is the 4th month...April");
            }
            else if (monthNumber == 5)
            {
                Console.WriteLine("This is the 5th month...May");
            }
            else if (monthNumber == 6)
            {
                Console.WriteLine("This is the 6th month...June");
            }
            else if (monthNumber == 7)
            {
                Console.WriteLine("This is the 7th month...July");
            }
            else if (monthNumber == 8)
            {
                Console.WriteLine("This is the 8th month...August");
            }
            else if (monthNumber == 9)
            {
                Console.WriteLine("This is the 9th month...September");
            }
            else if (monthNumber == 10)
            {
                Console.WriteLine("This is the 10th month...October");
            }
            else if (monthNumber == 11)
            {
                Console.WriteLine("This is the 11th month...November");
            }
            else if (monthNumber == 12)
            {
                Console.WriteLine("This is the 12th month...December");
            }
            Console.WriteLine(Environment.NewLine + "Thank you for using the program! ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

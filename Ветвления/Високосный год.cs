using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(IsLeapYear(2014));
            Console.WriteLine(IsLeapYear(1999));
            Console.WriteLine(IsLeapYear(8992));
            Console.WriteLine(IsLeapYear(1));
            Console.WriteLine(IsLeapYear(14));
            Console.WriteLine(IsLeapYear(400));
            Console.WriteLine(IsLeapYear(600));
            Console.WriteLine(IsLeapYear(3200));
            FinalTesting(); // Тестирование решения на секретных тестах
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
        }
    }
}

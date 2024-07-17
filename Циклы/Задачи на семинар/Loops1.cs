using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 23458;
            Console.WriteLine(GetReverseNumber(number));
        }

        static int GetReverseNumber(int number)
        {
            int reverseNumber = 0;
            var lenghtNumber = number.ToString().Length;
            var count = lenghtNumber - 1;
            for (var i = 0; i < lenghtNumber; i++)
            {
                var des = (int)Math.Pow(10, i);
                var digit = (number / des) % 10;
                reverseNumber += digit * (int)Math.Pow(10, count);
                count--;
            }
            return reverseNumber;
        }
    }
}

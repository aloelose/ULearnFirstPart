using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 100; i < 999;  i++)
            {
                var firstNumber = Convert.ToInt32(new string(i.ToString()[0], 1));
                var secondNumber = Convert.ToInt32(new string(i.ToString()[1], 1));
                var thirdNumber = Convert.ToInt32(new string(i.ToString()[2], 1));
                if (firstNumber + secondNumber + thirdNumber == n)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

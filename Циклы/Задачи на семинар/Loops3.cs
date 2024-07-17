using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPosition(11));
        }

        static int GetPosition(int number)
        {
            var sum = "";
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return (int)char.GetNumericValue(sum[number - 1]);
        }
    }
}

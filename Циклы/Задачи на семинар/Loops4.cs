using System;
using System.Linq;

namespace loops4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6};
            WriteArray(array);

            Console.WriteLine();
            Console.Write("subarray: ");
            WriteArray(GetMaxSubArrays(array));
            Console.WriteLine();
        }

        static int[] GetMaxSubArrays(int[] array)
        {
            int maxRepeat = 0;
            int repeat = 1;
            int end = 0;
            for ( int i = 0; i < array.Length-1; i++ )
            {
                if (array[i] == array[i + 1])
                    repeat += 1;
                else
                    repeat = 1;
                if (repeat > maxRepeat)
                {
                    maxRepeat = repeat;
                    end = i;
                }     
            }
            end += 1;
            var start = end - maxRepeat + 1;
            var newArray = array.Skip(start).Take(maxRepeat).ToArray();
            return newArray;
        }
        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}

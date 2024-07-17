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
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            string upFrame = "+";
            for (int i = 0; i < text.Length + 2; i++)
            {
                upFrame += "-";
            }
            upFrame += "+";

            string centerFrame = $"| {text} |";

            Console.WriteLine(upFrame);
            Console.WriteLine(centerFrame);
            Console.WriteLine(upFrame);
        }
    }
}

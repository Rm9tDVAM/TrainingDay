using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2c084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int count = line.Length + 2;
            printLine(count);
            Console.WriteLine("+{0}+",line);
            printLine(count);
        }
        static void printLine(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}

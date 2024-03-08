using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d281
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int Y = 0;
            for (int i = 0; i < line.Length; i++)
            {
                Y += int.Parse(line[i]);
            }
            if (X <= Y)
            {
                Console.WriteLine("NG");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}

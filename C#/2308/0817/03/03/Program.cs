using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            Console.WriteLine(Math.Max(int.Parse(line[0]), int.Parse(line[1]))-Math.Min(int.Parse(line[0]), int.Parse(line[1])));
        }
    }
}

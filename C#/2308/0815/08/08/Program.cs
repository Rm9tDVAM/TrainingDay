using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] sp = line.Split(' ');
            Console.WriteLine(int.Parse(sp[0]) * int.Parse(sp[1]));
        }
    }
}

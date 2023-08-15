using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] temp = line.Split(' ');
            Console.WriteLine(int.Parse(temp[0]) % int.Parse(temp[1]));
        }
    }
}

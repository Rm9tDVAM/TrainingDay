using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] array = line.Split(' ');
            Console.WriteLine(int.Parse(array[0]) - int.Parse(array[1]));
        }
    }
}

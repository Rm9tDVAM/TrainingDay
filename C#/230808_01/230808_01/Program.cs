using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230808_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(array[0]) - int.Parse(array[1]));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double line = double.Parse(Console.ReadLine());
            double ans = line * 1.5;
            Console.WriteLine(ans.ToString("F1"));
        }
    }
}

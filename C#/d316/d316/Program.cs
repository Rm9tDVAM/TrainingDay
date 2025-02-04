using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 30;
            int t = 0;
            for (int i = 0; i < 4; i++) {
                t = int.Parse(Console.ReadLine());
                min = Math.Min(t, min);
            }
            Console.WriteLine(min);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d284
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            if (W >= 8)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NG");
            }
        }
    }
}

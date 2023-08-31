using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] src = { 0, 1, 2, 3, 4, 5 };
            var query = src.Select(x => x % 3);
            Console.WriteLine("[{0}]",string.Join(",",query));
        }
    }
}

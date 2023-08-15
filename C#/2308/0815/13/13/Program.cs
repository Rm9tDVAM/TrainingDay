using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            int num1 = int.Parse(line1[0]) + int.Parse(line1[1]);
            int num2 = int.Parse(line2[0]) + int.Parse(line2[1]);
            int ans = Math.Min(num1,num2);
            Console.WriteLine(ans);
        }
    }
}

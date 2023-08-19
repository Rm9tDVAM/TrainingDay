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
            int ans = 0;
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                ans += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ans);
        }
    }
}

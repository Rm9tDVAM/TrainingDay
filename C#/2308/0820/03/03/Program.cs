using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < line2.Length; i++ )
            {
                if (line2.Substring(i,1) == line1)
                {
                    ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

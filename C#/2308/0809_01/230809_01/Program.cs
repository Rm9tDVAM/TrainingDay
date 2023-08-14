using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230809_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line=Console.ReadLine();
            int ans;ans = 2;
            for(int i = 1; i < int.Parse(line); i++)
            {
                ans = ans * 2;
            }
            Console.WriteLine(ans);
        }
    }
}

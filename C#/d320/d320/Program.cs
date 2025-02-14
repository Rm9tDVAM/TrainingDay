using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = n / 6;
            Console.WriteLine(ans);
            if ( n % 6 == 0) {
            }
            else
            {
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}

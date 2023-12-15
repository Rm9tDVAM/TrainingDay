using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ymd = Console.ReadLine().Split(' ');
            string[] ab = Console.ReadLine().Split(' ');
            int y = int.Parse(ymd[0]);
            int yy = 0;
            int m = int.Parse(ymd[1]);
            int d = int.Parse(ymd[2]);
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            int ans = 0;
            yy = y + 1;
            while (true)
            {
                y++;
                if (y % 4 == 1)
                {
                    break;
                }
            }

            for(int i = m+1; i <= 13; i++)
            {
                ans += getDays(i);
            }

            for(int i = 1; i < a; i++)
            {
                ans += getDays(i);
            }
            
            ans += 181 * (y-yy);
            ans += getDays(m)-d;
            ans += b;
            Console.WriteLine(ans);
        }
        private static int getDays(int m)
        {
            if (m % 2 == 0)
            {
                return 15;
            }
            else
            {
                return 13;
            }
        }
    }
}

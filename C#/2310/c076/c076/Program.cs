using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1=Console.ReadLine().Split(' ');
            int payX = int.Parse(line1[0]);
            int payY = int.Parse(line1[1]);
            int payZ = int.Parse(line1[2]);
            int day = int.Parse(Console.ReadLine());
            int ans = 0;
            for(int i = 0; i < day; i++)
            {
                string[] line2 = Console.ReadLine().Split(' ');
                int start = int.Parse(line2[0]);
                int end = int.Parse(line2[1]);
                for (int j = start; j < end; j++)
                {
                    if (j <= 8)
                    {
                        ans += payZ;
                    }
                    else if (j <= 16)
                    {
                        ans += payX;
                    }
                    else if (j <= 21)
                    {
                        ans += payY;
                    }
                    else
                    {
                        ans += payZ;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

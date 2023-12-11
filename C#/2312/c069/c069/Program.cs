using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] ymd = Console.ReadLine().Split(' ');
            //string[] ab = Console.ReadLine().Split(' ');
            //int y = int.Parse(ymd[0]);
            int y = 2000;
            int yy = 0;
            //int m = int.Parse(ymd[1]);
            //int d = int.Parse(ymd[2]);
            //int a = int.Parse(ab[0]);
            //int b = int.Parse(ab[1]);
            yy = y;
            while (true)
            {
                y++;
                if (y % 4 == 1)
                {
                    break;
                }
            }
            Console.WriteLine(y-yy);
        }
    }
}

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
            //string[] ymd = Console.ReadLine().Split(' ');
            //string[] ab = Console.ReadLine().Split(' ');
            //int y = int.Parse(ymd[0]);
            int y = 2000;
            int yy = 0;
            //int m = int.Parse(ymd[1]);
            int m = 12;
            //int d = int.Parse(ymd[2]);
            int d = 10;
            //int a = int.Parse(ab[0]);
            int a = 1;
            //int b = int.Parse(ab[1]);
            int b = 10;
            int ans = 0;
            yy = y;
            while (true)
            {
                y++;
                if (y % 4 == 1)
                {
                    break;
                }
            }
            con(yy,y);
        }
        private void con(int yy,int y)
        {
            Console.WriteLine();
        }
    }
}

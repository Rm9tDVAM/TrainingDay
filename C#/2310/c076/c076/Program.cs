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
            //string[] line1=Console.ReadLine().Split(' ');
            string[] line1 = { "1000","1300","1500" };
           // string[] line1 = { "1300","1500","1700" };
            //string[] line1 = { "10","100","1000" };
            int payX = int.Parse(line1[0]);
            int payY = int.Parse(line1[1]);
            int payZ = int.Parse(line1[2]);
            int x = 0;
            int y = 0;
            int z = 0;
            //int day = int.Parse(Console.ReadLine());
            //int day = 4;
            // int day = 7;
            int day = 1;
            //string[] temp = { "0 9","9 17","17 22","22 23" };
            //string[] temp = { "8 19","9 20","10 21","11 22","0 23","20 22","0 21" };
            string[] temp = { "9 17" };
            for(int i = 0; i < day; i++)
            {
                //string[] line2 = Console.ReadLine().Split(' ');
                string[] line2 = temp[i].Split(' ');
                int start = int.Parse(line2[0]);
                int end = int.Parse(line2[1]);
                //Console.WriteLine("{0},{1},{2}",i,start,end);
                for (int j = start; j < end; j++)
                {
                    if (j <= 9)
                    {
                        ans += payZ;
                    }
                    else if (j <= 17)
                    {
                        ans += payX;
                    }
                    else if (j <= 22)
                    {
                        ans += payY;
                    }
                    else if (j == 23)
                    {
                        ans += payZ;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

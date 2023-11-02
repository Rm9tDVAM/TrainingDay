using System;
using System.Collections.Generic;
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
            int payX = int.Parse(line1[0]);
            int payY = int.Parse(line1[1]);
            int payZ = int.Parse(line1[2]);
            //int day = int.Parse(Console.ReadLine());
            int day = 4;
            int ans = 0;
            string[] temp = { "0 9","9 17","17 22","22 23" };
            for(int i = 0; i < day; i++)
            {
                //string[] line2 = Console.ReadLine().Split(' ');
                string[] line2 = temp[i].Split(' ');
                int start = int.Parse(line2[0]);
                int end = int.Parse(line2[1]);
                for (int j = start; i < end; i++)
                {
                    if (i <= 9)
                    {
                        ans += payX;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

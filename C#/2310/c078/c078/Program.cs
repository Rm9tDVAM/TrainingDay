using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = { "5","110","120" };
            int count = int.Parse(line[0]);
            int min = int.Parse(line[1]);
            int max = int.Parse(line[2]);
            int ans = 0;
            int nums = 0;
            int[] testdata = { 110,100,120,130,105 };

            for (int i = 0; i < count; i++)
            {
                //int num = int.Parse(Console.ReadLine());
                int num = testdata[i];
                if(num <= min)
                {
                    ans -= num;
                    nums++;
                }
                else if (num >= max) {
                    ans += num * nums;
                    nums = 0;
                }
                Console.WriteLine("{0} {1} {2}",num,nums,ans);
            }
            Console.WriteLine(ans);
        }
    }
}

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
            string[] line = Console.ReadLine().Split(' ');
            int count = int.Parse(line[0]);
            int min = int.Parse(line[1]);
            int max = int.Parse(line[2]);
            int ans = 0;
            int nums = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num <= min)
                {
                    ans -= num;
                    nums++;
                }
                else if (num >= max) {
                    ans += num * nums;
                    nums = 0;
                }
            }
        }
    }
}

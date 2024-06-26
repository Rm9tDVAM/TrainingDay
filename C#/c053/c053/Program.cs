using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            int tenTimes = 1;
            string[] tmpList = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();

            for (int i = 0; i < tmpList.Length; i++) 
            {
                if (tmpList[i] == "x10")
                {
                    tenTimes = 10;
                }
                else
                {
                    list.Add(int.Parse(tmpList[i]));
                }
            }

            list.Sort();
            if (list[0] == 0) 
            {
                list[list.Count -1] = 0;
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum * tenTimes);
        }
    }
}

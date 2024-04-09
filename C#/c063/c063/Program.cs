using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //・1 ≦ N ≦ 30
            //・1 ≦ a_i, b_i ≦ 30(1 ≦ i ≦ N)
            int N = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int[] days = new int[60];
            int max = 0;
            List<string> list = new List<string>();

            for (int i = 0; i < N; i++) 
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0;i < list.Count; i++)
            {
                a = int.Parse(list[i].Substring(0,1));
                b = int.Parse(list[i].Substring(2,1));
                days[b -1 + a] ++;
            }

            foreach (int i in days)
            {
                max = Math.Max(max, i);
            }

            for (int i = 0;i < days.Length ; i++)
            {
                if (days[i] == max)
                {
                    Console.WriteLine(i + 1);
                    Environment.Exit(0);
                }
            }
        }
    }
}

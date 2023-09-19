using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for(int i = 0; i < count; i++)
            {
                list.Add(Console.ReadLine());
            }
            int ans = 0;
            string[] tempi;
            string[] tempj;
            RELOOP:
            for(int i = 0; i < list.Count; i++)
            {
                tempi = list[i].Split(' ');
                for (int j = 0; j < list.Count; j++)
                {
                    tempj = list[j].Split(' ');
                    if (tempi[0] == tempj[0] && tempi[1] != tempj[1]) 
                    {
                        list.RemoveAt(j);
                        list.RemoveAt(i);
                        ans++;
                        goto RELOOP;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

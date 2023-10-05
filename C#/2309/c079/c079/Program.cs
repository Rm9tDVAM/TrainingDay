﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] temp = Console.ReadLine().Split(' ');
            string[] temp = { "6", "3" };
            int count = int.Parse(temp[0]);
            int cards = int.Parse(temp[1]);
            Dictionary<int,int> map = new Dictionary<int,int>();
            int ans = 0;
            for (int i = 0; i < cards; i++)
            {
                map.Add(i,0);
            }
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (map.ContainsKey(num-1))
                {
                    map[num - 1] += 1;
                }

                for(int j= 0; j < map.Count; j++)
                {
                    if (map[i] != 0)
                    {
                        ans++;
                    }

                    if (ans == cards)
                    {
                        Console.WriteLine(j + 1);
                        Environment.Exit(1);
                    }
                }
            }
            Console.WriteLine("unlucky");
        }
    }
}

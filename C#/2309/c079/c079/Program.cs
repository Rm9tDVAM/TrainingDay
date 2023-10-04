using System;
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
            }
            foreach(KeyValuePair<int,int> item in map)
            {
                Console.WriteLine("{0},{1}",item.Key,item.Value);
            }
            for(int i = 0; i < map.Count; i++)
            {
                if (map[i] != 0)
                {
                    ans++;
                }
                else
                {
                    Console.WriteLine("unlucky");
                    Environment.Exit(1);
                }
            }
            Console.WriteLine(ans);
        }
    }
}

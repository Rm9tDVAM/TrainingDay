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
            string[] temp = Console.ReadLine().Split(' ');
            int count = int.Parse(temp[0]);
            int cards = int.Parse(temp[1]);
            Dictionary<int,int> map = new Dictionary<int,int>();
            int ans = 0;
            string msg = "unlucky";

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

                ans = 0;
                for(int j= 0; j < map.Count; j++)
                {
                    if (map[j] != 0)
                    {
                        ans++;
                    }
                    
                    if (ans == cards && msg == "unlucky" )
                    {
                        msg = Convert.ToString(i + 1);
                    }
                }
            }
            Console.WriteLine(msg);
        }
    }
}

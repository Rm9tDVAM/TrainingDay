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
            string[] temp = { "6", "2" };
            int count = int.Parse(temp[0]);
            int cards = int.Parse(temp[1]);
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < count; i++)
            {
                map.Add(i,0);
            }
            foreach (int i in map.Keys)
            {
                Console.WriteLine(map[i]);
            }
        }
    }
}

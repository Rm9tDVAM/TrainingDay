using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int T = int.Parse(line[0]);
            int x = int.Parse(line[1]);
            int y = int.Parse(line[2]);
            int a_i = 0;
            int b_i = 0;
            List<string> list = new List<string>();
            
            for (int i = 0; i < T; i++)
            {
                list.Add(Console.ReadLine());
            }

        }
    }
}

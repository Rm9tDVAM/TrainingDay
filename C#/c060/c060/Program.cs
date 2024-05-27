using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int N = int.Parse(line[0]);
            int K = int.Parse(line[1]);
            int P = int.Parse(line[2]);
            string[] temp = Console.ReadLine().Split(' ');
            List<string> sList = new List<string>();

            for (int i = 0; i < temp.Length; i++)
            {
                sList.Add(temp[i]);
            }
            sList.Sort();

        }
    }
}

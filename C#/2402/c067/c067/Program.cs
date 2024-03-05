using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ≦ N ≦ 32
            // 1 ≦ k_i ≦ 32 (1 ≦ i ≦ N)
            // 1 ≦ X < 2^31
            string[] line = Console.ReadLine().Split(' ');
            //string[] line = { "3", "44" };
            int N = int.Parse(line[0]);
            //int N = 1;
            string binary = Convert.ToString(int.Parse(line[1]),2);
            Console.WriteLine(binary);
            List<char> list = new List<char>();
            for (int i =0; i < binary.Length; i++)
            {
                list.Add(binary[i]);
            }
            foreach (char c in list) {
                Console.WriteLine(c);
            }

            int k = 0;
            for (int i = 0; i < N; i++)
            {
                k = int.Parse(Console.ReadLine())-1;
                Console.WriteLine(list[k]);
            }
        }
    }
}

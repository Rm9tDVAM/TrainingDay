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
            int N = int.Parse(line[0]);
            string binary = Convert.ToString(int.Parse(line[1]),2);
            List<char> list = new List<char>();

            for (int i = binary.Length-1; i >= 0; i--)
            {
                list.Add(binary[i]);
            }

            int k = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(list[int.Parse(Console.ReadLine())-1]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            if (int.Parse(line1[0]) > int.Parse(line2[0]))
            {
                Console.WriteLine("Yes");
            }
            else if(int.Parse(line1[0]) == int.Parse(line2[0]) && int.Parse(line1[1]) >= int.Parse(line2[1]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

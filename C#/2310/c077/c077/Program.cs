using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c077
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int loop = int.Parse(line[0]);
            double quest = double.Parse(line[1]);

            for ( int i = 0; i < loop; i++)
            {
                line=Console.ReadLine().Split(' ');
                int day = int.Parse(line[0]);
                double ans = double.Parse(line[1]);
                double temp = 0;
                if (day > 0)
                {
                    temp = (ans / quest) * 0.8;
                }
                else
                {
                    temp = ans / quest;
                }

                if (day >= 10)
                {
                    Console.WriteLine("D");
                }
                else if (temp >= 0.8)
                {
                    Console.WriteLine("A");
                }
                else if (temp >= 0.7)
                {
                    Console.WriteLine("B");
                }
                else if (temp >= 0.6)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("D");
                }
            }
        }
    }
}

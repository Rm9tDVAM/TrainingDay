using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace c080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int line2 = int.Parse(Console.ReadLine());
            string[] line3 = Console.ReadLine().Split(' ');
            int buttonNum = int.Parse(line1[0]);
            int limit = int.Parse(line1[1]);
            int limitPoint = 0;
            int point = 0;
            for (int i=0; i < line3.Length; i++)
            {
                if ((i + 1) % int.Parse(line1[0]) == 0)
                {
                    if (line1[0] == line3[i])
                    {
                        point += 1000;
                    }
                    else
                    {
                        limitPoint++;
                    }
                }
                else
                {   
                    if ((i + 1) % int.Parse(line1[0]) == int.Parse(line3[i]))
                    {
                        point += 1000;
                    }
                    else
                    {
                        limitPoint++;
                    }
                }

                if (limit == limitPoint)
                {
                    Console.WriteLine(-1);
                    Environment.Exit(0);
                }
            }
            Console.WriteLine(point);
        }
    }
}

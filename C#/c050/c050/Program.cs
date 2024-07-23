using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] line = Console.ReadLine().Split(' ');
            string[] line = new string[] {"1","1500","2050"};
            int S = int.Parse(line[0]);
            int a = int.Parse(line[1]);
            int b = int.Parse(line[2]);
            int cnt = 1;
            int ans = 0;

            while (true) 
            {
                if (cnt %2 == 1)
                {
                    if (S + 10 <= a)
                    {
                        S += 10;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (S + 1000 <= b)
                    {
                        S += 1000;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(S);
        }
    }
} 
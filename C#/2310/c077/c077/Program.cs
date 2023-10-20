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
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = { "3","25"};
            int loop = int.Parse(line[0]);
            int quest = int.Parse(line[1]);
            int day = 0;
            int ans = 0;
            line[0] = "-2 17";
            line[1] = "-2 17";
            line[2] = "-2 17";

            for ( int i = 1; i < loop; i++)
            {
                line=Console.ReadLine().Split(' ');
                day= int.Parse(line[0]);
                ans= int.Parse(line[1]);
                if (day >= 10)
                {
                    Console.WriteLine("D");
                    Environment.Exit(0);
                }
            }
        }
    }
}

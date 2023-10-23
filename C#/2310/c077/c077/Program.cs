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
            string[] line2 = { "-2 17","-7 20","2 24"};

            for ( int i = 0; i < loop; i++)
            {
                //line=Console.ReadLine().Split(' ');
                line=line2[i].Split(' ');
                day = int.Parse(line[0]);
                ans = int.Parse(line[1]);
                Console.WriteLine("{0},{1}",day,ans);
                if (day >= 10)
                {
                    Console.WriteLine("D");
                    Environment.Exit(0);
                }
            }
        }
    }
}

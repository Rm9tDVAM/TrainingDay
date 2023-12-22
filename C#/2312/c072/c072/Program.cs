using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string[] line = Console.ReadLine().Split(' ');  
            int ATK = int.Parse(line[0]);
            int DEF = int.Parse(line[1]);
            int AGI = int.Parse(line[2]);
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                string[] line2 = Console.ReadLine().Split(' ');
                string s = line2[0];
                int MINATK = int.Parse(line2[1]);
                int MAXATK = int.Parse(line2[2]);
                int MINDEF = int.Parse(line2[3]);
                int MAXDEF = int.Parse(line2[4]);
                int MINAGI = int.Parse(line2[5]);
                int MAXAGI = int.Parse(line2[6]);
                if(MINATK <= ATK && MAXATK >= ATK && MINDEF <= DEF && MAXDEF >= DEF && MINAGI <= AGI && MAXAGI >= AGI)
                {
                    list.Add(s);
                }
            }
            if( list.Count == 0 )
            {
                Console.WriteLine("no evolution");
            }
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
        }
    }
}

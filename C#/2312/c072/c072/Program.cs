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
            //string[] line = Console.ReadLine().Split(' ');  
            string[] line = { "100","150","200" };
            int ATK = int.Parse(line[0]);
            int DEF = int.Parse(line[1]);
            int AGI = int.Parse(line[0]);
            //int N = int.Parse(Console.ReadLine());
            int N = 3;
            string[] testData{ };
            for(int i = 0; i < N; i++)
            {
                string[] line2 = Console.ReadLine().Split(' ');
                string s = line2[0];
                int MINATK = int.Parse(line2[1]);
                int MAXATK = int.Parse(line2[1]);
                int MINDEF = int.Parse(line2[1]);
                int MAXDEF = int.Parse(line2[1]);
                int MINAGI = int.Parse(line2[1]);
                int MAXAGI = int.Parse(line2[1]);


            }
            if( list.Count == 0 )
            {
                Console.WriteLine("no evolution");
            }
        }
    }
}

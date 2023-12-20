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
            string[] testData = { "paizabird 100 200 130 180 80 120","paizawolf 180 220 100 120 90 140","paizasheep 80 110 150 220 170 250" };
            for(int i = 0; i < N; i++)
            {
                //string[] line2 = Console.ReadLine().Split(' ');
                string[] line2 = testData[i].Split(' ');
                string s = line2[0];
                int MINATK = int.Parse(line2[1]);
                int MAXATK = int.Parse(line2[2]);
                int MINDEF = int.Parse(line2[3]);
                int MAXDEF = int.Parse(line2[4]);
                int MINAGI = int.Parse(line2[5]);
                int MAXAGI = int.Parse(line2[6]);
                if(MINATK <= ATK && MAXATK >= ATK && MINDEF <= DEF && MAXDEF >= DEF && MINAGI <= AGI && MAXAGI >= AGI){
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

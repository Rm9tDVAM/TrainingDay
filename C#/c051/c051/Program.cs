using System; using System.Collections.Generic; using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            int sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                list.Add(int.Parse(line[i]));
            }

            list.Sort((a, b) => b - a);
            for(int i = 0;i < list.Count;i++) 
            {
                if (i == 0 || i == 1) 
                {
                    sum += list[i] * 10;
                }

                else
                {
                    sum += list[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

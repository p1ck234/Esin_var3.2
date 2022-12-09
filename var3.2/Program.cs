using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            List < List < int>> main = new List<List<int>>();
            List<int> first = new List<int>() { 1, 2, 3, 4 ,5 };
            List<int> second = new List<int>() { 2, 3, 4, 5 ,6 };
            List<int> third = new List<int>() { 3, 4, 5, 6, 7 };

            main.Add(first);
            main.Add(second);
            main.Add(third);

            List<int> max = new List<int>();

            for (int i = 0; i < main.Count; i++)
            {
                max.Add(main[i].Max());
            }

            Console.Write($"List<int> ");
            for (int i = 0; i < max.Count; i++)
            {
                Console.Write(max[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
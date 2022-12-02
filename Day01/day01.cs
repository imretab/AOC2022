using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            StreamReader sr = new StreamReader("input.txt");
            int sum = 0;
            int maxval = 0;
            List<int> top3 = new List<int>();
            while (!sr.EndOfStream)
            {
                string num = sr.ReadLine();
                if (string.IsNullOrEmpty(num))
                {
                    top3.Add(sum);
                    sum = 0;
                    continue;
                }
                else
                {
                    numbers.Add(int.Parse(num));
                    sum += int.Parse(num);
                    if (maxval < sum)
                    {
                        maxval = sum;
                    }
                }
            }
            sr.Close();
            top3.Sort();
            foreach (var item in top3)
            {
                Console.WriteLine(item);
            }

            int summax2 = top3[top3.Count - 1] + top3[top3.Count - 2] + top3[top3.Count - 3];
            int summax=0;
            for (int i = top3.Count-1; i > top3.Count-4; i--)
            {
                summax += top3[i];
            }
            Console.WriteLine();
            Console.WriteLine(summax2);
            Console.WriteLine(summax);
            Console.WriteLine();
            Console.WriteLine(maxval);
            Console.ReadLine();
        }
    }
}

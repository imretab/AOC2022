using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ranges> list = new List<Ranges>();
            StreamReader sr = new StreamReader("input.txt");
            while (!sr.EndOfStream)
            {
            string sor = sr.ReadLine();
            string[] sv = sor.Split(',');
            string[] range1 = sv[0].Split('-');
            string[] range2 = sv[1].Split('-');
            Ranges r = new Ranges(int.Parse(range1[0]), int.Parse(range1[1]));
            Ranges r2 = new Ranges(int.Parse(range2[0]), int.Parse(range2[1]));
            list.Add(r);
            list.Add(r2);
            }
            // Console.WriteLine(list.Count);
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < list.Count-1; i+=2)
            {
            //Test out if the class is working
            //Console.WriteLine($"{list[i].range1}-{list[i].range2},{list[i+1].range1}-{list[i+1].range2}");
                if ((list[i].Start <= list[i+1].Start && list[i].End >= list[i+1].End) ||(list[i+1].Start <= list[i].Start && list[i+1].End >= list[i].End)) counter++;
                if (list[i+1].Start <= list[i].End && list[i].Start <= list[i + 1].End) counter2++;
            }
            Console.WriteLine(counter);
            Console.WriteLine(counter2);
            Console.ReadKey();
        }
    }
}

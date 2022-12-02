using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RPS> game = new List<RPS>();
            StreamReader sr = new StreamReader("input.txt");
            int sum = 0;
            while (!sr.EndOfStream)
            {
                string[] seged = sr.ReadLine().Split(' ');
                game.Add(new RPS(Convert.ToChar(seged[0]), Convert.ToChar(seged[1])));
            }
            foreach (var item in game)
            {
                //Console.WriteLine($"{item.YourChoice} {item.ElfChoice}");
                switch (item.ElfChoice)
                {
                    case 'A': //rock
                        switch (item.YourChoice)
                        {
                            case 'X':
                                sum += 4;
                                break;
                            case 'Y':
                                sum += 8;
                                break;
                            case 'Z':
                                sum += 3;
                                break;
                        }
                        break;
                    case 'B': //paper
                        switch (item.YourChoice)
                        {
                            case 'X':
                                sum += 1;
                                break;
                            case 'Y':
                                sum += 5;
                                break;
                            case 'Z':
                                sum += 9;
                                break;
                        }
                        break;
                    case 'C': //scissors
                        switch (item.YourChoice)
                        {
                            case 'X':
                                sum += 7;
                                break;
                            case 'Y':
                                sum += 2;
                                break;
                            case 'Z':
                                sum += 6;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

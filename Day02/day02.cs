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
            int sum2 = 0;
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
                                sum2 += 3;
                                break;
                            case 'Y':
                                sum += 8;
                                sum2 += 4;
                                break;
                            case 'Z':
                                sum += 3;
                                sum2 += 8;
                                break;
                        }
                        break;
                    case 'B': //paper
                        switch (item.YourChoice)
                        {
                            case 'X':
                                sum++;
                                sum2++;
                                break;
                            case 'Y':
                                sum += 5;
                                sum2 += 5;
                                break;
                            case 'Z':
                                sum += 9;
                                sum2 += 9;
                                break;
                        }
                        break;
                    case 'C': //scissors
                        switch (item.YourChoice)
                        {
                            case 'X':
                                sum += 7;
                                sum2 += 2;
                                break;
                            case 'Y':
                                sum += 2;
                                sum2 += 6;
                                break;
                            case 'Z':
                                sum += 6;
                                sum2 += 7;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.ReadKey();

            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerGuessMyNumber
{
    public class Game
    {
        public static void Run(Dictionary <int, int> dict, int u)
        {
            if (u == Program.comp)
            {
                Console.WriteLine("\nYou guessed the number.");
                Environment.Exit(0);
            }
            else if (u > Program.comp)
            {
                Console.WriteLine("\nYour guess was too high.");
                dict.Clear();
               

                for (int i = 1; i <= u - 1; i++)
                {
                    dict.Add(i, i);
                }

                HighOrLOw(dict, u - 1);
            }
            else if (u < Program.comp)
            {
                Console.WriteLine("\nYour guess was too low.");
                dict.Clear();
                

                for (int i = u + 1; i <= 1000; i++)
                {
                    dict.Add(i, i);
                }

                HighOrLOw(dict, u + 1);
            }
        }
        private static void HighOrLOw(Dictionary<int, int> dict, int o, int f = 1)
        {
            int u = Program.UserInput(dict);

            if (u == Program.comp)
            {
                Console.WriteLine("\nYou guessed the number.");
                Environment.Exit(0);
            }
            else if (u > Program.comp)
            {
                Console.WriteLine("\nYour guess was too high.");
                if (u > o)
                {
                    var minK = dict.Keys.Min();
                    dict.Clear();
                    for (int i = minK; i <= u - 1; i++)
                    {
                        dict.Add(i, i);
                    }
                }
                else
                {
                    var minK = dict.Keys.Min();

                    dict.Clear();

                    for (int i = minK; i <= u - 1; i++)
                    {
                        dict.Add(i, i);
                    }
                }

                HighOrLOw(dict, u - 1);
            }
            else if (u < Program.comp)
            {
                Console.WriteLine("\nYour guess was too low.");

                if (u > o)
                {
                    var maxK = dict.Keys.Max();
                    dict.Clear();
                    for (int i = u + 1; i <= maxK; i ++)
                    {
                        dict.Add(i, i);
                    }
                }
                else if (u == o)
                {
                    Console.WriteLine($"The only possible answer left is {dict.Keys.Max()}");
                }
                else
                {
                    dict.Clear();
                    for (int i = u + 1; i <= o; i++)
                    {
                        dict.Add(i, i);
                    }
                }

                HighOrLOw(dict, u + 1);
            }
        }
    }
}

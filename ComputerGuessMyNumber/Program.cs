using System;
using System.Collections.Generic;

namespace ComputerGuessMyNumber
{
    public class Program
    {
            public static Random r = new Random();
            public static int comp = r.Next(1, 1000);
        static void Main(string[] args)
        {
            Console.WriteLine("GUESS MY NUMBER!!!!!!!!!!");
            Console.WriteLine("\nHint 1, it is between 1 and 1000.");

            Dictionary<int, int> dict = new Dictionary<int, int> { };

            for (int i = 1; i <= 1000; i++)
            {
                dict.Add(i, i);
            }


            try
            {
                int input = UserInput(dict);
                Game.Run(dict, input);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



        public static int UserInput(Dictionary<int, int> dict)
        {
            bool valid = false;

            int a;
            do
            {
                Console.Write("\nInput Guess: ");

                var x = Console.ReadLine();
                Console.Clear();
                valid = int.TryParse(x, out a);

            } while (!valid);

            if (!dict.ContainsValue(a))
            {
                throw new Exception("Input is not in range");
            }

            return a;
        }
    }
}


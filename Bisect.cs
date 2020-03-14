using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    public class Bisect
    {
        public static ConsoleKeyInfo cki = Console.ReadKey(true);
        internal List<int> bisect1(List<int> list, int x)
        {
            list.Clear();
            if (x == 5)
            {
                Console.WriteLine("You're answer is 5. LOSER");
                Environment.Exit(0);
            }

            else if (x != 5)
            {
                Console.Clear();
                Console.Write("Is your value higher or lower than 5? (h / l) ");
                if (cki.Key == ConsoleKey.H)
                {
                    if (x! < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("You lied to me..");
                        Environment.Exit(0);
                    }
                    else
                    {
                        int j = 0;
                        for (int i = 6; i <= 10; i++)
                        {
                            list.Insert(j, i);
                            j++;
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.L)
                {
                    if (x! > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("You lied to me..");
                        Environment.Exit(0);
                    }
                    else
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            list.Insert(i, i);
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You did not choose an option provided");
                }
            }
            return list;
        }


        internal List<int> bisect2(List<int> list, int user)
        {
            if (user == 3)
            {
                Console.Clear();
                Console.WriteLine("You're answer is 3. LOSER");
                Environment.Exit(0);
            }
            else if (user != 3)
            {
                Console.Clear();
                Console.Write("Is your value higher or lower than 3? (h / l) ");
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.H:
                        if (user! < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("You lied to me..");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("You're answer is 4.");
                            Environment.Exit(0);
                        }
                        break;
                    case ConsoleKey.L:
                        if (user! > 3)
                        {
                            Console.Clear();
                            Console.WriteLine("You lied to me..");
                            Console.WriteLine("You're answer is 4.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            list.Clear();
                            int j = 0;
                            for (int i = 1; i <= 2; i++)
                            {
                                list.Insert(j, i);
                                j++;
                            }
                        }
                        break;
                }
            }
            return list;
        }

        internal List<int> bisect3(List<int> list, int user)
        {
            if (user == 8)
            {
                Console.Clear();
                Console.WriteLine("You're answer is 8. LOSER");
                Environment.Exit(0);
            }
            else if (8 != user)
            {
                Console.Clear();
                Console.Write("Is your value higher or lower than 8? (h / l) ");
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.H:
                        if (user! < 8)
                        {
                            Console.Clear();
                            Console.WriteLine("You lied to me..");
                            Environment.Exit(0);
                        }
                        else
                        {
                            list.Clear();

                            int j = 0;
                            for (int i = 9; i <= 10; i++)
                            {
                                list.Insert(j, i);
                                j++;
                            }
                        }
                        break;
                    case ConsoleKey.L:
                        if (user! > 8)
                        {
                            Console.Clear();
                            Console.WriteLine("You lied to me..");
                            Environment.Exit(0);
                        }
                        else
                        {
                            list.Clear();

                            int j = 0;
                            for (int i = 6; i <= 7; i++)
                            {
                                list.Insert(j, i);
                                j++;
                            }
                        }
                        break;
                }
            }
            return list;
        }
        internal List<int> bisect4(List<int> list3, int user)
        {
            if (user == 2)
            {
                Console.Clear();
                Console.WriteLine("You're answer is 2. LOSER");
                Environment.Exit(0);
            }
            else if (user != 2)
            {
                Console.Clear();
                Console.WriteLine("You're answer is 1. LOSER");
                Environment.Exit(0);
            }
            return list3;
        }
        internal List<int> bisect5(List<int> list3, int user, int x, int y)
        {
            if (x == user)
            {
                Console.Clear();
                Console.WriteLine($"You're answer is {x}. LOSER");
                Environment.Exit(0);
            }
            else if (x != user)
            {
                Console.Clear();
                Console.WriteLine($"You're answer is {y}. LOSER");
                Environment.Exit(0);
            }
            return list3;
        }
    }
}

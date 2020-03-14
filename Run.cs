using System;
using System.Collections.Generic;

namespace GuessMyNumber
{
    public class Run
    {
        static void Main(string[] args)
        {
            int a;
            bool valid = false;
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Bisect bisect = new Bisect();
            try
            {
                do
                {
                    Console.Write("Select a number between 1-10: ");


                    var x = Console.ReadLine();
                    Console.Clear();
                    valid = int.TryParse(x, out a);

                } while (!valid);

                if (a > 10 || a < 1)
                {
                    throw new Exception("You did not input a number between 1 - 10.");
                }

                List<int> list2 = bisect.bisect1(list, a);

                if (list2.Contains(8))
                {
                    List<int> list3 = bisect.bisect3(list2, a);
                    if (list3.Contains(6))
                    {
                        List<int> list4 = bisect.bisect5(list3, a, 6, 7);
                    }
                    else if (list3.Contains(9))
                    {
                        List<int> list4 = bisect.bisect5(list3, a, 9, 10);
                    }
                }

                else if (list2.Contains(3))
                {
                    List<int> list3 = bisect.bisect2(list2, a);
                    if (list3.Contains(2))
                    {
                        List<int> list4 = bisect.bisect4(list3, a);
                    }
                }





            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

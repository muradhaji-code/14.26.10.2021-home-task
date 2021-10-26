using System;

namespace _14._26._10._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine(SumInterval(5, 9));
            #endregion

            #region Task 2
            //Console.WriteLine(SumOfTwo(6, 7));
            #endregion

            #region Task 3
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            #endregion
        }

        static int SumInterval(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int SumOfTwo(int a, int b)
        {
            return a + b;
        }
    }
}
using System;
using System.Collections.Generic;

namespace LargestPalindromeProduct
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}", Product(0,0));
        }


        private static Tuple<int, int> Product(int a, int b)
        {
            List<int> p = new List<int>();

            int temp = 0;

            var tuple = new Tuple<int, int>(0, 0);

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int x = i * j;

                    int r, sum = 0;

                    temp = x;
                    while (x > 0)
                    {
                        r = x % 10;
                        sum = (sum * 10) + r;
                        x /= 10;
                    }

                    if (temp == sum)
                    {
                        tuple = new Tuple<int, int>(i, j);
                    }
                }
            }
        
            return tuple;
        }
    }
}

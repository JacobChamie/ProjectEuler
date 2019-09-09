using System;

namespace EvenFibonacciNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input range");

            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", evenFibonacciSum(range));


            Console.ReadKey();
        }

        public static int evenFibonacciSum(int range)
        {
            int a = 0;
            int b = 1;
            int evenSum = 0;

            for (int i = 2; i < range; i++)
            {
                int c = a + b;
                a = b;
                b = c;

                if (c % 2 == 0)
                {
                    evenSum += c;
                }
            }

            return evenSum;
        }

    }
        

}

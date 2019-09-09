using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestEvenPrimeFactor
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("{0}", PrimeFactor(15492));
        }

        public static int PrimeFactor(long range)
        {
            bool isPrime = true;

            List<long> pNums = new List<long>();

            for (long i = range; i > 1; i--)
            {
                isPrime = true;

                for (long j = 2; j <= Math.Floor(Math.Sqrt(i)); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    pNums.Add(i);
                }

            }

            for (int x = 0; x < pNums.Count(); x++)
            {
                if (range % pNums[x] == 0)
                {
                    return (int)pNums[x];
                }
            }

            return 2;
        }
    }
}

using System;

namespace SumSquareDifference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}", Square(100));
        }


        public static int Square(int range)
        {
            int sum = 0;
            int square = 0;



            //Find the sum of the squares
            for (int i = 0; i < range; i++)
            {
                sum += i * i;
            }


            //Find the square of the sums
            for (int j = 0; j < range; j++)
            {
                square += j;
            }

            square *= square;

            return (square-sum);
        }

    }
}

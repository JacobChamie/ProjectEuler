using System;

namespace projectEuler1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int range = 0;
            int m1 = 0;
            int m2 = 0;

            Console.WriteLine("Input Range");

            range = int.Parse(Console.ReadLine());

            Console.WriteLine("Input multiple 1");

            m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input multple 2");

            m2 = int.Parse(Console.ReadLine());


            Console.WriteLine("{0}", addMultiples(range, m1, m2));



            Console.ReadKey();
        }




        public static int addMultiples(int range, int m1, int m2)
        {
            int temp = 0;

            for (int i = 2; i < range + 1; i++)
            {
                if (i % m1 == 0)
                {
                    temp += i;
                }

                if (i % m2 == 0)
                {
                    temp += i;
                }
            }

            return temp;
        }

    }
}

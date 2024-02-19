using System;

namespace AlgorithmsLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
        repeat:
            Console.WriteLine("Birinci eded:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci eded:");
            int m = Convert.ToInt32(Console.ReadLine());
            int count = default;

            if (n<m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Duzgun eded daxil et");
                goto repeat;
            }

            Console.WriteLine("Tek ededlerin sayi:" + count);


            //task2

            int x = Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            if (x != 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        count1 += 1;
                    }
                }
            }
            else { Console.WriteLine("Ne sade,nede murekkebdir"); }

            if (count1 > 2)
                Console.WriteLine("Murekkebdir");
            else
                Console.WriteLine("Sadedir");

            //task3

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (b != 0)
            {
                if (a % b == 0)
                    Console.WriteLine("Tam bolunur");
                else
                    Console.WriteLine("Bolunmur");
            }
            else Console.WriteLine("0-a bolmek olmaz");


        }


    }
}

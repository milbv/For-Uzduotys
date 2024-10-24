using System;

namespace VienuoliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            for (int i = 2; i <= 50; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++) {
                    isPrime = true;
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

    }
}
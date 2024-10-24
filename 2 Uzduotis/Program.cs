using System;

namespace AntraUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                x = int.Parse(Console.ReadLine());
                if (x > y)
                {
                    y = x;
                }
            }
            Console.WriteLine($"Didziausias skaicius - {y}");
        }
    }
}
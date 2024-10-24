using System;

namespace SeptintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int i = 0;
            int count = 0;
            while (i != 7) {
                i = random.Next(1, 11);
                count++;
                if (i == 7)
                {
                    Console.WriteLine($"Buvo sugeneruota {count} skaiciu pries pasiekiant skaiciu 7");
                }
             
            }
        }
    }
}
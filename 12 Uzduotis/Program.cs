using System;

namespace DvyliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite prieaugi: ");
            int prieaugis = int.Parse(Console.ReadLine());
            
            while (skaicius <= 500)
            {
                skaicius += prieaugis;
                if ( skaicius % 2 == 0)
                {
                    Console.WriteLine(skaicius * 2);
                }
            }
        }
    }
} 
using System;

namespace PenktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Parasykite skaiciu: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Skaiciaus {a} daugybos lentele:");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
                if (a * i > 50)
                {
                    break;
                }
            }
        }
    }
}
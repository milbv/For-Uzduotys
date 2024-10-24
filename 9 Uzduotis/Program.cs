using System;

namespace DevintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Iveskite sveika skaiciu: ");
                int j = int.Parse(Console.ReadLine());
                if (j == 0) {
                    break;
                }
                if (j > 0)
                {
                    Console.WriteLine("Teigiamas");
                } else
                {
                    Console.WriteLine("Neigiamas");
                }
            }
        }
    }
}
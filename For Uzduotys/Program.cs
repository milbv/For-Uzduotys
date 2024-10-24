using System;

namespace PirmaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Irasykite skaiciu");
                int skaicius = int.Parse(Console.ReadLine());
                if (skaicius > 0)
                {
                    Console.WriteLine("Teigiamas");
                }
                else if (skaicius < 0)
                {
                    Console.WriteLine("Neigiamas");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
using System;

namespace DesimtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Irasykite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());
            while (true)
            {
                skaicius *= 2;
                Console.WriteLine(skaicius);
                if (skaicius > 1000)
                {
                    break;
                }
            }
        }
    }
}
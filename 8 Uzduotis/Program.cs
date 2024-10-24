using System;

namespace AstuntaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                if (skaicius * i == 50)
                {
                    continue;
                }
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
            }
        }
    }
}
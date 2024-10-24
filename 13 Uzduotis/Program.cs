using System;

namespace TryliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            double sqr = 0;
            for (int i = 1; i <= skaicius; i++)
            {
                if (sqr > 200)
                {
                    break;
                }
                sqr = Math.Pow(i, 2);
                Console.WriteLine(sqr);
            }
        }
    }
}
using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                switch(int.Parse(Console.ReadLine())) {
                    case int n when (n % 2 == 0):
                        Console.WriteLine("Lyginis");
                        break;

                    default:
                        Console.WriteLine("Nelyginis");
                        break;
                }
            }
        }
    }
}
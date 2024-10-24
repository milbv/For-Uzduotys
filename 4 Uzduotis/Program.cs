using System;

namespace KetvirtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case int n when (n > 0 && n <= 10):
                        Console.WriteLine("Mazas");
                        break;
                    case int n when (n > 10 && n <= 100):
                        Console.WriteLine("Vidutinis");
                        break;
                    case int n when (n > 100):
                        Console.WriteLine("Didelis");
                        break;
                    case int n when (n < 0):
                        Console.WriteLine("Neigiamas skaicius");
                            break;
                    default:
                        Console.WriteLine("Skaicius yra 0");
                        break;
                }
            }
        }
    }
}
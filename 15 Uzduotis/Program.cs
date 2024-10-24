using System;

/* Sukurkite programą, kuri prašo vartotojo įvesti pirmąjį skaičių, prieaugį ir norimą progresijos ilgį.Naudodami for ciklą,
   sugeneruokite ir išveskite nurodytą aritmetinę progresiją.Programa turi baigtis, jei bet kuris progresijos narys tampa didesnis nei 100. */
namespace PenkioliktaUzduotis
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite prieaugi");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite norima progresijos ilgi");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Skaiciai:");
            for (int i = 0; i < c; i++) {
                Console.WriteLine(a += b);
                if (a > 100)
                {
                    break;
                }
            }
        }
    }
}
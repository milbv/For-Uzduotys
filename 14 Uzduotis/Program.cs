using System;

namespace KeturioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Sukurkite programą, kuri prašo vartotojo įvesti teigiamą skaičių.
            Naudodami while ciklą ir if sąlygą, suskaičiuokite, kiek skaitmenų turi vartotojo įvestas skaičius, ir išveskite rezultatą.
            */
            Console.WriteLine("Iveskite teigiama skaiciu");
            string a = Console.ReadLine();
            Console.WriteLine($"Skaiciaus ilgis - {a.Length}");
        }
    }
}
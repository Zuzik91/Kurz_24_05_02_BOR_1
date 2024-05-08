using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurz_24_05_02_BOR_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };

            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Console.WriteLine("Vypis vsechna cisla na konzoli (nachystej si pro to funkci)");
            Vypis(cisla);
            Console.WriteLine(cisla);
            Console.WriteLine();

            // Vypis na konzoli pocet cisel v seznamu
            Console.WriteLine("Vypis na konzoli pocet cisel v seznamu");
            VypisPocet(cisla);
            Console.WriteLine();

            // Pridej cislo 0.5 do seznamu
            Console.WriteLine("Pridej cislo 0.5 do seznamu");
            cisla.Add(0.5);
            Console.WriteLine($"Toto jsou všechna čísla:{string.Join("\n ", cisla)}");
            Console.WriteLine();

            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            Console.WriteLine("Vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8");
            foreach (double cislo in cisla)
            {
                if (cislo>0.8)
                {  Console.WriteLine(cislo);
                    break;
                }
            }
            Console.WriteLine();

            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            Console.WriteLine("Najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu");
            double max = cisla[0];
            foreach (double cislo in cisla)
            {
                if (cislo > max)
                {
                    max = cislo;
                }
            }
            Console.WriteLine(max);
            cisla.Remove(max);
            Console.WriteLine();

            // vypis opet vsechna cisla a jejich pocet
            Console.WriteLine("Vypis opet vsechna cisla a jejich pocet");
            Vypis(cisla);
            VypisPocet(cisla);
            Console.WriteLine();
        }
        public static void Vypis(List<double> cisla)
        {
            foreach (double cislo in cisla)
            {
                Console.WriteLine(cislo);
            }
        }
        public static void VypisPocet(List<double> cisla)
        {
            Console.WriteLine("Pocet cisel: " + cisla.Count);
        }
    }
}

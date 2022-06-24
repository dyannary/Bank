using System;
using System.Collections.Generic;
using System.Linq;
using OOP;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana pers1 = new Persoana();
            pers1.Name = "Diana";
            pers1.DataNasterii = new DateTime(2000, 3, 22);

            Persoana pers2 = new Persoana("Alex", new DateTime(2000, 4, 21));
            Persoana pers3 = new Persoana("Andrian", new DateTime(2000, 8, 11));
            Persoana pers4 = new Persoana("Eugen", new DateTime(2000, 6, 11));
            Persoana pers5 = new Persoana("Octavian", new DateTime(2000, 5, 31));

            List<Persoana> persList = new List<Persoana>() { pers1, pers2, pers3, pers4, pers5 };

            foreach (var pers in persList)
            {
                Console.WriteLine(pers.Name + " " + pers.DataNasterii.ToString("dd.MM.yyyy"));
                Console.WriteLine($"{pers.Name} {pers.DataNasterii.ToString("dd.MM.yyyy")}");
                Console.WriteLine();
            }

            ShowDianaDetails(persList);
            CheckAChar("Andrian");
            var x = GetOnlyNames(persList);
            var x2 = 0;
        }

        static void ShowDianaDetails(List<Persoana> persons)
        {
            var dianaList = persons.Where(x => CheckAChar(x.Name));

            foreach (var pers in dianaList)
            {
                Console.WriteLine($"{pers.Name} {pers.DataNasterii.ToString("dd.MM.yyyy")}");
            }
        }

        static bool CheckAChar(string nume)
        {
            return nume.Contains("a") || nume.Contains("A");
        }

        static List<string> GetOnlyNames(List<Persoana> persList)
        {
            return persList.Select(x => x.Name).ToList();
        }
    }
}

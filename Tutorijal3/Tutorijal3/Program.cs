using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorijal3
{
    
    class Program
    {
        public static void ToSortedArray(ref List<string> lista)
        {
            lista = lista.OrderBy(str => str.Length).ToList();
        }
        public static IEnumerable<IGrouping<int, string>> poredak(List<string> lista)
        {
            IEnumerable<IGrouping<int, string>> result = lista.GroupBy(str => String.Compare("etf", str), str => str);
            return result;
        }
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>(
                new string[] { "Bakir", "Ananas", "Kiwi", "ETF", "etf", "produzni", "sijalica", "olovka", "parfem" }
                );
            ToSortedArray(ref rijeci);
            Console.WriteLine("Sortirane rijeci: ");
            rijeci.ForEach(rijec => Console.WriteLine(rijec));

            IEnumerable<IGrouping<int, string>> result = poredak(rijeci);
            foreach (IGrouping<int, string> group in result)
            {  
                switch (group.Key)
                {
                    case -1:
                        Console.WriteLine("Broj rijeci prije stringa etf: " + group.Count());
                        break;
                    case 1:
                        Console.WriteLine("Broj rijeci poslije stringa etf: " + group.Count());
                        break;
                    default:
                        Console.WriteLine("Broj rijeci etf: " + group.Count());
                        break;
                }
                foreach(string s in group)
                {
                    Console.WriteLine(s);
                }
            }

            List<int> lista = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Unesite " + (i + 1) + ". broj: ");
                        string s = Console.ReadLine();
                        int number = int.Parse(s);
                        lista.Add(number);
                        break;
                    }
                    
                    catch (Exception)
                    {
                        Console.WriteLine("Pogresan unos! Pokusajte ponovo. ");
                    }
                }
            }

            if (lista.Any(broj => broj%2 == 0))
            {
                lista.RemoveAll(broj => broj % 2 != 0);
            } else
            {
                lista.RemoveAll(broj => broj % 2 == 0);
            }

            int suma = lista.Sum(broj => broj);
            if (suma < 0)
            {
                Console.WriteLine("Greska. Suma je negativna");
            } else
            {
                Console.WriteLine("Suma je: " + suma);
                lista.ForEach(broj => Console.WriteLine(broj));
            }
        }
    }
}

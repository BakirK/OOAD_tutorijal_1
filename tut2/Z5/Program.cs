using System;
using System.Collections.Generic;
using System.Linq;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite broj rijeci: ");
                string s = Console.ReadLine();
                int brojRijeci;
                try
                {
                    brojRijeci = int.Parse(s);
                    string[] words = new string[brojRijeci];
                    for (int i = 0; i < brojRijeci; i++)
                    {
                        Console.Write("Unesite " + (i + 1) + ". rijec: ");
                        words[i] = Console.ReadLine();
                    }

                    words = RemoveDuplicates(words);
                    Array.Sort(words, StringComparer.InvariantCulture);
                    Console.WriteLine("Sortirane rijeci bez duplikata su: ");
                    foreach (var word in words)
                    {
                        Console.WriteLine(word);
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo. ");
                }
            }
        }
        public static string[] RemoveDuplicates(string[] words)
        {
            System.Collections.ArrayList newList = new System.Collections.ArrayList();

            foreach (string word in words)
                if (!newList.Contains(word))
                    newList.Add(word);
            return (string[])newList.ToArray(typeof(string));
        }
    }
}

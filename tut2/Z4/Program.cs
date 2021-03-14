using System;
using System.Text.RegularExpressions;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite string: ");
                string recenica = Console.ReadLine();
                try
                {
                    if(DaLiJePalindrom(recenica))
                    {
                        Console.WriteLine("String jeste palindrom");
                    } else
                    {
                        Console.WriteLine("String nije palindrom");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo. ");
                }
            }
        }

        public static bool DaLiJePalindrom(string s)
        {
            s = Regex.Replace(s.ToLower(), @"[^a-zA-Z0-9]", "");
            //Console.WriteLine(s);

            int length = s.Length;
            for (int i = 0; i < length / 2 - 1; i++)
            {
                if(!s[i].Equals(s[length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

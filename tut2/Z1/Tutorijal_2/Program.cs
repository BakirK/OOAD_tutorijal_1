using System;

namespace Tutorijal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Unesite brzinu broda u čvorovima: ");
                string s = Console.ReadLine();
                int knots;
                try {
                    knots = int.Parse(s);
                    double kmh = knots * 1.852;
                    Console.WriteLine("Brzina broda u km/h je: " + kmh);
                    break;
                } catch(Exception) {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo. ");
                }
            }
        }
    }
}

using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite cijeli broj n: ");
                string s = Console.ReadLine();
                int n;
                try
                {
                    n = int.Parse(s);
                    int width = 2 * n - 1;
                    int stars = 1;
                    for(int i = 0; i < n; i++)
                    {
                        int blanks = (width - stars) / 2;
                        for (int j = 0; j < blanks; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < stars; j++)
                        {
                            Console.Write("*");
                        }
                        for (int j = 0; j < blanks; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        stars += 2;
                    }

                    // Console.WriteLine("Brzina broda u km/h je: " + kmh);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo. ");
                }
            }
        }
    }
}

using System;
using System.Collections;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesite prirodan broj n: ");
                string s = Console.ReadLine();
                uint n;
                try
                {
                    n = uint.Parse(s);
                    int[,] matrica = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Unesite cijeli broj na poziciji " + i + ", " + j + ": ");
                                    s = Console.ReadLine();
                                    matrica[i, j] = int.Parse(s);
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Pogresan unos! Pokusajte ponovo.");
                                }
                            }
                        }
                    }
                    int diagonala = 0;
                    for (int i = 0; i < n; i++)
                    {
                        diagonala += matrica[i, i];
                    }

                    int redMin = int.MaxValue;
                    int indexRedMin = -1;
                    for (int i = 0; i < n; i++)
                    {
                        int sumaReda = 0;
                        for (int j = 0; j < n; j++)
                        {
                            sumaReda += matrica[i, j];
                        }
                        if(sumaReda < redMin)
                        {
                            redMin = sumaReda;
                            indexRedMin = i;
                        }
                    }

                    int kolonaMax = int.MinValue;
                    int indexKolonaMax = -1;
                    for (int j = 0; j < n; j++)
                    {
                        int sumaKolone = 0;
                        for (int i = 0; i < n; i++)
                        {
                            sumaKolone += matrica[i, j];
                        }
                        if(sumaKolone > kolonaMax)
                        {
                            kolonaMax = sumaKolone;
                            indexKolonaMax = j;
                        }
                    }

                    Console.WriteLine("Suma dijagonale: " + diagonala);
                    Console.WriteLine(indexRedMin + 1 + ". red ima najmanju sumu.");
                    Console.WriteLine(indexKolonaMax + 1 + ". kolona ima najvecu sumu.");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo.");
                }
            }
        }
    }
}

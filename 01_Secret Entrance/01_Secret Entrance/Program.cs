using System;
using System.IO;

namespace _01_Secret_Entrance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "..\\..\\..\\input.txt";
            using (StreamReader sr = new StreamReader(input))
            {
                int vysledek = 50;
                int nuly = 0;
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    int odpocet = int.Parse(line.Substring(1));

                    if (line.Contains("R"))
                    {
                        vysledek += + odpocet;
                        while (vysledek > 99)
                        {
                            vysledek -= 100;
                            nuly++;
                        }
                    }
                    else if (line.Contains("L"))
                    {
                        //zabraneni falesnemu zapoctu pri odchodu z 0
                        if (vysledek == 0)
                        {
                            vysledek = 100;
                        }

                        vysledek -= odpocet;
                        while (vysledek < 0)
                        {
                            vysledek += 100;
                            nuly++;
                        }

                        if (vysledek == 0)
                        {
                            nuly++;
                        }
                    }
                }
                Console.WriteLine(nuly);
                Console.ReadLine();
            }
        }
    }
}

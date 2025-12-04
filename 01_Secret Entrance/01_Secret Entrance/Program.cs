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
                        vysledek = (vysledek + odpocet) % 100;
                    }
                    else if (line.Contains("L"))
                    {
                        vysledek = vysledek - odpocet;

                        while (vysledek < 0)
                        {
                            vysledek += 100;
                        }
                    }

                    if (vysledek == 0)
                    {
                        nuly++;
                    }
                }
                Console.WriteLine(nuly);
                Console.ReadLine();
            }
        }
    }
}

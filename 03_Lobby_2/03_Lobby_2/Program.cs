using System;
using System.IO;

namespace _03_Lobby
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "..\\..\\battery.txt";
            using (StreamReader sr = new StreamReader(inputFile))
            {
                string line;
                long vysledek = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    vysledek = vysledek + Joltage(line);
                }
                Console.WriteLine(vysledek);
            }

            Console.ReadLine();
        }
        static long Joltage(string baterka)
        {
            int nejvetsiCislo = -1;
            int indexPosledniho = 0;
            string vysledekString = "";
            int pocitadlo = 11;
            for (int i = 0; i < 12; i++)
            {
                nejvetsiCislo = -1;
                for (int j = indexPosledniho; j <= baterka.Length-1-pocitadlo; j++)
                {

                    if (baterka[j] - '0' > nejvetsiCislo)
                    {
                        indexPosledniho = j+1;
                        nejvetsiCislo = baterka[j] - '0';
                    }
                }
                if(pocitadlo >=0)
                {
                    pocitadlo--;
                }
                vysledekString = vysledekString + nejvetsiCislo.ToString();
            }

            long vysledek = long.Parse(vysledekString);
            return vysledek;
        }
    }
}

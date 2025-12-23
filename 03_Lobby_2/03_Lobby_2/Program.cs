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
                    //Console.WriteLine(line);
                    vysledek = vysledek + Joltage(line);
                }
                Console.WriteLine(vysledek);
            }
            Console.ReadLine();
        }
        static int Joltage(string baterka)
        {
            int nejvetsiCislo = baterka[0] - '0';
            int druheCislo = 0;
            int indexPrvniho = 0;

            int pocitadlo = 0;

            for (int i = 1; i < baterka.Length; i++)
            {
                pocitadlo++;
                if (baterka[i] - '0' > nejvetsiCislo && baterka.Length - i + pocitadlo )
                {
                    indexPrvniho = i;
                    nejvetsiCislo = baterka[indexPrvniho] - '0';
                }
            }

            int indexDruheho = indexPrvniho + 1;

            if (indexDruheho == baterka.Length)
            {
                druheCislo = baterka[indexDruheho] - '0';
            }
            else
            {
                for (int i = indexDruheho; i < baterka.Length; i++)
                {
                    if (baterka[i] - '0' > druheCislo)
                    {
                        druheCislo = baterka[i] - '0';
                    }
                }
            }
            string vysledekString = nejvetsiCislo.ToString() +druheCislo.ToString();
            int vysledek = int.Parse(vysledekString);
            return vysledek;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string baterka1 = "987654321111111";
            string baterka2 = "811111111111119";
            string baterka3 = "234234234234278";
            string baterka4 = "818181911112111";

            Console.WriteLine(Joltage(baterka1));
            Console.WriteLine(Joltage(baterka2));
            Console.WriteLine(Joltage(baterka3));
            Console.WriteLine(Joltage(baterka4));

            Console.ReadLine();
        }

        static long Joltage(int[] pole)
        {
            
        }
    }
}

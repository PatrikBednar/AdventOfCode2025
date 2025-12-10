using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GiftShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "6161588270-6161664791,128091420-128157776,306-494,510-1079,10977-20613,64552-123011,33-46,28076-52796,371150-418737,691122-766624,115-221,7426210-7504719,819350-954677,7713444-7877541,63622006-63661895,1370-1981,538116-596342,5371-8580,8850407-8965070,156363-325896,47-86,452615-473272,2012-4265,73181182-73335464,1102265-1119187,3343315615-3343342551,8388258268-8388317065,632952-689504,3-22,988344-1007943";

            //rozdeleni inputu na jednotlive rozmezi id
            string[] ids = input.Split(',');
            long pocet = ids.Length;

            Console.WriteLine(CheckForRepeating(ids, pocet));
            Console.ReadLine();
        }
        static long CheckForRepeating(string[] ids, long pocet)
        {
            long vysledek = 0;

            for (long i = 0; i < pocet; i++)
            {
                //rozdeleni rozmezi na cisla od - do
                string[] id = ids[i].Split('-');
                long idAlong = long.Parse(id[0]);
                long idBlong = long.Parse(id[1]);

                long cislo = idAlong;
                while(cislo <= idBlong)
                {
                    int delkaCisla = cislo.ToString().Length;
                    
                    if (delkaCisla % 2 == 0)
                    {
                        //rozdeleni cisla na dve casti pokud je sude
                        string levaCast = cislo.ToString().Substring(0, delkaCisla / 2);
                        string pravaCast = cislo.ToString().Substring(delkaCisla / 2);

                        //kontrola stejnosti obou casti cisla
                        if (levaCast == pravaCast)
                        {
                            vysledek = vysledek + cislo;
                        }
                    }
                    cislo++;
                }
            }
            return vysledek;
        }
    }
}

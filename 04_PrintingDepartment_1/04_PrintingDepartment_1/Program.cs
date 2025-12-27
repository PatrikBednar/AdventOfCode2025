using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_PrintingDepartment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "..\\..\\diagram.txt";
            string[] lines = File.ReadAllLines(inputFile);

            Console.WriteLine(Forklifts(lines));

            Console.ReadLine();
        }

        static int Forklifts(string[] lines)
        {
            string[] linesNew = new string[lines.Length];
            int pocetPapiruInt = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] != '@')
                    {
                        continue;
                    }

                    string pocetPapiruString = "";
                    if(i == 0 && i != lines.Length - 1 && j != 0 && j != lines[i].Length -1) //hrana nahore
                    {
                        pocetPapiruString = pocetPapiruString + lines[i + 1][j - 1].ToString() + lines[i + 1][j].ToString() + lines[i + 1][j + 1].ToString() //tri pod
                                        + lines[i][j - 1].ToString() + lines[i][j + 1].ToString();//dva kolem

                        pocetPapiruString = pocetPapiruString.Replace(".", "");
                        if (pocetPapiruString.Length < 4)
                        {
                            pocetPapiruInt++;
                        }
                    }
                    else if (i != 0 && i == lines.Length - 1 && j != 0 && j != lines[i].Length-1) //hrana dole
                    {
                        pocetPapiruString = pocetPapiruString + lines[i][j - 1].ToString() + lines[i][j + 1].ToString() +  //dva kolem
                                        lines[i - 1][j - 1].ToString() + lines[i - 1][j].ToString() + lines[i - 1][j + 1].ToString(); //tri nad

                        pocetPapiruString = pocetPapiruString.Replace(".", "");
                        if (pocetPapiruString.Length < 4)
                        {
                            pocetPapiruInt++;
                        }
                    }
                    else if (i != 0 && i != lines.Length - 1 && j == 0 && j != lines[i].Length - 1) //leva hrana
                    {
                        pocetPapiruString = pocetPapiruString + lines[i + 1][j].ToString() + lines[i + 1][j + 1].ToString() //dva pod
                                        + lines[i][j + 1].ToString() +  //vpravo
                                         lines[i - 1][j].ToString() + lines[i - 1][j + 1].ToString(); //dva nad

                        pocetPapiruString = pocetPapiruString.Replace(".", "");
                        if (pocetPapiruString.Length < 4)
                        {
                            pocetPapiruInt++;
                        }
                    }
                    else if (i != 0 && i != lines.Length - 1 && j != 0 && j == lines[i].Length - 1) //prava hrana
                    {
                        pocetPapiruString = pocetPapiruString + lines[i + 1][j - 1].ToString() + lines[i + 1][j].ToString() //dva pod
                                        + lines[i][j - 1].ToString() +  //vlevo
                                        lines[i - 1][j - 1].ToString() + lines[i - 1][j].ToString(); //dva nad

                        pocetPapiruString = pocetPapiruString.Replace(".", "");
                        if (pocetPapiruString.Length < 4)
                        {
                            pocetPapiruInt++;
                        }
                    }
                    else if (i != 0 && i != lines.Length - 1 && j != 0 && j != lines[i].Length - 1) //prostredek
                    {
                        pocetPapiruString = pocetPapiruString + lines[i + 1][j - 1].ToString() + lines[i + 1][j].ToString() + lines[i + 1][j + 1].ToString() //tri pod
                                        + lines[i][j - 1].ToString() + lines[i][j + 1].ToString() +  //dva kolem
                                        lines[i - 1][j - 1].ToString() + lines[i - 1][j].ToString() + lines[i - 1][j + 1].ToString(); //tri nad

                        pocetPapiruString = pocetPapiruString.Replace(".", "");
                        if (pocetPapiruString.Length < 4)
                        {
                            pocetPapiruInt++;
                        }
                    }
                    else if (i == 0 && j == 0 || i == 0 && j == lines[i].Length - 1 || i == lines.Length - 1 && j == 0 || i == lines.Length - 1 && j == lines[i].Length - 1) //rohy
                    {
                        char znak = lines[i][j];
                        if(znak == '@')
                        {
                            pocetPapiruInt++;
                        }
                    }     
                }
            }
            return pocetPapiruInt;
        }
    }
}

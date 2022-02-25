using System;

namespace BarriosPasswordGenetorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("password ");


            int[] numeri = new int[10];
            numeri[1] = 1;
            numeri[2] = 2;
            numeri[3] = 3;
            numeri[4] = 4;
            numeri[5] = 5;
            numeri[6] = 6;
            numeri[7] = 7;
            numeri[8] = 8;
            numeri[9] = 9;
            numeri[10] = 10;
            char[] alfabeto = new char[26];
            alfabeto[0] = 'a';
            alfabeto[1] = 'b';
            alfabeto[2]= 'c';
            alfabeto[3]= 'd';
            alfabeto[4]= 'e';
            alfabeto[5]= 'f';
            alfabeto[6]= 'g';
            alfabeto[7]= 'h';
            alfabeto[8]= 'i';
            alfabeto[9]= 'j';
            alfabeto[10]= 'k';
            alfabeto[11]= 'l';
            alfabeto[12]= 'm';
            alfabeto[13]= 'n';
            alfabeto[14]= 'o';
            alfabeto[15]= 'p';
            alfabeto[16]= 'q';
            alfabeto[17]= 'r';
            alfabeto[18]= 's';
            alfabeto[19]= 't';
            alfabeto[20]= 'u';
            alfabeto[21]= 'v';
            alfabeto[22]= 'w';
            alfabeto[23]= 'x';
            alfabeto[24]= 'y';
            alfabeto[25]= 'z';
            char[] simboli = new char[10];
            simboli[0]= 'è';
            simboli[1]= '@';
            simboli[2]= '#';
            simboli[3]= 'ò';
            simboli[4]= 'à';
            simboli[5]= 'ù';
            simboli[6]= 'ì';
            simboli[7]= '+';
            simboli[8]= '%';
            simboli[9]= '$';
            Console.WriteLine("quanto dev'essere lunga la tua password?");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            string nuovapassword = "";
            Random generatore = new Random();
            for (int i = 0; i < lunghezza; i++) 
                {
                int sceltamazzo = generatore.Next(1, 4);
                if (sceltamazzo == 1)
                {
                    int indicealfabeto = generatore.Next(0, 25);
                    nuovapassword = nuovapassword + alfabeto[indicealfabeto];
                }
               else if (sceltamazzo == 2)
                {
                    int indicenumeri = generatore.Next(0, 10);
                    nuovapassword = nuovapassword + numeri[indicenumeri];

                }
                else if(sceltamazzo==3)
                {
                    int indicesimboli = generatore.Next(0, 10);
                    nuovapassword = nuovapassword + numeri[indicesimboli];
                }

                Console.WriteLine($"la tua password è:{nuovapassword}");
                }

            
        }
    }
}

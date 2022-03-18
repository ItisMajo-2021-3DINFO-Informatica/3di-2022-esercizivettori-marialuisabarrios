using System;

namespace BarrioaVettori3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una app che carica un vettore di 30 elementi con valori casuali
            //compresi tra 0 e 50 e stampi la media dei valori contenuti nel vettore
            const int dim = 50;
            int[] numeri = new int[30];
            Random generatore = new Random();
            for (int i = 0; i < dim; i++)
            {
                numeri[i] = generatore.Next(0, 50);
            }
            for (int i = 0; i < dim; i++)
            {
                Console.WriteLine(numeri[i]);
            }
         
        }
    }
}

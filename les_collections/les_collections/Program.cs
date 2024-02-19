using System;

namespace MyApp
{
    internal class Program
    {


        static void AfficherTableau(int[] tableau)
        {
            for (int i=0; i<tableau.Length; i++)
            {
                Console.WriteLine($"[{i}] {tableau[i]}");
            }
        }

        static void ValeurMaximale(int[] t)
        {
            int maxValue = 0;
            for (int i=0; i<t.Length; i++)
            {
                if (t[i]>maxValue)
                {
                    maxValue = t[i];
                }
            }

            Array.Sort(t);
            int maxValue2 = t[t.Length-1];


            Console.WriteLine($"Le maximum est : {maxValue}");
            Console.WriteLine($"Le maximum est (sorted) : {maxValue2}");
        }

        static void Tableaux()
        {
            const int TAILLE_TABLEAU = 20;
            int[] t = new int[TAILLE_TABLEAU];
            Random rnd = new Random();

            for (int i=0; i<TAILLE_TABLEAU; i++)
            {
                t[i] = rnd.Next(0, 100+1);
            }

            AfficherTableau(t);
            ValeurMaximale(t);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tableaux();
            // ValeurMaximale()
        }
    }
}
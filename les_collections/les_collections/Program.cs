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

        static void Tableaux()
        {
            int[] t = {200, 40, 15, 8, 12};
            AfficherTableau(t);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tableaux();
        }
    }
}
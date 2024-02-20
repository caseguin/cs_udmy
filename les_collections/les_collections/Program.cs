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

        static void AfficherListe(List<string> liste, bool ordreDescendant=false)
        {
            string nomPlusGrand = "";

            if (ordreDescendant)
            {
                liste.Sort();
            }

            for (int i=0; i<liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
                
                if (liste[i].Length>nomPlusGrand.Length)
                {
                    nomPlusGrand = liste[i];
                }
            }

            Console.WriteLine("Le nom le plus est : " + nomPlusGrand);
        }

        static void AfficherElementsCommun(List<string> list1, List<string> list2)
        {
            var elementCommuns = new List<string> ();

            for (int i=0; i<list1.Count; i++)
            {
                if (list2.Contains(list1[i]))
                {
                    elementCommuns.Add(list1[i]);
                }
            }

            for (int i=0; i<elementCommuns.Count; i++)
            {
                Console.WriteLine(elementCommuns[i]);    
            }
        }

        static void Listes()
        {
            // var noms = new List<string>() {"Jean", "Alfonse", "Cassou", "Jean-Paul"};


            // while (true)
            // {
            //     Console.WriteLine("Rentrez un nom (Enter pour finir) : ");
            //     string nom = Console.ReadLine();

            //     if (nom == "")
            //     {
            //         break;
            //     }
 
            //     if (noms.Contains(nom))
            //     {
            //         Console.WriteLine("Erreur ce nom est déjà dans la liste");
            //     }
            //     else 
            //     {
            //         noms.Add(nom);
            //     }
            // }



            // const char LASTLETTER = 'e';

            // for (int i=noms.Count-1; i>=0; i--)
            // {
            //     if (noms[i][noms[i].Length - 1] == LASTLETTER)
            //     {
            //         noms.RemoveAt(i);
            //     }
            // }

            var liste1 = new List<string> {"Jean", "Paul", "Jean-Paul", "Charles"};
            var liste2 = new List<string> {"Paul","Charles"};

            AfficherElementsCommun(liste1, liste2);

            // AfficherListe(noms, true);
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Tableaux();
            // ValeurMaximale()
            Listes();
        }
    }
}
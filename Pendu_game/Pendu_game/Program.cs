using System;

namespace Jeu_pendu
{
    internal class Program
    {
        static void AfficherMot(string mot, List<char> lettres)
        {
            



            for (int i=0;i<mot.Length;i++)
            {
                if (lettres.Contains(mot[i]))
                {
                    Console.Write(mot[i] + " ");
                }
                else 
                {
                    Console.Write("_" + " ");
                }
                
            }
            // Console.WriteLine(listeChar);
        }

        static char DemanderLettre()
        {
            
            while (true)
            { 
                Console.Write("Choisissez une lettre");
                string reponse = Console.ReadLine();
                if (reponse.Length == 1)
                {
                    reponse = reponse.ToUpper();
                    Console.WriteLine(reponse);
                    return reponse[0];
                }
                Console.WriteLine("Erreur : entrez une lettre valide");
            }
        }

        // static void DevinerMot(string mot)
        // {
        // }
        
        static void Main(string[] args)
        {
            string mot = "ELEPHANT";
            
            Console.WriteLine(mot);

            // char lettre  = DemanderLettre();
            // List<char> lettres = new List<char> {lettre};

            // DevinerMot(mot);
            // AfficherMot(mot, lettres);

        }
    }
}
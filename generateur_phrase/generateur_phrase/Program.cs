using System;

namespace MyApp
{
    internal class Program
    {

        static string ObtenirElementAleatoire(string[] t)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, t.Length - 1);
            return t[index];
        }

        static void Main(string[] args)
        {

            var sujets = new string[] {
                "Le chat",
                "Le chien",
                "Charlou",
                "Cassou"
            };

            var verbes = new string[] {
                "mange", 
                "boit",
                "s'accroche à",
            };

            var complements = new string[] {
                "un os",
                "un poisson",
                "le ciel"
            };

            const int NB_PHRASE = 10;
            var phraseListe = new List<string>();
            int nombreDoublon = 0;


            while (phraseListe.Count < NB_PHRASE)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                var phrase = sujet + " " + verbe + " " + complement;
                
                if (phraseListe.Contains(phrase))
                {
                    nombreDoublon++;
                }
                else {
                    phraseListe.Add(phrase);
                }                
            }

            for (int i=0; i<phraseListe.Count; i++)
            {
                Console.WriteLine(phraseListe[i]);
            }
            Console.WriteLine(nombreDoublon);
            

            

            

        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static int DemanderNombre(int nombreMin, int nombreMax)
        {
            int nombreInt = nombreMin-1;

            while ((nombreInt < nombreMin) || (nombreInt > nombreMax))
            {
                Console.Write($"Entrez un nombre entre {nombreMin} et {nombreMax}:");
                string nombreStr = Console.ReadLine();
                
                try 
                {
                    nombreInt = int.Parse(nombreStr);
                    if ((nombreInt < nombreMin) || (nombreInt > nombreMax))
                    {
                        Console.WriteLine($"Erreur : Le nombre doit être compri entre {nombreMin} et {nombreMax}");
                        nombreInt = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur : Entrer un nombre valide");
                }

            }
            return nombreInt;
        }
        
        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);
            int number = NOMBRE_MIN -1;
            int nombreVie = 4;
            
            Console.WriteLine(NOMBRE_MAGIQUE);

            while (nombreVie > 0)
            {
                number = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
                nombreVie -= 1;
                Console.WriteLine("Nb vie : " + nombreVie);


                if (nombreVie == 0)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
                else if (number < NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre est plus grand");
                    
                }
                else if (number > NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique!");
                }
            }



        }
    }
}
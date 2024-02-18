// See https://aka.ms/new-console-template for more information


using System;

namespace premierProgramme // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static string PersonName(int numeroPersonne)
        {
            string personName = "";
            while (personName == "")
            {
                Console.Write($"Persone {numeroPersonne}, quel est ton nom? : ");
                personName = Console.ReadLine();
                personName = personName.Trim();

                if (personName == "")
                {
                    Console.WriteLine("Erreur : le nom ne doit pas être vide");
                }
            }
            return personName;
        }

        static int PersonAge(string personName)
        {

            int personAgeInt = 0;
            while (personAgeInt <= 0)   
            {
                try
                {
                    
                    Console.Write($"{personName}, quel est on âge? ");
                    string personAgeStr = Console.ReadLine();
                    personAgeInt = int.Parse(personAgeStr);

                    if (personAgeInt < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être inférieur à 0");
                    }
                    else if (personAgeInt == 0)
                    {
                        Console.WriteLine("Erreur : L'âge doit être supérieur à 0");
                    }
                    
                    
                }
                catch
                {
                    Console.WriteLine("Erreur : L'âge doit être un chiffre");
                }
            }
            return personAgeInt;
        }

        static void AfficherInfoPersonne(string personeName, int personAge)
        {
            if (personAge == 18)
            {
                Console.WriteLine($"{personeName} a {personAge}, vous ête tout juste majeur");
            }
            else if (personAge == 17)
            {
                Console.WriteLine($"{personeName} a {personAge} et est majeur");
            }
            else if ((personAge >= 12) && (personAge <18))
            {
               Console.WriteLine($"{personeName} a {personAge}, vous êtes Ado"); 
            }
            else if ((personAge == 12) || (personAge == 2))
            {
               Console.WriteLine($"{personeName} a {personAge}, vous êtes un bébé"); 
            }
            else if (personAge > 60)
            {
                Console.WriteLine($"{personeName} a {personAge}, vous êtes un sénior"); 
            }
            else if (personAge > 18)
            {
                Console.WriteLine($"{personeName} a {personAge}, vous êtes majeur");
            }
            else if (personAge < 10)
            {
               Console.WriteLine($"{personeName} a {personAge}, vous êtes un enfant"); 
            }
            else if (personAge < 18)
            {
                Console.WriteLine($"{personeName} a {personAge}, vous êtes un mineur"); 
            }
        }

        static void Main(string[] args)
        {
            string personName1 = PersonName(1);
            string personName2 = PersonName(2);

            int personAge1 = PersonAge(personName1);
            int personAge2 = PersonAge(personName2);

            AfficherInfoPersonne(personName1, personAge1);
            AfficherInfoPersonne(personName2, personAge2);
        }
    }
}

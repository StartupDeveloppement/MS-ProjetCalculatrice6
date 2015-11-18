using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.Afficher("Bonjour,pour utilisé ceci il faut avoir plus de 3 de qi !");
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Affichage.AffichageCouleur("1.Addition" , ConsoleColor.Yellow);
            Affichage.AffichageCouleur("2.soustraction", ConsoleColor.Red);
            Affichage.AffichageCouleur("3.multiplication", ConsoleColor.Blue);
            Affichage.AffichageCouleur("4.division", ConsoleColor.Green);
            Affichage.AffichageCouleur("", ConsoleColor.White);

            string saisieClavier = Console.ReadLine();
        
            int result;
            bool resultatParse = int.TryParse(saisieClavier, out result);
            if (!resultatParse)
            {
                    Affichage.AffichageCouleur("la saisie n'est pas un nombre,try again!", ConsoleColor.Red);
                Affichage.AffichageCouleur("", ConsoleColor.White);
                TypeOperation();
            }
            else
            {
                   
            if (result == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.addition();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 2)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
               double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.soustraction();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 3)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.multiplication();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 4)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.division();
                if (secondChiffre ==0)
                {
                    Console.WriteLine("impossible de divisé par 0 !");
                    TypeOperation();
                }

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else
            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
 }
}
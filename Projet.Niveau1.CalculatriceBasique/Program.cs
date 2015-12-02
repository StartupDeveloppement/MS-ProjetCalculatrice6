using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.AffichageCouleur("Bonjour !", ConsoleColor.White);
            TypeOperation();
        }

        public static double RecupererChiffre()
        {
            double premierChiffre = Convert.ToDouble(Console.ReadLine());
            return premierChiffre;
        }




        private static void TypeOperation()
        {
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Affichage.AffichageCouleur("1.Addition", ConsoleColor.Yellow);
            Affichage.AffichageCouleur("2.soustraction", ConsoleColor.Red);
            Affichage.AffichageCouleur("3.multiplication", ConsoleColor.Blue);
            Affichage.AffichageCouleur("4.division", ConsoleColor.Green);
            Affichage.AffichageCouleur("", ConsoleColor.White);

            double premierChiffre = 0.0;
            double secondChiffre = 0.0;
            Calcul calcul = new Calcul(premierChiffre, secondChiffre);
            double resultat;

            //try parse
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


                switch (result)
                {
                    case 1:
                        Affichage.AfficherSansRetourLigne("Premier nombre :");
                        premierChiffre = RecupererChiffre();
                        Affichage.AfficherSansRetourLigne("Second nombre :");
                        secondChiffre = RecupererChiffre();

                        calcul = new Calcul(premierChiffre, secondChiffre);
                        resultat = calcul.addition();

                        Affichage.AffichageCouleur("Le résultat est : " + resultat, ConsoleColor.Magenta);
                        TypeOperation();
                        break;
                    case 2:

                        Affichage.AfficherSansRetourLigne("Premier nombre :");
                        premierChiffre = RecupererChiffre();
                        Affichage.AfficherSansRetourLigne("Second nombre :");
                        secondChiffre = RecupererChiffre();

                        calcul = new Calcul(premierChiffre, secondChiffre);
                        resultat = calcul.soustraction();

                        Affichage.AffichageCouleur("Le résultat est : " + resultat, ConsoleColor.Magenta);
                        TypeOperation();
                        break;

                    case 3:

                        Affichage.AfficherSansRetourLigne("Premier nombre :");
                        premierChiffre = RecupererChiffre(); ;
                        Affichage.AfficherSansRetourLigne("Second nombre :");
                        secondChiffre = RecupererChiffre();

                        calcul = new Calcul(premierChiffre, secondChiffre);
                        resultat = calcul.multiplication();

                        Affichage.AffichageCouleur("Le résultat est : " + resultat, ConsoleColor.Magenta);
                        TypeOperation();
                        break;

                    case 4:

                        Affichage.AfficherSansRetourLigne("Premier nombre :");
                        premierChiffre = RecupererChiffre();
                        Affichage.AfficherSansRetourLigne("Second nombre :");
                        secondChiffre = RecupererChiffre();
                        calcul = new Calcul(premierChiffre, secondChiffre);
                        resultat = calcul.division();


                        if (secondChiffre == 0)
                        {
                            Console.WriteLine("Impossible de diviser par 0 !");
                            TypeOperation();
                        }


                        Affichage.AffichageCouleur("Le résultat est : " + resultat, ConsoleColor.Magenta);
                        TypeOperation();
                        break;





                }
                Affichage.AffichageCouleur("Mauvaise saisie", ConsoleColor.Red);
                TypeOperation();
            }
        }
    }
}
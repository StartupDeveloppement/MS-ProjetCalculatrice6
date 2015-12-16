
using static System.Console;
using System;

namespace Projet.Niveau1.MoneyManagement
{
    class Affichage
    {
        #region Affichage Console
        public static void Afficher(string texte)
        {
            WriteLine(texte);
        }

        public static void AfficherSansRetourLigne(string texte)
        {
            Write(texte);
        }
        #endregion

        #region Menu
        public static void DisplayMenu()
        {
            Afficher("----------------------------------------");
            AffichageCouleur("Menu du logiciel",ConsoleColor.White);
            Afficher("");
            AffichageCouleur("1. Lister le détails des opérations", ConsoleColor.Blue);
            AffichageCouleur("2. Ajouter une opération", ConsoleColor.Green);
            AffichageCouleur("3. Ajouter une opération régulière", ConsoleColor.DarkMagenta);
            AffichageCouleur("4. Supprimer une opération", ConsoleColor.Red);
            AffichageCouleur("5. Vider le compte", ConsoleColor.DarkRed);
            AffichageCouleur("6. Quitter le logiciel", ConsoleColor.White);
            Afficher("----------------------------------------");
        }
        #endregion
        public static void AffichageCouleur(string texte, ConsoleColor couleur)
        {
            ForegroundColor = couleur;
            Afficher(texte);
        }
        public static bool DemanderSiAutreOperation()
        {
            //TODO : Afficher un message
            //Retourner true si oui, false si non
            return false;
        }
    }
}

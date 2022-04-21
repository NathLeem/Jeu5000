using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu5000
{
    public struct MethodeDuProjet
    {
        public void ChoixNbreJoueur(int NbreJoueur, ref string player1, ref string player2, ref string player3, ref string player4, ref string player5)
        {
            if (NbreJoueur >= 2)
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
            }
            if (NbreJoueur >= 3)
            {
                Console.WriteLine("Veuillez entrer le prénom du troisième joueur");
                player3 = Console.ReadLine();
            }
            if (NbreJoueur >= 4)
            {
                Console.WriteLine("Veuillez entrer le prénom du quatrième joueur");
                player4 = Console.ReadLine();
            }
            if (NbreJoueur >= 5)
            {
                Console.WriteLine("Veuillez entrer le prénom du cinquième joueur");
                player5 = Console.ReadLine();
            }

            Console.ReadLine();
        }
        public void lancerDes(int[,] tablDes, int NbreJoueur)
        {
            NbreJoueur = 0;//na

        }
        public void AfficheTableau(int[,] tablDes, int NbreJoueur)
        {
            for (int i = 0; i < NbreJoueur; i++)
            {
                for (int j = 0; j < NbreJoueur; j++)
                {
                    Console.Write(tablDes[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

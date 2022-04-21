using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu5000
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = "";
            string player2 = "";
            string player3 = "";
            string player4 = "";
            string player5 = "";
            int NbreJoueur = 0;
            

            Console.WriteLine("-------------");
            Console.Write("|");
            Console.Write("Jeu du 5000");
            Console.WriteLine("|");
            Console.WriteLine("-------------");
            Console.WriteLine("Règles du jeu");
            Console.WriteLine("////");

            Console.WriteLine("Combien de joueurs vont jouer ?");
            NbreJoueur = int.Parse(Console.ReadLine());

            int[,] tablDes = new int[NbreJoueur, 5];
            MethodeDuProjet MesOutils = new MethodeDuProjet();

            MesOutils.AfficheTableau(tablDes, NbreJoueur);
            MesOutils.ChoixNbreJoueur(NbreJoueur, ref player1, ref player2, ref player3, ref player4, ref player5);

            Console.WriteLine($"1er Joueur: {player1}");
            Console.WriteLine($"2eme joueur:{player2}");
            Console.WriteLine($"3eme joueur: {player3}");
            Console.WriteLine($"4eme joueur: {player4}");
            Console.WriteLine($"5eme joueur: {player5}");

            Console.ReadLine();
        }
    }
}

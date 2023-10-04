/**
* Jeu du nombre caché
* author : Emds 
* date : 23/05/2020
*/
using System;


namespace NombreCache
{
	class Program
	{
		static void Main(string[] args)
		{  //déclaration
			int valeur = 0, essai, nbre = 1;
			bool correct = false;
			// saisie du nombre à chercher
			while (!correct)
			{
				try
				{






					Console.Write("Entrez le nombre à chercher = ");
					valeur = int.Parse(Console.ReadLine());
					correct = true;
				}
				catch
				{
					Console.WriteLine("Erreur de saisie : saisissez un nombre entier ");


				}
			}
			Console.Clear();


			// saisie du premier essai
			Console.Write("Entrez un essai = ");
			essai = int.Parse(Console.ReadLine());
			// boucle sur les essais
			while (essai != valeur) 
			{
				Console.ReadLine();
				// test de l'essai par rapport à la valeur à chercher
				if (essai > valeur)
				{
					Console.WriteLine(" --> trop grand ! ");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine(" --> trop petit !");
					Console.ReadLine();
				}
				// saisie d'un nouvel essai
				Console.Write("Entrez un essai =");
				essai = int.Parse(Console.ReadLine());
				// compteur d'essais
				nbre++;
				
			}
			// valeur trouvée
			Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
			Console.ReadLine();
		}
	}
}


	
	


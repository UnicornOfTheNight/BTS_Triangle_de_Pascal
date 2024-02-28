using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePascal
{
	class Program
	{
		static void afficher_matrice(List<List<int>> matrice, ref int taille)
		{

			Console.WriteLine("\nLa matrice a traité est : ");

			int c = 1;

			for (int i = 0; i < taille; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					if (j == 0 || i == 0)
						c = 1;

					else
						c = c * (i - j + 1) / j;

					Console.Write(c + "\t");
				}

				Console.Write("\n");

			}

		}

		static List<List<int>> matrice_nulle(ref int taille)
		{

			List<List<int>> mat = new List<List<int>>();
			List<int> mat1 = new List<int>();

			for (int i = 0; i < taille; i++)
			{
				for (int j = 0; j < taille; j++)
				{
					mat1.Add(0);
				}

				mat.Add(mat1);

			}

			return mat;


		}

		static void afficher_nulle(ref int taille)
		{
			int tmp = taille;
			foreach (List<int> subList in matrice_nulle(ref taille))
			{


				foreach (int item in subList)
				{

					while (taille > 0)
					{
						Console.Write(item + "\t");
						taille--;

					}
				}

				taille = tmp;
				Console.WriteLine("\n");
			}
		}


		static void pascal(ref int taille)
		{
			int c = 0;
			int r = 0;

			List<List<int>> mat = new List<List<int>>();
			List<int> mat1 = new List<int>();

			for (int i = 0; i < taille; i++)
			{


				for (int j = 0; j <= i; j++)
				{

					if (j == 0 || i == 0)
						c = 1;

					else
						c = c * (i - j + 1) / j;


					r++;
					Console.Write(c + "\t");

				}




				while (r < taille)
				{
					Console.Write(0 + "\t");
					r++;

				}
				if (r == taille)
					r = 0;


				Console.Write("\n");

			}

		}


		static void Main(string[] args)
		{
			List<List<int>> Mat;
			Mat = new List<List<int>>();

			int taille = 0;
			Console.WriteLine("Taille du triangle en nombre de ligne ?");
			try
			{
				taille = Convert.ToInt32(Console.ReadLine());
			}
			catch { }

			afficher_matrice(Mat, ref taille);


			Console.WriteLine("\nLa matrice carré est : ");
			afficher_nulle(ref taille);

			Console.WriteLine("\nVoici le triangle fini !");


			pascal(ref taille);



			Console.ReadLine();

		}
	}
}

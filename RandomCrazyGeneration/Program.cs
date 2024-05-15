using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCrazyGeneration
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WindowHeight = Console.LargestWindowHeight;
			Console.WindowWidth = Console.LargestWindowWidth;
			int coloumns = 50 * 4;
			int rows = 12 * 4;
			string[,] World = new string[rows, coloumns];
		start:
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < coloumns; j++)
				{
					if (i < 3)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						World[i, j] = "~";
					}
					else if (i >= 3)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						World[i, j] = "-";
						Random random = new Random();
						int treeCount = random.Next(coloumns / 2, coloumns);
						for (int t = 0; t < treeCount; t++)
						{
							string Tree = "T";
							int coloumnTree = random.Next(0, coloumns - 1);
							int rowTree = random.Next(0, rows - 1);
							World[rowTree, coloumnTree] = Tree;
						}
						//Просто при случайном положении x сменить направление или закончить реку

						int riverDirection = random.Next(-1, 1);
						int RiverBlockPosX = Convert.ToInt32(Math.Pow(j, 0.7));
						int RiverBlockPosY = Convert.ToInt32(j);
						Console.ForegroundColor = ConsoleColor.Blue;
						World[RiverBlockPosX, RiverBlockPosY] = "R";
						Console.ForegroundColor = ConsoleColor.Green;






					}
					Console.Write(World[i, j]);
				}

				Console.WriteLine();

			}
			string userInput = Console.ReadLine();
			goto start;
			
			Console.ReadKey();
		}
	
	}
}

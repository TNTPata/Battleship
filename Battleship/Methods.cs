using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public class Methods
	{
		///Some notes, please ignore...
		///2x 3
		///1x 2
		///1x 5
		///1x 4

		//Textbook randomiser
		static Random rnd = new Random();

		public static void ShipPlacer()
		{
			int[,] carrier5 = new int[1, 1];
			int[,] destroyer4 = new int[1, 1];
			int[,] cruiser3 = new int[1, 1];
			int[,] submarine3 = new int[1, 1];
			int[,] torpedoboat2 = new int[1, 1];

			int horisontal = rnd.Next(0, 2); 

			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				carrier5[0, 0] = x;
			}
			else 
			{

			}
		}
		//Goes through both boards and sets all indexes to false.
		public static void ResetBoards()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Battleship.playerOneGameboard[i, j] = false;
					Battleship.playerTwoGameboard[i, j] = false;
				}
			}
		}
	}
}

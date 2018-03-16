﻿using System;
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
			int[,] carrier5 = new int[2,2];
			int[,] destroyer4 = new int[2,2];
			int[,] cruiser3 = new int[2,2];
			int[,] submarine3 = new int[2,2];
			int[,] torpedoboat2 = new int[2,2];

			int horisontal = rnd.Next(0, 2); 

			//Starting coords and placement for 5 length ship
			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				carrier5[1, 0] = x;
				carrier5[0, 1] = y;
			}
			else 
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 5);
				carrier5[1, 0] = x;
				carrier5[0, 1] = y;
			}

			//Starting coords and placement for 4 length ship
			horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				destroyer4[1, 0] = x;
				destroyer4[0, 1] = y;
			}
			else
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 5);
				destroyer4[1, 0] = x;
				destroyer4[0, 1] = y;
			}

			//Starting coords and placement for 3 length ship
			horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				cruiser3[1, 0] = x;
				cruiser3[0, 1] = y;
			}
			else
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 5);
				cruiser3[1, 0] = x;
				cruiser3[0, 1] = y;
			}

			//Starting coords and placement for 3 length ship
			horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				submarine3[1, 0] = x;
				submarine3[0, 1] = y;
			}
			else
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 5);
				submarine3[1, 0] = x;
				submarine3[0, 1] = y;
			}

			//Starting coords and placement for 2 length ship
			horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				int x = rnd.Next(0, 5);
				int y = rnd.Next(0, 10);
				torpedoboat2[1, 0] = x;
				torpedoboat2[0, 1] = y;
			}
			else
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 5);
				torpedoboat2[1, 0] = x;
				torpedoboat2[0, 1] = y;
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

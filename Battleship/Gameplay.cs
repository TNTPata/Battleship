using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	class Gameplay
	{
		public static void Singleplayer()
		{

		}
		
		//Scans gameboard for all positions to be empty
		public static int WinCheck()
		{
			int gameboardOnePositionsChecked = 0;
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					if (Battleship.playerOneGameboard[x, y] == false)
					{
						gameboardOnePositionsChecked++;
					}
				}
			}
			if (gameboardOnePositionsChecked == 100)
			{
				return 1;
			}

			int gameboardTwoPositionsChecked = 0;
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					if (Battleship.playerTwoGameboard[x, y] == false)
					{
						gameboardTwoPositionsChecked++;
					}
				}
			}
			if (gameboardTwoPositionsChecked == 100)
			{
				return 2;
			}

			return 0;
		}
	}
}
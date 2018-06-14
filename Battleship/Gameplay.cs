using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	partial class Battleship
	{
		//Keeps track of number of moves
		public static int numberOfMoves = 0;

		public void MoveCounter()
		{
			numberOfMoves++;
			lblMoveCounter.Text = "Number of moves: " + numberOfMoves;
		}
		//Scans gameboard for all positions to be empty
		//Return 0 if noone has won yet, 1 if player one has won, 2 if player two has won
		public static int WinnerCheck()
		{
			int gameboardOnePositionsChecked = 0;
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					if (Battleship.playerOneGameboard[x, y] == '0')
					{
						gameboardOnePositionsChecked++;
					}
				}
			}

			//Ensures that all 100 positions are empty
			if (gameboardOnePositionsChecked == 100)
			{
				
				return 2;
			}

			int gameboardTwoPositionsChecked = 0;
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					if (Battleship.playerTwoGameboard[x, y] == '0')
					{
						gameboardTwoPositionsChecked++;
					}
				}
			}

			//Ensures that all 100 positions are empty
			if (gameboardTwoPositionsChecked == 100)
			{
				return 1;
			}

			//Neither of the boards had 100 empty positions, noone has won yet. 
			return 0;
		}
	}
}
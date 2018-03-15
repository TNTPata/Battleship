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

		Random rnd = new Random();
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

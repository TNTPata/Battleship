using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	class HitDetectors
	{
		#region Unused code
		//Detects hits or misses for player ones gameboard
		//Not used
		public static void HitDetectorGameboardOne(int x, int y, ref System.Windows.Forms.PictureBox buttonToChange)
		{
			//Hit
			if (Battleship.playerOneGameboard[x, y] != '0')
			{
				//Sets position to "hit"
				//Sets button color to yellow
				Battleship.playerOneGameboard[x, y] = '0';

				buttonToChange.BackColor = Color.Yellow;
			}
			//Miss
			else if (buttonToChange.BackColor != Color.Yellow)
			{
				buttonToChange.BackColor = Color.White;
			}
		}
		#endregion

		//Detects hits or misses for player two/enemy gameboard
		//Reference buttonToChange from PictureBox_Click event
		public static void HitDetectorGameboardTwo(int x, int y, ref System.Windows.Forms.PictureBox buttonToChange)
		{
			//Hit
			if (Battleship.playerTwoGameboard[x, y] != '0')
			{
				//Sets position to "hit"
				//Sets button color to yellow
				Battleship.playerTwoGameboard[x, y] = '0';

				buttonToChange.BackColor = Color.Yellow;
			}
			//Miss
			else if (buttonToChange.BackColor != Color.Yellow)
			{
				buttonToChange.BackColor = Color.LightBlue;
			}
		}

		//Used for when debug button "Hit All" is pressed 
		public static void DebugHitDetectorGameboardTwo(int x, int y, ref System.Windows.Forms.PictureBox buttonToChange)
		{ 
			if ((buttonToChange.BackColor == Color.Yellow) && (Battleship.playerTwoGameboard[x, y] == '0'))
			{
				buttonToChange.BackColor = Color.LightBlue;
			}
		}
	}
}

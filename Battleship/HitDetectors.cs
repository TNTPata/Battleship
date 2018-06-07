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
		//Detects hits or misses for right (enemy) gameboard
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
			//Used for debug Redraw
			else if ((buttonToChange.BackColor == Color.Yellow) && (Battleship.playerTwoGameboard[x, y] == '0'))
			{
				buttonToChange.BackColor = Color.LightBlue;
			}
			//Miss
			else if (buttonToChange.BackColor != Color.Yellow)
			{
				buttonToChange.BackColor = Color.LightBlue;
			}
			
		}

		//Used for when debug button "Redraw" is pushed. 
		public static void DebugHitDetectorGameboardTwo(int x, int y, ref System.Windows.Forms.PictureBox buttonToChange)
		{

		}
	}
}

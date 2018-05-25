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
			if (Battleship.playerTwoGameboard[x, y] == true)
			{
				//Sets position to "hit"
				//Sets button color to orange/yellow
				Battleship.playerTwoGameboard[x, y] = false;

				buttonToChange.BackColor = Color.Yellow;
			}
			//Miss
			else if (buttonToChange.BackColor != Color.Yellow)
			{
				buttonToChange.BackColor = Color.LightBlue;
			}
		}
	}
}

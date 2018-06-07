using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public partial class Battleship
	{
		//Textbook randomiser
		static Random rnd = new Random();

		//Goes through both boards and sets all indexes to false.
		public static void ResetBoards()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Battleship.playerOneGameboard[i, j] = '0';
					Battleship.playerTwoGameboard[i, j] = '0';
				}
			}
		}

		//Marks locations of all ships on your own gameboard, by checking *every single button* manually...
		//Send in all related buttons, because I don't know any other way
		#region ShipMarker()
		public static void ShipMarker(ref System.Windows.Forms.PictureBox pb1Pos00,
			ref System.Windows.Forms.PictureBox pb1Pos01,
			ref System.Windows.Forms.PictureBox pb1Pos02,
			ref System.Windows.Forms.PictureBox pb1Pos03,
			ref System.Windows.Forms.PictureBox pb1Pos04,
			ref System.Windows.Forms.PictureBox pb1Pos05,
			ref System.Windows.Forms.PictureBox pb1Pos06,
			ref System.Windows.Forms.PictureBox pb1Pos07,
			ref System.Windows.Forms.PictureBox pb1Pos08,
			ref System.Windows.Forms.PictureBox pb1Pos09,
			ref System.Windows.Forms.PictureBox pb1Pos10,
			ref System.Windows.Forms.PictureBox pb1Pos11,
			ref System.Windows.Forms.PictureBox pb1Pos12,
			ref System.Windows.Forms.PictureBox pb1Pos13,
			ref System.Windows.Forms.PictureBox pb1Pos14,
			ref System.Windows.Forms.PictureBox pb1Pos15,
			ref System.Windows.Forms.PictureBox pb1Pos16,
			ref System.Windows.Forms.PictureBox pb1Pos17,
			ref System.Windows.Forms.PictureBox pb1Pos18,
			ref System.Windows.Forms.PictureBox pb1Pos19,
			ref System.Windows.Forms.PictureBox pb1Pos20,
			ref System.Windows.Forms.PictureBox pb1Pos21,
			ref System.Windows.Forms.PictureBox pb1Pos22,
			ref System.Windows.Forms.PictureBox pb1Pos23,
			ref System.Windows.Forms.PictureBox pb1Pos24,
			ref System.Windows.Forms.PictureBox pb1Pos25,
			ref System.Windows.Forms.PictureBox pb1Pos26,
			ref System.Windows.Forms.PictureBox pb1Pos27,
			ref System.Windows.Forms.PictureBox pb1Pos28,
			ref System.Windows.Forms.PictureBox pb1Pos29,
			ref System.Windows.Forms.PictureBox pb1Pos30,
			ref System.Windows.Forms.PictureBox pb1Pos31,
			ref System.Windows.Forms.PictureBox pb1Pos32,
			ref System.Windows.Forms.PictureBox pb1Pos33,
			ref System.Windows.Forms.PictureBox pb1Pos34,
			ref System.Windows.Forms.PictureBox pb1Pos35,
			ref System.Windows.Forms.PictureBox pb1Pos36,
			ref System.Windows.Forms.PictureBox pb1Pos37,
			ref System.Windows.Forms.PictureBox pb1Pos38,
			ref System.Windows.Forms.PictureBox pb1Pos39,
			ref System.Windows.Forms.PictureBox pb1Pos40,
			ref System.Windows.Forms.PictureBox pb1Pos41,
			ref System.Windows.Forms.PictureBox pb1Pos42,
			ref System.Windows.Forms.PictureBox pb1Pos43,
			ref System.Windows.Forms.PictureBox pb1Pos44,
			ref System.Windows.Forms.PictureBox pb1Pos45,
			ref System.Windows.Forms.PictureBox pb1Pos46,
			ref System.Windows.Forms.PictureBox pb1Pos47,
			ref System.Windows.Forms.PictureBox pb1Pos48,
			ref System.Windows.Forms.PictureBox pb1Pos49,
			ref System.Windows.Forms.PictureBox pb1Pos50,
			ref System.Windows.Forms.PictureBox pb1Pos51,
			ref System.Windows.Forms.PictureBox pb1Pos52,
			ref System.Windows.Forms.PictureBox pb1Pos53,
			ref System.Windows.Forms.PictureBox pb1Pos54,
			ref System.Windows.Forms.PictureBox pb1Pos55,
			ref System.Windows.Forms.PictureBox pb1Pos56,
			ref System.Windows.Forms.PictureBox pb1Pos57,
			ref System.Windows.Forms.PictureBox pb1Pos58,
			ref System.Windows.Forms.PictureBox pb1Pos59,
			ref System.Windows.Forms.PictureBox pb1Pos60,
			ref System.Windows.Forms.PictureBox pb1Pos61,
			ref System.Windows.Forms.PictureBox pb1Pos62,
			ref System.Windows.Forms.PictureBox pb1Pos63,
			ref System.Windows.Forms.PictureBox pb1Pos64,
			ref System.Windows.Forms.PictureBox pb1Pos65,
			ref System.Windows.Forms.PictureBox pb1Pos66,
			ref System.Windows.Forms.PictureBox pb1Pos67,
			ref System.Windows.Forms.PictureBox pb1Pos68,
			ref System.Windows.Forms.PictureBox pb1Pos69,
			ref System.Windows.Forms.PictureBox pb1Pos70,
			ref System.Windows.Forms.PictureBox pb1Pos71,
			ref System.Windows.Forms.PictureBox pb1Pos72,
			ref System.Windows.Forms.PictureBox pb1Pos73,
			ref System.Windows.Forms.PictureBox pb1Pos74,
			ref System.Windows.Forms.PictureBox pb1Pos75,
			ref System.Windows.Forms.PictureBox pb1Pos76,
			ref System.Windows.Forms.PictureBox pb1Pos77,
			ref System.Windows.Forms.PictureBox pb1Pos78,
			ref System.Windows.Forms.PictureBox pb1Pos79,
			ref System.Windows.Forms.PictureBox pb1Pos80,
			ref System.Windows.Forms.PictureBox pb1Pos81,
			ref System.Windows.Forms.PictureBox pb1Pos82,
			ref System.Windows.Forms.PictureBox pb1Pos83,
			ref System.Windows.Forms.PictureBox pb1Pos84,
			ref System.Windows.Forms.PictureBox pb1Pos85,
			ref System.Windows.Forms.PictureBox pb1Pos86,
			ref System.Windows.Forms.PictureBox pb1Pos87,
			ref System.Windows.Forms.PictureBox pb1Pos88,
			ref System.Windows.Forms.PictureBox pb1Pos89,
			ref System.Windows.Forms.PictureBox pb1Pos90,
			ref System.Windows.Forms.PictureBox pb1Pos91,
			ref System.Windows.Forms.PictureBox pb1Pos92,
			ref System.Windows.Forms.PictureBox pb1Pos93,
			ref System.Windows.Forms.PictureBox pb1Pos94,
			ref System.Windows.Forms.PictureBox pb1Pos95,
			ref System.Windows.Forms.PictureBox pb1Pos96,
			ref System.Windows.Forms.PictureBox pb1Pos97,
			ref System.Windows.Forms.PictureBox pb1Pos98,
			ref System.Windows.Forms.PictureBox pb1Pos99) {

			//Mark all positions that are not empty with Lime green, others with light blue
			if (playerOneGameboard[0, 0] != '0') { pb1Pos00.BackColor = Color.LimeGreen; } else { pb1Pos00.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 1] != '0') { pb1Pos01.BackColor = Color.LimeGreen; } else { pb1Pos01.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 2] != '0') { pb1Pos02.BackColor = Color.LimeGreen; } else { pb1Pos02.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 3] != '0') { pb1Pos03.BackColor = Color.LimeGreen; } else { pb1Pos03.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 4] != '0') { pb1Pos04.BackColor = Color.LimeGreen; } else { pb1Pos04.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 5] != '0') { pb1Pos05.BackColor = Color.LimeGreen; } else { pb1Pos05.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 6] != '0') { pb1Pos06.BackColor = Color.LimeGreen; } else { pb1Pos06.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 7] != '0') { pb1Pos07.BackColor = Color.LimeGreen; } else { pb1Pos07.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 8] != '0') { pb1Pos08.BackColor = Color.LimeGreen; } else { pb1Pos08.BackColor = Color.LightBlue; }
			if (playerOneGameboard[0, 9] != '0') { pb1Pos09.BackColor = Color.LimeGreen; } else { pb1Pos09.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 0] != '0') { pb1Pos10.BackColor = Color.LimeGreen; } else { pb1Pos10.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 1] != '0') { pb1Pos11.BackColor = Color.LimeGreen; } else { pb1Pos11.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 2] != '0') { pb1Pos12.BackColor = Color.LimeGreen; } else { pb1Pos12.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 3] != '0') { pb1Pos13.BackColor = Color.LimeGreen; } else { pb1Pos13.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 4] != '0') { pb1Pos14.BackColor = Color.LimeGreen; } else { pb1Pos14.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 5] != '0') { pb1Pos15.BackColor = Color.LimeGreen; } else { pb1Pos15.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 6] != '0') { pb1Pos16.BackColor = Color.LimeGreen; } else { pb1Pos16.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 7] != '0') { pb1Pos17.BackColor = Color.LimeGreen; } else { pb1Pos17.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 8] != '0') { pb1Pos18.BackColor = Color.LimeGreen; } else { pb1Pos18.BackColor = Color.LightBlue; }
			if (playerOneGameboard[1, 9] != '0') { pb1Pos19.BackColor = Color.LimeGreen; } else { pb1Pos19.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 0] != '0') { pb1Pos20.BackColor = Color.LimeGreen; } else { pb1Pos20.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 1] != '0') { pb1Pos21.BackColor = Color.LimeGreen; } else { pb1Pos21.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 2] != '0') { pb1Pos22.BackColor = Color.LimeGreen; } else { pb1Pos22.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 3] != '0') { pb1Pos23.BackColor = Color.LimeGreen; } else { pb1Pos23.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 4] != '0') { pb1Pos24.BackColor = Color.LimeGreen; } else { pb1Pos24.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 5] != '0') { pb1Pos25.BackColor = Color.LimeGreen; } else { pb1Pos25.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 6] != '0') { pb1Pos26.BackColor = Color.LimeGreen; } else { pb1Pos26.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 7] != '0') { pb1Pos27.BackColor = Color.LimeGreen; } else { pb1Pos27.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 8] != '0') { pb1Pos28.BackColor = Color.LimeGreen; } else { pb1Pos28.BackColor = Color.LightBlue; }
			if (playerOneGameboard[2, 9] != '0') { pb1Pos29.BackColor = Color.LimeGreen; } else { pb1Pos29.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 0] != '0') { pb1Pos30.BackColor = Color.LimeGreen; } else { pb1Pos30.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 1] != '0') { pb1Pos31.BackColor = Color.LimeGreen; } else { pb1Pos31.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 2] != '0') { pb1Pos32.BackColor = Color.LimeGreen; } else { pb1Pos32.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 3] != '0') { pb1Pos33.BackColor = Color.LimeGreen; } else { pb1Pos33.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 4] != '0') { pb1Pos34.BackColor = Color.LimeGreen; } else { pb1Pos34.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 5] != '0') { pb1Pos35.BackColor = Color.LimeGreen; } else { pb1Pos35.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 6] != '0') { pb1Pos36.BackColor = Color.LimeGreen; } else { pb1Pos36.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 7] != '0') { pb1Pos37.BackColor = Color.LimeGreen; } else { pb1Pos37.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 8] != '0') { pb1Pos38.BackColor = Color.LimeGreen; } else { pb1Pos38.BackColor = Color.LightBlue; }
			if (playerOneGameboard[3, 9] != '0') { pb1Pos39.BackColor = Color.LimeGreen; } else { pb1Pos39.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 0] != '0') { pb1Pos40.BackColor = Color.LimeGreen; } else { pb1Pos40.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 1] != '0') { pb1Pos41.BackColor = Color.LimeGreen; } else { pb1Pos41.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 2] != '0') { pb1Pos42.BackColor = Color.LimeGreen; } else { pb1Pos42.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 3] != '0') { pb1Pos43.BackColor = Color.LimeGreen; } else { pb1Pos43.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 4] != '0') { pb1Pos44.BackColor = Color.LimeGreen; } else { pb1Pos44.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 5] != '0') { pb1Pos45.BackColor = Color.LimeGreen; } else { pb1Pos45.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 6] != '0') { pb1Pos46.BackColor = Color.LimeGreen; } else { pb1Pos46.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 7] != '0') { pb1Pos47.BackColor = Color.LimeGreen; } else { pb1Pos47.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 8] != '0') { pb1Pos48.BackColor = Color.LimeGreen; } else { pb1Pos48.BackColor = Color.LightBlue; }
			if (playerOneGameboard[4, 9] != '0') { pb1Pos49.BackColor = Color.LimeGreen; } else { pb1Pos49.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 0] != '0') { pb1Pos50.BackColor = Color.LimeGreen; } else { pb1Pos50.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 1] != '0') { pb1Pos51.BackColor = Color.LimeGreen; } else { pb1Pos51.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 2] != '0') { pb1Pos52.BackColor = Color.LimeGreen; } else { pb1Pos52.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 3] != '0') { pb1Pos53.BackColor = Color.LimeGreen; } else { pb1Pos53.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 4] != '0') { pb1Pos54.BackColor = Color.LimeGreen; } else { pb1Pos54.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 5] != '0') { pb1Pos55.BackColor = Color.LimeGreen; } else { pb1Pos55.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 6] != '0') { pb1Pos56.BackColor = Color.LimeGreen; } else { pb1Pos56.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 7] != '0') { pb1Pos57.BackColor = Color.LimeGreen; } else { pb1Pos57.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 8] != '0') { pb1Pos58.BackColor = Color.LimeGreen; } else { pb1Pos58.BackColor = Color.LightBlue; }
			if (playerOneGameboard[5, 9] != '0') { pb1Pos59.BackColor = Color.LimeGreen; } else { pb1Pos59.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 0] != '0') { pb1Pos60.BackColor = Color.LimeGreen; } else { pb1Pos60.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 1] != '0') { pb1Pos61.BackColor = Color.LimeGreen; } else { pb1Pos61.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 2] != '0') { pb1Pos62.BackColor = Color.LimeGreen; } else { pb1Pos62.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 3] != '0') { pb1Pos63.BackColor = Color.LimeGreen; } else { pb1Pos63.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 4] != '0') { pb1Pos64.BackColor = Color.LimeGreen; } else { pb1Pos64.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 5] != '0') { pb1Pos65.BackColor = Color.LimeGreen; } else { pb1Pos65.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 6] != '0') { pb1Pos66.BackColor = Color.LimeGreen; } else { pb1Pos66.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 7] != '0') { pb1Pos67.BackColor = Color.LimeGreen; } else { pb1Pos67.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 8] != '0') { pb1Pos68.BackColor = Color.LimeGreen; } else { pb1Pos68.BackColor = Color.LightBlue; }
			if (playerOneGameboard[6, 9] != '0') { pb1Pos69.BackColor = Color.LimeGreen; } else { pb1Pos69.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 0] != '0') { pb1Pos70.BackColor = Color.LimeGreen; } else { pb1Pos70.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 1] != '0') { pb1Pos71.BackColor = Color.LimeGreen; } else { pb1Pos71.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 2] != '0') { pb1Pos72.BackColor = Color.LimeGreen; } else { pb1Pos72.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 3] != '0') { pb1Pos73.BackColor = Color.LimeGreen; } else { pb1Pos73.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 4] != '0') { pb1Pos74.BackColor = Color.LimeGreen; } else { pb1Pos74.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 5] != '0') { pb1Pos75.BackColor = Color.LimeGreen; } else { pb1Pos75.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 6] != '0') { pb1Pos76.BackColor = Color.LimeGreen; } else { pb1Pos76.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 7] != '0') { pb1Pos77.BackColor = Color.LimeGreen; } else { pb1Pos77.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 8] != '0') { pb1Pos78.BackColor = Color.LimeGreen; } else { pb1Pos78.BackColor = Color.LightBlue; }
			if (playerOneGameboard[7, 9] != '0') { pb1Pos79.BackColor = Color.LimeGreen; } else { pb1Pos79.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 0] != '0') { pb1Pos80.BackColor = Color.LimeGreen; } else { pb1Pos80.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 1] != '0') { pb1Pos81.BackColor = Color.LimeGreen; } else { pb1Pos81.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 2] != '0') { pb1Pos82.BackColor = Color.LimeGreen; } else { pb1Pos82.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 3] != '0') { pb1Pos83.BackColor = Color.LimeGreen; } else { pb1Pos83.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 4] != '0') { pb1Pos84.BackColor = Color.LimeGreen; } else { pb1Pos84.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 5] != '0') { pb1Pos85.BackColor = Color.LimeGreen; } else { pb1Pos85.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 6] != '0') { pb1Pos86.BackColor = Color.LimeGreen; } else { pb1Pos86.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 7] != '0') { pb1Pos87.BackColor = Color.LimeGreen; } else { pb1Pos87.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 8] != '0') { pb1Pos88.BackColor = Color.LimeGreen; } else { pb1Pos88.BackColor = Color.LightBlue; }
			if (playerOneGameboard[8, 9] != '0') { pb1Pos89.BackColor = Color.LimeGreen; } else { pb1Pos89.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 0] != '0') { pb1Pos90.BackColor = Color.LimeGreen; } else { pb1Pos90.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 1] != '0') { pb1Pos91.BackColor = Color.LimeGreen; } else { pb1Pos91.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 2] != '0') { pb1Pos92.BackColor = Color.LimeGreen; } else { pb1Pos92.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 3] != '0') { pb1Pos93.BackColor = Color.LimeGreen; } else { pb1Pos93.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 4] != '0') { pb1Pos94.BackColor = Color.LimeGreen; } else { pb1Pos94.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 5] != '0') { pb1Pos95.BackColor = Color.LimeGreen; } else { pb1Pos95.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 6] != '0') { pb1Pos96.BackColor = Color.LimeGreen; } else { pb1Pos96.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 7] != '0') { pb1Pos97.BackColor = Color.LimeGreen; } else { pb1Pos97.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 8] != '0') { pb1Pos98.BackColor = Color.LimeGreen; } else { pb1Pos98.BackColor = Color.LightBlue; }
			if (playerOneGameboard[9, 9] != '0') { pb1Pos99.BackColor = Color.LimeGreen; } else { pb1Pos99.BackColor = Color.LightBlue; }
		}
		#endregion

		//Places ships on player one gameboard
		public static void ShipPlacerOne()
		{
			//Starting coords and placement for 5 length ship (Carrier)
			//Determine if ship is vertical or horisontal
			int horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				//Determine start coords
				int x = rnd.Next(0, 6);
				int y = rnd.Next(0, 10);
				for (int i = 0; i < 5; i++)
				{
					Battleship.playerOneGameboard[x, y] = 'C';
					x++;
				}
			}
			else 
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 6);
				for (int i = 0; i < 5; i++)
				{
					Battleship.playerOneGameboard[x, y] = 'C';
					y++;
				}
			}

			//Starting coords and placement for 4 length ship (Destroyer)
			PlaceDestroyer:
			bool destroyerClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 7);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 4; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceDestroyer;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'D';
						x++;
					}

				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 7);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 4; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceDestroyer;
						}
						yCheck++;
					}
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'D';
						y++;
					}
				}
			} while (destroyerClear == false);

			//Starting coords and placement for 3 length ship (Minesweeper)
			PlaceMinesweeper:
			bool minesweeperClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 8);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceMinesweeper;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'M';
						x++;
					}

				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 8);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceMinesweeper;
						}
						yCheck++;
					}
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'M';
						y++;
					}
				}
			} while (minesweeperClear == false);

			//Starting coords and placement for 3 length ship (Submarine)
			PlaceSubmarine:
			bool submarineClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 8);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceSubmarine;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'S';
						x++;
					}

				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 8);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceSubmarine;
						}
						yCheck++;
					}
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'S';
						y++;
					}
				}
			} while (submarineClear == false);

			//Starting coords and placement for 2 length ship (Torpedo Boat)
			PlaceTorpedoBoat:
			bool torpedoBoatClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 9);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 2; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceTorpedoBoat;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'T';
						x++;
					}

				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 9);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 2; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerOneGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceTorpedoBoat;
						}
						yCheck++;
					}
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerOneGameboard[x, y] = 'T';
						y++;
					}
				}
			} while (torpedoBoatClear == false);
		}

		//Places ships for player two/enemys gameboard
		public static void ShipPlacerTwo()
		{
			//Starting coords and placement for 5 length ship (Carrier)
			//Determine if ship is vertical or horisontal
			int horisontal = rnd.Next(0, 2);
			if (horisontal == 1)
			{
				//Determine start coords for horisontal ships
				int x = rnd.Next(0, 6);
				int y = rnd.Next(0, 10);
				for (int i = 0; i < 5; i++)
				{
					Battleship.playerTwoGameboard[x, y] = 'C';
					x++;
				}
			}
			else
			{
				//Determine start coords for vertical ships
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 6);
				for (int i = 0; i < 5; i++)
				{
					Battleship.playerTwoGameboard[x, y] = 'C';
					y++;
				}
			}
		
			//Starting coords and placement for 4 length ship (Destroyer)
			PlaceDestroyer:
			bool destroyerClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords for horisontal ships
					int x = rnd.Next(0, 7);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 4; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceDestroyer;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'D';
						x++;
					}
		
				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 7);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 4; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceDestroyer;
						}
						yCheck++;
					}
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'D';
						y++;
					}
				}
			} while (destroyerClear == false);
		
			//Starting coords and placement for 3 length ship (Minesweeper)
			PlaceMinesweeper:
			bool minesweeperClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 8);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceMinesweeper;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'M';
						x++;
					}
		
				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 8);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceMinesweeper;
						}
						yCheck++;
					}
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'M';
						y++;
					}
				}
			} while (minesweeperClear == false);
		
			//Starting coords and placement for 3 length ship (Submarine)
			PlaceSubmarine:
			bool submarineClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 8);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceSubmarine;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'S';
						x++;
					}
		
				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 8);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 3; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceSubmarine;
						}
						yCheck++;
					}
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'S';
						y++;
					}
				}
			} while (submarineClear == false);
		
			//Starting coords and placement for 2 length ship (Torpedo Boat)
			PlaceTorpedoBoat:
			bool torpedoBoatClear = false;
			do
			{
				//Determine if ship is vertical or horisontal
				horisontal = rnd.Next(0, 2);
				if (horisontal == 1)
				{
					//Determine start coords
					int x = rnd.Next(0, 9);
					int y = rnd.Next(0, 10);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 2; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceTorpedoBoat;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'T';
						x++;
					}
		
				}
				else
				{
					int x = rnd.Next(0, 10);
					int y = rnd.Next(0, 9);
					int xCheck = x;
					int yCheck = y;
					for (int i = 0; i < 2; i++)
					{
						//Check that all proposed positions are empty, if not, start over
						if (Battleship.playerTwoGameboard[xCheck, yCheck] != '0')
						{
							goto PlaceTorpedoBoat;
						}
						yCheck++;
					}
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerTwoGameboard[x, y] = 'T';
						y++;
					}
				}
			} while (torpedoBoatClear == false);
			
			
		}

	}
}
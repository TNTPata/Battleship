﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public class Startup
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
					Battleship.playerOneGameboard[i, j] = false;
					Battleship.playerTwoGameboard[i, j] = false;
				}
			}
		}

		//Marks locations of all ships on your own gameboard, by checking *every single button* manually...
		public static void ShipMarker()
		{
			Battleship bship = new Battleship();

			if (Battleship.playerOneGameboard[0, 0] == true) { bship.pb1Pos00.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 1] == true) { bship.pb1Pos01.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 2] == true) { bship.pb1Pos02.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 3] == true) { bship.pb1Pos03.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 4] == true) { bship.pb1Pos04.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 5] == true) { bship.pb1Pos05.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 6] == true) { bship.pb1Pos06.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 7] == true) { bship.pb1Pos07.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 8] == true) { bship.pb1Pos08.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[0, 9] == true) { bship.pb1Pos09.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 0] == true) { bship.pb1Pos10.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 1] == true) { bship.pb1Pos11.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 2] == true) { bship.pb1Pos12.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 3] == true) { bship.pb1Pos13.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 4] == true) { bship.pb1Pos14.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 5] == true) { bship.pb1Pos15.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 6] == true) { bship.pb1Pos16.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 7] == true) { bship.pb1Pos17.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 8] == true) { bship.pb1Pos18.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[1, 9] == true) { bship.pb1Pos19.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 0] == true) { bship.pb1Pos20.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 1] == true) { bship.pb1Pos21.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 2] == true) { bship.pb1Pos22.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 3] == true) { bship.pb1Pos23.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 4] == true) { bship.pb1Pos24.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 5] == true) { bship.pb1Pos25.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 6] == true) { bship.pb1Pos26.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 7] == true) { bship.pb1Pos27.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 8] == true) { bship.pb1Pos28.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[2, 9] == true) { bship.pb1Pos29.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 0] == true) { bship.pb1Pos30.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 1] == true) { bship.pb1Pos31.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 2] == true) { bship.pb1Pos32.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 3] == true) { bship.pb1Pos33.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 4] == true) { bship.pb1Pos34.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 5] == true) { bship.pb1Pos35.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 6] == true) { bship.pb1Pos36.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 7] == true) { bship.pb1Pos37.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 8] == true) { bship.pb1Pos38.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[3, 9] == true) { bship.pb1Pos39.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 0] == true) { bship.pb1Pos40.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 1] == true) { bship.pb1Pos41.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 2] == true) { bship.pb1Pos42.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 3] == true) { bship.pb1Pos43.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 4] == true) { bship.pb1Pos44.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 5] == true) { bship.pb1Pos45.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 6] == true) { bship.pb1Pos46.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 7] == true) { bship.pb1Pos47.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 8] == true) { bship.pb1Pos48.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[4, 9] == true) { bship.pb1Pos49.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 0] == true) { bship.pb1Pos50.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 1] == true) { bship.pb1Pos51.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 2] == true) { bship.pb1Pos52.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 3] == true) { bship.pb1Pos53.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 4] == true) { bship.pb1Pos54.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 5] == true) { bship.pb1Pos55.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 6] == true) { bship.pb1Pos56.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 7] == true) { bship.pb1Pos57.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 8] == true) { bship.pb1Pos58.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[5, 9] == true) { bship.pb1Pos59.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 0] == true) { bship.pb1Pos60.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 1] == true) { bship.pb1Pos61.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 2] == true) { bship.pb1Pos62.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 3] == true) { bship.pb1Pos63.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 4] == true) { bship.pb1Pos64.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 5] == true) { bship.pb1Pos65.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 6] == true) { bship.pb1Pos66.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 7] == true) { bship.pb1Pos67.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 8] == true) { bship.pb1Pos68.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[6, 9] == true) { bship.pb1Pos69.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 0] == true) { bship.pb1Pos70.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 1] == true) { bship.pb1Pos71.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 2] == true) { bship.pb1Pos72.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 3] == true) { bship.pb1Pos73.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 4] == true) { bship.pb1Pos74.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 5] == true) { bship.pb1Pos75.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 6] == true) { bship.pb1Pos76.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 7] == true) { bship.pb1Pos77.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 8] == true) { bship.pb1Pos78.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[7, 9] == true) { bship.pb1Pos79.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 0] == true) { bship.pb1Pos80.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 1] == true) { bship.pb1Pos81.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 2] == true) { bship.pb1Pos82.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 3] == true) { bship.pb1Pos83.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 4] == true) { bship.pb1Pos84.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 5] == true) { bship.pb1Pos85.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 6] == true) { bship.pb1Pos86.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 7] == true) { bship.pb1Pos87.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 8] == true) { bship.pb1Pos88.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[8, 9] == true) { bship.pb1Pos89.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 0] == true) { bship.pb1Pos90.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 1] == true) { bship.pb1Pos91.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 2] == true) { bship.pb1Pos92.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 3] == true) { bship.pb1Pos93.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 4] == true) { bship.pb1Pos94.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 5] == true) { bship.pb1Pos95.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 6] == true) { bship.pb1Pos96.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 7] == true) { bship.pb1Pos97.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 8] == true) { bship.pb1Pos98.BackColor = Color.LimeGreen; }
			if (Battleship.playerOneGameboard[9, 9] == true) { bship.pb1Pos99.BackColor = Color.LimeGreen; }
			bship.Invalidate();
		}

		//Places ships on your gameboard
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
					Battleship.playerOneGameboard[x, y] = true;
					x++;
				}
			}
			else 
			{
				int x = rnd.Next(0, 10);
				int y = rnd.Next(0, 6);
				for (int i = 0; i < 5; i++)
				{
					Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceDestroyer;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceDestroyer;
						}
						yCheck++;
					}
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceMinesweeper;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceMinesweeper;
						}
						yCheck++;
					}
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceSubmarine;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceSubmarine;
						}
						yCheck++;
					}
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceTorpedoBoat;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
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
						if (Battleship.playerOneGameboard[xCheck, yCheck] == true)
						{
							goto PlaceTorpedoBoat;
						}
						yCheck++;
					}
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerOneGameboard[x, y] = true;
						y++;
					}
				}
			} while (torpedoBoatClear == false);
		}

		//Places ships for enemys gameboard
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
					Battleship.playerTwoGameboard[x, y] = true;
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
					Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceDestroyer;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					destroyerClear = true;
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceDestroyer;
						}
						yCheck++;
					}
					for (int i = 0; i < 4; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceMinesweeper;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					minesweeperClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceMinesweeper;
						}
						yCheck++;
					}
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceSubmarine;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					submarineClear = true;
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceSubmarine;
						}
						yCheck++;
					}
					for (int i = 0; i < 3; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceTorpedoBoat;
						}
						xCheck++;
					}
					//All positions clear, set those positions to true
					torpedoBoatClear = true;
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
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
						if (Battleship.playerTwoGameboard[xCheck, yCheck] == true)
						{
							goto PlaceTorpedoBoat;
						}
						yCheck++;
					}
					for (int i = 0; i < 2; i++)
					{
						Battleship.playerTwoGameboard[x, y] = true;
						y++;
					}
				}
			} while (torpedoBoatClear == false);
			
			
		}

	}
}
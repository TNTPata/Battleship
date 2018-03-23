using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public class Methods
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

		public static void ShipMarker()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (Battleship.playerOneGameboard[i, j] == true)
					{
						//TD: If there is a ship in a position, change its coresponding button to Lime
					}
				}
			}
		}

		//Detects hits or misses
		public static void HitDetectorGameboardTwo (int x,int y)
		{
			if (Battleship.playerTwoGameboard[x, y] == true)
			{
				//Hit
				Battleship.playerTwoGameboard[x, y] = false;
				
				//TD: Set button color to orange/yellow
			}
			else
			{
				//Miss
				//TD: Set button color to blue(?)
			}
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
				//Determine start coords
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
					//Determine start coords
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
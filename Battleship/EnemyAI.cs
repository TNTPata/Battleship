using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	partial class Battleship
	{
		//List that stores tiles that have already been fired at
		List<int> alreadyFiredAt = new List<int>();

		//Temporarilly stores position of initial hit
		int tempInitialHit = -1;

		//Stores position of initial hit, -1 is default
		int initialHit = -1;

		//Stores position of last fired at tile
		int previouslyFiredAt = -1;

		//Stores next tile to fire at for smartEnemyFire (that is located around the initialHit-tile) (1-4)
		int searchDirection = 1;

		//Store coords for next tile to fire at
		int nextTileToFireAt = -1;

		//Determines if a new initialHit should be made
		bool newInitialHit = true;

		//Method that enemy uses for firing at player
		public void randomEnemyFire()
		{
			//Select random tile to fire at
			int positionToHit = rnd.Next(0, 101);

			//If proposed hit tile has already been fired at, generate a new hit tile, else break loop
			do
			{
				if (alreadyFiredAt.Contains(positionToHit))
				{
					alreadyFiredAt.Add(positionToHit);
					positionToHit = rnd.Next(0, 101);
				}
				else
				{
					alreadyFiredAt.Add(positionToHit);
					previouslyFiredAt = positionToHit;
					break;
				}

			} while (true);
			
			//Fires at the given tile
			//Checks if the tile is not empty
			//Sets gameboard to '0' and sets button to red if tile is not empty
			//If this switch is closed/hidden, do NOT open
			switch (positionToHit)
			{
				case 1:
					{
						if (playerOneGameboard[0,0] != '0')
						{
							playerOneGameboard[0, 0] = '0';
							pb1Pos00.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos00.BackColor = Color.White;
							break;
						}
					}
				case 2:
					{
						if (playerOneGameboard[0, 1] != '0')
						{
							playerOneGameboard[0, 1] = '0';
							pb1Pos01.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos01.BackColor = Color.White;
							break;
						}
					}
				case 3:
					{
						if (playerOneGameboard[0, 2] != '0')
						{
							playerOneGameboard[0, 2] = '0';
							pb1Pos02.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos02.BackColor = Color.White;
							break;
						}
					}
				case 4:
					{
						if (playerOneGameboard[0, 3] != '0')
						{
							playerOneGameboard[0, 3] = '0';
							pb1Pos03.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos03.BackColor = Color.White;
							break;
						}
					}
				case 5:
					{
						if (playerOneGameboard[0, 4] != '0')
						{
							playerOneGameboard[0, 4] = '0';
							pb1Pos04.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos04.BackColor = Color.White;
							break;
						}
					}
				case 6:
					{
						if (playerOneGameboard[0, 5] != '0')
						{
							playerOneGameboard[0, 5] = '0';
							pb1Pos05.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos05.BackColor = Color.White;
							break;
						}
					}
				case 7:
					{
						if (playerOneGameboard[0, 6] != '0')
						{
							playerOneGameboard[0, 6] = '0';
							pb1Pos06.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos06.BackColor = Color.White;
							break;
						}
					}
				case 8:
					{
						if (playerOneGameboard[0, 7] != '0')
						{
							playerOneGameboard[0, 7] = '0';
							pb1Pos07.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos07.BackColor = Color.White;
							break;
						}
					}
				case 9:
					{
						if (playerOneGameboard[0, 8] != '0')
						{
							playerOneGameboard[0, 8] = '0';
							pb1Pos08.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos08.BackColor = Color.White;
							break;
						}
					}
				case 10:
					{
						if (playerOneGameboard[0, 9] != '0')
						{
							playerOneGameboard[0, 9] = '0';
							pb1Pos09.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos09.BackColor = Color.White;
							break;
						}
					}
				case 11:
					{
						if (playerOneGameboard[1, 0] != '0')
						{
							playerOneGameboard[1, 0] = '0';
							pb1Pos10.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos10.BackColor = Color.White;
							break;
						}
					}
				case 12:
					{
						if (playerOneGameboard[1, 1] != '0')
						{
							playerOneGameboard[1, 1] = '0';
							pb1Pos11.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos11.BackColor = Color.White;
							break;
						}
					}
				case 13:
					{
						if (playerOneGameboard[1, 2] != '0')
						{
							playerOneGameboard[1, 2] = '0';
							pb1Pos12.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos12.BackColor = Color.White;
							break;
						}
					}
				case 14:
					{
						if (playerOneGameboard[1, 3] != '0')
						{
							playerOneGameboard[1, 3] = '0';
							pb1Pos13.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos13.BackColor = Color.White;
							break;
						}
					}
				case 15:
					{
						if (playerOneGameboard[1, 4] != '0')
						{
							playerOneGameboard[1, 4] = '0';
							pb1Pos14.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos14.BackColor = Color.White;
							break;
						}
					}
				case 16:
					{
						if (playerOneGameboard[1, 5] != '0')
						{
							playerOneGameboard[1, 5] = '0';
							pb1Pos15.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos15.BackColor = Color.White;
							break;
						}
					}
				case 17:
					{
						if (playerOneGameboard[1, 6] != '0')
						{
							playerOneGameboard[1, 6] = '0';
							pb1Pos16.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos16.BackColor = Color.White;
							break;
						}
					}
				case 18:
					{
						if (playerOneGameboard[1, 7] != '0')
						{
							playerOneGameboard[1, 7] = '0';
							pb1Pos17.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos17.BackColor = Color.White;
							break;
						}
					}
				case 19:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos18.BackColor = Color.White;
							break;
						}
					}
				case 20:
					{
						if (playerOneGameboard[1, 9] != '0')
						{
							playerOneGameboard[1, 9] = '0';
							pb1Pos19.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos19.BackColor = Color.White;
							break;
						}
					}
				case 21:
					{
						if (playerOneGameboard[2, 0] != '0')
						{
							playerOneGameboard[2, 0] = '0';
							pb1Pos20.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos20.BackColor = Color.White;
							break;
						}
					}
				case 22:
					{
						if (playerOneGameboard[2, 1] != '0')
						{
							playerOneGameboard[2, 1] = '0';
							pb1Pos21.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos21.BackColor = Color.White;
							break;
						}
					}
				case 23:
					{
						if (playerOneGameboard[2, 2] != '0')
						{
							playerOneGameboard[2, 2] = '0';
							pb1Pos22.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos22.BackColor = Color.White;
							break;
						}
					}
				case 24:
					{
						if (playerOneGameboard[2, 3] != '0')
						{
							playerOneGameboard[2, 3] = '0';
							pb1Pos23.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos23.BackColor = Color.White;
							break;
						}
					}
				case 25:
					{
						if (playerOneGameboard[2, 4] != '0')
						{
							playerOneGameboard[2, 4] = '0';
							pb1Pos24.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos24.BackColor = Color.White;
							break;
						}
					}
				case 26:
					{
						if (playerOneGameboard[2, 5] != '0')
						{
							playerOneGameboard[2, 5] = '0';
							pb1Pos25.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos25.BackColor = Color.White;
							break;
						}
					}
				case 27:
					{
						if (playerOneGameboard[2, 6] != '0')
						{
							playerOneGameboard[2, 6] = '0';
							pb1Pos26.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos26.BackColor = Color.White;
							break;
						}
					}
				case 28:
					{
						if (playerOneGameboard[2, 7] != '0')
						{
							playerOneGameboard[2, 7] = '0';
							pb1Pos27.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos27.BackColor = Color.White;
							break;
						}
					}
				case 29:
					{
						if (playerOneGameboard[2, 8] != '0')
						{
							playerOneGameboard[2, 8] = '0';
							pb1Pos28.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos28.BackColor = Color.White;
							break;
						}
					}
				case 30:
					{
						if (playerOneGameboard[2, 9] != '0')
						{
							playerOneGameboard[2, 9] = '0';
							pb1Pos29.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos29.BackColor = Color.White;
							break;
						}
					}
				case 31:
					{
						if (playerOneGameboard[3, 0] != '0')
						{
							playerOneGameboard[3, 0] = '0';
							pb1Pos30.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos30.BackColor = Color.White;
							break;
						}
					}
				case 32:
					{
						if (playerOneGameboard[3, 1] != '0')
						{
							playerOneGameboard[3, 1] = '0';
							pb1Pos31.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos31.BackColor = Color.White;
							break;
						}
					}
				case 33:
					{
						if (playerOneGameboard[3, 2] != '0')
						{
							playerOneGameboard[3, 2] = '0';
							pb1Pos32.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos32.BackColor = Color.White;
							break;
						}
					}
				case 34:
					{
						if (playerOneGameboard[3, 3] != '0')
						{
							playerOneGameboard[3, 3] = '0';
							pb1Pos33.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos33.BackColor = Color.White;
							break;
						}
					}
				case 35:
					{
						if (playerOneGameboard[3, 4] != '0')
						{
							playerOneGameboard[3, 4] = '0';
							pb1Pos34.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos34.BackColor = Color.White;
							break;
						}
					}
				case 36:
					{
						if (playerOneGameboard[3, 5] != '0')
						{
							playerOneGameboard[3, 5] = '0';
							pb1Pos35.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos35.BackColor = Color.White;
							break;
						}
					}
				case 37:
					{
						if (playerOneGameboard[3, 6] != '0')
						{
							playerOneGameboard[3, 6] = '0';
							pb1Pos36.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos36.BackColor = Color.White;
							break;
						}
					}
				case 38:
					{
						if (playerOneGameboard[3, 7] != '0')
						{
							playerOneGameboard[3, 7] = '0';
							pb1Pos37.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos37.BackColor = Color.White;
							break;
						}
					}
				case 39:
					{
						if (playerOneGameboard[3, 8] != '0')
						{
							playerOneGameboard[3, 8] = '0';
							pb1Pos38.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos38.BackColor = Color.White;
							break;
						}
					}
				case 40:
					{
						if (playerOneGameboard[3, 9] != '0')
						{
							playerOneGameboard[3, 9] = '0';
							pb1Pos39.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos39.BackColor = Color.White;
							break;
						}
					}
				case 41:
					{
						if (playerOneGameboard[4, 0] != '0')
						{
							playerOneGameboard[4, 0] = '0';
							pb1Pos40.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos40.BackColor = Color.White;
							break;
						}
					}
				case 42:
					{
						if (playerOneGameboard[4, 1] != '0')
						{
							playerOneGameboard[4, 1] = '0';
							pb1Pos41.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos41.BackColor = Color.White;
							break;
						}
					}
				case 43:
					{
						if (playerOneGameboard[4, 2] != '0')
						{
							playerOneGameboard[4, 2] = '0';
							pb1Pos42.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos42.BackColor = Color.White;
							break;
						}
					}
				case 44:
					{
						if (playerOneGameboard[4, 3] != '0')
						{
							playerOneGameboard[4, 3] = '0';
							pb1Pos43.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos43.BackColor = Color.White;
							break;
						}
					}
				case 45:
					{
						if (playerOneGameboard[4, 4] != '0')
						{
							playerOneGameboard[4, 4] = '0';
							pb1Pos44.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos44.BackColor = Color.White;
							break;
						}
					}
				case 46:
					{
						if (playerOneGameboard[4, 5] != '0')
						{
							playerOneGameboard[4, 5] = '0';
							pb1Pos45.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos45.BackColor = Color.White;
							break;
						}
					}
				case 47:
					{
						if (playerOneGameboard[4, 6] != '0')
						{
							playerOneGameboard[4, 6] = '0';
							pb1Pos46.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos46.BackColor = Color.White;
							break;
						}
					}
				case 48:
					{
						if (playerOneGameboard[4, 7] != '0')
						{
							playerOneGameboard[4, 7] = '0';
							pb1Pos47.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos47.BackColor = Color.White;
							break;
						}
					}
				case 49:
					{
						if (playerOneGameboard[4, 8] != '0')
						{
							playerOneGameboard[4, 8] = '0';
							pb1Pos48.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos48.BackColor = Color.White;
							break;
						}
					}
				case 50:
					{
						if (playerOneGameboard[4, 9] != '0')
						{
							playerOneGameboard[4, 9] = '0';
							pb1Pos49.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos49.BackColor = Color.White;
							break;
						}
					}
				case 51:
					{
						if (playerOneGameboard[5, 0] != '0')
						{
							playerOneGameboard[5, 0] = '0';
							pb1Pos50.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos50.BackColor = Color.White;
							break;
						}
					}
				case 52:
					{
						if (playerOneGameboard[5, 1] != '0')
						{
							playerOneGameboard[5, 1] = '0';
							pb1Pos51.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos51.BackColor = Color.White;
							break;
						}
					}
				case 53:
					{
						if (playerOneGameboard[5, 2] != '0')
						{
							playerOneGameboard[5, 2] = '0';
							pb1Pos52.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos52.BackColor = Color.White;
							break;
						}
					}
				case 54:
					{
						if (playerOneGameboard[5, 3] != '0')
						{
							playerOneGameboard[5, 3] = '0';
							pb1Pos53.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos53.BackColor = Color.White;
							break;
						}
					}
				case 55:
					{
						if (playerOneGameboard[5, 4] != '0')
						{
							playerOneGameboard[5, 4] = '0';
							pb1Pos54.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos54.BackColor = Color.White;
							break;
						}
					}
				case 56:
					{
						if (playerOneGameboard[5, 5] != '0')
						{
							playerOneGameboard[5, 5] = '0';
							pb1Pos55.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos55.BackColor = Color.White;
							break;
						}
					}
				case 57:
					{
						if (playerOneGameboard[5, 6] != '0')
						{
							playerOneGameboard[5, 6] = '0';
							pb1Pos56.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos56.BackColor = Color.White;
							break;
						}
					}
				case 58:
					{
						if (playerOneGameboard[5, 7] != '0')
						{
							playerOneGameboard[5, 7] = '0';
							pb1Pos57.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos57.BackColor = Color.White;
							break;
						}
					}
				case 59:
					{
						if (playerOneGameboard[5, 8] != '0')
						{
							playerOneGameboard[5, 8] = '0';
							pb1Pos58.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos58.BackColor = Color.White;
							break;
						}
					}
				case 60:
					{
						if (playerOneGameboard[5, 9] != '0')
						{
							playerOneGameboard[5, 9] = '0';
							pb1Pos59.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos59.BackColor = Color.White;
							break;
						}
					}
				case 61:
					{
						if (playerOneGameboard[6, 0] != '0')
						{
							playerOneGameboard[6, 0] = '0';
							pb1Pos60.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos60.BackColor = Color.White;
							break;
						}
					}
				case 62:
					{
						if (playerOneGameboard[6, 1] != '0')
						{
							playerOneGameboard[6, 1] = '0';
							pb1Pos61.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos61.BackColor = Color.White;
							break;
						}
					}
				case 63:
					{
						if (playerOneGameboard[6, 2] != '0')
						{
							playerOneGameboard[6, 2] = '0';
							pb1Pos62.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos62.BackColor = Color.White;
							break;
						}
					}
				case 64:
					{
						if (playerOneGameboard[6, 3] != '0')
						{
							playerOneGameboard[6, 3] = '0';
							pb1Pos63.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos63.BackColor = Color.White;
							break;
						}
					}
				case 65:
					{
						if (playerOneGameboard[6, 4] != '0')
						{
							playerOneGameboard[6, 4] = '0';
							pb1Pos64.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos64.BackColor = Color.White;
							break;
						}
					}
				case 66:
					{
						if (playerOneGameboard[6, 5] != '0')
						{
							playerOneGameboard[6, 5] = '0';
							pb1Pos65.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos65.BackColor = Color.White;
							break;
						}
					}
				case 67:
					{
						if (playerOneGameboard[6, 6] != '0')
						{
							playerOneGameboard[6, 6] = '0';
							pb1Pos66.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos66.BackColor = Color.White;
							break;
						}
					}
				case 68:
					{
						if (playerOneGameboard[6, 7] != '0')
						{
							playerOneGameboard[6, 7] = '0';
							pb1Pos67.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos67.BackColor = Color.White;
							break;
						}
					}
				case 69:
					{
						if (playerOneGameboard[6, 8] != '0')
						{
							playerOneGameboard[6, 8] = '0';
							pb1Pos68.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos68.BackColor = Color.White;
							break;
						}
					}
				case 70:
					{
						if (playerOneGameboard[6, 9] != '0')
						{
							playerOneGameboard[6, 9] = '0';
							pb1Pos69.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos69.BackColor = Color.White;
							break;
						}
					}
				case 71:
					{
						if (playerOneGameboard[7, 0] != '0')
						{
							playerOneGameboard[7, 0] = '0';
							pb1Pos70.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos70.BackColor = Color.White;
							break;
						}
					}
				case 72:
					{
						if (playerOneGameboard[7, 1] != '0')
						{
							playerOneGameboard[7, 1] = '0';
							pb1Pos71.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos71.BackColor = Color.White;
							break;
						}
					}
				case 73:
					{
						if (playerOneGameboard[7, 2] != '0')
						{
							playerOneGameboard[7, 2] = '0';
							pb1Pos72.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos72.BackColor = Color.White;
							break;
						}
					}
				case 74:
					{
						if (playerOneGameboard[7, 3] != '0')
						{
							playerOneGameboard[7, 3] = '0';
							pb1Pos73.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos73.BackColor = Color.White;
							break;
						}
					}
				case 75:
					{
						if (playerOneGameboard[7, 4] != '0')
						{
							playerOneGameboard[7, 4] = '0';
							pb1Pos74.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos74.BackColor = Color.White;
							break;
						}
					}
				case 76:
					{
						if (playerOneGameboard[7, 5] != '0')
						{
							playerOneGameboard[7, 5] = '0';
							pb1Pos75.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos75.BackColor = Color.White;
							break;
						}
					}
				case 77:
					{
						if (playerOneGameboard[7, 6] != '0')
						{
							playerOneGameboard[7, 6] = '0';
							pb1Pos76.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos76.BackColor = Color.White;
							break;
						}
					}
				case 78:
					{
						if (playerOneGameboard[7, 7] != '0')
						{
							playerOneGameboard[7, 7] = '0';
							pb1Pos77.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos77.BackColor = Color.White;
							break;
						}
					}
				case 79:
					{
						if (playerOneGameboard[7, 8] != '0')
						{
							playerOneGameboard[7, 8] = '0';
							pb1Pos78.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos78.BackColor = Color.White;
							break;
						}
					}
				case 80:
					{
						if (playerOneGameboard[7, 9] != '0')
						{
							playerOneGameboard[7, 9] = '0';
							pb1Pos79.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos79.BackColor = Color.White;
							break;
						}
					}
				case 81:
					{
						if (playerOneGameboard[8, 0] != '0')
						{
							playerOneGameboard[8, 0] = '0';
							pb1Pos80.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos80.BackColor = Color.White;
							break;
						}
					}
				case 82:
					{
						if (playerOneGameboard[8, 1] != '0')
						{
							playerOneGameboard[8, 1] = '0';
							pb1Pos81.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos81.BackColor = Color.White;
							break;
						}
					}
				case 83:
					{
						if (playerOneGameboard[8, 2] != '0')
						{
							playerOneGameboard[8, 2] = '0';
							pb1Pos82.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos82.BackColor = Color.White;
							break;
						}
					}
				case 84:
					{
						if (playerOneGameboard[8, 3] != '0')
						{
							playerOneGameboard[8, 3] = '0';
							pb1Pos83.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos83.BackColor = Color.White;
							break;
						}
					}
				case 85:
					{
						if (playerOneGameboard[8, 4] != '0')
						{
							playerOneGameboard[8, 4] = '0';
							pb1Pos84.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos84.BackColor = Color.White;
							break;
						}
					}
				case 86:
					{
						if (playerOneGameboard[8, 5] != '0')
						{
							playerOneGameboard[8, 5] = '0';
							pb1Pos85.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos85.BackColor = Color.White;
							break;
						}
					}
				case 87:
					{
						if (playerOneGameboard[8, 6] != '0')
						{
							playerOneGameboard[8, 6] = '0';
							pb1Pos86.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos86.BackColor = Color.White;
							break;
						}
					}
				case 88:
					{
						if (playerOneGameboard[8, 7] != '0')
						{
							playerOneGameboard[8, 7] = '0';
							pb1Pos87.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos87.BackColor = Color.White;
							break;
						}
					}
				case 89:
					{
						if (playerOneGameboard[8, 8] != '0')
						{
							playerOneGameboard[8, 8] = '0';
							pb1Pos88.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos88.BackColor = Color.White;
							break;
						}
					}
				case 90:
					{
						if (playerOneGameboard[8, 9] != '0')
						{
							playerOneGameboard[8, 9] = '0';
							pb1Pos89.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos89.BackColor = Color.White;
							break;
						}
					}
				case 91:
					{
						if (playerOneGameboard[9, 0] != '0')
						{
							playerOneGameboard[9, 0] = '0';
							pb1Pos90.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos90.BackColor = Color.White;
							break;
						}
					}
				case 92:
					{
						if (playerOneGameboard[9, 1] != '0')
						{
							playerOneGameboard[9, 1] = '0';
							pb1Pos91.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos91.BackColor = Color.White;
							break;
						}
					}
				case 93:
					{
						if (playerOneGameboard[9, 2] != '0')
						{
							playerOneGameboard[9, 2] = '0';
							pb1Pos92.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos92.BackColor = Color.White;
							break;
						}
					}
				case 94:
					{
						if (playerOneGameboard[9, 3] != '0')
						{
							playerOneGameboard[9, 3] = '0';
							pb1Pos93.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos93.BackColor = Color.White;
							break;
						}
					}
				case 95:
					{
						if (playerOneGameboard[9, 4] != '0')
						{
							playerOneGameboard[9, 4] = '0';
							pb1Pos94.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos94.BackColor = Color.White;
							break;
						}
					}
				case 96:
					{
						if (playerOneGameboard[9, 5] != '0')
						{
							playerOneGameboard[9, 5] = '0';
							pb1Pos95.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos95.BackColor = Color.White;
							break;
						}
					}
				case 97:
					{
						if (playerOneGameboard[9, 6] != '0')
						{
							playerOneGameboard[9, 6] = '0';
							pb1Pos96.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos96.BackColor = Color.White;
							break;
						}
					}
				case 98:
					{
						if (playerOneGameboard[9, 7] != '0')
						{
							playerOneGameboard[9, 7] = '0';
							pb1Pos97.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos97.BackColor = Color.White;
							break;
						}
					}
				case 99:
					{
						if (playerOneGameboard[9, 8] != '0')
						{
							playerOneGameboard[9, 8] = '0';
							pb1Pos98.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos98.BackColor = Color.White;
							break;
						}
					}
				case 100:
					{
						if (playerOneGameboard[9, 9] != '0')
						{
							playerOneGameboard[9, 9] = '0';
							pb1Pos99.BackColor = Color.Red;
							tempInitialHit = positionToHit;
							break;
						}
						else
						{
							pb1Pos99.BackColor = Color.White;
							break;
						}
					}
				default:
					{
						break;
					}
					//Förlåt för denna programmeringssynd.
			}
		}

		//Method that fires at specified tile
		//Returns 0 if could not fire or miss, returns 1 if hit
		public int controlledEnemyFire(int coords)
		{
			//Add one (1) to compensate for bad switch structure
			coords = coords++;

			//Return 0 if coords are out of range
			if ((coords < 0) && (coords > 100))
			{
				return 0;
			}

			//If proposed hit tile has already been fired at, generate a new hit tile, else break loop
			do
			{
				if (alreadyFiredAt.Contains(coords))
				{
					//Tile has already been fired at
					return 0;
				}
				else
				{
					//Save coords as previously fired at and add to alreadyFiredAt list
					alreadyFiredAt.Add(coords);
					previouslyFiredAt = coords;
					break;
				}

			} while (true);

			//Fires at the given tile
			//Checks if the tile is not empty
			//Sets gameboard to '0' and sets button to red if tile is not empty
			//If this switch is closed/hidden, do NOT open
			switch (coords)
			{
				case 1:
					{
						if (playerOneGameboard[0, 0] != '0')
						{
							playerOneGameboard[0, 0] = '0';
							pb1Pos00.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos00.BackColor = Color.White;
							return 0;
						}
					}
				case 2:
					{
						if (playerOneGameboard[0, 1] != '0')
						{
							playerOneGameboard[0, 1] = '0';
							pb1Pos01.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos01.BackColor = Color.White;
							return 0;
						}
					}
				case 3:
					{
						if (playerOneGameboard[0, 2] != '0')
						{
							playerOneGameboard[0, 2] = '0';
							pb1Pos02.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos02.BackColor = Color.White;
							return 0;
						}
					}
				case 4:
					{
						if (playerOneGameboard[0, 3] != '0')
						{
							playerOneGameboard[0, 3] = '0';
							pb1Pos03.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos03.BackColor = Color.White;
							return 0;
						}
					}
				case 5:
					{
						if (playerOneGameboard[0, 4] != '0')
						{
							playerOneGameboard[0, 4] = '0';
							pb1Pos04.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos04.BackColor = Color.White;
							return 0;
						}
					}
				case 6:
					{
						if (playerOneGameboard[0, 5] != '0')
						{
							playerOneGameboard[0, 5] = '0';
							pb1Pos05.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos05.BackColor = Color.White;
							return 0;
						}
					}
				case 7:
					{
						if (playerOneGameboard[0, 6] != '0')
						{
							playerOneGameboard[0, 6] = '0';
							pb1Pos06.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos06.BackColor = Color.White;
							return 0;
						}
					}
				case 8:
					{
						if (playerOneGameboard[0, 7] != '0')
						{
							playerOneGameboard[0, 7] = '0';
							pb1Pos07.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos07.BackColor = Color.White;
							return 0;
						}
					}
				case 9:
					{
						if (playerOneGameboard[0, 8] != '0')
						{
							playerOneGameboard[0, 8] = '0';
							pb1Pos08.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos08.BackColor = Color.White;
							return 0;
						}
					}
				case 10:
					{
						if (playerOneGameboard[0, 9] != '0')
						{
							playerOneGameboard[0, 9] = '0';
							pb1Pos09.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos09.BackColor = Color.White;
							return 0;
						}
					}
				case 11:
					{
						if (playerOneGameboard[1, 0] != '0')
						{
							playerOneGameboard[1, 0] = '0';
							pb1Pos10.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos10.BackColor = Color.White;
							return 0;
						}
					}
				case 12:
					{
						if (playerOneGameboard[1, 1] != '0')
						{
							playerOneGameboard[1, 1] = '0';
							pb1Pos11.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos11.BackColor = Color.White;
							return 0;
						}
					}
				case 13:
					{
						if (playerOneGameboard[1, 2] != '0')
						{
							playerOneGameboard[1, 2] = '0';
							pb1Pos12.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos12.BackColor = Color.White;
							return 0;
						}
					}
				case 14:
					{
						if (playerOneGameboard[1, 3] != '0')
						{
							playerOneGameboard[1, 3] = '0';
							pb1Pos13.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos13.BackColor = Color.White;
							return 0;
						}
					}
				case 15:
					{
						if (playerOneGameboard[1, 4] != '0')
						{
							playerOneGameboard[1, 4] = '0';
							pb1Pos14.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos14.BackColor = Color.White;
							return 0;
						}
					}
				case 16:
					{
						if (playerOneGameboard[1, 5] != '0')
						{
							playerOneGameboard[1, 5] = '0';
							pb1Pos15.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos15.BackColor = Color.White;
							return 0;
						}
					}
				case 17:
					{
						if (playerOneGameboard[1, 6] != '0')
						{
							playerOneGameboard[1, 6] = '0';
							pb1Pos16.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos16.BackColor = Color.White;
							return 0;
						}
					}
				case 18:
					{
						if (playerOneGameboard[1, 7] != '0')
						{
							playerOneGameboard[1, 7] = '0';
							pb1Pos17.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos17.BackColor = Color.White;
							return 0;
						}
					}
				case 19:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos18.BackColor = Color.White;
							return 0;
						}
					}
				case 20:
					{
						if (playerOneGameboard[1, 9] != '0')
						{
							playerOneGameboard[1, 9] = '0';
							pb1Pos19.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos19.BackColor = Color.White;
							return 0;
						}
					}
				case 21:
					{
						if (playerOneGameboard[2, 0] != '0')
						{
							playerOneGameboard[2, 0] = '0';
							pb1Pos20.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos20.BackColor = Color.White;
							return 0;
						}
					}
				case 22:
					{
						if (playerOneGameboard[2, 1] != '0')
						{
							playerOneGameboard[2, 1] = '0';
							pb1Pos21.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos21.BackColor = Color.White;
							return 0;
						}
					}
				case 23:
					{
						if (playerOneGameboard[2, 2] != '0')
						{
							playerOneGameboard[2, 2] = '0';
							pb1Pos22.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos22.BackColor = Color.White;
							return 0;
						}
					}
				case 24:
					{
						if (playerOneGameboard[2, 3] != '0')
						{
							playerOneGameboard[2, 3] = '0';
							pb1Pos23.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos23.BackColor = Color.White;
							return 0;
						}
					}
				case 25:
					{
						if (playerOneGameboard[2, 4] != '0')
						{
							playerOneGameboard[2, 4] = '0';
							pb1Pos24.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos24.BackColor = Color.White;
							return 0;
						}
					}
				case 26:
					{
						if (playerOneGameboard[2, 5] != '0')
						{
							playerOneGameboard[2, 5] = '0';
							pb1Pos25.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos25.BackColor = Color.White;
							return 0;
						}
					}
				case 27:
					{
						if (playerOneGameboard[2, 6] != '0')
						{
							playerOneGameboard[2, 6] = '0';
							pb1Pos26.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos26.BackColor = Color.White;
							return 0;
						}
					}
				case 28:
					{
						if (playerOneGameboard[2, 7] != '0')
						{
							playerOneGameboard[2, 7] = '0';
							pb1Pos27.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos27.BackColor = Color.White;
							return 0;
						}
					}
				case 29:
					{
						if (playerOneGameboard[2, 8] != '0')
						{
							playerOneGameboard[2, 8] = '0';
							pb1Pos28.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos28.BackColor = Color.White;
							return 0;
						}
					}
				case 30:
					{
						if (playerOneGameboard[2, 9] != '0')
						{
							playerOneGameboard[2, 9] = '0';
							pb1Pos29.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos29.BackColor = Color.White;
							return 0;
						}
					}
				case 31:
					{
						if (playerOneGameboard[3, 0] != '0')
						{
							playerOneGameboard[3, 0] = '0';
							pb1Pos30.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos30.BackColor = Color.White;
							return 0;
						}
					}
				case 32:
					{
						if (playerOneGameboard[3, 1] != '0')
						{
							playerOneGameboard[3, 1] = '0';
							pb1Pos31.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos31.BackColor = Color.White;
							return 0;
						}
					}
				case 33:
					{
						if (playerOneGameboard[3, 2] != '0')
						{
							playerOneGameboard[3, 2] = '0';
							pb1Pos32.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos32.BackColor = Color.White;
							return 0;
						}
					}
				case 34:
					{
						if (playerOneGameboard[3, 3] != '0')
						{
							playerOneGameboard[3, 3] = '0';
							pb1Pos33.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos33.BackColor = Color.White;
							return 0;
						}
					}
				case 35:
					{
						if (playerOneGameboard[3, 4] != '0')
						{
							playerOneGameboard[3, 4] = '0';
							pb1Pos34.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos34.BackColor = Color.White;
							return 0;
						}
					}
				case 36:
					{
						if (playerOneGameboard[3, 5] != '0')
						{
							playerOneGameboard[3, 5] = '0';
							pb1Pos35.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos35.BackColor = Color.White;
							return 0;
						}
					}
				case 37:
					{
						if (playerOneGameboard[3, 6] != '0')
						{
							playerOneGameboard[3, 6] = '0';
							pb1Pos36.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos36.BackColor = Color.White;
							return 0;
						}
					}
				case 38:
					{
						if (playerOneGameboard[3, 7] != '0')
						{
							playerOneGameboard[3, 7] = '0';
							pb1Pos37.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos37.BackColor = Color.White;
							return 0;
						}
					}
				case 39:
					{
						if (playerOneGameboard[3, 8] != '0')
						{
							playerOneGameboard[3, 8] = '0';
							pb1Pos38.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos38.BackColor = Color.White;
							return 0;
						}
					}
				case 40:
					{
						if (playerOneGameboard[3, 9] != '0')
						{
							playerOneGameboard[3, 9] = '0';
							pb1Pos39.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos39.BackColor = Color.White;
							return 0;
						}
					}
				case 41:
					{
						if (playerOneGameboard[4, 0] != '0')
						{
							playerOneGameboard[4, 0] = '0';
							pb1Pos40.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos40.BackColor = Color.White;
							return 0;
						}
					}
				case 42:
					{
						if (playerOneGameboard[4, 1] != '0')
						{
							playerOneGameboard[4, 1] = '0';
							pb1Pos41.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos41.BackColor = Color.White;
							return 0;
						}
					}
				case 43:
					{
						if (playerOneGameboard[4, 2] != '0')
						{
							playerOneGameboard[4, 2] = '0';
							pb1Pos42.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos42.BackColor = Color.White;
							return 0;
						}
					}
				case 44:
					{
						if (playerOneGameboard[4, 3] != '0')
						{
							playerOneGameboard[4, 3] = '0';
							pb1Pos43.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos43.BackColor = Color.White;
							return 0;
						}
					}
				case 45:
					{
						if (playerOneGameboard[4, 4] != '0')
						{
							playerOneGameboard[4, 4] = '0';
							pb1Pos44.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos44.BackColor = Color.White;
							return 0;
						}
					}
				case 46:
					{
						if (playerOneGameboard[4, 5] != '0')
						{
							playerOneGameboard[4, 5] = '0';
							pb1Pos45.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos45.BackColor = Color.White;
							return 0;
						}
					}
				case 47:
					{
						if (playerOneGameboard[4, 6] != '0')
						{
							playerOneGameboard[4, 6] = '0';
							pb1Pos46.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos46.BackColor = Color.White;
							return 0;
						}
					}
				case 48:
					{
						if (playerOneGameboard[4, 7] != '0')
						{
							playerOneGameboard[4, 7] = '0';
							pb1Pos47.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos47.BackColor = Color.White;
							return 0;
						}
					}
				case 49:
					{
						if (playerOneGameboard[4, 8] != '0')
						{
							playerOneGameboard[4, 8] = '0';
							pb1Pos48.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos48.BackColor = Color.White;
							return 0;
						}
					}
				case 50:
					{
						if (playerOneGameboard[4, 9] != '0')
						{
							playerOneGameboard[4, 9] = '0';
							pb1Pos49.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos49.BackColor = Color.White;
							return 0;
						}
					}
				case 51:
					{
						if (playerOneGameboard[5, 0] != '0')
						{
							playerOneGameboard[5, 0] = '0';
							pb1Pos50.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos50.BackColor = Color.White;
							return 0;
						}
					}
				case 52:
					{
						if (playerOneGameboard[5, 1] != '0')
						{
							playerOneGameboard[5, 1] = '0';
							pb1Pos51.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos51.BackColor = Color.White;
							return 0;
						}
					}
				case 53:
					{
						if (playerOneGameboard[5, 2] != '0')
						{
							playerOneGameboard[5, 2] = '0';
							pb1Pos52.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos52.BackColor = Color.White;
							return 0;
						}
					}
				case 54:
					{
						if (playerOneGameboard[5, 3] != '0')
						{
							playerOneGameboard[5, 3] = '0';
							pb1Pos53.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos53.BackColor = Color.White;
							return 0;
						}
					}
				case 55:
					{
						if (playerOneGameboard[5, 4] != '0')
						{
							playerOneGameboard[5, 4] = '0';
							pb1Pos54.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos54.BackColor = Color.White;
							return 0;
						}
					}
				case 56:
					{
						if (playerOneGameboard[5, 5] != '0')
						{
							playerOneGameboard[5, 5] = '0';
							pb1Pos55.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos55.BackColor = Color.White;
							return 0;
						}
					}
				case 57:
					{
						if (playerOneGameboard[5, 6] != '0')
						{
							playerOneGameboard[5, 6] = '0';
							pb1Pos56.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos56.BackColor = Color.White;
							return 0;
						}
					}
				case 58:
					{
						if (playerOneGameboard[5, 7] != '0')
						{
							playerOneGameboard[5, 7] = '0';
							pb1Pos57.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos57.BackColor = Color.White;
							return 0;
						}
					}
				case 59:
					{
						if (playerOneGameboard[5, 8] != '0')
						{
							playerOneGameboard[5, 8] = '0';
							pb1Pos58.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos58.BackColor = Color.White;
							return 0;
						}
					}
				case 60:
					{
						if (playerOneGameboard[5, 9] != '0')
						{
							playerOneGameboard[5, 9] = '0';
							pb1Pos59.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos59.BackColor = Color.White;
							return 0;
						}
					}
				case 61:
					{
						if (playerOneGameboard[6, 0] != '0')
						{
							playerOneGameboard[6, 0] = '0';
							pb1Pos60.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos60.BackColor = Color.White;
							return 0;
						}
					}
				case 62:
					{
						if (playerOneGameboard[6, 1] != '0')
						{
							playerOneGameboard[6, 1] = '0';
							pb1Pos61.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos61.BackColor = Color.White;
							return 0;
						}
					}
				case 63:
					{
						if (playerOneGameboard[6, 2] != '0')
						{
							playerOneGameboard[6, 2] = '0';
							pb1Pos62.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos62.BackColor = Color.White;
							return 0;
						}
					}
				case 64:
					{
						if (playerOneGameboard[6, 3] != '0')
						{
							playerOneGameboard[6, 3] = '0';
							pb1Pos63.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos63.BackColor = Color.White;
							return 0;
						}
					}
				case 65:
					{
						if (playerOneGameboard[6, 4] != '0')
						{
							playerOneGameboard[6, 4] = '0';
							pb1Pos64.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos64.BackColor = Color.White;
							return 0;
						}
					}
				case 66:
					{
						if (playerOneGameboard[6, 5] != '0')
						{
							playerOneGameboard[6, 5] = '0';
							pb1Pos65.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos65.BackColor = Color.White;
							return 0;
						}
					}
				case 67:
					{
						if (playerOneGameboard[6, 6] != '0')
						{
							playerOneGameboard[6, 6] = '0';
							pb1Pos66.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos66.BackColor = Color.White;
							return 0;
						}
					}
				case 68:
					{
						if (playerOneGameboard[6, 7] != '0')
						{
							playerOneGameboard[6, 7] = '0';
							pb1Pos67.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos67.BackColor = Color.White;
							return 0;
						}
					}
				case 69:
					{
						if (playerOneGameboard[6, 8] != '0')
						{
							playerOneGameboard[6, 8] = '0';
							pb1Pos68.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos68.BackColor = Color.White;
							return 0;
						}
					}
				case 70:
					{
						if (playerOneGameboard[6, 9] != '0')
						{
							playerOneGameboard[6, 9] = '0';
							pb1Pos69.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos69.BackColor = Color.White;
							return 0;
						}
					}
				case 71:
					{
						if (playerOneGameboard[7, 0] != '0')
						{
							playerOneGameboard[7, 0] = '0';
							pb1Pos70.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos70.BackColor = Color.White;
							return 0;
						}
					}
				case 72:
					{
						if (playerOneGameboard[7, 1] != '0')
						{
							playerOneGameboard[7, 1] = '0';
							pb1Pos71.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos71.BackColor = Color.White;
							return 0;
						}
					}
				case 73:
					{
						if (playerOneGameboard[7, 2] != '0')
						{
							playerOneGameboard[7, 2] = '0';
							pb1Pos72.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos72.BackColor = Color.White;
							return 0;
						}
					}
				case 74:
					{
						if (playerOneGameboard[7, 3] != '0')
						{
							playerOneGameboard[7, 3] = '0';
							pb1Pos73.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos73.BackColor = Color.White;
							return 0;
						}
					}
				case 75:
					{
						if (playerOneGameboard[7, 4] != '0')
						{
							playerOneGameboard[7, 4] = '0';
							pb1Pos74.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos74.BackColor = Color.White;
							return 0;
						}
					}
				case 76:
					{
						if (playerOneGameboard[7, 5] != '0')
						{
							playerOneGameboard[7, 5] = '0';
							pb1Pos75.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos75.BackColor = Color.White;
							return 0;
						}
					}
				case 77:
					{
						if (playerOneGameboard[7, 6] != '0')
						{
							playerOneGameboard[7, 6] = '0';
							pb1Pos76.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos76.BackColor = Color.White;
							return 0;
						}
					}
				case 78:
					{
						if (playerOneGameboard[7, 7] != '0')
						{
							playerOneGameboard[7, 7] = '0';
							pb1Pos77.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos77.BackColor = Color.White;
							return 0;
						}
					}
				case 79:
					{
						if (playerOneGameboard[7, 8] != '0')
						{
							playerOneGameboard[7, 8] = '0';
							pb1Pos78.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos78.BackColor = Color.White;
							return 0;
						}
					}
				case 80:
					{
						if (playerOneGameboard[7, 9] != '0')
						{
							playerOneGameboard[7, 9] = '0';
							pb1Pos79.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos79.BackColor = Color.White;
							return 0;
						}
					}
				case 81:
					{
						if (playerOneGameboard[8, 0] != '0')
						{
							playerOneGameboard[8, 0] = '0';
							pb1Pos80.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos80.BackColor = Color.White;
							return 0;
						}
					}
				case 82:
					{
						if (playerOneGameboard[8, 1] != '0')
						{
							playerOneGameboard[8, 1] = '0';
							pb1Pos81.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos81.BackColor = Color.White;
							return 0;
						}
					}
				case 83:
					{
						if (playerOneGameboard[8, 2] != '0')
						{
							playerOneGameboard[8, 2] = '0';
							pb1Pos82.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos82.BackColor = Color.White;
							return 0;
						}
					}
				case 84:
					{
						if (playerOneGameboard[8, 3] != '0')
						{
							playerOneGameboard[8, 3] = '0';
							pb1Pos83.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos83.BackColor = Color.White;
							return 0;
						}
					}
				case 85:
					{
						if (playerOneGameboard[8, 4] != '0')
						{
							playerOneGameboard[8, 4] = '0';
							pb1Pos84.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos84.BackColor = Color.White;
							return 0;
						}
					}
				case 86:
					{
						if (playerOneGameboard[8, 5] != '0')
						{
							playerOneGameboard[8, 5] = '0';
							pb1Pos85.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos85.BackColor = Color.White;
							return 0;
						}
					}
				case 87:
					{
						if (playerOneGameboard[8, 6] != '0')
						{
							playerOneGameboard[8, 6] = '0';
							pb1Pos86.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos86.BackColor = Color.White;
							return 0;
						}
					}
				case 88:
					{
						if (playerOneGameboard[8, 7] != '0')
						{
							playerOneGameboard[8, 7] = '0';
							pb1Pos87.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos87.BackColor = Color.White;
							return 0;
						}
					}
				case 89:
					{
						if (playerOneGameboard[8, 8] != '0')
						{
							playerOneGameboard[8, 8] = '0';
							pb1Pos88.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos88.BackColor = Color.White;
							return 0;
						}
					}
				case 90:
					{
						if (playerOneGameboard[8, 9] != '0')
						{
							playerOneGameboard[8, 9] = '0';
							pb1Pos89.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos89.BackColor = Color.White;
							return 0;
						}
					}
				case 91:
					{
						if (playerOneGameboard[9, 0] != '0')
						{
							playerOneGameboard[9, 0] = '0';
							pb1Pos90.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos90.BackColor = Color.White;
							return 0;
						}
					}
				case 92:
					{
						if (playerOneGameboard[9, 1] != '0')
						{
							playerOneGameboard[9, 1] = '0';
							pb1Pos91.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos91.BackColor = Color.White;
							return 0;
						}
					}
				case 93:
					{
						if (playerOneGameboard[9, 2] != '0')
						{
							playerOneGameboard[9, 2] = '0';
							pb1Pos92.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos92.BackColor = Color.White;
							return 0;
						}
					}
				case 94:
					{
						if (playerOneGameboard[9, 3] != '0')
						{
							playerOneGameboard[9, 3] = '0';
							pb1Pos93.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos93.BackColor = Color.White;
							return 0;
						}
					}
				case 95:
					{
						if (playerOneGameboard[9, 4] != '0')
						{
							playerOneGameboard[9, 4] = '0';
							pb1Pos94.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos94.BackColor = Color.White;
							return 0;
						}
					}
				case 96:
					{
						if (playerOneGameboard[9, 5] != '0')
						{
							playerOneGameboard[9, 5] = '0';
							pb1Pos95.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos95.BackColor = Color.White;
							return 0;
						}
					}
				case 97:
					{
						if (playerOneGameboard[9, 6] != '0')
						{
							playerOneGameboard[9, 6] = '0';
							pb1Pos96.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos96.BackColor = Color.White;
							return 0;
						}
					}
				case 98:
					{
						if (playerOneGameboard[9, 7] != '0')
						{
							playerOneGameboard[9, 7] = '0';
							pb1Pos97.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos97.BackColor = Color.White;
							return 0;
						}
					}
				case 99:
					{
						if (playerOneGameboard[9, 8] != '0')
						{
							playerOneGameboard[9, 8] = '0';
							pb1Pos98.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos98.BackColor = Color.White;
							return 0;
						}
					}
				case 100:
					{
						if (playerOneGameboard[9, 9] != '0')
						{
							playerOneGameboard[9, 9] = '0';
							pb1Pos99.BackColor = Color.Red;
							tempInitialHit = coords;
							return 1;
						}
						else
						{
							pb1Pos99.BackColor = Color.White;
							return 0;
						}
					}
				default:
					{
						return 0;
					}
					//Förlåt för denna programmeringssynd.
			}
		}

		//Find initial hit
		public void initialHit_Detector()
		{
			//Fire at random until an initial hit is made
			if ((initialHit == -1) && (tempInitialHit == -1))
			{
				randomEnemyFire();
			}
			else
			{
				//Set tile that "searching" will be based around, is the tile that recieved a hit
				nextTileToFireAt = initialHit = tempInitialHit;
			}
			smartEnemyFire();
		}

		//Methods that does the actual firing strategy
		public void smartEnemyFire()
		{
			switch (searchDirection)
			{
				case 1:
					if (nextTileToFireAt == initialHit)
					{
						controlledEnemyFire(initialHit - 10);
						nextTileToFireAt = initialHit - 10;
						break;
					}
					else if (controlledEnemyFire(nextTileToFireAt) == 1)
					{

					}
					else
					{
						searchDirection++;
						break;
					}
					break;

				case 2:
					break;

				case 3:
					break;

				case 4:
					break;

				default:
					break;
			}
			

			//			(D2)
			//			-1
			// (D1)	-10	HIT +10 (D3)
			//			+1
			//			(D4)
			
			//Pseudocode
			///Skjut på ett mål
			///
			///OM miss:
			///Välj nytt mål
			///
			///OM träff:
			///Minska x med 1
			///OM träff: 
			///Fortsätt minska x med 1
			///OM miss:
			///Öka x med 1
			///Samma sak för y-värden


		}
	}
}

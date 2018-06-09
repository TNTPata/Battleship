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

		//Method that enemy uses for firing at player
		public void EnemyFire()
		{
			//Select random tile to fire at, add said tile to list
			int positionToHit = rnd.Next(0, 101);

			//If proposed hit tile has already been fired at, generate a new hit tile
			do
			{
				alreadyFiredAt.Add(positionToHit);
				if (alreadyFiredAt.Contains(positionToHit))
				{
					positionToHit = rnd.Next(0, 101);
					alreadyFiredAt.Add(positionToHit);
				}
				else
				{
					break;
				}

			} while (true);
			
			//Fires at the given tile
			//Checks if the tile is not empty
			//Sets gameboard to '0' and sets button to red if tile is not empty.
			switch (positionToHit)
			{
				case 1:
					{
						if (playerOneGameboard[0,0] != '0')
						{
							playerOneGameboard[0, 0] = '0';
							pb1Pos00.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 2:
					{
						if (playerOneGameboard[0, 1] != '0')
						{
							playerOneGameboard[0, 1] = '0';
							pb1Pos01.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 3:
					{
						if (playerOneGameboard[0, 2] != '0')
						{
							playerOneGameboard[0, 2] = '0';
							pb1Pos02.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 4:
					{
						if (playerOneGameboard[0, 3] != '0')
						{
							playerOneGameboard[0, 3] = '0';
							pb1Pos03.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 5:
					{
						if (playerOneGameboard[0, 4] != '0')
						{
							playerOneGameboard[0, 4] = '0';
							pb1Pos04.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 6:
					{
						if (playerOneGameboard[0, 5] != '0')
						{
							playerOneGameboard[0, 5] = '0';
							pb1Pos05.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 7:
					{
						if (playerOneGameboard[0, 6] != '0')
						{
							playerOneGameboard[0, 6] = '0';
							pb1Pos06.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 8:
					{
						if (playerOneGameboard[0, 7] != '0')
						{
							playerOneGameboard[0, 7] = '0';
							pb1Pos07.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 9:
					{
						if (playerOneGameboard[0, 8] != '0')
						{
							playerOneGameboard[0, 8] = '0';
							pb1Pos08.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 10:
					{
						if (playerOneGameboard[0, 9] != '0')
						{
							playerOneGameboard[0, 9] = '0';
							pb1Pos09.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 11:
					{
						if (playerOneGameboard[1, 0] != '0')
						{
							playerOneGameboard[1, 0] = '0';
							pb1Pos10.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 12:
					{
						if (playerOneGameboard[1, 1] != '0')
						{
							playerOneGameboard[1, 1] = '0';
							pb1Pos11.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 13:
					{
						if (playerOneGameboard[1, 2] != '0')
						{
							playerOneGameboard[1, 2] = '0';
							pb1Pos12.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 14:
					{
						if (playerOneGameboard[1, 3] != '0')
						{
							playerOneGameboard[1, 3] = '0';
							pb1Pos13.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 15:
					{
						if (playerOneGameboard[1, 4] != '0')
						{
							playerOneGameboard[1, 4] = '0';
							pb1Pos14.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 16:
					{
						if (playerOneGameboard[1, 5] != '0')
						{
							playerOneGameboard[1, 5] = '0';
							pb1Pos15.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 17:
					{
						if (playerOneGameboard[1, 6] != '0')
						{
							playerOneGameboard[1, 6] = '0';
							pb1Pos16.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 18:
					{
						if (playerOneGameboard[1, 7] != '0')
						{
							playerOneGameboard[1, 7] = '0';
							pb1Pos17.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 19:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 20:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 21:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 22:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 23:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 24:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 25:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 26:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 27:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 28:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 29:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 30:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 31:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 32:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 33:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 34:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 35:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 36:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 37:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 38:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 39:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 40:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 41:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 42:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 43:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 44:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 45:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 46:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 47:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 48:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 49:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 50:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 51:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 52:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 53:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 54:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 55:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 56:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 57:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 58:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 59:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 60:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 61:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 62:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 63:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 64:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 65:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 66:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 67:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 68:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 69:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 70:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 71:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 72:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 73:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 74:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 75:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 76:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 77:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 78:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 79:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 80:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 81:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 82:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 83:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 84:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 85:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 86:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 87:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 88:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 89:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 90:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 91:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 92:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 93:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 94:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 95:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 96:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 97:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 98:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 99:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				case 100:
					{
						if (playerOneGameboard[1, 8] != '0')
						{
							playerOneGameboard[1, 8] = '0';
							pb1Pos18.BackColor = Color.Red;
							break;
						}
						else
						{
							break;
						}
					}
				default:
					{
						break;
					}
			}
		}
	}
}

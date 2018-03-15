using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
	public partial class Battleship : Form
	{

		//Init two gameboards that will hold the positions of the battleships
		public static bool[,] playerOneGameboard = new bool[10, 10];
		public static bool[,] playerTwoGameboard = new bool[10, 10];

		//Goes through both boards and sets all indexes to false.
		static void ResetBoards()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					playerOneGameboard[i, j] = false;
					playerTwoGameboard[i, j] = false;
				}
			}
		}
		public Battleship()
		{
			InitializeComponent();
		}

		private void Battleship_Load(object sender, EventArgs e)
		{
			//Sets all positions to false, as there aren't any ships on the gameboard yet.
			ResetBoards();

			
		}
	}
}
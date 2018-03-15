using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship {
	public partial class Battleship : Form {
		bool[,] playerOneGameboard = new bool[9,9];
		bool[,] playerTwoGameboard = new bool[9,9];

		static void ResetBoards()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; i < 10; j++)
				{

				}
			}
		}
		public Battleship() {
			InitializeComponent();
		}

		private void Battleship_Load(object sender, EventArgs e)
		{
			
		}
	}
}
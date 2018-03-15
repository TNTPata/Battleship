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
	public partial class Battleship1 : Form
	{
		bool[,] playerOneGameboard = new bool[9,9];
		bool[,] playerTwoGameboard = new bool[9,9];

		public Battleship1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

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

		public Battleship()
		{
			InitializeComponent();
		}

		private void Battleship_Load(object sender, EventArgs e)
		{
			//Sets all positions to false, as there aren't any ships on the gameboard yet.
			Methods.ResetBoards();

			//Ship placement
			Methods.ShipPlacerOne();
			Methods.ShipPlacerTwo();
		}

		private void pb2Pos00_Click(object sender, EventArgs e)
		{
			Methods.HitDetectorGameboardTwo(0, 0, ref pb2Pos00);
		}

		private void pb2Pos01_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos02_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos03_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos04_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos05_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos06_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos07_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos08_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos09_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos10_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos11_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos12_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos13_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos14_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos15_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos16_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos17_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos18_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos19_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos20_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos21_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos22_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos23_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos24_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos25_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos26_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos27_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos28_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos29_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos30_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos31_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos32_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos33_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos34_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos35_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos36_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos37_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos38_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos39_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos40_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos41_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos42_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos43_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos44_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos45_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos46_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos47_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos48_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos49_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos50_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos51_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos52_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos53_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos54_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos55_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos56_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos57_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos58_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos59_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos60_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos61_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos62_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos63_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos64_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos65_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos66_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos67_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos68_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos69_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos70_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos71_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos72_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos73_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos74_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos75_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos76_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos77_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos78_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos79_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos80_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos81_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos82_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos83_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos84_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos85_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos86_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos87_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos88_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos89_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos90_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos91_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos92_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos93_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos94_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos95_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos96_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos97_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos98_Click(object sender, EventArgs e)
		{

		}

		private void pb2Pos99_Click(object sender, EventArgs e)
		{

		}
	}
}
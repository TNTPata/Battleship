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

		//***REMOVE LATER***
		//public static int numberOfPlayers = 1;
		//***REMOVE LATER***

		private void Battleship_Load(object sender, EventArgs e)
		{
			//Sets all positions to false, as there aren't any ships on the gameboard yet.
			Battleship.ResetBoards();

			//Ship placement
			Battleship.ShipPlacerOne();
			Battleship.ShipPlacerTwo();
			groupBox1.Enabled = true;
			groupBox2.Enabled = true;
			Battleship.ShipMarker();


		}

		#region pictureBox.Click events
		private void pb2Pos00_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 0, ref pb2Pos00);
		}

		private void pb2Pos01_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 1, ref pb2Pos01);
		}

		private void pb2Pos02_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0,2,ref pb2Pos02);
		}

		private void pb2Pos03_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 0, ref pb2Pos03);
		}

		private void pb2Pos04_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 4, ref pb2Pos04);
		}

		private void pb2Pos05_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 5, ref pb2Pos05);
		}

		private void pb2Pos06_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 6, ref pb2Pos06);
		}

		private void pb2Pos07_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 7, ref pb2Pos07);
		}

		private void pb2Pos08_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 8, ref pb2Pos08);
		}

		private void pb2Pos09_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(0, 9, ref pb2Pos09);
		}

		private void pb2Pos10_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 0, ref pb2Pos10);
		}

		private void pb2Pos11_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 1, ref pb2Pos11);
		}

		private void pb2Pos12_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 2, ref pb2Pos12);
		}

		private void pb2Pos13_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 3, ref pb2Pos13);
		}

		private void pb2Pos14_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 5, ref pb2Pos14);
		}

		private void pb2Pos15_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 5, ref pb2Pos15);
		}

		private void pb2Pos16_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 6, ref pb2Pos16);
		}

		private void pb2Pos17_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 7, ref pb2Pos17);
		}

		private void pb2Pos18_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 8, ref pb2Pos18);
		}

		private void pb2Pos19_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(1, 9, ref pb2Pos19);
		}

		private void pb2Pos20_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 0, ref pb2Pos20);
		}

		private void pb2Pos21_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 1, ref pb2Pos21);

		}

		private void pb2Pos22_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 2, ref pb2Pos22);

		}

		private void pb2Pos23_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 3, ref pb2Pos23);

		}

		private void pb2Pos24_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 4, ref pb2Pos24);

		}

		private void pb2Pos25_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 5, ref pb2Pos25);

		}

		private void pb2Pos26_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 6, ref pb2Pos26);

		}

		private void pb2Pos27_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 7, ref pb2Pos27);

		}

		private void pb2Pos28_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 8, ref pb2Pos28);

		}

		private void pb2Pos29_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(2, 9, ref pb2Pos29);

		}

		private void pb2Pos30_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 0, ref pb2Pos30);

		}

		private void pb2Pos31_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 1, ref pb2Pos31);

		}

		private void pb2Pos32_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 2, ref pb2Pos32);

		}

		private void pb2Pos33_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 3, ref pb2Pos33);

		}

		private void pb2Pos34_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 4, ref pb2Pos34);

		}

		private void pb2Pos35_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 5, ref pb2Pos35);
		}

		private void pb2Pos36_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 6, ref pb2Pos36);
		}

		private void pb2Pos37_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 7, ref pb2Pos37);
		}

		private void pb2Pos38_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 8, ref pb2Pos38);
		}

		private void pb2Pos39_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(3, 9, ref pb2Pos39);
		}

		private void pb2Pos40_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 0, ref pb2Pos40);

		}

		private void pb2Pos41_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 1, ref pb2Pos41);

		}

		private void pb2Pos42_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 2, ref pb2Pos42);

		}

		private void pb2Pos43_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 3, ref pb2Pos43);

		}

		private void pb2Pos44_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 4, ref pb2Pos44);

		}

		private void pb2Pos45_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 5, ref pb2Pos45);

		}

		private void pb2Pos46_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 6, ref pb2Pos46);

		}

		private void pb2Pos47_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 7, ref pb2Pos47);

		}

		private void pb2Pos48_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 8, ref pb2Pos48);

		}

		private void pb2Pos49_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(4, 9, ref pb2Pos49);

		}

		private void pb2Pos50_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 0, ref pb2Pos50);

		}

		private void pb2Pos51_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 1, ref pb2Pos51);

		}

		private void pb2Pos52_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 2, ref pb2Pos52);

		}

		private void pb2Pos53_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 3, ref pb2Pos53);

		}

		private void pb2Pos54_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 4, ref pb2Pos54);

		}

		private void pb2Pos55_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 5, ref pb2Pos55);

		}

		private void pb2Pos56_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 6, ref pb2Pos56);

		}

		private void pb2Pos57_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 7, ref pb2Pos57);

		}

		private void pb2Pos58_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 8, ref pb2Pos58);

		}

		private void pb2Pos59_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(5, 9, ref pb2Pos59);

		}

		private void pb2Pos60_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 0, ref pb2Pos60);

		}

		private void pb2Pos61_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 1, ref pb2Pos61);

		}

		private void pb2Pos62_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 2, ref pb2Pos62);

		}

		private void pb2Pos63_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 3, ref pb2Pos63);

		}

		private void pb2Pos64_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 4, ref pb2Pos64);

		}

		private void pb2Pos65_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 5, ref pb2Pos65);

		}

		private void pb2Pos66_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 6, ref pb2Pos66);

		}

		private void pb2Pos67_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 7, ref pb2Pos67);

		}

		private void pb2Pos68_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 8, ref pb2Pos68);

		}

		private void pb2Pos69_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(6, 9, ref pb2Pos69);

		}

		private void pb2Pos70_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 0, ref pb2Pos70);

		}

		private void pb2Pos71_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 1, ref pb2Pos71);

		}

		private void pb2Pos72_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 2, ref pb2Pos72);

		}

		private void pb2Pos73_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 3, ref pb2Pos73);

		}

		private void pb2Pos74_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 4, ref pb2Pos74);

		}

		private void pb2Pos75_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 5, ref pb2Pos75);

		}

		private void pb2Pos76_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 6, ref pb2Pos76);

		}

		private void pb2Pos77_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 7, ref pb2Pos77);

		}

		private void pb2Pos78_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 8, ref pb2Pos78);

		}

		private void pb2Pos79_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(7, 9, ref pb2Pos79);

		}

		private void pb2Pos80_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 0, ref pb2Pos80);

		}

		private void pb2Pos81_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 1, ref pb2Pos81);
		}

		private void pb2Pos82_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 2, ref pb2Pos82);

		}

		private void pb2Pos83_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 3, ref pb2Pos83);
		}

		private void pb2Pos84_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 4, ref pb2Pos84);

		}

		private void pb2Pos85_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 5, ref pb2Pos85);

		}

		private void pb2Pos86_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 6, ref pb2Pos86);

		}

		private void pb2Pos87_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 7, ref pb2Pos87);
		}

		private void pb2Pos88_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 8, ref pb2Pos88);

		}

		private void pb2Pos89_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(8, 9, ref pb2Pos89);
		
		}

		private void pb2Pos90_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 0, ref pb2Pos90);

		}

		private void pb2Pos91_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 1, ref pb2Pos91);
		}

		private void pb2Pos92_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 2, ref pb2Pos92);

		}

		private void pb2Pos93_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 3, ref pb2Pos93);
		}

		private void pb2Pos94_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 4, ref pb2Pos94);

		}

		private void pb2Pos95_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 5, ref pb2Pos95);

		}

		private void pb2Pos96_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 6, ref pb2Pos96);

		}

		private void pb2Pos97_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 7, ref pb2Pos97);

		}

		private void pb2Pos98_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 9, ref pb2Pos98);

		}

		private void pb2Pos99_Click(object sender, EventArgs e)
		{
			HitDetectors.HitDetectorGameboardTwo(9, 9, ref pb2Pos99);

		}
		#endregion
	}
}
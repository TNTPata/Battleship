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
		public static char[,] playerOneGameboard = new char[10, 10];
		public static char[,] playerTwoGameboard = new char[10, 10];

		public Battleship()
		{
			InitializeComponent();
		}

		//Where X is 1 or 2, i.e. player one or player two
		public static int playerXTurn = 1;
		

		private void Battleship_Load(object sender, EventArgs e)
		{
			//Sets all positions to false, as there aren't any ships on the gameboard yet
			ResetBoards();

			//Ship placement
			ShipPlacerOne();
			ShipPlacerTwo();
			groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = true;
		
			#region ShipMarker()
			ShipMarker(ref pb1Pos00,
				ref pb1Pos01,
				ref pb1Pos02,
				ref pb1Pos03,
				ref pb1Pos04,
				ref pb1Pos05,
				ref pb1Pos06,
				ref pb1Pos07,
				ref pb1Pos08,
				ref pb1Pos09,
				ref pb1Pos10,
				ref pb1Pos11,
				ref pb1Pos12,
				ref pb1Pos13,
				ref pb1Pos14,
				ref pb1Pos15,
				ref pb1Pos16,
				ref pb1Pos17,
				ref pb1Pos18,
				ref pb1Pos19,
				ref pb1Pos20,
				ref pb1Pos21,
				ref pb1Pos22,
				ref pb1Pos23,
				ref pb1Pos24,
				ref pb1Pos25,
				ref pb1Pos26,
				ref pb1Pos27,
				ref pb1Pos28,
				ref pb1Pos29,
				ref pb1Pos30,
				ref pb1Pos31,
				ref pb1Pos32,
				ref pb1Pos33,
				ref pb1Pos34,
				ref pb1Pos35,
				ref pb1Pos36,
				ref pb1Pos37,
				ref pb1Pos38,
				ref pb1Pos39,
				ref pb1Pos40,
				ref pb1Pos41,
				ref pb1Pos42,
				ref pb1Pos43,
				ref pb1Pos44,
				ref pb1Pos45,
				ref pb1Pos46,
				ref pb1Pos47,
				ref pb1Pos48,
				ref pb1Pos49,
				ref pb1Pos50,
				ref pb1Pos51,
				ref pb1Pos52,
				ref pb1Pos53,
				ref pb1Pos54,
				ref pb1Pos55,
				ref pb1Pos56,
				ref pb1Pos57,
				ref pb1Pos58,
				ref pb1Pos59,
				ref pb1Pos60,
				ref pb1Pos61,
				ref pb1Pos62,
				ref pb1Pos63,
				ref pb1Pos64,
				ref pb1Pos65,
				ref pb1Pos66,
				ref pb1Pos67,
				ref pb1Pos68,
				ref pb1Pos69,
				ref pb1Pos70,
				ref pb1Pos71,
				ref pb1Pos72,
				ref pb1Pos73,
				ref pb1Pos74,
				ref pb1Pos75,
				ref pb1Pos76,
				ref pb1Pos77,
				ref pb1Pos78,
				ref pb1Pos79,
				ref pb1Pos80,
				ref pb1Pos81,
				ref pb1Pos82,
				ref pb1Pos83,
				ref pb1Pos84,
				ref pb1Pos85,
				ref pb1Pos86,
				ref pb1Pos87,
				ref pb1Pos88,
				ref pb1Pos89,
				ref pb1Pos90,
				ref pb1Pos91,
				ref pb1Pos92,
				ref pb1Pos93,
				ref pb1Pos94,
				ref pb1Pos95,
				ref pb1Pos96,
				ref pb1Pos97,
				ref pb1Pos98,
				ref pb1Pos99);
			#endregion

		}

		#region PictureBox.Click events
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

		#region Debug
		//Debug button to fire at all buttons at the same time, press again to generate new ship placements
		private void btnDebugHITALL_Click(object sender, EventArgs e)
		{
			//Reset all boards
			ResetBoards();

			//Essentially set all buttons to blue
			HitDetectors.DebugHitDetectorGameboardTwo(0, 0, ref pb2Pos00);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 1, ref pb2Pos01);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 2, ref pb2Pos02);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 3, ref pb2Pos03);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 4, ref pb2Pos04);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 5, ref pb2Pos05);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 6, ref pb2Pos06);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 7, ref pb2Pos07);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 8, ref pb2Pos08);
			HitDetectors.DebugHitDetectorGameboardTwo(0, 9, ref pb2Pos09);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 0, ref pb2Pos10);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 1, ref pb2Pos11);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 2, ref pb2Pos12);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 3, ref pb2Pos13);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 4, ref pb2Pos14);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 5, ref pb2Pos15);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 6, ref pb2Pos16);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 7, ref pb2Pos17);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 8, ref pb2Pos18);
			HitDetectors.DebugHitDetectorGameboardTwo(1, 9, ref pb2Pos19);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 0, ref pb2Pos20);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 1, ref pb2Pos21);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 2, ref pb2Pos22);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 3, ref pb2Pos23);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 4, ref pb2Pos24);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 5, ref pb2Pos25);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 6, ref pb2Pos26);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 7, ref pb2Pos27);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 8, ref pb2Pos28);
			HitDetectors.DebugHitDetectorGameboardTwo(2, 9, ref pb2Pos29);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 0, ref pb2Pos30);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 1, ref pb2Pos31);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 2, ref pb2Pos32);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 3, ref pb2Pos33);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 4, ref pb2Pos34);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 5, ref pb2Pos35);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 6, ref pb2Pos36);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 7, ref pb2Pos37);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 8, ref pb2Pos38);
			HitDetectors.DebugHitDetectorGameboardTwo(3, 9, ref pb2Pos39);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 0, ref pb2Pos40);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 1, ref pb2Pos41);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 2, ref pb2Pos42);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 3, ref pb2Pos43);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 4, ref pb2Pos44);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 5, ref pb2Pos45);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 6, ref pb2Pos46);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 7, ref pb2Pos47);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 8, ref pb2Pos48);
			HitDetectors.DebugHitDetectorGameboardTwo(4, 9, ref pb2Pos49);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 0, ref pb2Pos50);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 1, ref pb2Pos51);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 2, ref pb2Pos52);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 3, ref pb2Pos53);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 4, ref pb2Pos54);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 5, ref pb2Pos55);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 6, ref pb2Pos56);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 7, ref pb2Pos57);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 8, ref pb2Pos58);
			HitDetectors.DebugHitDetectorGameboardTwo(5, 9, ref pb2Pos59);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 0, ref pb2Pos60);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 1, ref pb2Pos61);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 2, ref pb2Pos62);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 3, ref pb2Pos63);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 4, ref pb2Pos64);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 5, ref pb2Pos65);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 6, ref pb2Pos66);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 7, ref pb2Pos67);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 8, ref pb2Pos68);
			HitDetectors.DebugHitDetectorGameboardTwo(6, 9, ref pb2Pos69);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 0, ref pb2Pos70);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 1, ref pb2Pos71);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 2, ref pb2Pos72);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 3, ref pb2Pos73);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 4, ref pb2Pos74);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 5, ref pb2Pos75);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 6, ref pb2Pos76);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 7, ref pb2Pos77);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 8, ref pb2Pos78);
			HitDetectors.DebugHitDetectorGameboardTwo(7, 9, ref pb2Pos79);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 0, ref pb2Pos80);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 1, ref pb2Pos81);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 2, ref pb2Pos82);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 3, ref pb2Pos83);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 4, ref pb2Pos84);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 5, ref pb2Pos85);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 6, ref pb2Pos86);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 7, ref pb2Pos87);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 8, ref pb2Pos88);
			HitDetectors.DebugHitDetectorGameboardTwo(8, 9, ref pb2Pos89);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 0, ref pb2Pos90);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 1, ref pb2Pos91);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 2, ref pb2Pos92);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 3, ref pb2Pos93);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 4, ref pb2Pos94);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 5, ref pb2Pos95);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 6, ref pb2Pos96);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 7, ref pb2Pos97);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 8, ref pb2Pos98);
			HitDetectors.DebugHitDetectorGameboardTwo(9, 9, ref pb2Pos99);

			//Place ships for both boards
			ShipPlacerOne();
			ShipPlacerTwo();

			//Mark ship for player one
			#region ShipMarker()
			ShipMarker(ref pb1Pos00,
				ref pb1Pos01,
				ref pb1Pos02,
				ref pb1Pos03,
				ref pb1Pos04,
				ref pb1Pos05,
				ref pb1Pos06,
				ref pb1Pos07,
				ref pb1Pos08,
				ref pb1Pos09,
				ref pb1Pos10,
				ref pb1Pos11,
				ref pb1Pos12,
				ref pb1Pos13,
				ref pb1Pos14,
				ref pb1Pos15,
				ref pb1Pos16,
				ref pb1Pos17,
				ref pb1Pos18,
				ref pb1Pos19,
				ref pb1Pos20,
				ref pb1Pos21,
				ref pb1Pos22,
				ref pb1Pos23,
				ref pb1Pos24,
				ref pb1Pos25,
				ref pb1Pos26,
				ref pb1Pos27,
				ref pb1Pos28,
				ref pb1Pos29,
				ref pb1Pos30,
				ref pb1Pos31,
				ref pb1Pos32,
				ref pb1Pos33,
				ref pb1Pos34,
				ref pb1Pos35,
				ref pb1Pos36,
				ref pb1Pos37,
				ref pb1Pos38,
				ref pb1Pos39,
				ref pb1Pos40,
				ref pb1Pos41,
				ref pb1Pos42,
				ref pb1Pos43,
				ref pb1Pos44,
				ref pb1Pos45,
				ref pb1Pos46,
				ref pb1Pos47,
				ref pb1Pos48,
				ref pb1Pos49,
				ref pb1Pos50,
				ref pb1Pos51,
				ref pb1Pos52,
				ref pb1Pos53,
				ref pb1Pos54,
				ref pb1Pos55,
				ref pb1Pos56,
				ref pb1Pos57,
				ref pb1Pos58,
				ref pb1Pos59,
				ref pb1Pos60,
				ref pb1Pos61,
				ref pb1Pos62,
				ref pb1Pos63,
				ref pb1Pos64,
				ref pb1Pos65,
				ref pb1Pos66,
				ref pb1Pos67,
				ref pb1Pos68,
				ref pb1Pos69,
				ref pb1Pos70,
				ref pb1Pos71,
				ref pb1Pos72,
				ref pb1Pos73,
				ref pb1Pos74,
				ref pb1Pos75,
				ref pb1Pos76,
				ref pb1Pos77,
				ref pb1Pos78,
				ref pb1Pos79,
				ref pb1Pos80,
				ref pb1Pos81,
				ref pb1Pos82,
				ref pb1Pos83,
				ref pb1Pos84,
				ref pb1Pos85,
				ref pb1Pos86,
				ref pb1Pos87,
				ref pb1Pos88,
				ref pb1Pos89,
				ref pb1Pos90,
				ref pb1Pos91,
				ref pb1Pos92,
				ref pb1Pos93,
				ref pb1Pos94,
				ref pb1Pos95,
				ref pb1Pos96,
				ref pb1Pos97,
				ref pb1Pos98,
				ref pb1Pos99);
			#endregion

			//Mark ships for player two/enemy
			HitDetectors.HitDetectorGameboardTwo(0, 0, ref pb2Pos00);
			HitDetectors.HitDetectorGameboardTwo(0, 1, ref pb2Pos01);
			HitDetectors.HitDetectorGameboardTwo(0, 2, ref pb2Pos02);
			HitDetectors.HitDetectorGameboardTwo(0, 3, ref pb2Pos03);
			HitDetectors.HitDetectorGameboardTwo(0, 4, ref pb2Pos04);
			HitDetectors.HitDetectorGameboardTwo(0, 5, ref pb2Pos05);
			HitDetectors.HitDetectorGameboardTwo(0, 6, ref pb2Pos06);
			HitDetectors.HitDetectorGameboardTwo(0, 7, ref pb2Pos07);
			HitDetectors.HitDetectorGameboardTwo(0, 8, ref pb2Pos08);
			HitDetectors.HitDetectorGameboardTwo(0, 9, ref pb2Pos09);
			HitDetectors.HitDetectorGameboardTwo(1, 0, ref pb2Pos10);
			HitDetectors.HitDetectorGameboardTwo(1, 1, ref pb2Pos11);
			HitDetectors.HitDetectorGameboardTwo(1, 2, ref pb2Pos12);
			HitDetectors.HitDetectorGameboardTwo(1, 3, ref pb2Pos13);
			HitDetectors.HitDetectorGameboardTwo(1, 4, ref pb2Pos14);
			HitDetectors.HitDetectorGameboardTwo(1, 5, ref pb2Pos15);
			HitDetectors.HitDetectorGameboardTwo(1, 6, ref pb2Pos16);
			HitDetectors.HitDetectorGameboardTwo(1, 7, ref pb2Pos17);
			HitDetectors.HitDetectorGameboardTwo(1, 8, ref pb2Pos18);
			HitDetectors.HitDetectorGameboardTwo(1, 9, ref pb2Pos19);
			HitDetectors.HitDetectorGameboardTwo(2, 0, ref pb2Pos20);
			HitDetectors.HitDetectorGameboardTwo(2, 1, ref pb2Pos21);
			HitDetectors.HitDetectorGameboardTwo(2, 2, ref pb2Pos22);
			HitDetectors.HitDetectorGameboardTwo(2, 3, ref pb2Pos23);
			HitDetectors.HitDetectorGameboardTwo(2, 4, ref pb2Pos24);
			HitDetectors.HitDetectorGameboardTwo(2, 5, ref pb2Pos25);
			HitDetectors.HitDetectorGameboardTwo(2, 6, ref pb2Pos26);
			HitDetectors.HitDetectorGameboardTwo(2, 7, ref pb2Pos27);
			HitDetectors.HitDetectorGameboardTwo(2, 8, ref pb2Pos28);
			HitDetectors.HitDetectorGameboardTwo(2, 9, ref pb2Pos29);
			HitDetectors.HitDetectorGameboardTwo(3, 0, ref pb2Pos30);
			HitDetectors.HitDetectorGameboardTwo(3, 1, ref pb2Pos31);
			HitDetectors.HitDetectorGameboardTwo(3, 2, ref pb2Pos32);
			HitDetectors.HitDetectorGameboardTwo(3, 3, ref pb2Pos33);
			HitDetectors.HitDetectorGameboardTwo(3, 4, ref pb2Pos34);
			HitDetectors.HitDetectorGameboardTwo(3, 5, ref pb2Pos35);
			HitDetectors.HitDetectorGameboardTwo(3, 6, ref pb2Pos36);
			HitDetectors.HitDetectorGameboardTwo(3, 7, ref pb2Pos37);
			HitDetectors.HitDetectorGameboardTwo(3, 8, ref pb2Pos38);
			HitDetectors.HitDetectorGameboardTwo(3, 9, ref pb2Pos39);
			HitDetectors.HitDetectorGameboardTwo(4, 0, ref pb2Pos40);
			HitDetectors.HitDetectorGameboardTwo(4, 1, ref pb2Pos41);
			HitDetectors.HitDetectorGameboardTwo(4, 2, ref pb2Pos42);
			HitDetectors.HitDetectorGameboardTwo(4, 3, ref pb2Pos43);
			HitDetectors.HitDetectorGameboardTwo(4, 4, ref pb2Pos44);
			HitDetectors.HitDetectorGameboardTwo(4, 5, ref pb2Pos45);
			HitDetectors.HitDetectorGameboardTwo(4, 6, ref pb2Pos46);
			HitDetectors.HitDetectorGameboardTwo(4, 7, ref pb2Pos47);
			HitDetectors.HitDetectorGameboardTwo(4, 8, ref pb2Pos48);
			HitDetectors.HitDetectorGameboardTwo(4, 9, ref pb2Pos49);
			HitDetectors.HitDetectorGameboardTwo(5, 0, ref pb2Pos50);
			HitDetectors.HitDetectorGameboardTwo(5, 1, ref pb2Pos51);
			HitDetectors.HitDetectorGameboardTwo(5, 2, ref pb2Pos52);
			HitDetectors.HitDetectorGameboardTwo(5, 3, ref pb2Pos53);
			HitDetectors.HitDetectorGameboardTwo(5, 4, ref pb2Pos54);
			HitDetectors.HitDetectorGameboardTwo(5, 5, ref pb2Pos55);
			HitDetectors.HitDetectorGameboardTwo(5, 6, ref pb2Pos56);
			HitDetectors.HitDetectorGameboardTwo(5, 7, ref pb2Pos57);
			HitDetectors.HitDetectorGameboardTwo(5, 8, ref pb2Pos58);
			HitDetectors.HitDetectorGameboardTwo(5, 9, ref pb2Pos59);
			HitDetectors.HitDetectorGameboardTwo(6, 0, ref pb2Pos60);
			HitDetectors.HitDetectorGameboardTwo(6, 1, ref pb2Pos61);
			HitDetectors.HitDetectorGameboardTwo(6, 2, ref pb2Pos62);
			HitDetectors.HitDetectorGameboardTwo(6, 3, ref pb2Pos63);
			HitDetectors.HitDetectorGameboardTwo(6, 4, ref pb2Pos64);
			HitDetectors.HitDetectorGameboardTwo(6, 5, ref pb2Pos65);
			HitDetectors.HitDetectorGameboardTwo(6, 6, ref pb2Pos66);
			HitDetectors.HitDetectorGameboardTwo(6, 7, ref pb2Pos67);
			HitDetectors.HitDetectorGameboardTwo(6, 8, ref pb2Pos68);
			HitDetectors.HitDetectorGameboardTwo(6, 9, ref pb2Pos69);
			HitDetectors.HitDetectorGameboardTwo(7, 0, ref pb2Pos70);
			HitDetectors.HitDetectorGameboardTwo(7, 1, ref pb2Pos71);
			HitDetectors.HitDetectorGameboardTwo(7, 2, ref pb2Pos72);
			HitDetectors.HitDetectorGameboardTwo(7, 3, ref pb2Pos73);
			HitDetectors.HitDetectorGameboardTwo(7, 4, ref pb2Pos74);
			HitDetectors.HitDetectorGameboardTwo(7, 5, ref pb2Pos75);
			HitDetectors.HitDetectorGameboardTwo(7, 6, ref pb2Pos76);
			HitDetectors.HitDetectorGameboardTwo(7, 7, ref pb2Pos77);
			HitDetectors.HitDetectorGameboardTwo(7, 8, ref pb2Pos78);
			HitDetectors.HitDetectorGameboardTwo(7, 9, ref pb2Pos79);
			HitDetectors.HitDetectorGameboardTwo(8, 0, ref pb2Pos80);
			HitDetectors.HitDetectorGameboardTwo(8, 1, ref pb2Pos81);
			HitDetectors.HitDetectorGameboardTwo(8, 2, ref pb2Pos82);
			HitDetectors.HitDetectorGameboardTwo(8, 3, ref pb2Pos83);
			HitDetectors.HitDetectorGameboardTwo(8, 4, ref pb2Pos84);
			HitDetectors.HitDetectorGameboardTwo(8, 5, ref pb2Pos85);
			HitDetectors.HitDetectorGameboardTwo(8, 6, ref pb2Pos86);
			HitDetectors.HitDetectorGameboardTwo(8, 7, ref pb2Pos87);
			HitDetectors.HitDetectorGameboardTwo(8, 8, ref pb2Pos88);
			HitDetectors.HitDetectorGameboardTwo(8, 9, ref pb2Pos89);
			HitDetectors.HitDetectorGameboardTwo(9, 0, ref pb2Pos90);
			HitDetectors.HitDetectorGameboardTwo(9, 1, ref pb2Pos91);
			HitDetectors.HitDetectorGameboardTwo(9, 2, ref pb2Pos92);
			HitDetectors.HitDetectorGameboardTwo(9, 3, ref pb2Pos93);
			HitDetectors.HitDetectorGameboardTwo(9, 4, ref pb2Pos94);
			HitDetectors.HitDetectorGameboardTwo(9, 5, ref pb2Pos95);
			HitDetectors.HitDetectorGameboardTwo(9, 6, ref pb2Pos96);
			HitDetectors.HitDetectorGameboardTwo(9, 7, ref pb2Pos97);
			HitDetectors.HitDetectorGameboardTwo(9, 8, ref pb2Pos98);
			HitDetectors.HitDetectorGameboardTwo(9, 9, ref pb2Pos99);
		}
		#endregion
	}
}
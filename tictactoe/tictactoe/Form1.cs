using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
	public partial class Form1 : Form
	{
		bool uservspc = false;
		bool turn = true;
		int turn_count = 0;
		public Form1()
		{
			InitializeComponent();
		}
		/* Watermark of a bad student
		private void button1_Click(object sender, EventArgs e){}
		private void B1_Click(object sender, EventArgs e){}
		*/
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Created by Alex\nVerson alfa 2.2.1\nWhat's new:\n 1. Added new mode\n 2. Autostart every end of game\n 3. Minor fixes\nThanks for using AniMount products\n Alex<3", "About");
		}

		private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to Tic Tac Toe by Alex\n\n\nRULES FOR TIC-TAC-TOE\n1.The game is played on a grid that's 3 squares by 3 squares.\n2.You are X, your friend(or the computer in this case) is O.Players take turns putting their marks in empty squares.\n3.The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner.\n4.When all 9 squares are full, the game is over.If no player has 3 marks in a row, the game ends in a tie.\nCan you win? Yes, but you can try your best\n Good luck!", "Help");
		}

		private void button_click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (turn)
				b.Text = "x";
			else
				b.Text = "o";

			turn = !turn;
			b.Enabled = false;

			turn_count++;

			winnercheck();

			if ((!turn) && (uservspc))
			{
				pc_choice();
			}//logic of our pc making choises playing against us

		}//buttonclick

		/// <logic user vs pc mode>
		
		private void pc_choice()
		{
			
				//priority 1:  get tick tac toe
				//priority 2:  block x tic tac toe
				//priority 3:  go for corner space
				//priority 4:  pick open space

				Button move = null;

				//look for tic tac toe opportunities
				move = look_for_win_or_block("o"); //look for win
				if (move == null)
				{
					move = look_for_win_or_block("x"); //look for block
					if (move == null)
					{
						move = look_for_corner();
						if (move == null)
						{
							move = look_for_open_space();
						}//end if
					}//end if
				}//end if

				move.PerformClick();
			}

			private Button look_for_open_space()
			{
				Console.WriteLine("Looking for open space");
				Button b = null;
				foreach (Control c in Controls)
				{
					b = c as Button;
					if (b != null)
					{
						if (b.Text == "")
							return b;
					}//end if
				}//end if

				return null;
			}

			private Button look_for_corner()
			{
				Console.WriteLine("Looking for corner");
				if (T1.Text == "o")
				{
					if (T3.Text == "")
						return T3;
					if (L3.Text == "")
						return L3;
					if (L1.Text == "")
						return L1;
				}

				if (T3.Text == "o")
				{
					if (T1.Text == "")
						return T1;
					if (L3.Text == "")
						return L3;
					if (L1.Text == "")
						return L1;
				}

				if (L3.Text == "o")
				{
					if (T1.Text == "")
						return T3;
					if (T3.Text == "")
						return T3;
					if (L1.Text == "")
						return L1;
				}

				if (L1.Text == "o")
				{
					if (T1.Text == "")
						return T3;
					if (T3.Text == "")
						return T3;
					if (L3.Text == "")
						return L3;
				}

				if (T1.Text == "")
					return T1;
				if (T3.Text == "")
					return T3;
				if (L1.Text == "")
					return L1;
				if (L3.Text == "")
					return L3;

				return null;
			}

			private Button look_for_win_or_block(string mark)
			{
				Console.WriteLine("Looking for win or block:  " + mark);
				//HORIZONTAL TESTS
				if ((T1.Text == mark) && (T2.Text == mark) && (T3.Text == ""))
					return T3;
				if ((T2.Text == mark) && (T3.Text == mark) && (T1.Text == ""))
					return T1;
				if ((T1.Text == mark) && (T3.Text == mark) && (T2.Text == ""))
					return T2;

				if ((M1.Text == mark) && (M2.Text == mark) && (M3.Text == ""))
					return M3;
				if ((M2.Text == mark) && (M3.Text == mark) && (M1.Text == ""))
					return M1;
				if ((M1.Text == mark) && (M3.Text == mark) && (M2.Text == ""))
					return M2;

				if ((L1.Text == mark) && (L2.Text == mark) && (L3.Text == ""))
					return L3;
				if ((L2.Text == mark) && (L3.Text == mark) && (L1.Text == ""))
					return L1;
				if ((L1.Text == mark) && (L3.Text == mark) && (L2.Text == ""))
					return L2;

				//VERTICAL TESTS
				if ((T1.Text == mark) && (M1.Text == mark) && (L1.Text == ""))
					return L1;
				if ((M1.Text == mark) && (L1.Text == mark) && (T1.Text == ""))
					return T1;
				if ((T1.Text == mark) && (L1.Text == mark) && (M1.Text == ""))
					return M1;

				if ((T2.Text == mark) && (M2.Text == mark) && (L2.Text == ""))
					return L2;
				if ((M2.Text == mark) && (L2.Text == mark) && (T2.Text == ""))
					return T2;
				if ((T2.Text == mark) && (L2.Text == mark) && (M2.Text == ""))
					return M2;

				if ((T3.Text == mark) && (M3.Text == mark) && (L3.Text == ""))
					return L3;
				if ((M3.Text == mark) && (L3.Text == mark) && (T3.Text == ""))
					return T3;
				if ((T3.Text == mark) && (L3.Text == mark) && (M3.Text == ""))
					return M3;

				//DIAGONAL TESTS
				if ((T1.Text == mark) && (M2.Text == mark) && (L3.Text == ""))
					return L3;
				if ((M2.Text == mark) && (L3.Text == mark) && (T1.Text == ""))
					return T1;
				if ((T1.Text == mark) && (L3.Text == mark) && (M2.Text == ""))
					return M2;

				if ((T3.Text == mark) && (M2.Text == mark) && (L1.Text == ""))
					return L1;
				if ((M2.Text == mark) && (L1.Text == mark) && (T3.Text == ""))
					return T3;
				if ((T3.Text == mark) && (L1.Text == mark) && (M2.Text == ""))
					return M2;

				return null;
			
		}

		/// </logic user vs pc mode>

		private void winnercheck ()
		{
			bool player_win = false;

			// horizontal
			if ((T1.Text == T2.Text) && (T2.Text == T3.Text) && (!T1.Enabled))
				player_win = true;
			else if ((M1.Text == M2.Text) && (M2.Text == M3.Text) && (!M1.Enabled))
				player_win = true;
			else if ((L1.Text == L2.Text) && (L2.Text == L3.Text) && (!L1.Enabled))
				player_win = true;
			// vertical
			else if ((T1.Text == M1.Text) && (M1.Text == L1.Text) && (!T1.Enabled))
				player_win = true;
			else if ((T2.Text == M2.Text) && (M2.Text == L2.Text) && (!M2.Enabled))
				player_win = true;
			else if ((T3.Text == M3.Text) && (M3.Text == L3.Text) && (!L3.Enabled))
				player_win = true;
			// cross
			else if ((T1.Text == M2.Text) && (M2.Text == L3.Text) && (!T1.Enabled))
				player_win = true;
			else if ((L1.Text == M2.Text) && (M2.Text == T3.Text) && (!L1.Enabled))
				player_win = true;
			if (player_win)
			{
				disablebuttons();

				String winner = "";
				if (turn)
					winner = "o";
				else
					winner = "x";

				MessageBox.Show(winner + " Wins!", "Congratulations!");
				Autostart();
			}//ifwinner
			else if (turn_count == 9)
			{
				MessageBox.Show("Draw","Unfortunatly");
				Autostart();
			}
		}//winnercheck
		private void disablebuttons()
		{
			try
			{
				foreach (Control c in Controls)
				{
					Button b = (Button)c;
					b.Enabled = false;
				}//foreach
			}
			catch { }
		}//disablebuttons

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			turn = true;
			turn_count = 0;
			try
			{
				foreach (Control c in Controls)
				{
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
				}//foreach2
			}
			catch { }
		}

		private void mouse_enter(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (b.Enabled)
			{
				if (turn)
					b.Text = "x";
				else
					b.Text = "o";
			}//enable button
		}

		private void mouse_leave(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (b.Enabled)
			{
				b.Text = "";
			}//enable button2
		}

		private void Autostart()// Add after every messagebox Win/Draw.
		{
			disablebuttons(); 
			turn = true;
			turn_count = 0;
			try
			{
				foreach (Control c in Controls)
				{
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
				}//foreach2
			}
			catch { }
		}//Autostart


		private void mode_user_vs_pc(object sender, EventArgs e)
		{
			Autostart();
			uservspc = true;
			MessageBox.Show("Before you start\nHere's some information you used know\n 1. You start first\n 2. You can win\n 3. Enjoy the game!","Welcome to User vs Pc mode");
			
		}//user vs pc

		private void mode_user_vs_user(object sender, EventArgs e)
		{
			Autostart();
			uservspc = false;
			MessageBox.Show("Old sweet user vs user.\n Enjoy the game!", "Welcome to User vs User mode");
		}//user vs user 

		
	}//Form1
}//tictactoe

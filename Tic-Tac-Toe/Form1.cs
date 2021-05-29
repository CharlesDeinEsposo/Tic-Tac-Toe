using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            PlayerO.BackColor = Color.Gray;
            PlayerX.BackColor = Color.Orange;
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            if (turn)
            {
                PlayerO.BackColor = Color.Orange;
                PlayerX.BackColor = Color.Gray;
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            winner_checker();
        }
        private void winner_checker()
        {
            bool player_wins = false;

            //Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                player_wins = true;
                A1.BackColor = Color.Orange;
                A2.BackColor = Color.Orange;
                A3.BackColor = Color.Orange;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                player_wins = true;
                B1.BackColor = Color.Orange;
                B2.BackColor = Color.Orange;
                B3.BackColor = Color.Orange;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                player_wins = true;
                C1.BackColor = Color.Orange;
                C2.BackColor = Color.Orange;
                C3.BackColor = Color.Orange;
            }

            //Vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                player_wins = true;
                A1.BackColor = Color.Orange;
                B1.BackColor = Color.Orange;
                C1.BackColor = Color.Orange;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                player_wins = true;
                A2.BackColor = Color.Orange;
                B2.BackColor = Color.Orange;
                C2.BackColor = Color.Orange;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                player_wins = true;
                A3.BackColor = Color.Orange;
                B3.BackColor = Color.Orange;
                C3.BackColor = Color.Orange;
            }

            //Diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                player_wins = true;
                A1.BackColor = Color.Orange;
                B2.BackColor = Color.Orange;
                C3.BackColor = Color.Orange;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                player_wins = true;
                A3.BackColor = Color.Orange;
                B2.BackColor = Color.Orange;
                C1.BackColor = Color.Orange;
            }


            if (player_wins)
            {
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("Player " + winner + " wins!");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw");
            }
        }


        private void quitgame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            try
            {
                turn_count = 0;
                turn = true;

                PlayerO.BackColor = Color.Gray;
                PlayerX.BackColor = Color.Orange;

                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;

                A1.BackColor = Color.Gray;
                A2.BackColor = Color.Gray;
                A3.BackColor = Color.Gray;
                B1.BackColor = Color.Gray;
                B2.BackColor = Color.Gray;
                B3.BackColor = Color.Gray;
                C1.BackColor = Color.Gray;
                C2.BackColor = Color.Gray;
                C3.BackColor = Color.Gray;

                A1.Text = "";
                A2.Text = "";
                A3.Text = "";
                B1.Text = "";
                B2.Text = "";
                B3.Text = "";
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
            }
            catch { }
        }
            
        }
    }

          
 

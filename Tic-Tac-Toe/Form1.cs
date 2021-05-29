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
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                PlayerO.BackColor = Color.Orange;
                PlayerX.BackColor = Color.Gray;
            }
            else
            {
                b.Text = "O";
                PlayerX.BackColor = Color.Orange;
                PlayerO.BackColor = Color.Gray;
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
                disableButtons();
                
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
        private void disableButtons()
        {
            try {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
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

                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;

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

          
 

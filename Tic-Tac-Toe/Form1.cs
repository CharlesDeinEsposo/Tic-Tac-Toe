﻿using System;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            winner_checker();
        }
        private void winner_checker()
        {
            bool player_wins = false;
            //Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text))
                player_wins = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text))
                player_wins = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text))
                player_wins = true;

            //Vertical
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                player_wins = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text))
                player_wins = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text))
                player_wins = true;

            //Diagonal
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text))
                player_wins = true;
            if ((C1.Text == B2.Text) && (B2.Text == A3.Text))
                player_wins = true;


        }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xochilt
{
    public partial class Form1 : Form
    {
        int turnCount = 0;
        string player1 = "";
        string player2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckIfWinner()
        {
            string winner = "";
            
            if (btn_one.Text == btn_two.Text && btn_two.Text == btn_three.Text && btn_three.Text != "")
            {
                winner = btn_one.Text;
                Winner(winner);
            }
            else if (btn_four.Text == btn_five.Text && btn_five.Text == btn_six.Text && btn_six.Text != "")
            {
                winner = btn_four.Text;
                Winner(winner);
            }
            else if (btn_seven.Text == btn_eight.Text && btn_eight.Text == btn_nine.Text && btn_nine.Text != "")
            {
                winner = btn_seven.Text;
                Winner(winner);
            }
            else if (btn_one.Text == btn_four.Text && btn_four.Text == btn_seven.Text && btn_seven.Text != "")
            {
                winner = btn_one.Text;
                Winner(winner);
            }
            else if (btn_two.Text == btn_five.Text && btn_five.Text == btn_eight.Text && btn_eight.Text != "")
            {
                winner = btn_two.Text;
                Winner(winner);
            }
            else if (btn_three.Text == btn_six.Text && btn_six.Text == btn_nine.Text && btn_nine.Text != "")
            {
                winner = btn_three.Text;
                Winner(winner);
            }
            else if (btn_one.Text == btn_five.Text && btn_five.Text == btn_nine.Text && btn_nine.Text != "")
            {
                winner = btn_one.Text;
                Winner(winner);
            }
            else if (btn_three.Text == btn_five.Text && btn_five.Text == btn_seven.Text && btn_seven.Text != "")
            {
                winner = btn_three.Text;
                Winner(winner);
            }
            
        }

        private void Winner(string winner)
        {
            if (winner == player1)
            {
                MessageBox.Show("Player 1 wins");
            }
            else
            {
                MessageBox.Show("Player 2 wins");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_one.Text = "";
            btn_two.Text = "";
            btn_three.Text = "";
            btn_four.Text = "";
            btn_five.Text = "";
            btn_six.Text = "";
            btn_seven.Text = "";
            btn_eight.Text = "";
            btn_nine.Text = "";
            btn_one.Enabled = true;
            btn_two.Enabled = true;
            btn_three.Enabled = true;
            btn_four.Enabled = true;
            btn_five.Enabled = true;
            btn_six.Enabled = true;
            btn_seven.Enabled = true;
            btn_eight.Enabled = true;
            btn_nine.Enabled = true;
            turnCount = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (turnCount % 2 == 0)
            {
                b.Text = player1;
            }
            else
            {
                b.Text = player2;
            }
                turnCount++;
                b.Enabled = false;
            CheckIfWinner();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txb_Player1.Text != "" && txb_Player2.Text != "")
            {
                player1 = txb_Player1.Text;
                player2 = txb_Player2.Text;
                tabControl.SelectedTab = tab_Play;
                MessageBox.Show("Player 1 starts");
            }
            else
            {
                MessageBox.Show("Please enter a character for each player", "Characters not selected");
            }
        }
    }
}

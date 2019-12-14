using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsScoreKeeper
{
    public partial class Form1 : Form
    {
        bool newScoreApplied = false;
        DartBoard dartBoard = new DartBoard();
        public Form1()
        {
            InitializeComponent();
            dartBoard.ScoreChanged += DartBoard_ScoreChanged;
            reset();
        }

        private void DartBoard_ScoreChanged(object sender, ScoreChangedEventArgs args)
        {
            textCurrentScore.Text = "";
            textScore1.Text = dartBoard.ScorePlayer1.ToString();
            textScore2.Text = dartBoard.ScorePlayer2.ToString();
        }

        private void radioPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            dartP1.Visible = true;
            dartP2.Visible = false;
        }

        private void radioPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            dartP1.Visible = false;
            dartP2.Visible = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            radioPlayer1.Checked = true;
            textCurrentScore.Text = "";
            dartBoard.reset();
        }

        private void textCurrentScore_TextChanged(object sender, EventArgs e)
        {
            newScoreApplied = false;
        }

        private void textCurrentScore_Leave(object sender, EventArgs e)
        {
            updateScores();
        }

        private void textCurrentScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                updateScores();
            }
        }

        private void updateScores()
        {
            if (newScoreApplied)
                return;

            int score = 0;
            if (!int.TryParse(textCurrentScore.Text, out score))
                return;

            dartBoard.applyScore(score, getPlayer());

            newScoreApplied = true;

            if (radioPlayer1.Checked)
                radioPlayer2.Checked = true;
            else if (radioPlayer2.Checked)
                radioPlayer1.Checked = true;
        }

        private DartBoard.Player getPlayer()
        {
            if (radioPlayer1.Checked)
                return DartBoard.Player.PlayerOne;
            else
                return DartBoard.Player.PlayerTwo;
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            dartBoard.StartValue = 301;
            reset();
        }
    }
}

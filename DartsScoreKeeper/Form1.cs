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

        private static System.Timers.Timer musicTimer = new System.Timers.Timer(500.0);
        BackgroundWorker musicPlayerThread = new BackgroundWorker();
        System.Media.SoundPlayer sound;
        string introMusic = @"Resources/startMusic.wav";
        string finishMusic = @"Resources/finishMusic.wav";
        Bitmap celebrate1 = new Bitmap(@"Resources/Celebrate1.jpg");
        Bitmap celebrate2= new Bitmap(@"Resources/Celebrate2.jpg");
        int celebrateToggle = 0;

        private delegate void UpdatePictureCallback(Bitmap bitmap);

        public Form1()
        {
            InitializeComponent();
            musicPlayerThread.DoWork += MusicPlayerThread_DoWork;
            dartBoard.ScoreChanged += DartBoard_ScoreChanged;
            musicTimer.Elapsed += MusicTimer_Elapsed;
            reset();
        }

        private void MusicTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(celebrateToggle == 0)
            {
                setDancingPicture(celebrate1);
                celebrateToggle = 1;
            }
            else
            {
                setDancingPicture(celebrate2);
                celebrateToggle = 0;
            }
        }

        private void setDancingPicture(Bitmap bitmap)
        {
            if(this.InvokeRequired)
            {
                UpdatePictureCallback d = new UpdatePictureCallback(setDancingPicture);
                this.BeginInvoke(d, bitmap);
                return;
            }

            if (bitmap != null)
                pictureBoxCelebrate.Image = bitmap;
            else
                pictureBoxCelebrate.Visible = false;
        }

        private void MusicPlayerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            musicTimer.Start();
            if (sound != null)
                sound.PlaySync();
            musicTimer.Stop();
            setDancingPicture(null);    //Sets picture invisible
        }

        private void DartBoard_ScoreChanged(object sender, ScoreChangedEventArgs args)
        {
            textCurrentScore.Text = "";
            textScore1.Text = dartBoard.getScore(DartBoard.PlayerNum.PlayerOne).ToString();
            textScore2.Text = dartBoard.getScore(DartBoard.PlayerNum.PlayerTwo).ToString();

            float avP1 = dartBoard.getAverage(DartBoard.PlayerNum.PlayerOne);
            labelP1Average.Text = "Average: " + string.Format("{0:0.0#}", avP1);
            float avP2 = dartBoard.getAverage(DartBoard.PlayerNum.PlayerTwo);
            labelP2Average.Text = "Average: " + string.Format("{0:0.0#}", avP2);

            if (dartBoard.winner != DartBoard.PlayerNum.Nobody)
            {
                winningPictureBox.Visible = true;
                playSound(finishMusic);
            }
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
            dartBoard.StartValue = radio301.Checked ? 301 : 501;
            reset();
        }

        private void reset()
        {
            radioPlayer1.Checked = true;
            winningPictureBox.Visible = false;
            textCurrentScore.Text = "";
            dartBoard.reset();

            bool playing301 = dartBoard.StartValue == 301;
            radio301.Checked = playing301;
            radio501.Checked = !playing301;
            playSound(introMusic);
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

        private DartBoard.PlayerNum getPlayer()
        {
            if (radioPlayer1.Checked)
                return DartBoard.PlayerNum.PlayerOne;
            else
                return DartBoard.PlayerNum.PlayerTwo;
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            dartBoard.StartValue = 301;
            reset();
        }

        private void playSound(string path)
        {
            sound = new System.Media.SoundPlayer(path);
            pictureBoxCelebrate.Visible = true;
            if(!musicPlayerThread.IsBusy)
                musicPlayerThread.RunWorkerAsync();
        }

        private void setNewGameRadio()
        {
            if (dartBoard.StartValue == 301)
            {
                radio301.Checked = true;
            }
            else
            {
                radio501.Checked = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsScoreKeeper
{
    class DartBoard
    {
        public enum PlayerNum
        {
            Nobody = -1,
            PlayerOne,
            PlayerTwo
        }

        public delegate void ScoreChangedEventHandler(object sender, ScoreChangedEventArgs args);
        public event ScoreChangedEventHandler ScoreChanged;

        Player player1 = new Player();
        Player player2 = new Player();

        public int StartValue = 501;
        public PlayerNum winner { get; private set; } = PlayerNum.Nobody;

        public void reset()
        {
            player1.reset(StartValue);
            player2.reset(StartValue);
            winner = PlayerNum.Nobody;
            ScoreChanged?.Invoke(this, new ScoreChangedEventArgs());
        }

        public void applyScore(int score, PlayerNum player)
        {
            int currentScore = getScore(player);
            int remaining = currentScore - score;
            if (remaining < 0 || remaining == 1)    //No score
                return;

            if (remaining == 0)     //TODO Should we check if it's a double?
                winner = player;

            if (player == PlayerNum.PlayerOne)
                player1.Score -= score;
            if (player == PlayerNum.PlayerTwo)
                player2.Score -= score;

            ScoreChanged?.Invoke(this, new ScoreChangedEventArgs());
        }

        public int getScore(PlayerNum player)
        {
            if (player == PlayerNum.PlayerOne)
                return player1.Score;
            if (player == PlayerNum.PlayerTwo)
                return player2.Score;
            throw new System.ArgumentException("Invalid player");
        }

        public float getAverage(PlayerNum player)
        {
            if (player == PlayerNum.PlayerOne)
                return player1.Average;
            if (player == PlayerNum.PlayerTwo)
                return player2.Average;
            throw new System.ArgumentException("Invalid player");
        }
    }

    public class ScoreChangedEventArgs : EventArgs
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsScoreKeeper
{
    class Player
    {
        public int Score
        {
            get {return _score; }
            set
            {
                _score = value;
                NumberOfGoes++;
            }
        }
        private int _score;
        public int StartScore { get; set; }
        public int NumberOfGoes { get; set; }
        public float Average 
        { 
            get
            {
                if (NumberOfGoes == 0)
                    return 0.0f;
                return (float)(StartScore - Score) / NumberOfGoes;
            }
        }

        public void reset(int initialScore = 501)
        {
            Score = StartScore = initialScore;
            NumberOfGoes = 0;
        }
    }
}

using System.Collections.Generic;

namespace TennisGame_v1
{
    internal class Game
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private Dictionary<int, string> _scoreDict = new Dictionary<int, string>()
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };


        public string GetScore()
        {
            if (_secondPlayerScore >= 1)
            {
                return "Love_" + _scoreDict[_secondPlayerScore];
            }

            if ( _firstPlayerScore >=1 )
            {
                return _scoreDict[_firstPlayerScore] + "_Love";
            }
     
            return "Love_All";
        }


        public void FirstPlayerGotScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerGotscore()
        {
            _secondPlayerScore++;
        }
    }
}
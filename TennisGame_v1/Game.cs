using System;
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
            var isSameSore = _firstPlayerScore == _secondPlayerScore;

            if (isSameSore)
            {
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }
                else
                {
                    return _scoreDict[_firstPlayerScore] + "_All";
                }
            }
            else
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    var scoreDifferencePlvsP2 = _firstPlayerScore - _secondPlayerScore;

                    if (Math.Abs(scoreDifferencePlvsP2) == 1)
                    {
                        return (scoreDifferencePlvsP2 > 0) ? "Player1_Advance" : "Player2_Advance";
                    }
                    else
                    {
                        return (scoreDifferencePlvsP2 > 0) ? "Player1_Win" : "Player2_Win";
                    }
                }
                return _scoreDict[_firstPlayerScore] + "_" + _scoreDict[_secondPlayerScore];
            }
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
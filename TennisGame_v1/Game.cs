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
            return IsSameScore() 
                ? (IsDeuce() ? Deuce() : SameScore()) 
                : (IsReadyForWin() ? AdvScore() : LookupScore());
        }

        private string AdvScore()
        {
            return AdvPlayer() + (IsAdvance() ? "_Advance" : "_Win");
        }

        private string LookupScore()
        {
            return _scoreDict[_firstPlayerScore] + "_" + _scoreDict[_secondPlayerScore];
        }

        private bool IsAdvance()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string AdvPlayer()
        {
            return _firstPlayerScore > _secondPlayerScore ? "Player1" : "Player2";
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private string SameScore()
        {
            return _scoreDict[_firstPlayerScore] + "_All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
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
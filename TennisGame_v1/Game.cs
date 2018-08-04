namespace TennisGame_v1
{
    internal class Game
    {
        private int _firstPlayerScore;

        public string GetScore()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen_Love";
            }
            return "Love_All";
        }


        public void FirstPlayerGotScore()
        {
            _firstPlayerScore++;
        }
    }
}
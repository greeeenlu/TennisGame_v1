using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_v1
{
    [TestClass]
    public class UnitTest1
    {
        private Game _game = new Game();
        private int _firstPlayerScore;

        [TestMethod]
        public void LoveAll()
        {
            Assert.AreEqual("Love_All", _game.GetScore());
        }
        [TestMethod]
        public void FifteenLove()
        {
            GivenFirstPlayerScore(1);
            Assert.AreEqual("Fifteen_Love", _game.GetScore());
        }
        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            Assert.AreEqual("Thirty_Love", _game.GetScore());
        }

        private void GivenFirstPlayerScore(int score)
        {
            for (int i = 0; i < score; i++)
            {
                _game.FirstPlayerGotScore();
            }
        }
    }
}
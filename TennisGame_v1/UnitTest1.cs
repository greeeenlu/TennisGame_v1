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
            ResultShouldBe("Love_All");
        }

        private void ResultShouldBe(string resllt)
        {
            Assert.AreEqual(resllt, _game.GetScore());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ResultShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ResultShouldBe("Thirty_Love");
        }
        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ResultShouldBe("Forty_Love");
        }
        [TestMethod]
        public void Love_Fifteen()
        {
            GivenSecondPlayerScore(1);
            ResultShouldBe("Love_Fifteen");
        }
        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ResultShouldBe("Love_Thirty");
        }
        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ResultShouldBe("Fifteen_All");
        }
        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
            ResultShouldBe("Deuce");
        }
        [TestMethod]
        public void Player1_Advance()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(3);
            ResultShouldBe("Player1_Advance");
        }

        [TestMethod]
        public void Player2_Advance()
        {
            GivenFirstPlayerScore(5);
            GivenSecondPlayerScore(6);
            ResultShouldBe("Player2_Advance");
        }
        [TestMethod]
        public void Player1_Win()
        {
            GivenFirstPlayerScore(5);
            GivenSecondPlayerScore(3);
            ResultShouldBe("Player1_Win");
        }



        private void GivenSecondPlayerScore(int score)
        {
            for (int i = 0; i < score; i++)
            {
                _game.SecondPlayerGotscore();
            }
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
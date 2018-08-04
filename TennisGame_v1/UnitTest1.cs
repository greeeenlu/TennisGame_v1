using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_v1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoveAll()
        {
            var game = new Game();
            var score = game.GetScore();
            Assert.AreEqual("Love_All", score);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Basket;
using Moq;


namespace TestTdd_Basket
{
    [TestClass]
    public class UnitTest1
    {
        readonly ScoreKeeper scoreKeeper = new();

        [TestMethod]
        public void GetScore_ShouldReturn_000_000_WhenNoGoal()
        {
            Assert.AreEqual(scoreKeeper.GetScore(), "000:000");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_001_000_WhenTeamAScore()
        {
            scoreKeeper.ScoreTeamA1();
            Assert.AreEqual(scoreKeeper.GetScore(), "001:000");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_002_000_WhenTeamAScoreTwice()
        {
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            Assert.AreEqual(scoreKeeper.GetScore(), "002:000");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_003_000_WhenTeamAScore3Times()
        {
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            Assert.AreEqual(scoreKeeper.GetScore(), "003:000");
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Basket;


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

        [TestMethod]
        public void GetScore_ShouldReturn_000_001_WhenTeamBScore()
        {
            scoreKeeper.ScoreTeamB1();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:001");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_000_002_WhenTeamBScoreTwice()
        {
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:002");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_000_000_WhenTeamBScore3Times()
        {
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:003");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_003_003_WhenTeamBAndTeamBScore3Times()
        {
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            Assert.AreEqual(scoreKeeper.GetScore(), "003:003");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_003_003_WhenTeamBAndTeamBScore3TimesDifferently()
        {
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamB1();
            Assert.AreEqual(scoreKeeper.GetScore(), "003:003");
        }
    }
}

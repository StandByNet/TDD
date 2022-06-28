using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Basket;


namespace TestTdd_Basket
{
    [TestClass]
    public class UnitTest1
    {
        readonly ScoreKeeper scoreKeeper = new();

        #region Test Score One Point
        #region For TeamA
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

        #endregion
        #region For TeamB

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
        #endregion
        #endregion
        #region Test Score Two Points
        #region For TeamA
        [TestMethod]
        public void GetScore_ShouldReturn_002_000_WhenTeamAScore2Points()
        {
            scoreKeeper.ScoreTeamA2();
            Assert.AreEqual(scoreKeeper.GetScore(), "002:000");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_004_000_WhenTeamAScoreTwice2Points()
        {
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA2();
            Assert.AreEqual(scoreKeeper.GetScore(), "004:000");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_006_000_WhenTeamAScore3Times2Points()
        {
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA2();
            Assert.AreEqual(scoreKeeper.GetScore(), "006:000");
        }
        #endregion
        #region For TeamB
        [TestMethod]
        public void GetScore_ShouldReturn_000_002_WhenTeamBScore2Points()
        {
            scoreKeeper.ScoreTeamB2();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:002");
        }

        [TestMethod]
        public void GetScore_ShouldReturn_000_004_WhenTeamBScoreTwice2Points()
        {
            scoreKeeper.ScoreTeamB2();
            scoreKeeper.ScoreTeamB2();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:004");
        }
        #endregion
        #endregion
        #region Test Score Three POINTS
        #region TeamA
        [TestMethod]
        public void GetScore_ShouldReturn003_000_WhenTeamAScore3Points()
        {
            scoreKeeper.ScoreTeamA3();
            Assert.AreEqual("003:000", scoreKeeper.GetScore());
        }

        [TestMethod]
        public void GetScore_ShouldReturn009_000_WhenTeamAScore3times3Points()
        {
            scoreKeeper.ScoreTeamA3();
            scoreKeeper.ScoreTeamA3();
            scoreKeeper.ScoreTeamA3();
            Assert.AreEqual("009:000", scoreKeeper.GetScore());
        }

        #endregion
        #region TeamB
        [TestMethod]
        public void GetScore_ShouldReturn000_003_WhenTeamBScore3Points()
        {
            scoreKeeper.ScoreTeamB3();
            Assert.AreEqual("000:003", scoreKeeper.GetScore());
        }
        #endregion
        #endregion
        #region TEST score Differently
        [TestMethod]
        public void GetScore_ShouldReturn011_010_WhenTeamAAndTeamBScoreLot()
        {
            scoreKeeper.ScoreTeamA1();
            scoreKeeper.ScoreTeamA3();
            scoreKeeper.ScoreTeamB3();
            scoreKeeper.ScoreTeamB2();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB1();
            scoreKeeper.ScoreTeamB3();
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA2();
            scoreKeeper.ScoreTeamA3();
            Assert.AreEqual("011:010",scoreKeeper.GetScore());
        }
        #endregion
    }
}

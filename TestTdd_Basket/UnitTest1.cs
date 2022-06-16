using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Basket;

namespace TestTdd_Basket
{
    [TestClass]
    public class UnitTest1
    {
        readonly ScoreKeeper scoreKeeper = new();

        [TestMethod]
        public void GetScore_return000_000_when_ScoreBegining()
        {
            Assert.AreEqual("000:000", scoreKeeper.GetScore());
        }

        [TestMethod]
        public void GetScore_return001_000_when_TeamAGetOneGool()
        {
            Assert.AreEqual("000:000", scoreKeeper.GetScore());
            Assert.AreEqual("001:000", scoreKeeper.GetScore());
            Assert.AreEqual("002:000", scoreKeeper.GetScore());
            Assert.AreEqual("003:000", scoreKeeper.GetScore());
        }
    }
}

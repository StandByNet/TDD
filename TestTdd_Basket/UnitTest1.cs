using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd_Basket;
using Moq;


namespace TestTdd_Basket
{
    [TestClass]
    public class UnitTest1
    {
        readonly ScoreKeeper scoreKeeper = new();
       // private readonly Mock<ScoreKeeper> mockRepo = new Mock<ScoreKeeper>();
       
        [TestMethod]
        public void GetScore_return00x_000_when_TeamAGetOneGool()
        {            
            Assert.AreEqual("000:000", scoreKeeper.GetScore());
            Assert.AreEqual("001:000", scoreKeeper.GetScore());
            Assert.AreEqual("002:000", scoreKeeper.GetScore());
            Assert.AreEqual("003:000", scoreKeeper.GetScore());
        }

        [TestMethod]
        public void GetScore_return000_00x_when_TeamBGetOneGool()
        {
            Assert.AreEqual("000:000", scoreKeeper.GetScore());
            Assert.AreEqual("000:001", scoreKeeper.GetScore());
            Assert.AreEqual("000:002", scoreKeeper.GetScore());
            Assert.AreEqual("000:003", scoreKeeper.GetScore());
           // Assert.AreEqual("000:004", scoreKeeper.GetScore());
        }

        [TestMethod]
        public void GetScore_return00x_00x_when_TeamBGetOneGool()
        {
            Assert.AreEqual("000:001", scoreKeeper.GetScore());
            Assert.AreEqual("001:002", scoreKeeper.GetScore());
            Assert.AreEqual("002:003", scoreKeeper.GetScore());
            Assert.AreEqual("003:004", scoreKeeper.GetScore());
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootBallLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallLib.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _footballPlayer;

        [TestInitialize]
        public void BeforeTest()
        {
            _footballPlayer = new FootballPlayer(1, "Messi", 5000000.23, 30);
        }


        [TestMethod()]
        public void ConstructorTest()
        {
            FootballPlayer fb = new FootballPlayer(1, "Messe", 9235252.523232, 52);

            Assert.AreEqual(1, fb.Id);
            Assert.AreEqual("Messe", fb.Name);
            Assert.AreEqual(9235252.523232, fb.Price);
            Assert.AreEqual(52, fb.ShirtNumber);
        }


        [TestMethod()]
        public void NameTest()
        {
            _footballPlayer.Name = "Messi";
            Assert.AreEqual("Messi", _footballPlayer.Name);
            Assert.ThrowsException<ArgumentException>(() => _footballPlayer.Name = "M");
        }


        [TestMethod()]
        public void TestPrice()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Price = -52);
        }


        [TestMethod()]
        public void TestShirtNumber()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = -30);
            _footballPlayer.ShirtNumber = 1;
            Assert.AreEqual(1, _footballPlayer.ShirtNumber);
            _footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, _footballPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 120);
        }
    }
}
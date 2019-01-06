using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeadAnts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts.Solution
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void DeadAntCountBasicTests()
        {
            Assert.AreEqual(0, Kata.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, Kata.DeadAntCount(null));
            Assert.AreEqual(2, Kata.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, Kata.DeadAntCount("ant ant .... a nt"));
        }
    }
}
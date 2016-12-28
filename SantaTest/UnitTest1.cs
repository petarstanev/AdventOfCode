using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SantaBlocks;


namespace SantaTest
{
    [TestClass]
    public class UnitTest1
    {
        Santa santa = new Santa();


        [TestMethod]
        public void TestR2L3()
        {
            santa.SetUpRoad("R2, L3");
            Assert.AreEqual(santa.BlocksAway(), 5);
        }

        [TestMethod]
        public void TestR2R2R2()
        {
            santa.SetUpRoad("R2, R2, R2");
            Assert.AreEqual(santa.BlocksAway(), 2);
        }

        [TestMethod]
        public void TestR5L5R5R3()
        {
            santa.SetUpRoad("R5, L5, R5, R3");
            Assert.AreEqual(santa.BlocksAway(), 12);
        }

        [TestMethod]
        public void TestFinale()
        {
            santa.SetUpRoad("L4, L1, R4, R1, R1, L3, R5, L5, L2, L3, R2, R1, L4, R5, R4, L2, R1, R3, L5, R1, L3, L2, R5, L4, L5, R1, R2, L1, R5, L3, R2, R2, L1, R5, R2, L1, L1, R2, L1, R1, L2, L2, R4, R3, R2, L3, L188, L3, R2, R54, R1, R1, L2, L4, L3, L2, R3, L1, L1, R3, R5, L1, R5, L1, L1, R2, R4, R4, L5, L4, L1, R2, R4, R5, L2, L3, R5, L5, R1, R5, L2, R4, L2, L1, R4, R3, R4, L4, R3, L4, R78, R2, L3, R188, R2, R3, L2, R2, R3, R1, R5, R1, L1, L1, R4, R2, R1, R5, L1, R4, L4, R2, R5, L2, L5, R4, L3, L2, R1, R1, L5, L4, R1, L5, L1, L5, L1, L4, L3, L5, R4, R5, R2, L5, R5, R5, R4, R2, L1, L2, R3, R5, R5, R5, L2, L1, R4, R3, R1, L4, L2, L3, R2, L3, L5, L2, L2, L1, L2, R5, L2, L2, L3, L1, R1, L4, R2, L4, R3, R5, R3, R4, R1, R5, L3, L5, L5, L3, L2, L1, R3, L4, R3, R2, L1, R3, R1, L2, R4, L3, L3, L3, L1, L2");
            int result = santa.BlocksAway();
            Assert.AreEqual(santa.BlocksAway(), 279);
        }
    }
}

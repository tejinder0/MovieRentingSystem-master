using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentingSystem;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckDBConn()
        {
            Assert.AreEqual("Closed", new Database().CheckConnection());
            Console.WriteLine(new Database().CheckConnection());
            Console.ReadKey();
        }

        [TestMethod]
        public void CheckData()
        {
            Assert.IsNotNull(new Database().GetTopMovies());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BackendCodingChallenge
{
    [TestClass]
    public class CartUnitTest
    {
        [TestMethod]
        public void DictionaryBuild_RolexCount_Test()
        {
            string[] watches = new string[] { "001", "002", "001", "004", "003" };
            var dict = WatchHelper.CalculateWatchCount(watches);
            Assert.Equals(2, dict["001"]);
        }

        [TestMethod]
        public void CalculateDiscountedValue_Rolex_Test1()
        {
            var dict = new Dictionary<string, int>() { { "001", 2 } };
            var rolex = new Rolex(dict);
            Assert.Equals(200, rolex.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_Rolex_Test2()
        {
            var dict = new Dictionary<string, int>() { { "001", 3 } };
            var rolex = new Rolex(dict);
            Assert.Equals(200, rolex.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_Rolex_Test3()
        {
            var dict = new Dictionary<string, int>() { { "001", 6 } };
            var rolex = new Rolex(dict);
            Assert.Equals(400, rolex.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_MichaelKors_Test1()
        {
            var dict = new Dictionary<string, int>() { { "002", 1 } };
            var michaelKors = new MichaelKors(dict);
            Assert.Equals(80, michaelKors.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_MichaelKors_Test2()
        {
            var dict = new Dictionary<string, int>() { { "002", 2 } };
            var michaelKors = new MichaelKors(dict);
            Assert.Equals(120, michaelKors.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_MichaelKors_Test3()
        {
            var dict = new Dictionary<string, int>() { { "002", 3 } };
            var michaelKors = new MichaelKors(dict);
            Assert.Equals(200, michaelKors.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_Swatch_Test()
        {
            var dict = new Dictionary<string, int>() { { "003", 1 } };
            var swatch = new Swatch(dict);
            Assert.Equals(50, swatch.GetValueAfterDiscount());
        }

        [TestMethod]
        public void CalculateDiscountedValue_Casio_Test()
        {
            var dict = new Dictionary<string, int>() { { "004", 3 } };
            var casio = new Casio(dict);
            Assert.Equals(90, casio.GetValueAfterDiscount());
        }
    }
}

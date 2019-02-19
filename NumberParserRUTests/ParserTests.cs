using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using NumberParserRU;

namespace NumberParserRUTests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        public void RulesTest()
        {
            using (var parser = ParserFactory.CreateDefault())
            {
                Assert.AreEqual("тридцати одного", parser.SumProp(31, "М", "Р"));
                Assert.AreEqual("двадцатью двумя", parser.SumProp(22, "С", "Т"));
                Assert.AreEqual("сто пятьдесят четыре тысячи триста двадцать три", parser.SumProp(154323, "М", "И"));
                Assert.AreEqual("ста пятьюдесятью четырьмя тысячами тремястами двадцатью тремя", parser.SumProp(154323, "М", "Т"));


                Assert.AreEqual("ноль", parser.SumProp(0, "М", "В"));
            }

        }
        [TestMethod()]
        public void ZeroTest()
        {
            using (var parser = ParserFactory.CreateDefault())
            {
                Assert.AreEqual("ноль", parser.SumProp(0, "М", "В"));
            }

        }
        [TestMethod()]
        public void NegativeTest()
        {
            using (var parser = ParserFactory.CreateDefault())
            {
                Assert.AreEqual("минус ста пятьюдесятью четырьмя тысячами тремястами двадцатью тремя", parser.SumProp(-154323, "М", "Т"));
            }
        }
    }
}
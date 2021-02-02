using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputToDouble()
        {
            double result = _inputConverter.ConverterToDouble("5.8");
            Assert.AreEqual(5.8, result);
        }

        [TestMethod]
        public void ConvertValidStringInputToInteger()
        {
            double result = _inputConverter.ConverterToInteger("3");
            Assert.AreEqual(3, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {

        private readonly SimpleCalculatorEngine _simpleCalculatorEngine = new SimpleCalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResult()
        {

            double resultAddingWithNonSymbolOperation = _simpleCalculatorEngine.Calculate("Add", 5, 3);
            Assert.AreEqual(8, resultAddingWithNonSymbolOperation);

            double resultAddingWithSymbolOperation = _simpleCalculatorEngine.Calculate("+", 5, 3);
            Assert.AreEqual(8, resultAddingWithSymbolOperation);
        }

        [TestMethod]
        public void SubtractTwoNumbersAndReturnsValidResult()
        {

            double resultSubtractingWithNonSymbolOperation = _simpleCalculatorEngine.Calculate("SUBTRACT", 5, 3);
            Assert.AreEqual(2, resultSubtractingWithNonSymbolOperation);

            double resultSubtractingWithSymbolOperation = _simpleCalculatorEngine.Calculate("-", 5, 3);
            Assert.AreEqual(2, resultSubtractingWithSymbolOperation);
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResult()
        {

            double resultMultiplyingWithNonSymbolOperation = _simpleCalculatorEngine.Calculate("multiply", 5, 3);
            Assert.AreEqual(15, resultMultiplyingWithNonSymbolOperation);

            double resultMultiplyingWithSymbolOperation = _simpleCalculatorEngine.Calculate("*", 5, 3);
            Assert.AreEqual(15, resultMultiplyingWithSymbolOperation);
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResult()
        {
            double resultDividingWithNonSymbolOperation = _simpleCalculatorEngine.Calculate("divide", 15, 3);
            Assert.AreEqual(5, resultDividingWithNonSymbolOperation);

            double resultDividingWithSymbolOperation = _simpleCalculatorEngine.Calculate("/", 15, 3);
            Assert.AreEqual(5, resultDividingWithSymbolOperation);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalculateTwoNumbersWithNonValidOperatorAndReturnsException()
        {
            _simpleCalculatorEngine.Calculate("(", 5, 3);
        }
    }
}

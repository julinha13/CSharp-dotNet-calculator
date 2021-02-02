using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {

            double result;

            switch (argOperation.ToLower())
            {

                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "divide":
                    result = argFirstNumber / argSecondNumber;
                    break;

                default:
                    throw new InvalidOperationException("Specified operation is not recognized");

            }

            return result;
        }
    }
}

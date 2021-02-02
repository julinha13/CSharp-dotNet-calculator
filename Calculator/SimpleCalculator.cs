using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculator
    {

        private double _firstNumber, _secondNumber, _result;
        private string _operation;

        private InputConverter _inputConverter = new InputConverter();
        private SimpleCalculatorEngine _calculatorEngine = new SimpleCalculatorEngine();

        internal void CalculatorStart()
        {
            try
            {
                Console.WriteLine("\n ** Welcome to the simple calculator! **");
                Console.WriteLine("Here you can calculate the four main operations\n");
                Console.WriteLine("Please enter the firts number, in sequence, enter the operation and the second number:");
                Console.WriteLine("Tip! You can either type '+' or 'Add' as operator :");

                _firstNumber = _inputConverter.ConverterToDouble(Console.ReadLine());
                _operation = Console.ReadLine();
                _secondNumber = _inputConverter.ConverterToDouble(Console.ReadLine());

                _result = _calculatorEngine.Calculate(_operation, _firstNumber, _secondNumber);
                Console.WriteLine("He is the result {0}", _result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

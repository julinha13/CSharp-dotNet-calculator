using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StatisticsCalculator
    {
        private string[] _input = new string[] { };
        private List<int> _numbers = new List<int> ();

        private InputConverter _inputConverter = new InputConverter();

        internal void CalculatorStart()
        {
            try
            {
                Console.WriteLine("\n ** Welcome to the Statistics calculator! **");
                Console.WriteLine("Please insert the numbers separated by comma (,) - don't use empty space:");

                _input = Console.ReadLine().Split(',');

                foreach (var number in _input)
                {
                    this._numbers.Add(_inputConverter.ConverterToInteger(number));
                }

                this._CalculateStatistics();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void _CalculateStatistics()
        {

            try
            {
                double sum = 0, avarage = 0, variance = 0, standardDeviation = 0, aux = 0;
                int NumbersCount = this._numbers.Count;

                for (int i = 0; i < NumbersCount; i++)
                {
                    sum += this._numbers[i];
                }

                avarage = Math.Round((sum / NumbersCount), 4);

                for (int i = 0; i < NumbersCount; i++)
                {
                    aux += Math.Pow((this._numbers[i] - avarage), 2);
                }

                variance = Math.Round((aux / (NumbersCount - 1)), 4);
                standardDeviation = Math.Round((Math.Sqrt(aux / NumbersCount)), 4);

                Console.WriteLine("\nResults: ");
                Console.WriteLine("Sum: {0} ", sum);
                Console.WriteLine("Avarage (mean): {0}", avarage);
                Console.WriteLine("Variance: {0}", variance);
                Console.WriteLine("Standard Deviation: {0}", standardDeviation);

            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {

        public double ConverterToDouble(string argTextInput)
        {
            double convertedNumber;
            bool isConverted = double.TryParse(argTextInput, out convertedNumber);

            if (!isConverted)
            {
                throw new ArgumentException(" Error to convert: Expected a numeric value!");
            }
            else
            {
                return convertedNumber;
            }
        }

        public int ConverterToInteger(string argTextInput)
        {
            int convertedNumber;
            bool isConverted = int.TryParse(argTextInput, out convertedNumber);

            if (!isConverted)
            {
                throw new ArgumentException(" Error to convert: Expected a numeric value!");
            }
            else
            {
                return convertedNumber;
            }
        }
    }
}

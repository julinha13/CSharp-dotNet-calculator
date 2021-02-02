using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            InputConverter inputConverter = new InputConverter();

            Console.WriteLine("Hi, there! Welcome to the Simple and Statistics Calculator \n");
            Console.WriteLine("Please, choose what do you want to calculate today:");
            Console.WriteLine("1. Simple calculator\n2. Statics Calculator \n");

            try
            {
                int option = inputConverter.ConverterToInteger(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        SimpleCalculator simpleCalculator = new SimpleCalculator();
                        simpleCalculator.CalculatorStart();
                        break;

                    case 2:
                        StatisticsCalculator statisticsCalculator = new StatisticsCalculator();
                        statisticsCalculator.CalculatorStart();
                        break;

                    default:
                        throw new InvalidOperationException("Invalid calculator option!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

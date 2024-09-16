using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                //InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                if(operation == "+" || operation.ToLower() == "add")
                {
                    Console.WriteLine("The result of the addition of {0} {1} is equal to {2:F2}", firstNumber, secondNumber,result);
                }
                if (operation == "-" || operation.ToLower() == "substract")
                {
                    Console.WriteLine("The result of the substraction of {0} {1} is equal to {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "*" || operation.ToLower() == "multiply")
                {
                    Console.WriteLine("The result of the multuplication of {0} {1} is equal to {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "/" || operation.ToLower() == "divide")
                {
                    Console.WriteLine("The result of the division of {0} {1} is equal to {2:F2}", firstNumber, secondNumber, result);
                }


            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                //hello
                //myturn
                Console.WriteLine(ex.Message);
            }

        }
    }
}

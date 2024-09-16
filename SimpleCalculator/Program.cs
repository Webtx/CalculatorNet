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
                    Console.WriteLine("The result of the addition of "+firstNumber +" and "
                        + secondNumber+ " is "+result);
                }
                if (operation == "-" || operation.ToLower() == "substract")
                {
                    
                }
                else if (operation == "*" || operation.ToLower() == "multiply")
                {
                    
                }
                else if (operation == "/" || operation.ToLower() == "divide")
                {
                    
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

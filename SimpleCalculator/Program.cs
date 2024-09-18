using System;
using System.Net.NetworkInformation;

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

                Console.WriteLine("Please enter a number");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());


                while(!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                     Console.WriteLine("Please enter a valid number");
                     firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
                 

                Console.WriteLine("Please enter a second number");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());


                while (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Please enter a valid number");
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }

                Console.WriteLine("Please enter an operation. The valid " +
                    "operations are: (+,-,*,/ or %) or (add, substract, multiply, divide or modulus");
                string operation = Console.ReadLine();

                while (!operation.Equals("+") || !operation.Equals("-") || !operation.Equals("*") || 
                    !operation.Equals("/") || !operation.Equals("%") || !operation.Equals("add") || 
                    !operation.Equals("substract") ||!operation.Equals("multiply") || !operation.Equals("divide") ||
                    !operation.Equals("modulus"))
                {
                    Console.WriteLine("Please enter a valid operation.The valid operations are:" +
                        " (+,-,*,/ or %) or (add, substract, multiply, divide or modulus");
                    operation = Console.ReadLine();
                }

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                //i do poopy stringbuilder when dll works 

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
                else if (operation == "%" || operation.ToLower() == "modulus")
                {
                    Console.WriteLine("The modulus of {0} {1} is equal to {2:F2}", firstNumber, secondNumber, result);
                }


            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.

                Console.WriteLine(ex.Message);
            }

        }
    }
}

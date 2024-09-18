using System;
using System.Net.NetworkInformation;
using System.Text;
using Engine;

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
                CalculatorEngine1 calculatorEngine = new CalculatorEngine1();

                double firstNumber = GetValidNumber("Please enter a number:");

                
                double secondNumber = GetValidNumber("Please enter a second number:");

                Console.WriteLine("Please enter an operation (+, -, *, /, % or add, subtract, multiply, divide, modulus):");
                



                Console.WriteLine("Please enter an operation. The valid " +
                    "operations are: (+,-,*,/ or %) or (add, subtract, multiply, divide or modulus");
                string operation = Console.ReadLine();

                while (operation != "+" && operation != "-" && operation != "*" &&
                       operation != "/" && operation != "%" &&
                       operation != "add" && operation != "subtract" &&
                       operation != "multiply" && operation != "divide" &&
                       operation != "modulus")
                {
                    Console.WriteLine("Please enter a valid operation.The valid operations are:" +
                        " (+,-,*,/ or %) or (add, subtract, multiply, divide or modulus");
                    operation = Console.ReadLine();
                }

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);



                StringBuilder sb = new StringBuilder();

                if (operation == "+" || operation == "add")
                {
                    sb.AppendFormat("The result of adding {0} and {1} is {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "-" || operation == "subtract")
                {
                    sb.AppendFormat("The result of subtracting {0} from {1} is {2:F2}", secondNumber, firstNumber, result);
                }
                else if (operation == "*" || operation == "multiply")
                {
                    sb.AppendFormat("The result of multiplying {0} and {1} is {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "/" || operation == "divide")
                {
                    sb.AppendFormat("The result of dividing {0} by {1} is {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "%" || operation == "modulus")
                {
                    sb.AppendFormat("The modulus of {0} and {1} is {2:F2}", firstNumber, secondNumber, result);
                }

                // Output result
                Console.WriteLine(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static double GetValidNumber(string prompt)
        {
            double number;
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    number = InputConverter.ConvertInputToNumeric(input);
                    break; 
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a valid number:");
                }
            }
            return number;
        }
    }
}

    

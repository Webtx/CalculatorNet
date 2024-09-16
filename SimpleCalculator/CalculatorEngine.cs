using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            if (argOperation == "-" || argOperation.ToLower() == "substract")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                if (argSecondNumber == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                result = argFirstNumber / argSecondNumber;
            }
            else
            {
                throw new ArgumentException("Invalid operation. Only +, -, *, / are supported");
            }

            return result;
        }
    }
}



return result;
        
        }
    }
}

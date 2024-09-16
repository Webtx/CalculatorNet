using System;

namespace SimpleCalculator
{
    public class InputConverter
    {   
        public static double ConvertInputToNumeric(string argTextInput)
        {
            if (double.TryParse(argTextInput, out double result)) //out can be returned more than one value
            {
                return result;
            }

            else
            {
                throw new ArgumentException("numeric number needed");
            }
        }
    }

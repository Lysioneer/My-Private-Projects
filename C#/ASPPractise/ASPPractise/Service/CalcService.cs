using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPractise.Service
{
    public class CalcService
    {
        public int Operation(int firstNumber, string value, int secondNumber)
        {
            if (value.Equals("+"))
            {
                return firstNumber + secondNumber;
            }
            else if (value.Equals("-"))
            {
                return firstNumber - secondNumber;
            }
            else if (value.Equals("*"))
            {
                return firstNumber * secondNumber;
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
    }
}

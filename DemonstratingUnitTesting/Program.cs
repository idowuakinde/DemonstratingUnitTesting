using System;

namespace DemonstratingUnitTesting
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public double Add(double firstOperand, double secondOperand)
        {
            return (firstOperand + secondOperand);
        }

        public double Subtract(double firstOperand, double secondOperand)
        {
            return (firstOperand - secondOperand);
        }

        public double Divide(double firstOperand, double secondOperand)
        {
            return (firstOperand / secondOperand);
        }

        public double Multiply(double firstOperand, double secondOperand)
        {
            return (firstOperand * secondOperand);
        }
    }
}

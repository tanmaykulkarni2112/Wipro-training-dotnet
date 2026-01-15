using System;
using static ConsoleApp1.Calculator;


// This is the multicast delegate
namespace ConsoleApp1
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
        }

        public delegate double OperationDelegate(double x, double y);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationDelegate op;

            double num1 = 20;
            double num2 = 10;

            op = Calculator.Add;
            Console.WriteLine($"Add: {op(num1, num2)}");

            op = Calculator.Subtract;
            Console.WriteLine($"Subtract: {op(num1, num2)}");

            op = Calculator.Multiply;
            Console.WriteLine($"Multiply: {op(num1, num2)}");

            op = Calculator.Divide;
            Console.WriteLine($"Divide: {op(num1, num2)}");
        }
    }
}

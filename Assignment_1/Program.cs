using System;

namespace SimpleCalculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Simple Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 – Add (+)\n" + 
                              "2 - Subtract (-)\n" + 
                              "3 - Multiply (*)\n" +
                              "4 – Divide (/)\n" +
                              "5 – Power (^)\n");
            
            // Read user input for calculator operation
            int operation = int.Parse(Console.ReadLine());

            // Get the first number from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Get the second number from the user
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the calculation based on the operation
            double result = 0;
            bool validOperation = true;
            string operationSymbol = "";

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition operation selected");
                    result = Add(num1, num2);
                    operationSymbol = "+";
                    break;
                case 2:
                    Console.WriteLine("Subtraction operation selected");
                    result = Subtract(num1, num2);
                    operationSymbol = "-";
                    break;
                case 3:
                    Console.WriteLine("Multiplication operation selected");
                    result = Multiply(num1, num2);
                    operationSymbol = "*";
                    break;
                case 4:
                    Console.WriteLine("Division operation selected");
                    operationSymbol = "/";
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                case 5:
                    Console.WriteLine("Power operation selected");
                    operationSymbol = "^";
                    result = Power(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                    break;
            }

            // Display the result
            if (validOperation)
            {
                Console.WriteLine($"{num1} {operationSymbol} {num2} = {result}");
            }

            // Wait for the user to close the console
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        // Method for addition
        static double Add(double x, double y)
        {
            return x + y;
        }

        // Method for subtraction
        static double Subtract(double x, double y)
        {
            return x - y;
        }

        // Method for multiplication
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        // Method for division
        static double Divide(double x, double y)
        {
            return x / y;
        }

        // Method for power using the multiply method
        static double Power(double x, double y)
        {
            double result = 1;
            for (int i = 0; i < y; i++)
            {
                result = Multiply(result, x);
            }
            return result;
        }
    }
}

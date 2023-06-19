using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_XUnit_Acceptanstestning
{
    public class Calculator
    {
        
        public List<Calculation> calculations;

        public Calculator()
        {
            calculations = new List<Calculation>();
        }
        public void Choose()
        {
            Console.Clear();
            Calculator calculator = new Calculator(); // Create an instance of the Calculator class
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== Calculator App ===");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Show Previous Calculations");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "0")
                {
                    exit = true;
                    continue;
                }

                double result = 0;
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        double[] addNumbers = GetNumbersFromUser();
                        if (addNumbers.Length == 2)
                        {
                            result = Add(addNumbers[0], addNumbers[1]);
                            Console.WriteLine("The result is: " + result);
                        }
                      
                        break;
                    case "2":
                        Console.Clear();
                        double[] subNumbers = GetNumbersFromUser();
                        if (subNumbers.Length == 2)
                        {
                            result = Sub(subNumbers[0], subNumbers[1]);
                            Console.WriteLine("The result is: " + result);
                        }
                        
                        break;
                    case "3":
                        Console.Clear();
                        double[] multiplyNumbers = GetNumbersFromUser();
                        if (multiplyNumbers.Length == 2)
                        {
                            result = Multiplication(multiplyNumbers[0], multiplyNumbers[1]);
                            Console.WriteLine("The result is: " + result);
                        }
                     
                        break;
                    case "4":
                        Console.Clear();
                        double[] divideNumbers = GetNumbersFromUser();
                        if (divideNumbers.Length == 2)
                        {
                            if (divideNumbers[1] != 0)
                            {
                                result = Division(divideNumbers[0], divideNumbers[1]);
                                Console.WriteLine("The result is: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                        }
                        break;
                    case "5":
                        Console.Clear();
                        ShowPreviousCalculations();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            Calculation calculation = new Calculation { Num1 = num1, Num2 = num2, Operator = "+", Result = result };
            calculations.Add(calculation);
            return result;
        }

        public double Sub(double num1, double num2)
        {
            double result = num1 - num2;
            Calculation calculation = new Calculation { Num1 = num1, Num2 = num2, Operator = "-", Result = result };
            calculations.Add(calculation);
            return result;
        }

        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            Calculation calculation = new Calculation { Num1 = num1, Num2 = num2, Operator = "*", Result = result };
            calculations.Add(calculation);
            return result;
        }

        public double Division(double num1, double num2)
        {
            double result;
            if (num2 != 0)
            {
                result = num1 / num2;
                Calculation calculation = new Calculation { Num1 = num1, Num2 = num2, Operator = "/", Result = result };
                calculations.Add(calculation);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                result = 0;
            }
            return result;
        }

        public List<Calculation> ShowPreviousCalculations()
        {
            Console.WriteLine("Previous Calculations:");
            if (calculations.Count == 0)
            {
                Console.WriteLine("No calculations found.");
            }
            else
            {
                foreach (Calculation calculation in calculations)
                {
                    Console.WriteLine(calculation);
                }
            }
            return calculations;
        }
        public double[] GetNumbersFromUser()
        {
            double[] numbers = new double[2];
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out numbers[0]))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else
            {
                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out numbers[1]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            return numbers;
        }
    }
}

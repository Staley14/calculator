using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            int first = ReadInteger("Enter first number: ");
            int second = ReadInteger("Enter second number: ");

            string operation;
            double? result = null;

          
            while (true)
            {
                Console.Write("Choose operation (+, -, *, /, %, = : ");
                operation = Console.ReadLine();
                Console.WriteLine();

                if ("+-*/%=".Contains(operation))
                    break;

                Console.WriteLine("Incorrect Operation Used, please try again");
            }

            if (operation == "=")
            {
                keepRunning = false;
                Console.WriteLine("Program terminated.");
            }
            else
            {
                result = Calculate(first, second, operation);

                if (result != null)
                    Console.WriteLine("Result: " + result);
            }

            Console.WriteLine();
        }
    }

  
    public static int ReadInteger(string message)
    {
        int value;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)){
                continue;
            }
            
            if (int.TryParse(input, out value))
                return value;

            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
    }
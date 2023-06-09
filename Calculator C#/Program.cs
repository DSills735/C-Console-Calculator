﻿class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        
        Console.WriteLine("Welcome to David's C# Console Calculator! \r");
        Console.WriteLine("Console will instuct you to ender numbers. Please enter them in the order you want them calculated.");
        Console.WriteLine("----------------------------------------------------------------------------------------------------\n");

        while (!endApp)
        {
            Calculator calculator = new Calculator();
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            
            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Invalid Input. Please enter a number: ");
                numInput1 = Console.ReadLine();
            }

            
            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Invalid Input. Please Enter a number: ");
                numInput2 = Console.ReadLine();
            }

            
            Console.WriteLine("Choose what operation you would like to do:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string op = Console.ReadLine();

            try
            { 
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); 
        }
        return;
    }
}
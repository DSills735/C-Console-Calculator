class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; 

        switch (op)
        {
            case "a":
                Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Your Result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Your Result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "d":
                while (num2 == 0)
                {
                    Console.WriteLine("Enter a Non-Zero Divisor:  ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));

                break;

        }

    }
}

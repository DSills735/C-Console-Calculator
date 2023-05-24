double num1 = 0; double num2 = 0;

Console.WriteLine("Welcome to David's Console Calculator!");
Console.WriteLine("You will be asked to type in 2 numbers. Please type them in the order you want them calculated.");
Console.WriteLine("-----------------------------------------------------------------------------------------------\n");

Console.WriteLine("Type the first number, then press Enter!");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please type the second number, then press enter!");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please choose the calculation from the following list.");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Type your choice and press enter.");


Console.WriteLine("Press any key to close");
Console.ReadKey();
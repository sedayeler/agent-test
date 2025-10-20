using AgentTest;

Calculator calc = new Calculator();

Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
Console.WriteLine("5 - 3 = " + calc.Subtract(5, 3));
Console.WriteLine("6 * 2 = " + calc.Multiply(6, 2));

try
{
    Console.WriteLine("10 / 2 = " + calc.Divide(10, 2));
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}


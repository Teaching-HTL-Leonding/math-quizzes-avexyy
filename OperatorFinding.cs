Console.Clear();

System.Console.Write("Enter the first operand: ");
double firstOperand = double.Parse(Console.ReadLine()!);

System.Console.Write("Enter the second operand: ");
double secondOperand = double.Parse(Console.ReadLine()!);

System.Console.Write("Enter the result: ");
double result = double.Parse(Console.ReadLine()!);

if (firstOperand + secondOperand == result || secondOperand + firstOperand == result)
{
    System.Console.WriteLine("Operator: Plus ");
}
else if (firstOperand - secondOperand == result || secondOperand - firstOperand == result)
{
    System.Console.WriteLine("Operator: Minus ");
}
else if (firstOperand * secondOperand == result || secondOperand * firstOperand == result)
{
    System.Console.WriteLine("Operator: Multiply ");
}
else if (Math.Round(firstOperand / secondOperand,2) == result || Math.Round(secondOperand / firstOperand,2) == result)
{
    System.Console.WriteLine("Operator: Divide ");
}
else if (firstOperand % secondOperand == result || secondOperand % firstOperand == result)
{
    System.Console.WriteLine("Operator: Modulo ");
}
else if (Math.Pow(firstOperand, secondOperand) == result || Math.Pow(secondOperand, firstOperand) == result)
{
    System.Console.WriteLine("Operator: Exponentiation ");
}
else 
{
    System.Console.WriteLine("Invalid Input!");
}
int startingValue;
int startingValue2;
do
{
    System.Console.Write("Enter a starting value ( > 1): ");
    startingValue = int.Parse(Console.ReadLine()!);

    System.Console.Write("Enter a starting value ( > 1): ");
    startingValue2 = int.Parse(Console.ReadLine()!);

} while (startingValue <= 1 || startingValue2 <= 1);

int counter = 0;

while (!(startingValue == 1))
{
    if (startingValue % 2 == 0)
    {
        startingValue /= 2;
    }
    else
    {
        startingValue *= 3;
        startingValue++;
    }
    counter++;
}

int counter2 = 0;

while (!(startingValue2 == 1))
{
    if (startingValue2 % 2 == 0)
    {
        startingValue2 /= 2;
    }
    else
    {
        startingValue2 *= 3;
        startingValue2++;
    }
    counter2++;
}

if (counter > counter2)
{
    System.Console.WriteLine("The sequence of the first number is longer.");
}
else if(counter2 > counter)
{
    System.Console.WriteLine("The sequence of the second number is longer.");
}
else
{
    System.Console.WriteLine("The sequences have the same length.");
}
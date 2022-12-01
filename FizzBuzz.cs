System.Console.Write("Enter a integer number ( > 0): ");
int n = int.Parse(Console.ReadLine()!);

System.Console.Write("Enter a second integer number ( > 0): ");
int a = int.Parse(Console.ReadLine()!);

System.Console.Write("Enter a third integer number ( > 0): ");
int b = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= n; i++)
{
    if (i % a == 0 && i % b == 0)
    {
        System.Console.Write("FizzBuzz,  ");
    }
    else if (i % a == 0)
    {
        System.Console.Write("Fizz,  ");
    }
    else if (i % b == 0)
    {
        System.Console.Write("Buzz,  ");
    }
    else
    {
        System.Console.Write($"{i},  ");
    }
}
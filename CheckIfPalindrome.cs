System.Console.Write("Enter a positive integer number: ");
int number = int.Parse(Console.ReadLine()!);

int tmp = number;
int reverse = 0;
int count;

while (number != 0)
{
    count = number % 10;
    reverse = reverse * 10 + count;
    number /= 10;
}

if (tmp < 0)
{
    System.Console.WriteLine("Invalid Input!");
}
else if (reverse == tmp)
{
    System.Console.WriteLine($"The number {tmp} is a palindrome.");
}
else
{
    System.Console.WriteLine($"The number {tmp} is not a palindrome.");
}
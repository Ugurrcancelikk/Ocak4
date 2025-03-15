PrintNumbers();
SumUpToNumber();

void PrintNumbers()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}

void SumUpToNumber()
{
    Console.Write("Please enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }

    Console.WriteLine($"The sum of numbers from 1 to {num} is: {sum}");
}
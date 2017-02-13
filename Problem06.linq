<Query Kind="Program" />

void Main()
{
    Console.WriteLine(squareSum(100) - sumOfSquares(100));
}

public int sumOfSquares(int num)
{
    int sum = 0;
    
    for (int i = 1; i <= num; i++)
    {
        sum += i*i;
    }
    
    return sum;
}

public int squareSum(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    
    return sum*sum;
}
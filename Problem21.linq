<Query Kind="Program" />

void Main()
{
    List<int> amicableNums = new List<int>();

    for (int i = 1; i < 10000; i++)
    {
        if (isAmicable(i))
        {
            amicableNums.Add(i);
        }
    }
    
    Console.WriteLine(amicableNums.Distinct().Sum());
}

public bool isAmicable(int num)
{
    int divisorSum1 = 0;
    int divisorSum2 = 0;

    for (int i = 1; i < num; i++)
    {
        if (num % i == 0)
        {
            divisorSum1 += i;
        }
    }

    for (int i = 1; i < divisorSum1; i++)
    {
        if (divisorSum1 % i == 0)
        {
            divisorSum2 += i;
        }
    }

    if (divisorSum1 == divisorSum2)
    {
        return false;
    }
    else
    {
        return num == divisorSum2;
    }
}

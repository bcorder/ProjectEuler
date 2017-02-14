<Query Kind="Program" />

void Main()
{
    long primeSum = 0;
    
    for (int i = 2; i < 2000000; i++)
    {
        if (isPrime(i))
        {
            primeSum += i;
        }
    }
    
    Console.WriteLine(primeSum);
}

public bool isPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}
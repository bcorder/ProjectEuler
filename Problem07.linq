<Query Kind="Program" />

void Main()
{
    getPrimeN(10001).Max().Dump();
}

public List<int> getPrimeN(int num)
{
    List<int> primes = new List<int>();
    int counter = 2;

    while (primes.Count() != num)
    {
        if (isPrime(counter))
        {
            primes.Add(counter);
        }
        
        counter++;
    }
    
    return primes;
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
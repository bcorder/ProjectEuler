<Query Kind="Program" />

void Main()
{
	List<long> primeFactors = new List<long>();
    
    var factors = getFactors(600851475143);

	foreach (var f in factors)
	{
		if (isPrime(f))
		{
            primeFactors.Add(f);
		}
	}
    
    primeFactors.Dump();
    
}


public bool isPrime(long num)
{
	for (long i = 2; i <= num-1; i++)
	{
		if (num % i == 0)
		{
            return false;
		}
	}
    
    return true;
}

public List<long> getFactors(long num)
{
	List<long> factors = new List<long>();
    
	for (long i = 1; i <= Math.Sqrt(num); i++)
	{
		if (num % i == 0)
		{
            factors.Add(i);
		}
	}
    
    return factors;
}


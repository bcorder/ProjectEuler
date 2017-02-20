<Query Kind="Program" />

void Main()
{
    int maxChainSeed = 0;
    int maxChain = 0;

    for (int i = 1; i <= 1000000; i++)
    {
        if (doCollatz(i) > maxChain)
        {
            maxChainSeed = i;
            maxChain = doCollatz(i);
        }
    }
    
    Console.WriteLine("seed: " + maxChainSeed + " - chainLength: " + maxChain);
}

public int doCollatz(long num)
{
    int chainLength = 1;

    while (num != 1)
    {
        if (num % 2 == 0)
        {
            num = num / 2;
            chainLength++;
        }
        else
        {
            num = (3 * num) + 1;
            chainLength++;
        }
    }
    
    return chainLength;
}

<Query Kind="Program" />

void Main()
{

    int numDivisors = 0;
    int triangleNum = 0;

    for (int i = 1; numDivisors < 500; i++)
    {
        triangleNum = getTriangleNum(i);
        numDivisors = getNumDivisors(triangleNum);
    }
    
    Console.WriteLine(triangleNum);
}

public int getTriangleNum(int n)
{
    return (n * (n + 1)) / 2;
}

public int getNumDivisors(int n)
{
    int numDivisors = 0;
    
    for (int i = 1; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            if (i != n / i)
            {
                numDivisors += 2;
            }
            else
            {
                numDivisors++;
            }
        }
    }
    
    return numDivisors;
}
<Query Kind="Program" />

void Main()
{
    int abcProd = 0;
    
    for (int a = 1; a <= 1000; a++)
    {
        for (int b = 1; b <= 1000; b++)
        {
            for (int c = 1; c <= 1000; c++)
            {
                if (isPythag(a, b, c) && (a + b + c) == 1000)
                {
                    abcProd = a * b * c;
                }
            }
        }
    }
    
    Console.WriteLine(abcProd);
}

public bool isPythag(int a, int b, int c)
{
    return ((a * a) + (b * b)) == (c * c);
}

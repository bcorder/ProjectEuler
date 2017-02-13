<Query Kind="Program" />

void Main()
{
    int num = 0;
    bool weDone = true;
    
    while (weDone)
    {
        num++;
        
        for (int i = 1; i <= 20; i++)
        {
            if (num % i != 0) break;
            else if (i == 20) weDone = false;
        }
    }
    
    Console.WriteLine(num);
}

//shit's slow....2.8 seconds

<Query Kind="Program" />

void Main()
{
    int sumOfEven = 0;
    var fibs = getFibList(4000000);

    foreach (var i in fibs)
    {
        if (i % 2 == 0)
        {
            sumOfEven += i;
        }
    }
    
    Console.WriteLine(sumOfEven);
}

public List<int> getFibList(int max)
{
    List<int> fibList = new List<int>() { 1, 2 };
    
    int term1 = 1;
    int term2 = 2;
    int nextFib = 0;

    for (int i = 3; nextFib <= max; i++)
    {
        nextFib = term1 + term2;
        term1 = term2;
        term2 = nextFib;
        
        fibList.Add(nextFib);        
    }
    
    return fibList;
}
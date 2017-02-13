<Query Kind="Program" />

void Main()
{
    Dictionary<intPair, int> palindromicProducts = new Dictionary<intPair, int>();

	for (int i = 999; i >= 100; i--)
	{
		for (int j = 999; j >= 100; j--)
		{
			if (isPalindrome(i * j))
            {
                intPair temp = new intPair(i, j);
                
                palindromicProducts.Add(temp, i * j);
			}
		}
	}
    
    palindromicProducts.OrderBy(p => p.Value).Last().Dump();
    
}



public bool isPalindrome(int num)
{
	char[] charArray = num.ToString().ToCharArray();
    Array.Reverse(charArray);

	return num.ToString() == new string(charArray);
}

//just want to be able to see the pair that creates the answer
public class intPair
{
	int term1 { get; set; }
	int term2 { get; set; }
    
    public intPair(int i, int j)
    {
    	term1 = i;
        term2 = j;
    }
}
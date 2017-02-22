<Query Kind="Program" />

void Main()
{
    List<int> dblPalindromes = new List<int>();
    
    for (int i = 1; i <= 1000000; i++)
    {
        if (isPalindrome(i.ToString()) && isPalindrome(Convert.ToString(i, 2)))
        {
            dblPalindromes.Add(i);
        }
    }
    
    Console.WriteLine(dblPalindromes.Sum());
}

public bool isPalindrome(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);

    return s == new string(charArray);
}


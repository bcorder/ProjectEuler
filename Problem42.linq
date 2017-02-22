<Query Kind="Program" />

void Main()
{
    List<string> words = File.ReadAllText(@"C:\Repos\ProjectEuler\p042_words.txt")
                             .Replace("\"", "")
                             .Split(',')
                             .ToList<string>();
                             
    List<string> triWords = new List<string>();

    foreach (var s in words)
    {
        if (isTriangleNum(getWordValue(s)))
        {
            triWords.Add(s);
        }
    }
    
    Console.WriteLine(triWords.Count());
}

public bool isTriangleNum(int num)
{
    for (int i = 1; i <= num; i++)
    {
        if (num == (.5 * i) * ((i + 1)))
        {
            return true;
        }
    }
    
    return false;
}

public int getWordValue(string s)
{
    char[] characters = s.ToCharArray();

    int charSum = 0;
    foreach (char c in characters)
    {
        charSum += ((int)c) - 64;
    }
    
    return charSum;
}


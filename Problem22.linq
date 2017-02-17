<Query Kind="Program" />

void Main()
{    
    List<string> names = File.ReadAllText(@"C:\Repos\ProjectEuler\p022_names.txt")
                             .Replace("\"", "")
                             .Split(',')
                             .ToList<string>();
    
    names.Sort();

    int nameScoreSum = 0;

    for (int i = 0; i <= names.Count() - 1; i++)
    {
        char[] characters = names.ElementAt(i).ToCharArray();
        
        int charSum = 0;
        foreach (char c in characters)
        {
            charSum += ((int)c) - 64;
        }
        
        nameScoreSum += ((i + 1) * charSum);
    }
    
    Console.WriteLine(nameScoreSum);
}


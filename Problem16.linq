<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
    var bigNum = new BigInteger(Math.Pow(2, 1000));
    var chars = bigNum.ToString().ToCharArray();

    int sumOfDigits = 0;
    foreach (var c in chars)
    {
        sumOfDigits += Int32.Parse(c.ToString());
    }
    
    Console.WriteLine(sumOfDigits);
}

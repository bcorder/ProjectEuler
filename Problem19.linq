<Query Kind="Program" />

void Main()
{
    DateTime day = new DateTime(1901, 1, 1);
    int numSundays = 0;

    while (day <= DateTime.Parse("12/31/2000"))
    {
        if (day.DayOfWeek.ToString() == "Sunday" && day.Date.ToString().Contains("/1/"))
        {
            numSundays++;
        }
        day = day.AddDays(1);
    }
    
    Console.WriteLine(numSundays);
}

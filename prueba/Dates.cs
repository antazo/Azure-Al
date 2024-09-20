using System.Runtime.Serialization;
using Microsoft.VisualBasic;

public class Dates
{
    public static string GenerateDates()
    {
        Console.WriteLine("Dates and Times");
        Console.WriteLine("---------------");

        Console.WriteLine("DateTime.Today: " + DateTime.Today);
        Console.WriteLine("DateTime.Now: " + DateTime.Now);
        Console.WriteLine("DateTime.UtcNow: " + DateTime.UtcNow);
        Console.WriteLine("DateTime.IsLeapYear(1980): " + DateTime.IsLeapYear(1980));
        Console.WriteLine("DateAndTime.Year(DateTime.Today): " + DateAndTime.Year(DateTime.Today));
        Console.WriteLine("DateTime.IsLeapYear(DateAndTime.Year(DateTime.Today)): " + DateTime.IsLeapYear(DateAndTime.Year(DateTime.Today)));
        Console.WriteLine("DateTime.Today.AddDays(2): " + DateTime.Today.AddDays(2));

        return $@"";
    }
}
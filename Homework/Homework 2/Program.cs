using System;

internal class Programm
{

    public enum Month
    {
        January = 1, February, March, April,
        May, June, July, August, September,
        October, November, December
    }

    static void Main(string[] args)
    {
        Month month = (Month)DateTime.Today.Month;
        Console.WriteLine(month); // Название текущего месяца
    }
}
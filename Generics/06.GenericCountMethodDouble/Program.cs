using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var elements = new List<double>();

        var elementsCount = double.Parse(Console.ReadLine());
        for (int i = 0; i < elementsCount; i++)
        {
            elements.Add(double.Parse(Console.ReadLine()));
        }

        var valueToCompareWith = double.Parse(Console.ReadLine());

        var result = CountGreaterThanValue(elements, valueToCompareWith);

        Console.WriteLine(result);
    }

    public static int CountGreaterThanValue<T>(List<T> elements, T value)
        where T : IComparable<T>
    {
        int counter = 0;

        foreach (var element in elements)
        {
            if (element.CompareTo(value) > 0)
            {
                counter++;
            }
        }

        return counter;
    }
}
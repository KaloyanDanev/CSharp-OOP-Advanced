using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var boxes = new List<Box<int>>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var box = new Box<int>(int.Parse(input));
            boxes.Add(box);
        }
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var positionOne = indexes[0];
        var positionTwo = indexes[1];

        SwapElements(boxes, positionOne, positionTwo);

        boxes.ForEach(b => Console.WriteLine(b));
    }
    static void SwapElements<T>(List<T> boxes, int positionOne, int positionTwo)
    {
        var temp = boxes[positionOne];
        boxes[positionOne] = boxes[positionTwo];
        boxes[positionTwo] = temp;
    }
}

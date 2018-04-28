using System;

class Program
{
    static void Main(string[] args)
    {
        var boxes = int.Parse(Console.ReadLine());
        for (int i = 0; i < boxes; i++)
        {
            var input = int.Parse(Console.ReadLine());
            var box = new Box<int>(input);
            Console.WriteLine(box);
        }
    }
}

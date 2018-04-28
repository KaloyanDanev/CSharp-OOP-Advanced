using System;
using System.Linq;
using P03_DependencyInversion;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new PrimitiveCalculator();
        while (true)
        {
            var input = Console.ReadLine().Split();
            if (input[0] == "End") break;

            if (input[0] == "mode")
            {
                var strategy = input[1][0];
                calculator.changeStrategy(strategy);

                input = Console.ReadLine().Split();
            }

            var operands = input.Select(int.Parse).ToArray();
            var result = calculator.performCalculation(operands[0], operands[1]);
            Console.WriteLine(result);
        }
    }
    }
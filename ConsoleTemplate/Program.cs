using Math = MathLib.Math;
namespace ConsoleTemplate;

/// <summary>
/// This is the main entrypoint of a console application that uses the class library for functionality.
/// It prints out a sequence of numbers following the Fibonacci sequence.
/// </summary>
public static class Program
{
    public static void Main()
    {
        var previousNumber = 0;
        var currentNumber = 1;
        for (var i = 0; i < 20; i++)
        {
            var result = Math.Add(currentNumber, previousNumber);
            previousNumber = currentNumber;
            currentNumber = result;
            Console.WriteLine($"Fibonacci: { result }");
        }
    }
}

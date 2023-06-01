// See https://aka.ms/new-console-template for more information
using Math = MathLib.Math;
namespace ConsoleTemplate;

// The code should be microbenchmarked
// Documentation should be compiled and output
// It should release?

/// <summary>
/// This is the main entrypoint of a console application that uses the class library for functionality.
/// </summary>
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Adding 5 + 3: { Math.Add(5, 3)}");
    }
}

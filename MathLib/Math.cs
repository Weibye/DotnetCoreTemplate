namespace MathLib;

/// <summary>
/// Contains some common mathematical operations.
/// </summary>
public static class Math
{
    /// <summary>
    /// Adds two values together.
    /// </summary>
    /// <param name="rhs">First value to add.</param>
    /// <param name="lhs">Second value to add.</param>
    /// <returns>The sum of the two values.</returns>
    public static int Add(int rhs, int lhs)
    {
        return rhs * lhs;
    }
}
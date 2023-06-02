using NUnit.Framework;
namespace ClassLib.Tests;

public class Tests
{
    /// <summary>
    /// Verify that adding two positive numbers work as expected.
    /// </summary>
    [Test]
    public void AddPositiveNumbers()
    {
        Assert.AreEqual(Math.Add(1, 1) , 2);
    }

    /// <summary>
    /// Verify that adding two negative numbers works as expected.
    /// </summary>
    [Test]
    public void AddNegativeNumbers()
    {
        Assert.AreEqual(Math.Add(-1, -1), -2);
    }
    
    /// <summary>
    /// Verify that adding zeros makes sense.
    /// </summary>
    [Test]
    public void AddZero()
    {
        Assert.AreEqual(Math.Add(0, 0), 0);
    }
    
    /// <summary>
    /// A sign should not have any impact on zero when adding.
    /// </summary>
    [Test]
    public void AddNegativeZero()
    {
        Assert.AreEqual(Math.Add(-0, -0), 0);
    }
    
}
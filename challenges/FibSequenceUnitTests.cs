using NUnit.Framework;

[TestFixture]
public class FibSequenceTests
{
    [Test]
    public void TestFibSequence_Positive()
    {
        int result = FibSequence.fib(5);
        Assert.AreEqual(5, result);
    }

}
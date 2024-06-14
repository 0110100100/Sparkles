using NUnit.Framework;

[TestFixture]
public class SparklersTest
{
    private Program _program;

    [SetUp]
    public void Setup()
    {
        _program = new Program();
    }

    [Test]
    [TestCase(10, 5, 28)]
    [TestCase(1, 2, 2)]
    [TestCase(10, 2, 20)] 
    [TestCase(0, 3, 0)]
    [TestCase(6, 3, 24)]
    public void CalculateTotalHours_WhenCalled_ReturnsExpectedResult(int c1, int b1, int expectedHours)
    {
        int result = _program.CalculateTotalHours(c1, b1);

        Assert.That(result, Is.EqualTo(expectedHours));
    }
}
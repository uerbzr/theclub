using workshop.calculator;

namespace workshop.tests;

public class Tests
{

    [Test]
    public void TestTwoAddOneEqualsThree()
    {
        Calculator calculator = new Calculator();

        int a = 1;
        int b = 2;

        int result = calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(3));
    }
    [TestCase(2,2,4)]
    [TestCase(12, 2, 14)]
    [TestCase(20, 2, 22)]
    [TestCase(1, 2, 3)]
    [TestCase(2, 2, 4)]
    public void TestTwoAddOneEqualsThree(int a, int b, int expectedResult)
    {
        Calculator calculator = new Calculator();


        int actualResult = calculator.Add(a, b);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}

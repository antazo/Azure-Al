namespace prueba;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void TestOperation()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 15;

        // Act
        double actual = Calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestAdd()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 15;

        // Act
        double actual = Calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestSubstract()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 5;

        // Act
        double actual = Calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
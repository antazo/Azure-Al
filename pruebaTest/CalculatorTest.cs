namespace prueba;

[TestClass]
public class CalculatorTest
{
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
    public void TestSubtract()
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

    [TestMethod]
    public void TestMultiply()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 50;

        // Act
        double actual = Calculator.Multiply(a, b);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDivide()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 2;

        // Act
        double actual = Calculator.Divide(a, b);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDivideByZero()
    {
        // Arrange
        double a = 10;
        double b = 0;

        // Act
        double actual = Calculator.Divide(a, b);

        // Assert
        Assert.AreEqual(double.NaN, actual);
    }
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
}
namespace prueba;

[TestClass]
public class CodeKataTest
{

    [TestMethod]
    public void TestMod3()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Mod3(3);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMod5()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Mod5(5);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMod3_5()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Mod3_5(15);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMulti7()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Multi7(7);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestPrimo()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Primo(7);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
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
    public void TestMod7()
    {
        // Arrange
        bool expected = true;

        // Act
        bool actual = CodeKata.Mod7(7);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestPrime()
    {
        // Arrange
        bool expected00 = false;
        bool expected01 = true;

        // Act prime
        bool actual = CodeKata.IsPrime(7);
        bool actual01 = CodeKata.IsPrime(11);
        bool actual02 = CodeKata.IsPrime(13);
        bool actual03 = CodeKata.IsPrime(17);
        // Act not prime
        bool actual04 = CodeKata.IsPrime(12);
        bool actual05 = CodeKata.IsPrime(14);
        bool actual06 = CodeKata.IsPrime(15);
        bool actual07 = CodeKata.IsPrime(16);

        // Assert prime
        Assert.AreEqual(expected01, actual);
        Assert.AreEqual(expected01, actual01);
        Assert.AreEqual(expected01, actual02);
        Assert.AreEqual(expected01, actual03);
        // Assert not prime
        Assert.AreEqual(expected00, actual04);
        Assert.AreEqual(expected00, actual05);
        Assert.AreEqual(expected00, actual06);
    }
}
namespace prueba;

[TestClass]
public class CodeKataBowlingTest
{

    [TestMethod]
    public void TestTirarBolos()
    {
        // Arrange
        Random random = new Random();
        
        int expected = 11;

        // Act
        int actual = CodeKataBowling.tirarBolos(random.Next(0, 11));

        // Assert
        Assert.IsTrue(actual<expected);
    }
}
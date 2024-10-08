namespace prueba;

[TestClass]
public class CodeKataBowlingTest
{

    [TestMethod]
    public void TestTirarBolos()
    {
        // Arrange
        Random random = new Random();
        
        int expected = random.Next(1, 11);

        // Act
        int actual = CodeKataBowling.tirarBolos();

        // Assert
        Assert.IsTrue(actual<11);
    }
}
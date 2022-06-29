namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.99m;
        var cents = valor.ToCents();

        Assert.AreEqual(27999, cents);
    }
}
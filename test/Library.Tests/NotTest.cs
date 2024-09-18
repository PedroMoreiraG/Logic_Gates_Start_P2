namespace Library.Tests;

public class NotTest
{
    [Test]
    public void Test1()
    {

        NOT primerNot = new NOT("not1");
        primerNot.AgregarEntrada("a", 1);
        Assert.AreEqual(0, primerNot.Calcular());
        primerNot.AgregarEntrada("b", 0);
        Assert.AreEqual(1, primerNot.Calcular());
    }
}

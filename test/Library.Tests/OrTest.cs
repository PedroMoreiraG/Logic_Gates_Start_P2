namespace Library.Tests;


public class OrTest
{
    [Test]
    public void Test1()
    {
        OR primerOr = new OR("or1");
        primerOr.AgregarEntrada("a", 1);
        primerOr.AgregarEntrada("b",0);
        
        Assert.AreEqual(1, primerOr.Calcular());
    }
}
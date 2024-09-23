namespace Library.Tests;


public class ANDTest
{
    [Test]
    public void AndTest()
    {
        AND primerAnd = new AND("and1");
        primerAnd.AgregarEntrada("a",1);
        primerAnd.AgregarEntrada("b",1);
        
        Assert.AreEqual(1, primerAnd.Calcular());
    }
}
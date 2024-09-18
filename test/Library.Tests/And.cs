namespace Library.Tests;


public class ANDTest
{
    [Test]
    public void Test1()
    {
        AND primerAnd = new AND("and1");
        primerAnd.AgregarEntrada("a",1);
        primerAnd.AgregarEntrada("b",1);
        
        Assert.AreEqual(0, primerAnd.Calcular());
    }
}
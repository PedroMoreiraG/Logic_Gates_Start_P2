namespace Library.Tests;

[TestFixture]
public class GarageGateTests
{
    [Test]
    public void Prueba()
    {
        GarageGate garageGate = new GarageGate();
        int resultado = garageGate.Calcular("C", 1, "B", 0, "A", 1);
        Assert.AreEqual(0, resultado);
    }
}
namespace Library.Tests;

// Clase de pruebas unitarias para la clase NOT
public class NotTest
{
    // Método de prueba para verificar el comportamiento de la puerta lógica NOT
    [Test]
    public void Test1()
    {
        // Se crea una instancia de la clase NOT con el nombre "not1"
        NOT primerNot = new NOT("not1");

        // Se agrega la primera entrada con la etiqueta "a" y el valor 1 (representa un valor lógico de 1)
        primerNot.AgregarEntrada("a", 1);

        // Verificamos que la operación NOT sobre el valor 1 devuelva 0 (NOT de 1 es 0)
        Assert.AreEqual(0, primerNot.Calcular());

        // Se agrega una nueva entrada con la etiqueta "b" y el valor 0 (representa un valor lógico de 0)
        primerNot.AgregarEntrada("b", 0);

        // Verificamos que la operación NOT sobre el valor 0 devuelva 1 (NOT de 0 es 1)
        Assert.AreEqual(1, primerNot.Calcular());
    }
}

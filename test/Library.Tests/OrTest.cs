namespace Library.Tests;

// Definimos la clase de pruebas unitarias para la clase OR
public class OrTest
{
    // Método de prueba para verificar el comportamiento de la puerta lógica OR
    [Test]
    public void Test1()
    {
        // Se crea una instancia de la clase OR, con el nombre "or1"
        OR primerOr = new OR("or1");

        // Se agrega la primera entrada con la etiqueta "a" y el valor 1 (representa un valor lógico de 1)
        primerOr.AgregarEntrada("a", 1);

        // Se agrega la segunda entrada con la etiqueta "b" y el valor 0 (representa un valor lógico de 0)
        primerOr.AgregarEntrada("b", 0);

        // Verificamos si el método Calcular() devuelve el valor esperado de 1 para la operación lógica OR
        // La operación lógica OR de 1 OR 0 debe ser 1, por lo tanto, se espera que el resultado sea 1
        Assert.AreEqual(1, primerOr.Calcular());
    }
}

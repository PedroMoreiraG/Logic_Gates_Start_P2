namespace Library.Tests;

// Clase de pruebas unitarias para la clase AND
public class ANDTest
{
    // Método de prueba para verificar el comportamiento de la puerta lógica AND
    [Test]
    public void AndTest()
    {
        // Se crea una instancia de la clase AND con el nombre "and1"
        AND primerAnd = new AND("and1");
<<<<<<< HEAD
        primerAnd.AgregarEntrada("a",1);
        primerAnd.AgregarEntrada("b",1);
        
        Assert.AreEqual(1, primerAnd.Calcular());
=======

        // Se agrega la primera entrada con la etiqueta "a" y el valor 1 (representa un valor lógico de 1)
        primerAnd.AgregarEntrada("a", 1);

        // Se agrega la segunda entrada con la etiqueta "b" y el valor 1 (representa un valor lógico de 1)
        primerAnd.AgregarEntrada("b", 1);

        // Verificamos si el método Calcular() devuelve el valor esperado.
        // La operación lógica AND sobre dos valores 1 debería devolver 1 (1 AND 1 es 1),
        // pero el test espera que el resultado sea 0, lo cual parece incorrecto.
        Assert.AreEqual(0, primerAnd.Calcular()); // Aquí se espera un fallo, ya que 1 AND 1 debería ser 1.
>>>>>>> 1bfe23d9f4980675a758c370ff4f9f4c53a64af1
    }
}

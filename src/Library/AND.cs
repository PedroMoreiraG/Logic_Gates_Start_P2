using System.Collections;

namespace Library
{
    // Definición de la clase AND, que simula una compuerta lógica AND
    public class AND
    {
        // Atributo privado para almacenar el nombre de la compuerta
        private string nombre;
        
        // Lista para almacenar las letras asociadas a las entradas de la compuerta
        private ArrayList listaLetras;
        
        // Lista para almacenar los valores (0 o 1) de las entradas
        private ArrayList listaValores;

        // Propiedad pública para acceder y modificar el nombre de la compuerta
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        // Constructor que inicializa la compuerta con un nombre y listas vacías para letras y valores
        public AND(string nombre)
        {
            this.nombre = nombre;
            this.listaLetras = new ArrayList(); // Lista que almacena las letras de las entradas
            this.listaValores = new ArrayList(); // Lista que almacena los valores asociados
        }

        // Método para agregar una entrada a la compuerta AND
        public void AgregarEntrada(string letra, int valor)
        {
            // Si ya hay dos entradas, se limpian las listas (porque una compuerta AND opera solo con dos entradas a la vez)
            if (listaValores.Count >= 2)
            {
                listaValores.Clear(); // Limpia los valores previos
                listaLetras.Clear();  // Limpia las letras previas
            }
            // Agrega el valor (0 o 1) a la lista de valores
            listaValores.Add(valor);
            // Agrega la letra asociada a la lista de letras
            listaLetras.Add(letra);
        }
        
    public string getNombre()
    {
        return this.nombre;
    }
    

        // Método que realiza el cálculo lógico de la compuerta AND
        public int Calcular()
        {
            // Si ambas entradas tienen un valor de 1, devuelve 1 (verdadero)
            if (Convert.ToInt32(listaValores[0]) == 1 && Convert.ToInt32(listaValores[1]) == 1)
            {
                return 1;
            }
            else
            {
                // Si alguna de las entradas es 0, devuelve 0 (falso)
                return 0;
            }
        }
    }
}

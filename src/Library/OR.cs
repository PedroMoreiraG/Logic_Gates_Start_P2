using System.Collections;

namespace Library;
 // Definición de la clase or, que simula una compuerta lógica or

public class OR
{
    //Atributo privado para almacenar el nombre de la compuerta
    private string nombre;
    //Lista para almacenar las letras asociadas a las entradas de la compuerta
    private ArrayList listaLetras;
    //lista para almacenar los valores de ( 0 o 1 )
    private ArrayList listaValores;
    
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }


    //Propiedad publica para acceder y modificar el nombre de la compuerta
    public OR(String nombre)
    {
        this.nombre = nombre;
        this.listaLetras = new ArrayList();
        this.listaValores = new ArrayList();
    }

  //Metodo para agregar una entrada a la compuerta AND  
    public void AgregarEntrada(string letra, int valor)
    {
        // si ya hay dos entradas, se limpian las Listas (por que una compuerta or opera solo con dos entradas a la vez)
        if (listaValores.Count >= 2)
        {
            listaValores.Clear();//limpio los valores previos
            listaLetras.Clear();//limpio las letras previas
        }
        //agrego el valor ( 0 o 1 a la lista de valores)
        listaValores.Add(valor);
        //agrego la letra asociada a la lista de
        listaLetras.Add(letra);
    }

    //aca hago una funcion para obtener el nombre
    public string getNombre()
    {
        return this.nombre;
    }
    
    //Metodo que realiza el calculo logico de la compuerta en cuestion
    
    public int Calcular()
    {
        //Chequeo si ambas entradas tienen un valor de 1 devuelvo 1
        
        if (Convert.ToInt32(listaValores[0]) == 1 || Convert.ToInt32(listaValores[1]) == 1)
        {
            return 1;
        }
        else
        {
            //si alguna de las entradas es 0, devuelvo un 0
            return 0;
        }
    }
}
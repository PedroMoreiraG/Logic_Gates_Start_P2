using System.Collections;

namespace Library;

public class OR
{
    private string nombre;
    private ArrayList listaLetras;
    private ArrayList listaValores;
    
    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    
    public OR(String name)
    {
        this.nombre = name;
    }

    
    public void AgregarEntrada(string letra, int valor)
    {
        if (listaValores.Count >= 2)
        {
            listaValores.Clear();
            listaLetras.Clear();
        }
        listaValores.Add(valor);
        listaLetras.Add(letra);
    }

    
    public string getNombre()
    {
        return this.nombre;
    }
    
    
    public int Calcular()
    {
        
        if (Convert.ToInt32(listaValores[0]) == 1 || Convert.ToInt32(listaValores[1]) == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
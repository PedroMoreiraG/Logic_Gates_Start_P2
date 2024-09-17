using System.Collections;

namespace Library;

public class OR
{
    private string name;
    private ArrayList entrada;
    private ArrayList nameEntry;
    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public OR(String name)
    {
        this.name = name;
    }

    public void AgregarEntrada(string nameEntry, int entrada1)
    {
        entrada.Add(entrada1);
        if (entrada.Count>2)
        {
            entrada.Clear();
            entrada.Add(entrada1);
        }
    }
    
    public int Calcular()
    {
        
        if (Convert.ToInt32(entrada[0]) == 1 || Convert.ToInt32(entrada[1]) == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
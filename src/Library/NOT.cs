using System.Collections;

namespace Library;

public class NOT
{
    private string name;
    private ArrayList entrada;
    private ArrayList nameEntry;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public NOT(string name)
    {
        this.name = name;
        this.entrada = new ArrayList();  
    }

    public void AgregarEntrada(string nameEntry, int entrada1)
    {
        this.entrada.Add(entrada1);
        if (this.entrada.Count > 1)
        {
            this.entrada.Clear();
            this.entrada.Add(entrada1);  
        }
    }
    
    public string getNombre()
    {
        return this.name;
    }
    
    public int Calcular()
    {
       
        if (Convert.ToInt32(this.entrada[0]) == 1)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}

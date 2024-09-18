using System.Collections;

namespace Library;

public class GarageGate
{
    //Instancio AND, OR Y NOT para utilizarlos
    private AND CompuertaAND = new AND("AND-1");
    private OR CompuertaOR = new OR("OR-1");
    private NOT CompuertaNOT = new NOT("NOT-1");
    private string name;
    private ArrayList listaLetras;
    private ArrayList listaValores;

    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public GarageGate()
    {
    }
    
    //Utilizo las clases para actuar segun la compuerta logica de c, b, a
    public int Calcular(string c, int valorC, string b, int valorB, string a, int valorA)
    {
        CompuertaAND.AgregarEntrada(a, valorA);
        CompuertaAND.AgregarEntrada(b, valorB);
        int resultadoAND = CompuertaAND.Calcular();
        
        CompuertaNOT.AgregarEntrada(CompuertaAND.getNombre(), resultadoAND);
        int resultadoNOT = CompuertaNOT.Calcular();
        
        CompuertaOR.AgregarEntrada(CompuertaAND.getNombre(), resultadoAND);
        CompuertaOR.AgregarEntrada(CompuertaNOT.getNombre(), resultadoNOT);
        int resultadoOR = CompuertaOR.Calcular();

        CompuertaAND.AgregarEntrada(CompuertaOR.getNombre(), resultadoOR);
        CompuertaAND.AgregarEntrada(c, valorC);
        return CompuertaAND.Calcular();
    }
}
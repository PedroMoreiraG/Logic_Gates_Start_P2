using System.Collections;

namespace Library;

public class GarageGate
{
    //Instancio AND, OR Y NOT para utilizarlos
    private AND CompuertaAND = new AND("AND-1");
    private OR CompuertaOR = new OR("OR-1");
    private NOT CompuertaNOT = new NOT("NOT-1");
    
    
    //Utilizo las clases para actuar segun la compuerta logica de c, b, a
    public int Calcular(string c, int valorC, string b, int valorB, string a, int valorA)
    {
        CompuertaAND.AgregarEntrada(a, valorA);
        CompuertaAND.AgregarEntrada(b, valorB);
        int primerAND = CompuertaAND.Calcular();
        
        CompuertaNOT.AgregarEntrada(b, valorB);
        int notB = CompuertaNOT.Calcular();
        CompuertaNOT.AgregarEntrada(a, valorA);
        int notA = CompuertaNOT.Calcular();
        
        CompuertaAND.AgregarEntrada("notA", notA);
        CompuertaAND.AgregarEntrada("notB", notB);
        
        CompuertaOR.AgregarEntrada("PrimerAnd", primerAND);
        CompuertaOR.AgregarEntrada("SegundoAnd", CompuertaAND.Calcular());

        CompuertaAND.AgregarEntrada(CompuertaOR.getNombre(), CompuertaOR.Calcular());
        CompuertaAND.AgregarEntrada(c, valorC);
        return CompuertaAND.Calcular();
    }
}
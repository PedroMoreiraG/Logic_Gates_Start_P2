using System.Collections;

namespace Library
{
    public class AND
    {
        private string nombre;
        private ArrayList listaLetras;
        private ArrayList listaValores;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public AND(string nombre)
        {
            this.nombre = nombre;
            this.listaLetras = new ArrayList();
            this.listaValores = new ArrayList();
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

        public int Calcular()
        {
            if (Convert.ToInt32(listaValores[0]) == 1 && Convert.ToInt32(listaValores[1]) == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

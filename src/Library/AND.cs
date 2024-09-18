using System.Collections;

namespace Library
{
    public class AND
    {
        private string name;
        private ArrayList entrada;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public AND(string name)
        {
            this.name = name;
            entrada = new ArrayList(); // Inicializar la lista
        }

        public void AgregarEntrada(string nameEntry, int entrada1)
        {
            entrada.Add(entrada1);
            if (entrada.Count > 2)
            {
                entrada.Clear();
                entrada.Add(entrada1);
            }
        }

        public int Calcular()
        {
            if (Convert.ToInt32(entrada[0]) == 1 && Convert.ToInt32(entrada[1]) == 1)
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
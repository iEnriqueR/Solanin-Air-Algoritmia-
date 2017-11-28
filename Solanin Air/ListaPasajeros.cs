using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solanin_Air
{
    public class ListaPasajeros : List<Pasajero>
    {
        public void guardarPasajeros(ListaVuelos listVuelos)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("Pasajeros.txt");
            foreach (Vuelo vuelo in listVuelos)
            {
                foreach (Pasajero pasajero in vuelo.getListPasajeros())
                {
                    writer.WriteLine(pasajero.toStringOut());
                }
            }
            writer.Close();
        }

        public void cargarPasajeros(ref ListaVuelos listaVuelos)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Pasajeros.txt");
            string cad;
            Pasajero pasajero;

            while (!reader.EndOfStream)
            {
                cad = reader.ReadLine();
                pasajero = new Pasajero(cad);
                for(int i = 0; i < listaVuelos.Count; i++)
                {
                    if(listaVuelos[i].getCodigo() == pasajero.getRuta())
                    {
                        listaVuelos[i].getListPasajeros().Add(pasajero);
                    }
                }
            }

            reader.Close();
        }

    }
}

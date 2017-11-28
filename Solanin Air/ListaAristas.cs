using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solanin_Air
{
    public class ListaAristas: List<Arista>
    {
        public override string ToString()
        {
            string lista = "";
            foreach (Arista arista in this)
            {
                lista += arista.Origen + arista.getDestino();
            }
            return lista;
        }

    }
}

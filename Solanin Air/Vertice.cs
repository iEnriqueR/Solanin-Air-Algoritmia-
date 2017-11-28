using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solanin_Air
{
    public class Vertice
    {
        char origen;
        int x, y;
        ListaAristas listaA;

        public Vertice(char o, char d)
        {

            origen = o;
            listaA = new ListaAristas();

            Arista a = new Arista(o, d);
            listaA.Add(a);
            x = new int();
            y = new int();
        }

        public Vertice(char o)
        {
            origen = o;
            listaA = new ListaAristas();
            x = new int();
            y = new int();
        }

        public Vertice(char c, ListaAristas l)
        {
            origen = c;
            listaA = new ListaAristas();
            listaA = l;
            x = new int();
            y = new int();
        }

        public Vertice(char c, ListaAristas l, int x, int y)
        {
            origen = c;
            listaA = new ListaAristas();
            listaA = l;
            this.x = x;
            this.y = y;     
        }

        public Vertice(char c, int x, int y)
        {
            origen = c;
            listaA = new ListaAristas();
            this.x = x;
            this.y = y;
        }

        public void setXYfromFile(string cadena)
        {
            x = new int();
            y = new int();

            string subCadena = "";

            for (int i = 1; i < cadena.Length; i++)
            {
                if (cadena[i] != ',' && cadena[i] != '!')
                {
                    subCadena += cadena[i];
                }

                else if (cadena[i] == ',')
                {
                    x = Int32.Parse(subCadena);
                    subCadena = "";
                }
                else if (cadena[i] == '!')
                {
                    y = Int32.Parse(subCadena);
                }
            }
        }

        public override string ToString()
        {
            string cadena = origen.ToString() + ":";
            for(int i = 0; i < this.listaA.Count; i++)
            {
                cadena += this.listaA[i].getDestino().ToString() + ",";
            }
            return cadena;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public char getOrigen()
        {
            return origen;
        }
        public ListaAristas getListAristas()
        {
            return listaA;
        }

        public string ToStringOut()
        {
            return origen.ToString() + x.ToString() + "," + y.ToString() + "!";
        }
    }
}

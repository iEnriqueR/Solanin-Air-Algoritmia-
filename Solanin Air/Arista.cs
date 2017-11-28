using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solanin_Air
{
    public class Arista
    {
        char origen;
        char destino;
        int peso;
        int x;
        int y;

        public Arista()
        {
            origen = new char();
            destino = new char();
            peso = new char();
            x = new int();
            y = new int();
        }

        public Arista(char o, char d, int p, int x, int y)
        {
            origen = o;
            destino = d;
            peso = p;
            this.x = x;
            this.y = y;
        }

        public Arista(char o, char d, int p)
        {
            origen = o;
            destino = d;
            peso = p;
            x = new int();
            y = new int();
        }

        public Arista(char d, int p)
        {
            destino = d;
            peso = p;
            x = new int();
            y = new int();
        }

        public Arista(char d, int p, int x, int y)
        {
            destino = d;
            peso = p;
            this.x = x;
            this.y = y;
        }

        public char getDestino()
        {
            return destino;
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

        public char Origen
        {
            get
            {
                return origen;
            }
            set
            {
                origen = value;
            }
        }                     

        public int Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
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

        public override string ToString()
        {
            return origen.ToString()  + destino.ToString() + ", " + "Peso: " + peso.ToString();
        }

        public string ToStringOut(char origen)
        {
            return origen.ToString() + x.ToString() + "," + y.ToString() + "!";
        }
    }
}

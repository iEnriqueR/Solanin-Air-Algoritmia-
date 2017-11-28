using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solanin_Air
{
    public class Vuelo
    {
        ListaPasajeros listPasajeros;
        bool[] asiento;
        int asientosDisp;
        char origen;
        char destino;
        string codigo;
        int costo;
        int tiempo;
        DateTime fechaSalida;


        public Vuelo()
        {
            listPasajeros = new ListaPasajeros();
            fechaSalida = new DateTime();
            costo = new int();
            tiempo = new int();
            codigo = " ";
            asiento = new bool[16];
            asientosDisp = 16;
            origen = destino = ' ';
            for(int i = 0; i < 16; i++)
                asiento[i] =  true ;
        }

        public Vuelo(string cadena)
        {            
            listPasajeros = new ListaPasajeros();
            fechaSalida = new DateTime();
            costo = new int();
            tiempo = new int();
            asiento = new bool[16];
            asientosDisp = 16;
            origen = destino = ' ';
            for(int i = 0; i < 16; i++)
                asiento[i] =  true ;

            string indiceS = "";
            int contadorAsientos = new int();
            origen = cadena[0];
            destino = cadena[1];
            codigo = "SK1" + origen + destino;

            for (int i = 2; i < cadena.Length; i++)
            {
                if (cadena[i] != '|' && cadena[i] != ',' && cadena[i] != '!' && cadena[i] != '~')
                {
                    indiceS += cadena[i];
                }
                
                else if(cadena[i] == ',')
                {
                    indiceS = "";
                    for (int j = i+1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '!')
                            indiceS += cadena[j];
                        else
                        {
                            i = j-1;
                            break;                            
                        }                            
                    }
                    
                fechaSalida = DateTime.Parse(indiceS);
                }

                else if (cadena[i] == '!')
                {
                    indiceS = "";
                    for (int j = i + 1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '~')
                            indiceS += cadena[j];
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }

                    tiempo = Int32.Parse(indiceS);
                }

                else if (cadena[i] == '~')
                {
                    indiceS = "";
                    for (int j = i + 1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '\n')
                            indiceS += cadena[j];
                        else
                        {
                            i = j;
                            break;
                        }
                    }

                    costo = Int32.Parse(indiceS);
                }

                else
                {
                    asiento[Int32.Parse(indiceS) - 1] = false;
                    indiceS = "";
                    contadorAsientos++;
                }
            }
            asientosDisp -= contadorAsientos;
        }

        public Vuelo(char origen, char destino, int tiempo, int costo)
        {
            listPasajeros = new ListaPasajeros();
            this.fechaSalida = new DateTime();
            this.costo = costo;
            this.tiempo = tiempo;
            asiento = new bool[16];
            asientosDisp = 16;
            this.origen = origen;
            this.destino = destino;
            codigo = "SK1" + origen + destino;
            for (int i = 0; i < 16; i++)
                asiento[i] = true;
        }

        public Vuelo(char origen, char destino, int tiempo, int costo, DateTime fechaSalida)
        {
            listPasajeros = new ListaPasajeros();
            this.fechaSalida = fechaSalida;
            this.costo = costo;
            this.tiempo = tiempo;
            asiento = new bool[16];
            asientosDisp = 16;
            this.origen = origen;
            this.destino = destino;
            codigo = "SK1" + origen + destino;
            for (int i = 0; i < 16; i++)
                asiento[i] = true;
        }

        public ListaPasajeros getListPasajeros()
        {
            return listPasajeros;
        }

        public char getOrigen()
        {
            return origen;
        }
        
        public char getDestino()
        {
            return destino;
        }

        public bool getAsiento(int indice)
        {
                return asiento[indice];
        }

        public void setOrigen(char origen)
        {
            this.origen = origen;
        }

        public void setDestino(char destino)
        {
            this.destino = destino;
        }

        public void setAsiento(bool asiento, int indice)
        {
            this.asiento[indice] = asiento;
        }

        public void setPasajero(Pasajero pasajero)
        {
            listPasajeros.Add(pasajero);
        }

        public void reducirAsiento(int indice)
        {
            asientosDisp--;
            this.asiento[indice] = false;
        }

        public void aumentarAsiento(int indice)
        {
            asientosDisp++;
            this.asiento[indice] = true;
        }

        public int getTiempo() {
            return tiempo;
        }

        public int getCosto() {
            return costo;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public int getAsientosDisp()
        {
            return this.asientosDisp;
        }

        public int getNumPasajeros()
        {
            return listPasajeros.Count;
        }

        public Pasajero getPasajero(int indice)
        {
            return listPasajeros[indice];
        }

        public DateTime getFechaSalida()
        {
            return fechaSalida;
        }

        public string toStringOut()
        {
            string asientos = "";

            for(int i = 0; i < asiento.Length; i++)
            {
                if(asiento[i] == false)                
                    asientos += (i+1) + "|";                
            }

            return origen.ToString() + destino.ToString() + asientos + "," + fechaSalida.Year + "-" + 
                fechaSalida.Month + "-" + fechaSalida.Day + "!" + tiempo.ToString() + "~" + costo.ToString();
        }

        public override string ToString()
        {
            return origen + " -> " + destino + ", Asientos: " + asientosDisp + ", " + fechaSalida.ToShortDateString();
        }
        
    }
}

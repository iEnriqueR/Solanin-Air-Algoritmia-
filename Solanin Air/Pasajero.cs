using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solanin_Air
{
    public class Pasajero
    {
        string nombre;
        string apellido;
        int edad;
        int asiento;
        string ruta;

        public Pasajero()
        {
            nombre = "";
            apellido = "";
            edad = new int();
            asiento = new int();    
        }

        public Pasajero(string cadena)
        {
            if(cadena.Length == 0)
            {
                return;
            }
            nombre = "";
            apellido = "";
            edad = new int();
            asiento = new int();

            string subCadena = "";
            ruta = "SK1" + cadena[0] + cadena[1];

            for (int i = 2; i < cadena.Length; i++)
            {
                if (cadena[i] != ',' && cadena[i] != '|' && cadena[i] != '!')
                {
                    subCadena += cadena[i];
                }

                else if (cadena[i] == ',')
                {
                    nombre = subCadena;
                    subCadena = "";
                    for (int j = i + 1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '|')
                            subCadena += cadena[j];
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }

                    apellido = subCadena;
                }

                else if (cadena[i] == '|')
                {
                    subCadena = "";
                    for (int j = i + 1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '!')
                            subCadena += cadena[j];
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }

                    edad = Int32.Parse(subCadena);
                }

                else if(cadena[i] == '!')
                {
                    subCadena = "";
                    for (int j = i + 1; j < cadena.Length; j++)
                    {
                        if (cadena[j] != '\n')
                            subCadena += cadena[j];
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }
                    asiento = Int32.Parse(subCadena);                    
                }
            }
        
    }

        public Pasajero(string nombre, string apellido, int edad, int asiento, string ruta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.asiento = asiento;
            this.ruta = ruta;
        }

        public string getAsiento()
        {
            return (asiento + 1 ).ToString();
        }

        public int getAsientoCrudo()
        {
            return asiento;
        }

        public string getNombreCompleto()
        {
            return nombre + " " + apellido;
        }

        public string getRuta()
        {
            return ruta;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public string toStringOut()
        {
            return ruta[3].ToString() + ruta[4].ToString() + nombre + "," + apellido + "|" + edad + "!" + asiento;
        }

        public override string ToString()
        {
            return apellido + ", " + nombre + ", Edad: " + edad + ", Asiento: " + (asiento + 1).ToString();
        }
    }
}

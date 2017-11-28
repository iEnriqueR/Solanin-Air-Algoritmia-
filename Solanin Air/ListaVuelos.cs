using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solanin_Air
{
    public class ListaVuelos : List<Vuelo>
    {
        public void quickSort(int primero, int ultimo, char tipo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            if (tipo == 'f') { 
                do
                {
                    while (this[i].getFechaSalida() < pivote.getFechaSalida())
                    {
                        i++;
                        if (i > ultimo)
                            break;
                    }
                    while (this[j].getFechaSalida() > pivote.getFechaSalida())
                    {
                        j--;
                        if (j < primero)
                            break;
                    }
                    if (i <= j)
                    {
                        Vuelo temp;
                        temp = this[i];
                        this[i] = this[j];
                        this[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

            if (primero < j)
            {
                quickSort(primero, j, tipo);
            }
            if (i < ultimo)
            {
                quickSort(i, ultimo, tipo);
            }
        }
            if (tipo == 'a')
            {
                do
                {
                    while (this[i].getAsientosDisp() < pivote.getAsientosDisp())
                    {
                        i++;
                        if (i > ultimo)
                            break;
                    }
                    while (this[j].getAsientosDisp() > pivote.getAsientosDisp())
                    {
                        j--;
                        if (j < primero)
                            break;
                    }
                    if (i <= j)
                    {
                        Vuelo temp;
                        temp = this[i];
                        this[i] = this[j];
                        this[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j)
                {
                    quickSort(primero, j, tipo);
                }
                if (i < ultimo)
                {
                    quickSort(i, ultimo, tipo);
                }
            }
        }

        public void guardarVuelos()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("Vuelos.txt");
            foreach(Vuelo vuelo in this)
            {
                writer.WriteLine(vuelo.toStringOut());
            }
            writer.Close();
        }

        public void cargarVuelos()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Vuelos.txt");
            string cad;
            Vuelo vuelo;

            while (!reader.EndOfStream)
            {
                cad = reader.ReadLine();
                vuelo = new Vuelo(cad);
                this.Add(vuelo);
            }

            reader.Close();
        }
        
        
        public void cargarVuelos2()
        {
            
            Vuelo vuelo1;
            DateTime fecha1 = new DateTime(2016, 1, 22);
            DateTime fecha2 = new DateTime(2016, 3, 10);
            DateTime fecha3 = new DateTime(1996, 10, 30);
            DateTime fecha4 = new DateTime(1970, 10, 30);

            vuelo1 = new Vuelo('A', 'B', 50, 600, fecha1);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('A', 'F', 90, 1050, fecha2);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('A', 'G', 80, 1150, fecha3);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('B', 'A', 50, 600, fecha4);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('B', 'C', 40, 750);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('B', 'D', 60, 650);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('B', 'E', 70, 1850);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('C', 'B', 35, 800);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('C', 'E', 50, 850);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('E', 'C', 45, 750);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('E', 'G', 80, 1150);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('E', 'L', 60, 1650);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('E', 'D', 35, 700);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('D', 'E', 45, 900);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('D', 'B', 55, 700);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('F', 'B', 65, 800);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('F', 'L', 140, 2850);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('G', 'A', 95, 1250);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('G', 'E', 75, 1175);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('G', 'L', 135, 2675);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('G', 'J', 60, 1400);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('G', 'H', 25, 450);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('H', 'G', 30, 350);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('H', 'I', 35, 400);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('I', 'H', 30, 400);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('I', 'K', 35, 400);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('K', 'I', 35, 400);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('K', 'J', 25, 300);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('J', 'L', 40, 750);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('J', 'M', 70, 1450);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('L', 'M', 40, 650);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('L', 'K', 70, 700);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('L', 'E', 60, 1550);
            this.Add(vuelo1);
            vuelo1 = new Vuelo('M', 'L', 40, 700);
            this.Add(vuelo1);
        }

    }

}

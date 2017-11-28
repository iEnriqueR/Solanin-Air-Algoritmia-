using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solanin_Air
{
    public partial class FormRegistoVenta : Form
    {
        int indiceSeleccionado, identificadorAsiento;
        ListaVuelos listVuelos;
        Pasajero pasajeroAux;

        public FormRegistoVenta(ref ListaVuelos listVuelos, int indiceSeleccionado)
        {
            InitializeComponent();

            this.listVuelos = listVuelos;
            this.indiceSeleccionado = indiceSeleccionado;
            identificadorAsiento = -1;                        
            labelVuelo.Text = "Vuelo " + listVuelos[indiceSeleccionado].getCodigo() + 
                "\nOrigen: " + listVuelos[indiceSeleccionado].getOrigen() + 
                "\nDestino: " + listVuelos[indiceSeleccionado].getDestino() + 
                "\nTiempo de Vuelo: " + listVuelos[indiceSeleccionado].getTiempo().ToString() + " min" +
                "\nCosto: $" + listVuelos[indiceSeleccionado].getCosto().ToString();

            if (identificadorAsiento == -1)
            {
                buttonVenta.Enabled = false;               
            }
        }

        public FormRegistoVenta(ref ListaVuelos listVuelos, char origen, char destino)
        {
            InitializeComponent();

            this.listVuelos = listVuelos;
            this.indiceSeleccionado = new int();
            for(int i = 0; i < listVuelos.Count; i++)
            {
                if (listVuelos[i].getOrigen() == origen && listVuelos[i].getDestino() == destino)
                {
                    indiceSeleccionado = i;
                    break;
                }
            }

            identificadorAsiento = -1;
            labelVuelo.Text = "Vuelo " + listVuelos[indiceSeleccionado].getCodigo() +
                "\nOrigen: " + listVuelos[indiceSeleccionado].getOrigen() +
                "\nDestino: " + listVuelos[indiceSeleccionado].getDestino() +
                "\nTiempo de Vuelo: " + listVuelos[indiceSeleccionado].getTiempo().ToString() + " min" +
                "\nCosto: $" + listVuelos[indiceSeleccionado].getCosto().ToString();

            if (identificadorAsiento == -1)
            {
                buttonVenta.Enabled = false;
            }
        }
        public FormRegistoVenta(ref ListaVuelos listVuelos, char origen, char destino, Pasajero pasajero)
        {
            InitializeComponent();

            this.listVuelos = listVuelos;
            this.indiceSeleccionado = new int();
            this.pasajeroAux = pasajero;
            this.textBoxNombre.Text = pasajero.Nombre;
            this.textBoxApellido.Text = pasajero.Apellido;
            this.textBoxEdad.Text = pasajero.Edad.ToString();

            this.textBoxNombre.Enabled = false;
            this.textBoxApellido.Enabled = false;
            this.textBoxEdad.Enabled = false;

            for (int i = 0; i < listVuelos.Count; i++)
            {
                if (listVuelos[i].getOrigen() == origen && listVuelos[i].getDestino() == destino)
                    indiceSeleccionado = i;
            }

            identificadorAsiento = -1;
            labelVuelo.Text = "Vuelo " + listVuelos[indiceSeleccionado].getCodigo() +
                "\nOrigen: " + listVuelos[indiceSeleccionado].getOrigen() +
                "\nDestino: " + listVuelos[indiceSeleccionado].getDestino() +
                "\nTiempo de Vuelo: " + listVuelos[indiceSeleccionado].getTiempo().ToString() + " min" +
                "\nCosto: $" + listVuelos[indiceSeleccionado].getCosto().ToString();

            if (identificadorAsiento == -1)
            {
                buttonVenta.Enabled = false;
            }
        }

        private void buttonSelAsiento_MouseClick(object sender, MouseEventArgs e)
        {
            FormAsientos ventanaAsientos = new FormAsientos(listVuelos[indiceSeleccionado]);
            ventanaAsientos.ShowDialog();
            this.identificadorAsiento = ventanaAsientos.getIdentificador();
            if (this.identificadorAsiento != -1)
            {
                this.buttonVenta.Enabled = true;
                labelAsiento.Text = "Asiento: " + (identificadorAsiento + 1).ToString();
            }
            else
            {
                labelAsiento.Text = "Asiento: ";
            }
            
        }

        private void buttonCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        private void buttonVenta_MouseClick(object sender, MouseEventArgs e)
        {
            if(pasajeroAux == null)
            this.pasajeroAux = new Pasajero(textBoxNombre.Text, textBoxApellido.Text, Int32.Parse(textBoxEdad.Text),
                identificadorAsiento, listVuelos[indiceSeleccionado].getCodigo());

            this.listVuelos[indiceSeleccionado].setPasajero(pasajeroAux);
            this.listVuelos[indiceSeleccionado].reducirAsiento(identificadorAsiento);
            this.Close();
        }

        public Pasajero Pasajero
        {
            get
            {
                return pasajeroAux;
            }
        }
    }
}

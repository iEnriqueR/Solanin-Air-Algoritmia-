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
    public partial class FormPrincipal : Form
    {
        
        ListaVuelos listVuelos;
        Grafo grafoVuelos;

        public FormPrincipal(ref ListaVuelos listaVuelos, ref Grafo grafoVuelos)
        {
            InitializeComponent();
            
            listVuelos = listaVuelos;
            this.grafoVuelos = grafoVuelos;
        }

        private void buttonPasajeros_Click(object sender, EventArgs e)
        {
            FormPasajeros ventanaPasajeros = new FormPasajeros(ref listVuelos);
            this.Hide();
            ventanaPasajeros.ShowDialog();
            this.Show();
        }

        private void buttonVentas_MouseClick(object sender, MouseEventArgs e)
        {
            FormVuelos ventanaVuelos = new FormVuelos(ref listVuelos);
            this.Hide();
            ventanaVuelos.ShowDialog();
            this.Show();
        }

        private void buttonVuelosABC_Click(object sender, EventArgs e)
        {
            FormVuelosABC ventanaVuelosABC = new FormVuelosABC(ref listVuelos, ref grafoVuelos);
            this.Hide();
            ventanaVuelosABC.ShowDialog();
            this.Show();
        }

        private void buttonCiudadesABC_Click(object sender, EventArgs e)
        {
            FormCiudadesABC ventanaCiudades = new FormCiudadesABC(ref grafoVuelos, ref listVuelos);
            this.Hide();
            ventanaCiudades.ShowDialog();
            this.Show();
        }
    }
}

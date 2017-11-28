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
    public partial class FormVuelos : Form
    {
        ListaVuelos listVuelos;

        private void buttonAccRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceSeleccionado = listBoxVuelos.SelectedIndex;
            
            FormRegistoVenta ventanaRegistro = new FormRegistoVenta(ref listVuelos, indiceSeleccionado);
            this.Hide();
            ventanaRegistro.ShowDialog();

            listBoxVuelos.DataSource = null;
            listBoxVuelos.DataSource = listVuelos;
            this.Show();
        }

        
        public FormVuelos(ref ListaVuelos listVuelos)
        {
            InitializeComponent();

            this.listVuelos = listVuelos;
            listBoxVuelos.DataSource = listVuelos;            
        }

        private void buttonOrdenarAsientos_Click(object sender, EventArgs e)
        {
            this.listVuelos.quickSort(0, listVuelos.Count - 1, 'a');
            actualizarLista();
        }

        private void buttonOrdenarFecha_Click(object sender, EventArgs e)
        {
            this.listVuelos.quickSort(0, listVuelos.Count - 1, 'f');
            actualizarLista();
        }

        private void actualizarLista()
        {
            listBoxVuelos.DataSource = null;
            listBoxVuelos.DataSource = listVuelos;
        }

        private void buttonActLista_Click(object sender, EventArgs e)
        {
            DateTime tiempoActual = DateTime.Today;
            for(int i = 0; i < listVuelos.Count; i++)
            {
                if (DateTime.Compare(listVuelos[i].getFechaSalida(), tiempoActual) < 0)
                {
                    listVuelos.RemoveAt(i);
                }
            }

            actualizarLista();
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {

        }
    }
}

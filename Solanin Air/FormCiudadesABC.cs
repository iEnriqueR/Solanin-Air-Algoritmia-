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
    public partial class FormCiudadesABC : Form
    {
        Grafo grafoVuelos;
        ListaVuelos listaVuelos;

        public FormCiudadesABC(ref Grafo listCiudades, ref ListaVuelos listaVuelos)
        {
            InitializeComponent();

            this.grafoVuelos = listCiudades;
            this.listaVuelos = listaVuelos;
            actualizarListBox();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Vertice vertice;
            FormGrafo ventanaGrafo = new FormGrafo(grafoVuelos, true);

            ventanaGrafo.ShowDialog();

            vertice = new Vertice(Convert.ToChar(textBoxNombre.Text), ventanaGrafo.getX(), ventanaGrafo.getY());
            grafoVuelos.Add(vertice);
            actualizarListBox();
        }

        public void actualizarListBox()
        {
            listBoxlistCiudades.DataSource = null;
            listBoxlistCiudades.DataSource = grafoVuelos;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Vertice vertice = listBoxlistCiudades.SelectedItem as Vertice;
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                if(listaVuelos[i].getOrigen() == vertice.getOrigen())
                {
                    listaVuelos.RemoveAt(i);                    
                    --i;
                }

                else if (listaVuelos[i].getDestino() == vertice.getOrigen())
                {
                    listaVuelos.RemoveAt(i);
                    --i;
                }
            }

            grafoVuelos.Remove(vertice);

            List<char> listaCD = new List<char>();
            List<char> listaCO = new List<char>();

            foreach (Vuelo v in listaVuelos)
            {
                listaCO.Add(v.getOrigen());
                listaCD.Add(v.getDestino());
            }

            for(int i = 0; i < grafoVuelos.Count; i++)
            {
                for (int j = 0; j < grafoVuelos[i].getListAristas().Count; j++)
                {
                    if (!listaCD.Contains(grafoVuelos[i].getListAristas()[j].getDestino()))
                    {
                        grafoVuelos[i].getListAristas().RemoveAt(j);
                    }
                }

                if ( (!listaCO.Contains(grafoVuelos[i].getOrigen())) && (!listaCD.Contains(grafoVuelos[i].getOrigen())) )
                {
                    grafoVuelos.RemoveAt(i);
                }                                                                    
            }

            
            actualizarListBox();
        }
    }
}

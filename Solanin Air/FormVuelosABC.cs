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
    public partial class FormVuelosABC : Form
    {
        ListaVuelos listVuelos;
        Grafo grafoVuelos;

        public FormVuelosABC(ref ListaVuelos listVuelos, ref Grafo grafoVuelos)
        {
            InitializeComponent();

            this.grafoVuelos = grafoVuelos;
            this.listVuelos = listVuelos;
            actualizarListViewVuelos();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool duplicado = false;
            bool origenExisteEnGrafo, destinoExisteEnGrafo;
            origenExisteEnGrafo = destinoExisteEnGrafo = false;

            Vuelo vuelo = new Vuelo(Convert.ToChar(textBoxOrigen.Text), Convert.ToChar(textBoxDestino.Text),
                Int32.Parse(textBoxTiempo.Text), Int32.Parse(textBoxCosto.Text), dateTimePickerFechaSalida.Value);

            Arista arista1;
            int i, k;

            for (i = 0; i < listVuelos.Count; i++)
            {
                if (vuelo.getOrigen() == listVuelos[i].getOrigen() && vuelo.getDestino() == listVuelos[i].getDestino())
                    duplicado = true;
            }
            //**********
            if (!duplicado)
            {
                FormGrafo ventanaGrafo = new FormGrafo(grafoVuelos, true);

                Vertice vertice;

                for (i = 0; i < grafoVuelos.Count; i++)
                {
                    if (grafoVuelos[i].getOrigen() == Convert.ToChar(textBoxOrigen.Text))
                    {
                        origenExisteEnGrafo = true;
                        break;
                    }
                }

                for (k = 0; k < grafoVuelos.Count; k++)
                {
                    if (grafoVuelos[k].getOrigen() == Convert.ToChar(textBoxDestino.Text))
                    {
                        destinoExisteEnGrafo = true;
                        break;
                    }
                }

                if (origenExisteEnGrafo && destinoExisteEnGrafo)
                {
                    arista1 = new Arista(grafoVuelos[i].getOrigen(), grafoVuelos[k].getOrigen(), vuelo.getCosto(), grafoVuelos[k].X, grafoVuelos[k].Y);
                    grafoVuelos[i].getListAristas().Add(arista1);
                }

                else if (!origenExisteEnGrafo && destinoExisteEnGrafo)
                {
                    arista1 = new Arista(vuelo.getOrigen(), grafoVuelos[k].getOrigen(), vuelo.getCosto(), grafoVuelos[k].X, grafoVuelos[k].Y);
                    ventanaGrafo.ShowDialog();
                    vertice = new Vertice(Convert.ToChar(textBoxOrigen.Text), ventanaGrafo.getX(), ventanaGrafo.getY());
                    vertice.getListAristas().Add(arista1);
                    grafoVuelos.Add(vertice);
                }

                else if (origenExisteEnGrafo && !destinoExisteEnGrafo)
                {
                    ventanaGrafo.ShowDialog();
                    vertice = new Vertice(Convert.ToChar(textBoxDestino.Text), ventanaGrafo.getX(), ventanaGrafo.getY());
                    grafoVuelos.Add(vertice);
                    arista1 = new Arista(grafoVuelos[i].getOrigen(), vertice.getOrigen(), vuelo.getCosto(), vertice.X, vertice.Y);
                    grafoVuelos[i].getListAristas().Add(arista1);
                }

                else if (!origenExisteEnGrafo && !destinoExisteEnGrafo)
                {
                    Vertice vertice2;
                    ventanaGrafo.ShowDialog();
                    vertice = new Vertice(vuelo.getOrigen(), ventanaGrafo.getX(), ventanaGrafo.getY());
                    ventanaGrafo.ShowDialog();
                    vertice2 = new Vertice(vuelo.getDestino(), ventanaGrafo.getX(), ventanaGrafo.getY());

                    arista1 = new Arista(vertice.getOrigen(), vertice2.getOrigen(), vuelo.getCosto(), vertice2.X, vertice2.Y);
                    vertice.getListAristas().Add(arista1);
                    grafoVuelos.Add(vertice);
                    grafoVuelos.Add(vertice2);
                }
                listVuelos.Add(vuelo);
            }
            //*************

            actualizarListViewVuelos();
        }

        private void actualizarListViewVuelos()
        {
            listBoxVuelos.DataSource = null;
            listBoxVuelos.DataSource = listVuelos;
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            ListaVuelos listVAux = new ListaVuelos();

            for(int i = 0; i < listVuelos.Count; i++)
            {
                if(textBoxBusqueda.Text == Convert.ToString(listVuelos[i].getDestino()) || textBoxBusqueda.Text == Convert.ToString(listVuelos[i].getOrigen()))
                {
                    listVAux.Add(listVuelos[i]);
                }
            }

            if (textBoxBusqueda.Text == "")
                actualizarListViewVuelos();

            listBoxVuelos.DataSource = null;
            listBoxVuelos.DataSource = listVAux;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Vuelo vuelo = listBoxVuelos.SelectedItem as Vuelo;

            for(int i = 0; i < grafoVuelos.Count; i++)
            {
                if(grafoVuelos[i].getOrigen() == vuelo.getOrigen())
                {
                    for(int j = 0; j < grafoVuelos[i].getListAristas().Count; j++)
                    {
                        if(grafoVuelos[i].getListAristas()[j].getDestino() == vuelo.getDestino())
                        {
                            grafoVuelos[i].getListAristas().RemoveAt(j);
                        }
                    }
                }
            }

            listVuelos.Remove(vuelo);
            textBoxBusqueda.Clear();
            actualizarListViewVuelos();
        }

        private void buttonMapa_Click(object sender, EventArgs e)
        {
            FormGrafo ventanaGrafo = new FormGrafo(grafoVuelos, false);
            ventanaGrafo.ShowDialog();
        }

        private void buttonKruskal_Click(object sender, EventArgs e)
        {
            Grafo grafoKruskal = new Grafo(listVuelos, 't');
            grafoKruskal.cargarVertices();
            FormGrafo ventanaGrafo = new FormGrafo(grafoKruskal.kruskal(), false);
            ventanaGrafo.ShowDialog();
        }

        private void buttonPrim_Click(object sender, EventArgs e)
        {
            Grafo grafoPrim = grafoVuelos.prim();
            FormGrafo ventanaGrafo = new FormGrafo(grafoPrim, false);
            ventanaGrafo.ShowDialog();
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            FormDijkstra ventanaDijkstra = new FormDijkstra(grafoVuelos, ref listVuelos);
            ventanaDijkstra.ShowDialog();
        }
    }
}

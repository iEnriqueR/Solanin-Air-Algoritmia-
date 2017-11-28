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
    public partial class FormDijkstra : Form
    {
        Grafo grafoVuelos;
        ListaVuelos listaVuelos;
        string cadena;

        public FormDijkstra(Grafo grafoVuelos, ref ListaVuelos listaVuelos)
        {            
            InitializeComponent();
            this.grafoVuelos = grafoVuelos;
            this.listaVuelos = listaVuelos;
            List<char> listC = new List<char>();
            List<char> listC2 = new List<char>();
            for (int i = 0; i < grafoVuelos.Count; i++)
            {
                listC.Add(grafoVuelos[i].getOrigen());
                listC2.Add(grafoVuelos[i].getOrigen());
            }
            listC2.RemoveAt(0);
            this.listBoxVertices.DataSource = listC;
            this.listBoxDestinos.DataSource = listC2;
        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            this.labelLista.Text = "";
            actualizarLabel(this.listBoxVertices.SelectedIndex);
        }

        private void actualizarLabel(int indDeVertice)
        {
            int indDestino = new int();
            string[,] pesoXruta = grafoVuelos.Dijkstra(indDeVertice);
            List<char> listC = new List<char>();
            for (int i = 0; i < grafoVuelos.Count; i++)
            {
                listC.Add(grafoVuelos[i].getOrigen());
            }
            indDestino = listC.IndexOf(Convert.ToChar(this.listBoxDestinos.SelectedItem));
            if (pesoXruta[indDestino, 0] == null)
            {
                this.labelLista.Text = "No existen rutas disponibles entre estas ciudades.";
                return;
            }
                
            int indice = listC.IndexOf(pesoXruta[indDestino, 1][0]);
            cadena = listC[indDestino].ToString();
            while (indice != indDeVertice)
            {
                cadena += grafoVuelos[indice].getOrigen();
                indice = listC.IndexOf(pesoXruta[indice, 1][0]);
            }
            cadena += grafoVuelos[indDeVertice].getOrigen().ToString();
            int tiempoTotal = new int();
            for (int j = cadena.Length - 1; j >= 0; j--)
            {
                if (j == 0)
                {
                    this.labelLista.Text += cadena[j] + "\n";                    
                }
                else
                {
                    for (int k = 0; k < this.listaVuelos.Count; k++)
                    {
                        if (listaVuelos[k].getOrigen() == cadena[j] && listaVuelos[k].getDestino() == cadena[j - 1])
                            tiempoTotal += listaVuelos[k].getTiempo();
                    }
                    this.labelLista.Text += cadena[j] + " -> ";
                }
            }
            this.labelCostoTiempo.Text = "Costo total: " + pesoXruta[indDestino, 0].ToString() + "\nTiempo de vuelo total: " + tiempoTotal.ToString();
            this.buttonAceptar.Enabled = true;
            this.buttonRechazar.Enabled = true;
        }

        private void listBoxVertices_MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonAceptar.Enabled = false;
            this.buttonRechazar.Enabled = false;
            List<char> listC = new List<char>();
            for(int i = 0; i < grafoVuelos.Count; i ++)
            {
                if (i != this.listBoxVertices.SelectedIndex)
                    listC.Add(grafoVuelos[i].getOrigen());
            }
            this.listBoxDestinos.DataSource = listC;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int j = cadena.Length - 1;
            FormRegistoVenta ventanaVenta = new FormRegistoVenta(ref listaVuelos, cadena[j], cadena[j - 1]);
            ventanaVenta.ShowDialog();
            j--;
            while (j != 0)
            {
                ventanaVenta = new FormRegistoVenta(ref listaVuelos, cadena[j], cadena[j - 1], ventanaVenta.Pasajero);
                ventanaVenta.ShowDialog();
                j--;
            } 
        }

        private void buttonRechazar_Click(object sender, EventArgs e)
        {
            this.buttonAceptar.Enabled = false;
            this.buttonRechazar.Enabled = false;
            this.labelLista.Text = this.labelCostoTiempo.Text = "";
        }
    }
}

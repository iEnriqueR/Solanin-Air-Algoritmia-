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
    public partial class FormPasajeros : Form
    {
        ListaVuelos listVuelos;

        public FormPasajeros(ref ListaVuelos listVuelos)
        {
            InitializeComponent();

            this.listVuelos = listVuelos;
            actualizaListView();
        }

        private void actualizaListView()
        {
            listViewPasajeros.Items.Clear();
            for (int i = 0; i < listVuelos.Count; i++)
            {
                for (int j = 0; j < listVuelos[i].getNumPasajeros(); j++)
                {
                    string[] cadenas = new string[3];
                    cadenas[0] = listVuelos[i].getCodigo();
                    cadenas[1] = listVuelos[i].getPasajero(j).getNombreCompleto();
                    cadenas[2] = listVuelos[i].getPasajero(j).getAsiento();
                    ListViewItem item = new ListViewItem(cadenas);
                    listViewPasajeros.Items.Add(item);
                }
            }
            if(listViewPasajeros.Items.Count == 0)
            {
                buttonEliminar.Enabled = false;
            }
        }

        /*private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int i, j, contador = -1, indice;
            indice = listViewPasajeros.FocusedItem.Index;
            for(i = 0; i < listVuelos.Count; i++)
            {
                for (j = 0; j < listVuelos[i].getNumPasajeros(); j++)
                {
                    contador++;
                    if (contador == indice)
                    {
                        listVuelos[i].aumentarAsiento(listVuelos[i].getListPasajeros()[j].getAsientoCrudo());
                        listVuelos[i].getListPasajeros().RemoveAt(j);
                    }
                }
            }

            actualizaListView();
        }*/

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           Console.WriteLine(listViewPasajeros.FocusedItem.ToString());// esto regresa la ruta
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListaPasajeros listPAux = new ListaPasajeros();

            if (textBoxBusqueda.Text == "")
            {
                actualizaListView();
            }
            else
            {
                listViewPasajeros.Items.Clear();

                for (int i = 0; i < listVuelos.Count; i++)
                {
                    for (int j = 0; j < listVuelos[i].getNumPasajeros(); j++)
                    {
                        bool band = true;
                        for (int k = 0; k < textBoxBusqueda.Text.Length && k < listVuelos[i].getPasajero(j).getNombreCompleto().Length; k++)
                        {
                            if (listVuelos[i].getPasajero(j).getNombreCompleto()[k] != textBoxBusqueda.Text[k])
                            {
                                band = false;
                                break;
                            }
                        }
                        if (band)
                        {
                            listPAux.Add(listVuelos[i].getPasajero(j));
                        }
                    }
                }

                for (int j = 0; j < listPAux.Count; j++)
                {
                    string[] cadenas = new string[3];

                    cadenas[0] = listPAux[j].getRuta();
                    cadenas[1] = listPAux[j].getNombreCompleto();
                    cadenas[2] = listPAux[j].getAsiento();
                    ListViewItem item = new ListViewItem(cadenas);
                    listViewPasajeros.Items.Add(item);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solanin_Air
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListaVuelos listVuelos = new ListaVuelos();
            ListaPasajeros listPasajeros = new ListaPasajeros();            

            listVuelos.cargarVuelos();
            listPasajeros.cargarPasajeros(ref listVuelos);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Grafo grafoVuelos = new Grafo(listVuelos);
            grafoVuelos.cargarVertices();
            
            FormPrincipal menuPrincipal = new FormPrincipal(ref listVuelos, ref grafoVuelos);

            menuPrincipal.ShowDialog();
            grafoVuelos.guardarVertices();
            listVuelos.guardarVuelos();
            listPasajeros.guardarPasajeros(listVuelos);
        }
        
    }
}

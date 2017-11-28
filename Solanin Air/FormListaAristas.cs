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
    public partial class FormListaAristas : Form
    {
        public FormListaAristas(ListaAristas listaAristas)
        {
            InitializeComponent();
            this.listBoxListaAristas.DataSource = listaAristas;
        }
    }
}

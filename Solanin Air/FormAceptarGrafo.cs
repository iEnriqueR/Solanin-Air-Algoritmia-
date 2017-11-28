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
    public partial class FormAceptarGrafo : Form
    {
        bool aceptado;
        public FormAceptarGrafo(float x, float y)
        {
            InitializeComponent();

            aceptado = new bool();
            labelX.Text += x.ToString();
            labelY.Text += y.ToString();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            aceptado = true;
            this.Close();
        }

        private void buttonRechazar_Click(object sender, EventArgs e)
        {
            aceptado = false;
            this.Close();
        }

        public bool fueAceptado()
        {
            return aceptado;
        }
    }
}

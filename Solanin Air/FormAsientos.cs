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
    public partial class FormAsientos : Form
    {
        int identificadorAsiento;
        Vuelo vueloSeleccionado;

        public FormAsientos(Vuelo vueloSeleccionado)
        {
            this.vueloSeleccionado = vueloSeleccionado;
            this.identificadorAsiento = -1;
            InitializeComponent();
        }

        public int getIdentificador()
        {
            return identificadorAsiento;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           identificadorAsiento = 0;
            this.Close();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 1;
            this.Close();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 2;
            this.Close();
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 3;
            this.Close();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 4;
            this.Close();
        }
        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 5;
            this.Close();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 6;
            this.Close();
        }
        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 7;
            this.Close();
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 8;
            this.Close();
        }
        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 9;
            this.Close();
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 10;
            this.Close();
        }
        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 11;
            this.Close();
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 12;
            this.Close();
        }
        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 13;
            this.Close();
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 14;
            this.Close();
        }

        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            identificadorAsiento = 15;
            this.Close();
        }
    }
}

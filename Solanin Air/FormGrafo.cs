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
    public partial class FormGrafo : Form
    {
        int x;
        int y;
        Grafo grafoVuelos;
        bool editable;

        public FormGrafo(Grafo grafoVuelos, bool editable)
        {
            InitializeComponent();

            this.grafoVuelos = grafoVuelos;
            this.editable = editable;
        }

        private void panelGrafo_MouseDown(object sender, MouseEventArgs e)
        {
            FormAceptarGrafo ventanaAceptar = new FormAceptarGrafo(e.X, e.Y);
            Pen pen1 = new Pen(Color.FromArgb(156, 170, 198), 8);
            Pen pen2 = new Pen(Color.FromArgb(90, 121, 165), 7);
            Font fuente = new Font(Font.FontFamily, 20);
            SolidBrush brush = new SolidBrush(Color.FromArgb(206, 0, 0));

            pen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            for (int i = 0; i < grafoVuelos.Count; i++)
            {
                panelGrafo.CreateGraphics().DrawEllipse(pen1, grafoVuelos[i].X - 9, grafoVuelos[i].Y - 9, 35, 35);
            }
            for (int i = 0; i < grafoVuelos.Count; i++)
            {
                for (int j = 0; j < grafoVuelos[i].getListAristas().Count; j++)
                {
                    panelGrafo.CreateGraphics().DrawLine(pen2, grafoVuelos[i].X, grafoVuelos[i].Y,
                                            grafoVuelos[i].getListAristas()[j].X, grafoVuelos[i].getListAristas()[j].Y);
                }
            }

            for (int i = 0; i < grafoVuelos.Count; i++)
            {
                panelGrafo.CreateGraphics().DrawString(Convert.ToString(grafoVuelos[i].getOrigen()),
                                                    /*Font*/fuente,/*Brush*/brush, grafoVuelos[i].X - 9, grafoVuelos[i].Y - 9);
            }

            if (editable)
            {
                ventanaAceptar.ShowDialog();

                if (ventanaAceptar.fueAceptado())
                {
                    x = e.X;
                    y = e.Y;
                    this.Close();
                }
            }
            if (grafoVuelos.getListaKruskal().Count != 0)
            {
                FormListaAristas ventanaAristas = new FormListaAristas(grafoVuelos.getListaKruskal());
                ventanaAristas.ShowDialog();
            }
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}

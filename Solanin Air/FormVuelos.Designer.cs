namespace Solanin_Air
{
    partial class FormVuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.buttonAccRegistro = new System.Windows.Forms.Button();
            this.labelTitulos = new System.Windows.Forms.Label();
            this.buttonOrdenarAsientos = new System.Windows.Forms.Button();
            this.buttonOrdenarFecha = new System.Windows.Forms.Button();
            this.buttonActLista = new System.Windows.Forms.Button();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.Location = new System.Drawing.Point(21, 36);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(274, 199);
            this.listBoxVuelos.TabIndex = 0;
            // 
            // buttonAccRegistro
            // 
            this.buttonAccRegistro.Location = new System.Drawing.Point(21, 272);
            this.buttonAccRegistro.Name = "buttonAccRegistro";
            this.buttonAccRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonAccRegistro.TabIndex = 1;
            this.buttonAccRegistro.Text = "Venta";
            this.buttonAccRegistro.UseVisualStyleBackColor = true;
            this.buttonAccRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAccRegistro_MouseClick);
            // 
            // labelTitulos
            // 
            this.labelTitulos.AutoSize = true;
            this.labelTitulos.Location = new System.Drawing.Point(21, 13);
            this.labelTitulos.Name = "labelTitulos";
            this.labelTitulos.Size = new System.Drawing.Size(145, 13);
            this.labelTitulos.TabIndex = 2;
            this.labelTitulos.Text = "Origen|Destino|Asientos Disp.";
            // 
            // buttonOrdenarAsientos
            // 
            this.buttonOrdenarAsientos.Location = new System.Drawing.Point(102, 256);
            this.buttonOrdenarAsientos.Name = "buttonOrdenarAsientos";
            this.buttonOrdenarAsientos.Size = new System.Drawing.Size(75, 39);
            this.buttonOrdenarAsientos.TabIndex = 3;
            this.buttonOrdenarAsientos.Text = "O. por Asientos Disp";
            this.buttonOrdenarAsientos.UseVisualStyleBackColor = true;
            this.buttonOrdenarAsientos.Click += new System.EventHandler(this.buttonOrdenarAsientos_Click);
            // 
            // buttonOrdenarFecha
            // 
            this.buttonOrdenarFecha.Location = new System.Drawing.Point(183, 256);
            this.buttonOrdenarFecha.Name = "buttonOrdenarFecha";
            this.buttonOrdenarFecha.Size = new System.Drawing.Size(75, 39);
            this.buttonOrdenarFecha.TabIndex = 4;
            this.buttonOrdenarFecha.Text = "O. por Fecha";
            this.buttonOrdenarFecha.UseVisualStyleBackColor = true;
            this.buttonOrdenarFecha.Click += new System.EventHandler(this.buttonOrdenarFecha_Click);
            // 
            // buttonActLista
            // 
            this.buttonActLista.Location = new System.Drawing.Point(264, 256);
            this.buttonActLista.Name = "buttonActLista";
            this.buttonActLista.Size = new System.Drawing.Size(75, 39);
            this.buttonActLista.TabIndex = 5;
            this.buttonActLista.Text = "Actualizar lista";
            this.buttonActLista.UseVisualStyleBackColor = true;
            this.buttonActLista.Click += new System.EventHandler(this.buttonActLista_Click);
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Location = new System.Drawing.Point(301, 36);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(75, 38);
            this.buttonDijkstra.TabIndex = 6;
            this.buttonDijkstra.Text = "Elegir ruta mas corta";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // FormVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 307);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.buttonActLista);
            this.Controls.Add(this.buttonOrdenarFecha);
            this.Controls.Add(this.buttonOrdenarAsientos);
            this.Controls.Add(this.labelTitulos);
            this.Controls.Add(this.buttonAccRegistro);
            this.Controls.Add(this.listBoxVuelos);
            this.Name = "FormVuelos";
            this.Text = "Lista de Vuelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.Button buttonAccRegistro;
        private System.Windows.Forms.Label labelTitulos;
        private System.Windows.Forms.Button buttonOrdenarAsientos;
        private System.Windows.Forms.Button buttonOrdenarFecha;
        private System.Windows.Forms.Button buttonActLista;
        private System.Windows.Forms.Button buttonDijkstra;
    }
}
namespace Solanin_Air
{
    partial class FormVuelosABC
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.dateTimePickerFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.buttonPrim = new System.Windows.Forms.Button();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(46, 276);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(334, 276);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(39, 26);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrigen.TabIndex = 2;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(39, 73);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestino.TabIndex = 3;
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(39, 122);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTiempo.TabIndex = 4;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(39, 171);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCosto.TabIndex = 5;
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(39, 10);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(38, 13);
            this.labelOrigen.TabIndex = 6;
            this.labelOrigen.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(39, 57);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(43, 13);
            this.labelDestino.TabIndex = 7;
            this.labelDestino.Text = "Destino";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(39, 106);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(86, 13);
            this.labelTiempo.TabIndex = 8;
            this.labelTiempo.Text = "Tiempo de vuelo";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(39, 155);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(34, 13);
            this.labelCosto.TabIndex = 9;
            this.labelCosto.Text = "Costo";
            // 
            // dateTimePickerFechaSalida
            // 
            this.dateTimePickerFechaSalida.Location = new System.Drawing.Point(12, 220);
            this.dateTimePickerFechaSalida.Name = "dateTimePickerFechaSalida";
            this.dateTimePickerFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaSalida.TabIndex = 10;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(39, 204);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(82, 13);
            this.labelFecha.TabIndex = 11;
            this.labelFecha.Text = "Fecha de salida";
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.Location = new System.Drawing.Point(245, 57);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(274, 199);
            this.listBoxVuelos.TabIndex = 12;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(331, 13);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 14;
            this.labelBuscar.Text = "Buscar";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(331, 29);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusqueda.TabIndex = 13;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // buttonMapa
            // 
            this.buttonMapa.Location = new System.Drawing.Point(187, 276);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(75, 23);
            this.buttonMapa.TabIndex = 15;
            this.buttonMapa.Text = "Mapa";
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Location = new System.Drawing.Point(137, 305);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(75, 23);
            this.buttonKruskal.TabIndex = 16;
            this.buttonKruskal.Text = "Kruskal";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // buttonPrim
            // 
            this.buttonPrim.Location = new System.Drawing.Point(234, 305);
            this.buttonPrim.Name = "buttonPrim";
            this.buttonPrim.Size = new System.Drawing.Size(75, 23);
            this.buttonPrim.TabIndex = 17;
            this.buttonPrim.Text = "Prim";
            this.buttonPrim.UseVisualStyleBackColor = true;
            this.buttonPrim.Click += new System.EventHandler(this.buttonPrim_Click);
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Location = new System.Drawing.Point(187, 334);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(75, 36);
            this.buttonDijkstra.TabIndex = 18;
            this.buttonDijkstra.Text = "Tabla Dijkstra";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // FormVuelosABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 379);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.buttonPrim);
            this.Controls.Add(this.buttonKruskal);
            this.Controls.Add(this.buttonMapa);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerFechaSalida);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxTiempo);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Name = "FormVuelosABC";
            this.Text = "FormVuelosABC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalida;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonMapa;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Button buttonPrim;
        private System.Windows.Forms.Button buttonDijkstra;
    }
}
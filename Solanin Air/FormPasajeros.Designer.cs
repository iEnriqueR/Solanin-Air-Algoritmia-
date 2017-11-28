namespace Solanin_Air
{
    partial class FormPasajeros
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
            this.listViewPasajeros = new System.Windows.Forms.ListView();
            this.columnRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAsiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPasajeros
            // 
            this.listViewPasajeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRuta,
            this.columnNombre,
            this.columnAsiento});
            this.listViewPasajeros.Location = new System.Drawing.Point(13, 13);
            this.listViewPasajeros.Name = "listViewPasajeros";
            this.listViewPasajeros.Size = new System.Drawing.Size(192, 314);
            this.listViewPasajeros.TabIndex = 0;
            this.listViewPasajeros.UseCompatibleStateImageBehavior = false;
            this.listViewPasajeros.View = System.Windows.Forms.View.Details;
            // 
            // columnRuta
            // 
            this.columnRuta.Text = "Ruta";
            this.columnRuta.Width = 45;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 99;
            // 
            // columnAsiento
            // 
            this.columnAsiento.Text = "Asiento";
            this.columnAsiento.Width = 49;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(212, 89);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(212, 40);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusqueda.TabIndex = 2;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(212, 21);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 3;
            this.labelBuscar.Text = "Buscar";
            // 
            // FormPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 339);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.listViewPasajeros);
            this.Name = "FormPasajeros";
            this.Text = "FormPasajeros2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPasajeros;
        private System.Windows.Forms.ColumnHeader columnRuta;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnAsiento;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label labelBuscar;
    }
}
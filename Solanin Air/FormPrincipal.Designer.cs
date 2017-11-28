namespace Solanin_Air
{
    partial class FormPrincipal
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
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonPasajeros = new System.Windows.Forms.Button();
            this.buttonVuelosABC = new System.Windows.Forms.Button();
            this.buttonCiudadesABC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVentas
            // 
            this.buttonVentas.Location = new System.Drawing.Point(144, 12);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(150, 60);
            this.buttonVentas.TabIndex = 0;
            this.buttonVentas.Text = "Venta de boletos";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonVentas_MouseClick);
            // 
            // buttonPasajeros
            // 
            this.buttonPasajeros.Location = new System.Drawing.Point(144, 78);
            this.buttonPasajeros.Name = "buttonPasajeros";
            this.buttonPasajeros.Size = new System.Drawing.Size(150, 60);
            this.buttonPasajeros.TabIndex = 1;
            this.buttonPasajeros.Text = "Lista de pasajeros";
            this.buttonPasajeros.UseVisualStyleBackColor = true;
            this.buttonPasajeros.Click += new System.EventHandler(this.buttonPasajeros_Click);
            // 
            // buttonVuelosABC
            // 
            this.buttonVuelosABC.Location = new System.Drawing.Point(144, 144);
            this.buttonVuelosABC.Name = "buttonVuelosABC";
            this.buttonVuelosABC.Size = new System.Drawing.Size(150, 60);
            this.buttonVuelosABC.TabIndex = 2;
            this.buttonVuelosABC.Text = "Administracion de Vuelos";
            this.buttonVuelosABC.UseVisualStyleBackColor = true;
            this.buttonVuelosABC.Click += new System.EventHandler(this.buttonVuelosABC_Click);
            // 
            // buttonCiudadesABC
            // 
            this.buttonCiudadesABC.Location = new System.Drawing.Point(144, 210);
            this.buttonCiudadesABC.Name = "buttonCiudadesABC";
            this.buttonCiudadesABC.Size = new System.Drawing.Size(150, 60);
            this.buttonCiudadesABC.TabIndex = 3;
            this.buttonCiudadesABC.Text = "Administracion de ciudades";
            this.buttonCiudadesABC.UseVisualStyleBackColor = true;
            this.buttonCiudadesABC.Click += new System.EventHandler(this.buttonCiudadesABC_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 384);
            this.Controls.Add(this.buttonCiudadesABC);
            this.Controls.Add(this.buttonVuelosABC);
            this.Controls.Add(this.buttonPasajeros);
            this.Controls.Add(this.buttonVentas);
            this.Name = "FormPrincipal";
            this.Text = "Solanin Air";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonPasajeros;
        private System.Windows.Forms.Button buttonVuelosABC;
        private System.Windows.Forms.Button buttonCiudadesABC;
    }
}


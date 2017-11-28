namespace Solanin_Air
{
    partial class FormDijkstra
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
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.listBoxVertices = new System.Windows.Forms.ListBox();
            this.labelCiudades = new System.Windows.Forms.Label();
            this.listBoxDestinos = new System.Windows.Forms.ListBox();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonRechazar = new System.Windows.Forms.Button();
            this.labelCostoTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(12, 160);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(0, 13);
            this.labelLista.TabIndex = 0;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(257, 12);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 49);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "Generar rutas mas cortas";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // listBoxVertices
            // 
            this.listBoxVertices.FormattingEnabled = true;
            this.listBoxVertices.Location = new System.Drawing.Point(12, 38);
            this.listBoxVertices.Name = "listBoxVertices";
            this.listBoxVertices.Size = new System.Drawing.Size(51, 95);
            this.listBoxVertices.TabIndex = 2;
            this.listBoxVertices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxVertices_MouseDown);
            // 
            // labelCiudades
            // 
            this.labelCiudades.AutoSize = true;
            this.labelCiudades.Location = new System.Drawing.Point(12, 19);
            this.labelCiudades.Name = "labelCiudades";
            this.labelCiudades.Size = new System.Drawing.Size(51, 13);
            this.labelCiudades.TabIndex = 3;
            this.labelCiudades.Text = "Ciudades";
            // 
            // listBoxDestinos
            // 
            this.listBoxDestinos.FormattingEnabled = true;
            this.listBoxDestinos.Location = new System.Drawing.Point(89, 38);
            this.listBoxDestinos.Name = "listBoxDestinos";
            this.listBoxDestinos.Size = new System.Drawing.Size(51, 95);
            this.listBoxDestinos.TabIndex = 4;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(69, 73);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(13, 13);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "a";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(12, 264);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonRechazar
            // 
            this.buttonRechazar.Enabled = false;
            this.buttonRechazar.Location = new System.Drawing.Point(119, 264);
            this.buttonRechazar.Name = "buttonRechazar";
            this.buttonRechazar.Size = new System.Drawing.Size(75, 23);
            this.buttonRechazar.TabIndex = 7;
            this.buttonRechazar.Text = "Rechazar";
            this.buttonRechazar.UseVisualStyleBackColor = true;
            this.buttonRechazar.Click += new System.EventHandler(this.buttonRechazar_Click);
            // 
            // labelCostoTiempo
            // 
            this.labelCostoTiempo.AutoSize = true;
            this.labelCostoTiempo.Location = new System.Drawing.Point(12, 206);
            this.labelCostoTiempo.Name = "labelCostoTiempo";
            this.labelCostoTiempo.Size = new System.Drawing.Size(0, 13);
            this.labelCostoTiempo.TabIndex = 8;
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 343);
            this.Controls.Add(this.labelCostoTiempo);
            this.Controls.Add(this.buttonRechazar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.listBoxDestinos);
            this.Controls.Add(this.labelCiudades);
            this.Controls.Add(this.listBoxVertices);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.labelLista);
            this.Name = "FormDijkstra";
            this.Text = "FormDijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.ListBox listBoxVertices;
        private System.Windows.Forms.Label labelCiudades;
        private System.Windows.Forms.ListBox listBoxDestinos;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonRechazar;
        private System.Windows.Forms.Label labelCostoTiempo;
    }
}
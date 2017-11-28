namespace Solanin_Air
{
    partial class FormRegistoVenta
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelAsiento = new System.Windows.Forms.Label();
            this.labelVuelo = new System.Windows.Forms.Label();
            this.buttonSelAsiento = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(12, 130);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(12, 110);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // labelAsiento
            // 
            this.labelAsiento.AutoSize = true;
            this.labelAsiento.Location = new System.Drawing.Point(300, 110);
            this.labelAsiento.Name = "labelAsiento";
            this.labelAsiento.Size = new System.Drawing.Size(48, 13);
            this.labelAsiento.TabIndex = 4;
            this.labelAsiento.Text = "Asiento: ";
            // 
            // labelVuelo
            // 
            this.labelVuelo.AutoSize = true;
            this.labelVuelo.Location = new System.Drawing.Point(300, 25);
            this.labelVuelo.Name = "labelVuelo";
            this.labelVuelo.Size = new System.Drawing.Size(34, 13);
            this.labelVuelo.TabIndex = 5;
            this.labelVuelo.Text = "Vuelo";
            // 
            // buttonSelAsiento
            // 
            this.buttonSelAsiento.Location = new System.Drawing.Point(303, 126);
            this.buttonSelAsiento.Name = "buttonSelAsiento";
            this.buttonSelAsiento.Size = new System.Drawing.Size(75, 41);
            this.buttonSelAsiento.TabIndex = 9;
            this.buttonSelAsiento.Text = "Seleccion de Asiento";
            this.buttonSelAsiento.UseVisualStyleBackColor = true;
            this.buttonSelAsiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSelAsiento_MouseClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(15, 394);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCancelar_MouseClick);
            // 
            // buttonVenta
            // 
            this.buttonVenta.Location = new System.Drawing.Point(303, 394);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonVenta.TabIndex = 8;
            this.buttonVenta.Text = "Venta";
            this.buttonVenta.UseVisualStyleBackColor = true;
            this.buttonVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonVenta_MouseClick);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(12, 190);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 6;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(12, 170);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 10;
            this.labelEdad.Text = "Edad";
            // 
            // FormRegistoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 433);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelAsiento);
            this.Controls.Add(this.labelVuelo);
            this.Controls.Add(this.labelAsiento);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormRegistoVenta";
            this.Text = "FormRegistoVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelAsiento;
        private System.Windows.Forms.Label labelVuelo;
        private System.Windows.Forms.Button buttonSelAsiento;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
    }
}
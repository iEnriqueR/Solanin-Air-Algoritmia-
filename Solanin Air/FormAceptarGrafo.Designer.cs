namespace Solanin_Air
{
    partial class FormAceptarGrafo
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonRechazar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(78, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Posición en X: ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(153, 36);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(78, 13);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Posición en Y: ";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(13, 71);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonRechazar
            // 
            this.buttonRechazar.Location = new System.Drawing.Point(156, 71);
            this.buttonRechazar.Name = "buttonRechazar";
            this.buttonRechazar.Size = new System.Drawing.Size(75, 23);
            this.buttonRechazar.TabIndex = 3;
            this.buttonRechazar.Text = "Rechazar";
            this.buttonRechazar.UseVisualStyleBackColor = true;
            this.buttonRechazar.Click += new System.EventHandler(this.buttonRechazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirmar la posición seleccionada";
            // 
            // FormAceptarGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRechazar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "FormAceptarGrafo";
            this.Text = "FormAceptarGrafo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonRechazar;
        private System.Windows.Forms.Label label1;
    }
}
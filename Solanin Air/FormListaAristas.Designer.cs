namespace Solanin_Air
{
    partial class FormListaAristas
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
            this.listBoxListaAristas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxListaAristas
            // 
            this.listBoxListaAristas.FormattingEnabled = true;
            this.listBoxListaAristas.Location = new System.Drawing.Point(13, 13);
            this.listBoxListaAristas.Name = "listBoxListaAristas";
            this.listBoxListaAristas.Size = new System.Drawing.Size(158, 238);
            this.listBoxListaAristas.TabIndex = 0;
            // 
            // FormListaAristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 261);
            this.Controls.Add(this.listBoxListaAristas);
            this.Name = "FormListaAristas";
            this.Text = "FormListaAristas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaAristas;
    }
}
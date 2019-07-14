namespace FrbaCrucero.AbmPuerto
{
    partial class AltaModificacionPuerto
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
            this.nombrePuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombrePuerto
            // 
            this.nombrePuerto.Location = new System.Drawing.Point(132, 38);
            this.nombrePuerto.Name = "nombrePuerto";
            this.nombrePuerto.Size = new System.Drawing.Size(114, 20);
            this.nombrePuerto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 104);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(105, 102);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(77, 25);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(188, 102);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 24);
            this.delete.TabIndex = 4;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // AltaModificacionPuerto
            // 
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrePuerto);
            this.Name = "AltaModificacionPuerto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombrePuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
    }
}
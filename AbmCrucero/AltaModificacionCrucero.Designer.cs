namespace FrbaCrucero.AbmCrucero
{
    partial class AltaModificacionCrucero
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
            this.textCantCab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCantCab
            // 
            this.textCantCab.Location = new System.Drawing.Point(161, 102);
            this.textCantCab.Name = "textCantCab";
            this.textCantCab.Size = new System.Drawing.Size(149, 20);
            this.textCantCab.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Cabinas";
            // 
            // textIdentificador
            // 
            this.textIdentificador.Location = new System.Drawing.Point(161, 64);
            this.textIdentificador.Name = "textIdentificador";
            this.textIdentificador.Size = new System.Drawing.Size(149, 20);
            this.textIdentificador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ldentificador";
            // 
            // fechaAlta
            // 
            this.fechaAlta.CustomFormat = "dd/MM/yyyy";
            this.fechaAlta.Location = new System.Drawing.Point(161, 144);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(149, 20);
            this.fechaAlta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Alta";
            // 
            // comboFabricante
            // 
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.Location = new System.Drawing.Point(161, 184);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(148, 21);
            this.comboFabricante.TabIndex = 6;
            this.comboFabricante.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fabricante";
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(161, 228);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(148, 21);
            this.comboModelo.TabIndex = 8;
            this.comboModelo.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(30, 292);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(70, 31);
            this.save.TabIndex = 10;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(130, 293);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(66, 29);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(221, 292);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(76, 31);
            this.delete.TabIndex = 12;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CRUCERO";
            // 
            // AltaModificacionCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 373);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIdentificador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCantCab);
            this.Name = "AltaModificacionCrucero";
            this.Text = "AltaModificacionCrucero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCantCab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label6;
    }
}